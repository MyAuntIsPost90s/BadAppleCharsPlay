using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImageConvertToChar
{
    interface IVideoConverterView
    {
        TextBox TBVideoWidth { get; }
        TextBox TBVideoHeight { get; }
        TextBox TBVideoPath { get; }
        Button BtnVideoPath { get; } 
        Button BtnConvertVideo { get; }
        Label LBTip { get; }
    }
}
