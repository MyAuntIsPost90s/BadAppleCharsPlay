using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImageConvertToChar
{
    interface IImageConverterView
    {
        TextBox TBXNum { get; }
        TextBox TBYNum { get; }
        TextBox TBSourcePath { get; }
        Button BtnSourcePath { get; }
        Button BtnExecute { get; }
        ProgressBar PBPersent { get; }
    }
}
