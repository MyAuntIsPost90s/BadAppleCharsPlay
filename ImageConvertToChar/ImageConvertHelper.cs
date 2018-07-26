using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;

namespace ImageConvertToChar
{
    class ImageConvertHelper
    {
        private static readonly string grayForMiddle = "MNHQ&OC?7>!:-;. ";
        //private static  readonly string grayForMax = "$@B%8&WM#*oahkbdpqwmZO0QLCJUYXzcvunxrjft/\\|()1{}[]?-_+~<>i!lI;:,\"^`'. ";

        /// <summary>
        /// 算法2.0
        /// </summary>
        /// <param name="bitmap"></param>
        /// <param name="colSize"></param>
        /// <param name="rowSize"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string Generate(Bitmap bitmap, int colSize, int rowSize)
        {
            StringBuilder result = new StringBuilder();
            int bitmapH = bitmap.Height;
            int bitmapW = bitmap.Width;
            for (int h = 0; h < bitmapH / rowSize; h++)
            {
                int offsetY = h * rowSize;
                for (int w = 0; w < bitmapW / colSize; w++)
                {
                    int offsetX = w * colSize;
                    double averBright = 0;
                    for (int j = 0; j < rowSize && offsetY + j < bitmapH; j++)
                    {
                        for (int i = 0; i < colSize && offsetX + i < bitmapW; i++)
                        {
                            Color color = bitmap.GetPixel(offsetX + i, offsetY + j);
                            averBright += (color.R * 0.299 + color.G * 0.587 + color.B * 0.114);
                        }
                    }
                    averBright /= (rowSize * colSize);
                    int index = (int)(averBright / (256.0 / (double)grayForMiddle.Length));
                    if (index >= grayForMiddle.Length)
                    {
                        result.Append(grayForMiddle[grayForMiddle.Length - 1]);
                    }
                    else
                    {
                        result.Append(grayForMiddle[index]);
                    }
                }
                result.Append("\r\n");
            }
            return result.ToString();
        }

    }
}
