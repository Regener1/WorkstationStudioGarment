using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkstationStudioGarment_WinForm.tool
{
    class ImgConverter
    {
        /// <summary>
        /// Convert image to string
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        public static string ImageToString(Image image)
        {
            string strData = "";
            try
            {
                MemoryStream ms = new MemoryStream();
                image.Save(ms, ImageFormat.Png);
                byte[] data = ms.ToArray();
                strData = Convert.ToBase64String(data);
                return strData;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Convert image from string
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static Image ImageFromString(string data)
        {
            try
            {
                byte[] img = Convert.FromBase64String(data);
                MemoryStream ms = new MemoryStream(img);
                return Image.FromStream(ms);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
