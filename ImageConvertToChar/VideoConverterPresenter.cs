using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageConvertToChar
{
    class VideoConverterPresenter
    {
        private string basePath;
        private Task videoConvertTask;
        private Task getMusicTask;
        private IVideoConverterView converterView;

        public VideoConverterPresenter(IVideoConverterView converterView)
        {
            this.converterView = converterView;
            this.basePath = AppDomain.CurrentDomain.BaseDirectory;
            InitEvent();
        }

        private void InitEvent()
        {
            converterView.BtnConvertVideo.Click += BtnConvertVideoClick;
            converterView.BtnVideoPath.Click += BtnVideoPathClick;
        }

        private void BtnVideoPathClick(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
  
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                converterView.TBVideoPath.Text = dialog.FileName;
            }
        }

        private void BtnConvertVideoClick(object sender,EventArgs e)
        {
            if (videoConvertTask!=null&&!videoConvertTask.IsCompleted)
            {
                MessageBox.Show("转换视频正在进行中！");
                return;
            }
            if (getMusicTask != null && !getMusicTask.IsCompleted)
            {
                MessageBox.Show("抽取音频正在进行中！");
                return;
            }
            if (string.IsNullOrEmpty(converterView.TBVideoPath.Text))
            {
                MessageBox.Show("请选视频文件");
                return;
            }
            try
            {
                int width = Convert.ToInt32(converterView.TBVideoWidth.Text);
                int height = Convert.ToInt32(converterView.TBVideoHeight.Text);
                VideoConvert(converterView.TBVideoPath.Text, width, height);
            }
            catch
            {
                MessageBox.Show("请输入正确的宽高");
            }
        }

        private void VideoConvert(string videoPath,int width,int height)
        {
            InitDirectory();
            //异步调用
            videoConvertTask = new Task(() =>
            {
                ConvertToImage(videoPath, width, height);
                string tip;
                if (getMusicTask != null && !getMusicTask.IsCompleted)
                {
                    tip= "视频转换图片已完成，等待抽取音频";
                }
                else
                {
                    tip = "执行完成";
                }
                converterView.LBTip.Invoke(new Action(() => {
                    converterView.LBTip.Text = tip;
                }));
            });
            getMusicTask = new Task(() =>
            {
                GetMusic(videoPath);
                string tip;
                if (videoConvertTask != null && !videoConvertTask.IsCompleted)
                {
                    tip = "抽取音频已完成，等待视频转换图片";
                }
                else
                {
                    tip = "执行完成";
                }
                converterView.LBTip.Invoke(new Action(() => {
                    converterView.LBTip.Text = tip;
                }));
            });
            converterView.LBTip.Text = "正在转换中...";
            videoConvertTask.Start();
            getMusicTask.Start();
        }

        private void InitDirectory()
        {
            if (Directory.Exists("imgs"))
            {
                Directory.Delete("imgs", true);
            }
            Directory.CreateDirectory("imgs");
            File.Delete("data.mp3");
        }

        private void ConvertToImage(string videoPath, int width, int height)
        {
            string cmd = string.Format("{0}bin/ffmpeg -i \"{1}\" -s {2}*{3} -r 20 {0}imgs/%d.jpg", basePath, videoPath, width, height);
            CMDHelper.ExcuteCmd(cmd);
        }

        private void GetMusic(string videoPath)
        {
            string cmd = string.Format("{0}bin/ffmpeg -i \"{1}\" -f mp3 -vn {0}data.mp3", basePath, videoPath);
            CMDHelper.ExcuteCmd(cmd);
        }
    }
}
