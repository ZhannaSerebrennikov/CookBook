using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Helpers
{
    public class ImageHelper
    {
        public static byte[] ConvertToDbImage(string imagePath)
        {
            FileInfo fileInfo = new FileInfo(imagePath);
            long bytes = fileInfo.Length;
            FileStream fileStream = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            byte[] convertedImage = binaryReader.ReadBytes((int)bytes);
            return convertedImage;
        }
        public static Image ConvertFromDbImage(byte[] bytes)
        {
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                Image convertedImage = Image.FromStream(ms);
                return convertedImage;
            }
        }
    }
}
