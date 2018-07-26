using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageConvertToChar
{
    class ImageConverterPresenter
    {
        private Task convertTask;
        private IImageConverterView converterView;

        public ImageConverterPresenter(IImageConverterView converterView)
        {
            this.converterView = converterView;
            InitEvent();
        }

        private void InitEvent()
        {
            converterView.BtnExecute.Click += BtnExecuteClick;
            converterView.BtnSourcePath.Click += BtnSourcePathClick;
        }

        private void BtnSourcePathClick(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                converterView.TBSourcePath.Text = dialog.SelectedPath;
            }
        }

        private void BtnExecuteClick(object sender,EventArgs e)
        {
            if(convertTask!=null&& !convertTask.IsCompleted)
            {
                MessageBox.Show("字符转码正在执行中！");
                return;
            }
            if (string.IsNullOrEmpty(converterView.TBSourcePath.Text))
            {
                MessageBox.Show("请选根文件");
                return;
            }
            try
            {
                int width = Convert.ToInt32(converterView.TBXNum.Text);
                int height = Convert.ToInt32(converterView.TBYNum.Text);
                converterView.PBPersent.Value = 0;
                convertTask = new Task(() =>
                {
                    ImageConverter.Get(converterView.TBSourcePath.Text).ConvertImageToTxt(width, height, new Action<int>((percent) =>
                    {
                        converterView.PBPersent.Invoke(new Action(() =>
                        {
                            converterView.PBPersent.Value = percent;
                        }));

                    }));
                    converterView.PBPersent.Invoke(new Action(() =>
                    {
                        converterView.PBPersent.Value = 100;
                        MessageBox.Show("执行完成");
                    }));
                });
                convertTask.Start();
            }
            catch
            {
                MessageBox.Show("请输入正确的宽高");
            }
        }

    }
}
