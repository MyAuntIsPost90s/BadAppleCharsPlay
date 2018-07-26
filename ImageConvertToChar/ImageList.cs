using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace ImageConvertToChar
{
    class ImageList
    {
        private string sourcePath;
        private List<FileInfo> fileList;
        private int index;

        public int Count { get { return fileList.Count; } }

        private ImageList(string sourcePath)
        {
            this.sourcePath = sourcePath;
            this.index = 0;
            this.fileList = new List<FileInfo>();
            LoadImages();
        }

        private void LoadImages()
        {
            DirectoryInfo directory = new DirectoryInfo(sourcePath);
            FileInfo[] files = directory.GetFiles();
            foreach (var item in files)
            {
                if(item.Extension.Contains("png")|| item.Extension.Contains("jpg"))
                {
                    fileList.Add(item);
                }
            }
            fileList.Sort((n, o) => {
                int nValue = 0;
                int oValue = 0;
                if (!int.TryParse(n.Name.Replace(n.Extension,""),out nValue))
                {
                    return -1;
                }
                if (!int.TryParse(o.Name.Replace(o.Extension, ""), out oValue))
                {
                    return -1;
                }
                return nValue > oValue ? 1 : -1;
            });
        }

        public static ImageList Get(string sourcePath)
        {
            return new ImageList(sourcePath);
        }

        public bool hasNext()
        {
            return fileList != null && fileList.Count > index;
        }

        public Bitmap next()
        {
            try
            {
                Bitmap bitmap = new Bitmap(fileList[index].FullName);
                index++;
                return bitmap;
            }
            catch
            {
                index++;
                return next();
            }
        }
    }
}
