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
    }
}
