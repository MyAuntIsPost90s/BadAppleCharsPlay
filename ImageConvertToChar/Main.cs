using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImageConvertToChar
{
    public partial class Main : Form,IImageConverterView,IVideoConverterView
    {
        public Main()
        {
            InitializeComponent();

            new ImageConverterPresenter(this);
            new VideoConverterPresenter(this);
        }

        public TextBox TBXNum => this.tbXNum;

        public TextBox TBYNum => this.tbYNum;

        public TextBox TBSourcePath => this.tbSourcePath;

        public Button BtnSourcePath => this.btnSourcePath;

        public Button BtnExecute => this.btnExecute;

        public TextBox TBVideoWidth => this.tbVideoWidth;

        public TextBox TBVideoHeight => this.tbVideoHeight;

        public TextBox TBVideoPath => this.tbVideoPath;

        public Button BtnVideoPath => this.btnVideoPath;

        public Button BtnConvertVideo => this.btnConvertVideo;

        public Label LBTip => this.lbTip;

        public ProgressBar PBPersent => this.pbPercent;
    }
}
