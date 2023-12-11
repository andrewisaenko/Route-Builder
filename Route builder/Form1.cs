using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Route_builder
{
    public partial class Form1 : Form
    {
        Map map;
        Graph graph;
        List<Image> buffer;        
        Ruler ruler;
        

            
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = Crud.GetDataFromDB();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
            pictureBox1.AllowDrop = true;
            optimize_comboBox.Items.AddRange(new string[] {"Triangle", "Angle"});
            optimize_comboBox.SelectedIndex = 0;
            build_route_comboBox.Items.AddRange(new string[] { "Deep search", "Ant colony" });
            build_route_comboBox.SelectedIndex = 1;

        }

        private void PictureBox1_DragEnter(object sender, DragEventArgs e)  // Drag&Drop event
        {
            e.Effect = DragDropEffects.Move;
        }
        private void Picturedox1_DragDrop(object sender, DragEventArgs e)  // Drag&Drop event
        {
            int x = this.PointToClient(new Point(e.X, e.Y)).X;

            int y = this.PointToClient(new Point(e.X, e.Y)).Y;

            if (x >= pictureBox1.Location.X && x <= pictureBox1.Location.X + pictureBox1.Width && y >= pictureBox1.Location.Y && y <= pictureBox1.Location.Y + pictureBox1.Height)
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                pictureBox1.Image = Image.FromFile(files[0]);
                
            }

        }
                 
        private void open_img_button_Click(object sender, EventArgs e)  // adding img to app
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Image Files(*.jpg;*.png)|*.jpg;*.png|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(ofd.FileName);
                    map = new Map();
                    graph = new Graph();
                    buffer = new List<Image>();
                    buffer.Add(pictureBox1.Image);
                    map.mapImg = ImgFunc.ImgToByteArr(pictureBox1.Image);
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }            
        }
                
        private void save_img_button_Click(object sender, EventArgs e)  // saving img from app
        {
            if (pictureBox1.Image != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Save image as...";
                sfd.OverwritePrompt = true;
                sfd.CheckPathExists = true;

                sfd.Filter = "Image Files(*.jpg)|*.jpg|Image Files(*.png)|*.png|All files (*.*)|*.*";
                sfd.ShowHelp = true;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pictureBox1.Image.Save(sfd.FileName);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void add_but_Click(object sender, EventArgs e) // add to DB
        {
            if(pictureBox1.Image!=null && map_name_textBox.Text != "")
            {
                map = Crud.AddNameAndImg(map_name_textBox.Text, pictureBox1.Image);
                dataGridView1.DataSource = Crud.GetDataFromDB();               
            }
            else
            {
                MessageBox.Show("Добавьте изображение и введите название карты!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void open_but_Click(object sender, EventArgs e) // open from DB
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                graph = new Graph();
                buffer = new List<Image>();
                map = Crud.FindById(id);
                
                if(map.cpValue != null && map.cpValue != "" && map.cpCoordinates != null && map.cpCoordinates != "")
                {
                    graph = Converter.StringToVertexes(map.cpValue, map.cpCoordinates);
                    if(map.distanseBeetweenCP != "")
                    {
                        graph = Converter.EdgeLengthStringToEdges(graph, map.distanseBeetweenCP);
                    }
                } 
                map_name_textBox.Text = map.name;
                pictureBox1.Image = ImgFunc.ByteArrToImg(map.mapImg);
                buffer.Add(pictureBox1.Image);
            }
        }

        private void change_but_Click(object sender, EventArgs e) // change in DB
        {
            if (map != null && pictureBox1.Image != null && map_name_textBox.Text!="")
            {
                map.name = map_name_textBox.Text;
                map.mapImg = ImgFunc.ImgToByteArr(pictureBox1.Image);
                Crud.UpdateMap(map);
                dataGridView1.DataSource = Crud.GetDataFromDB();
            }
        }

        private void del_but_Click(object sender, EventArgs e)  // del from DB
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                Crud.DeleteMap(id);
                dataGridView1.DataSource = Crud.GetDataFromDB();
            }
        }

        private void map_name_textBox_KeyDown(object sender, KeyEventArgs e) // search in DB by Enter
        {
            if (e.KeyCode == Keys.Enter) search_but.PerformClick();
        }

        private void search_but_Click(object sender, EventArgs e)  // search in DB by button
        {
            if (map_name_textBox.Text == "")
            {
                dataGridView1.DataSource = Crud.GetDataFromDB();
                map = null;
                pictureBox1.Image = null;
            }
            else
            {
                dataGridView1.DataSource = Crud.SearchMaps(map_name_textBox.Text);
            }
        }
        
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e) // add vertex to graph
        {
            if (pictureBox1.Image != null)
            {
                if (point_cb.Checked)
                {
                    pictureBox1.Image = ImgFunc.DrawCircle(e.X, e.Y, pictureBox1.Image, Color.Red);
                    buffer.Add(pictureBox1.Image);

                    Form2 f = new Form2(new MyDelegate(func));
                    f.ShowDialog();
                    void func(string param)
                    {
                        graph.AddVertex(Convert.ToInt32(param), e.X, e.Y);
                    }
                }
                else if (finish_cb.Checked)
                {
                    pictureBox1.Image = ImgFunc.DrawCircle(e.X, e.Y, pictureBox1.Image, Color.Black);
                    buffer.Add(pictureBox1.Image);                                     
                    graph.AddVertex(1, e.X, e.Y);
                    finish_cb.Checked = false;                    
                }
                else if (ruler_cb.Checked)
                {
                    if (ruler == null) 
                    {
                        ruler = new Ruler();
                        ruler.points.Add(new Point(e.X, e.Y));                        
                    }
                    else if (ruler.points.Count == 1)
                    {
                        ruler.points.Add(new Point(e.X, e.Y));
                        ruler.CalculateLength();
                        pictureBox1.Image = ImgFunc.DrawLine(ruler.points[0], ruler.points[1], pictureBox1.Image);
                    }
                    else if (ruler.points.Count == 2)
                    {
                        ruler = new Ruler();
                        ruler.points.Add(new Point(e.X, e.Y));
                    }
                }
            }
        }


        private void build_but_Click(object sender, EventArgs e) // draw graph
        {
            //Image img = pictureBox1.Image;

            //  foreach (Edge edge in graph.Edges)
            //  {
            //      img = ImgFunc.DrawLine(new Point(edge.From.X, edge.From.Y), new Point(edge.To.X, edge.To.Y), img);
            //  }           


            if(buffer != null && pictureBox1.Image != null) 
            {
                Image img = buffer.Last();
                buffer.Clear();
                buffer.Add(img);
                pictureBox1.Image = ImgFunc.DrawGraph(pictureBox1.Image, graph);
            }
            
           
          // pictureBox1.Image = img;

        }        

        private void optimize_graph_but_Click(object sender, EventArgs e)
        {
            graph.CpOrder?.Clear();
            graph.RouteLength = 0;
            graph.RouteValue = 0;
            //pictureBox1.Image = buffer.Last();

            graph.Edges.Clear();
            graph.BuildAllEdges();

            //switch (optimize_comboBox.SelectedIndex)
            //{                
            //    case 0: graph.OptimizeGraphByTriangle(); break;
            //    case 1: graph.OptimizeGraph(); break;
            //}
        
        }

        private void clear_but_Click(object sender, EventArgs e)
        {
            graph = new Graph();
            buffer = new List<Image>();
        }

        private void back_but_Click(object sender, EventArgs e)
        {
            if(graph!=null && graph.Vertexes.Count !=0 && buffer != null)
            {
                buffer.RemoveAt(buffer.Count - 1);
                pictureBox1.Image = buffer[buffer.Count - 1];               
                graph.Vertexes.RemoveAt(graph.Vertexes.Count-1);                
            }
        }

        private void route_but_Click(object sender, EventArgs e)
        {
            if (distance_textBox.Text != "" && map_scale_textBox.Text != "" && ruler != null &&ruler.scale_px>0)
            {
                optimize_graph_but.PerformClick();

                ruler.plannedDistanсeKm = Convert.ToDouble(distance_textBox.Text);
                ruler.scale_m = Convert.ToDouble(map_scale_textBox.Text);

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();               

                switch (build_route_comboBox.SelectedIndex)
                {
                    case 0: graph.FindBestRoute(ruler.CalculateDistanceInPx()); break;
                    case 1: graph.BuildRouteAntColonyOptimization(); break;
                }
                
                pictureBox1.Image = ImgFunc.DrawRoute(pictureBox1.Image, graph);

                stopwatch.Stop();
                MessageBox.Show(Convert.ToString(stopwatch.Elapsed));
            }
        }

        private void save_graph_in_DB_Click(object sender, EventArgs e)
        {
            if (map != null && graph.Vertexes != null)
            {
                map.cpCoordinates = graph.Converter.CpCoordinatesToString();
                map.cpValue = graph.Converter.CpValueToString();
                map.distanseBeetweenCP = graph.Converter.EdgeLengthMatrixToString();

                Crud.UpdateMap(map);
                dataGridView1.DataSource = Crud.GetDataFromDB();
            }
        }

        private void point_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (point_cb.Checked)
            {
                finish_cb.Checked = false;
                ruler_cb.Checked = false;
            }
        }

        private void finish_cb_CheckedChanged(object sender, EventArgs e)
        {
            point_cb.Checked = false;
            ruler_cb.Checked = false;
            if(graph != null && graph.Vertexes.Find(x => x.Number == 1) != null)
            {
                finish_cb.Checked = false;
            }            
        }

        private void ruler_cb_CheckedChanged(object sender, EventArgs e)
        {
            point_cb.Checked = false;
            finish_cb.Checked = false;            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    public delegate void MyDelegate(string data);
}
