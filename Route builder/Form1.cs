using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = Crud.GetDataFromDB();
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
            pictureBox1.AllowDrop = true;
        }

        private void PictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
        private void Picturedox1_DragDrop(object sender, DragEventArgs e)
        {
            int x = this.PointToClient(new Point(e.X, e.Y)).X;

            int y = this.PointToClient(new Point(e.X, e.Y)).Y;

            if (x >= pictureBox1.Location.X && x <= pictureBox1.Location.X + pictureBox1.Width && y >= pictureBox1.Location.Y && y <= pictureBox1.Location.Y + pictureBox1.Height)
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                pictureBox1.Image = Image.FromFile(files[0]);
            }

        }
         
        private void open_img_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Image Files(*.jpg;*.png)|*.jpg;*.png|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(ofd.FileName);
                    map = new Map();
                    map.mapImg = ImgFunc.ImgToByteArr(pictureBox1.Image);
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }            
        }
        
        private void save_img_button_Click(object sender, EventArgs e)
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

        private void add_but_Click(object sender, EventArgs e)
        {
            map = Crud.AddNameAndImg(textBox1.Text, pictureBox1.Image);
            dataGridView1.DataSource = Crud.GetDataFromDB();
        }

        private void open_but_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                map = Crud.FindById(id);

                textBox1.Text = map.name;
                pictureBox1.Image = ImgFunc.ByteArrToImg(map.mapImg);
            }
        }

        private void change_but_Click(object sender, EventArgs e)
        {
            map.name = textBox1.Text;
            map.mapImg = ImgFunc.ImgToByteArr(pictureBox1.Image);
            Crud.UpdateMap(map);
            dataGridView1.DataSource = Crud.GetDataFromDB();
        }

        private void del_but_Click(object sender, EventArgs e)
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

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) search_but.PerformClick();
        }

        private void search_but_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                dataGridView1.DataSource = Crud.GetDataFromDB();
            }
            else
            {
                dataGridView1.DataSource = Crud.SearchMaps(textBox1.Text);
            }
        }
    }
}
