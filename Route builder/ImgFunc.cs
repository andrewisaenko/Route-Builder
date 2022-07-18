using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Route_builder
{
    class ImgFunc
    {
        public static byte[] ImgToByteArr(Image image)
        {
            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
            image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] byteArr = memoryStream.ToArray();
            return byteArr;
        }

        public static Image ByteArrToImg(byte[] byteArr)
        {
            System.IO.MemoryStream memoryStream1 = new System.IO.MemoryStream();
            foreach (byte b1 in byteArr) memoryStream1.WriteByte(b1);
            Image image = Image.FromStream(memoryStream1);
            return image;
        }

        public static Bitmap DrawCircle(int x, int y, Image img, Color color)
        {

            Bitmap bmp = new Bitmap(img);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawEllipse(new Pen(color, 5), x - 2.5f, y - 2.5f, 5, 5);
            return bmp;
        }

        public static Bitmap DrawLine(Point p1, Point p2, Image img)
        {
            try
            {
                Bitmap bmp = new Bitmap(img);
                Graphics g = Graphics.FromImage(bmp);
                Pen p = new Pen(Color.Red, 4);// цвет линии и ширина           
                g.DrawLine(p, p1, p2);
                return bmp;
            }
            finally
            {
                img?.Dispose();
            }

        }

        public static Bitmap DrawGraph(Image img, Graph graph)
        {
            Bitmap bmp = new Bitmap(img);
            foreach (Edge edge in graph.Edges)
            {
                bmp = ImgFunc.DrawLine(new Point(edge.From.X, edge.From.Y), new Point(edge.To.X, edge.To.Y), bmp);
            }
            return bmp;
        }

        public static Bitmap DrawRoute(Image img, Graph graph) 
        {
            Bitmap bmp = new Bitmap(img);
            if (graph.CpOrder != null && graph.CpOrder.Count > 1)
            {
                for(int i = 1; i < graph.CpOrder.Count; i++)
                {
                    bmp = ImgFunc.DrawLine(new Point(graph.CpOrder[i-1].X, graph.CpOrder[i-1].Y), new Point(graph.CpOrder[i].X, graph.CpOrder[i].Y), bmp);
                }
            }
            return bmp;
        }
    }

}
