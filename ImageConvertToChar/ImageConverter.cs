using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace ImageConvertToChar
{
    class ImageConverter
    {
        private string sourcePath;
        private ImageList imageList;
        private string txtPath = "data.txt";

        private ImageConverter(string sourcePath)
        {
            this.sourcePath = sourcePath;
            this.imageList = ImageList.Get(sourcePath);
        }

        public static ImageConverter Get(string sourcePath)
        {
            return new ImageConverter(sourcePath);
        }

        public void ConvertImageToTxt(int width,int height, Action<int> callback)
        {
            File.Delete(txtPath);
            File.AppendAllText(txtPath, imageList.Count + "\r\n");
            int i = 0;
            while (imageList.hasNext())
            {
                using (Bitmap bitmap = imageList.next())
                {
                    File.AppendAllText(txtPath, ImageConvertHelper.Generate(bitmap, bitmap.Width / width, bitmap.Height / height));
                    int percent = (i++*100)/ imageList.Count;
                    if (callback != null)
                    {
                        callback.Invoke(percent);
                    }
                }
            }
        }
    }
}
