namespace ImageConvertToChar
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSourcePath = new System.Windows.Forms.Button();
            this.tbSourcePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbXNum = new System.Windows.Forms.TextBox();
            this.tbYNum = new System.Windows.Forms.TextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbVideoPath = new System.Windows.Forms.TextBox();
            this.btnConvertVideo = new System.Windows.Forms.Button();
            this.btnVideoPath = new System.Windows.Forms.Button();
            this.tbVideoHeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbVideoWidth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pbPercent = new System.Windows.Forms.ProgressBar();
            this.lbTip = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSourcePath
            // 
            this.btnSourcePath.Location = new System.Drawing.Point(7, 14);
            this.btnSourcePath.Name = "btnSourcePath";
            this.btnSourcePath.Size = new System.Drawing.Size(100, 23);
            this.btnSourcePath.TabIndex = 0;
            this.btnSourcePath.Text = "选择图片路径";
            this.btnSourcePath.UseVisualStyleBackColor = true;
            // 
            // tbSourcePath
            // 
            this.tbSourcePath.Location = new System.Drawing.Point(113, 16);
            this.tbSourcePath.Name = "tbSourcePath";
            this.tbSourcePath.ReadOnly = true;
            this.tbSourcePath.Size = new System.Drawing.Size(225, 21);
            this.tbSourcePath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "横向字符数：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "纵向字符数：";
            // 
            // tbXNum
            // 
            this.tbXNum.Location = new System.Drawing.Point(90, 53);
            this.tbXNum.Name = "tbXNum";
            this.tbXNum.Size = new System.Drawing.Size(84, 21);
            this.tbXNum.TabIndex = 3;
            this.tbXNum.Text = "80";
            // 
            // tbYNum
            // 
            this.tbYNum.Location = new System.Drawing.Point(90, 83);
            this.tbYNum.Name = "tbYNum";
            this.tbYNum.Size = new System.Drawing.Size(84, 21);
            this.tbYNum.TabIndex = 3;
            this.tbYNum.Text = "30";
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(7, 114);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(331, 23);
            this.btnExecute.TabIndex = 4;
            this.btnExecute.Text = "生成";
            this.btnExecute.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(353, 189);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pbPercent);
            this.tabPage1.Controls.Add(this.tbSourcePath);
            this.tabPage1.Controls.Add(this.btnExecute);
            this.tabPage1.Controls.Add(this.btnSourcePath);
            this.tabPage1.Controls.Add(this.tbYNum);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbXNum);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(345, 163);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "图片工具";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbTip);
            this.tabPage2.Controls.Add(this.tbVideoPath);
            this.tabPage2.Controls.Add(this.btnConvertVideo);
            this.tabPage2.Controls.Add(this.btnVideoPath);
            this.tabPage2.Controls.Add(this.tbVideoHeight);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.tbVideoWidth);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(345, 163);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "视频工具";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbVideoPath
            // 
            this.tbVideoPath.Location = new System.Drawing.Point(113, 13);
            this.tbVideoPath.Name = "tbVideoPath";
            this.tbVideoPath.ReadOnly = true;
            this.tbVideoPath.Size = new System.Drawing.Size(225, 21);
            this.tbVideoPath.TabIndex = 6;
            // 
            // btnConvertVideo
            // 
            this.btnConvertVideo.Location = new System.Drawing.Point(7, 111);
            this.btnConvertVideo.Name = "btnConvertVideo";
            this.btnConvertVideo.Size = new System.Drawing.Size(331, 23);
            this.btnConvertVideo.TabIndex = 11;
            this.btnConvertVideo.Text = "生成";
            this.btnConvertVideo.UseVisualStyleBackColor = true;
            // 
            // btnVideoPath
            // 
            this.btnVideoPath.Location = new System.Drawing.Point(7, 11);
            this.btnVideoPath.Name = "btnVideoPath";
            this.btnVideoPath.Size = new System.Drawing.Size(100, 23);
            this.btnVideoPath.TabIndex = 5;
            this.btnVideoPath.Text = "选择视频路径";
            this.btnVideoPath.UseVisualStyleBackColor = true;
            // 
            // tbVideoHeight
            // 
            this.tbVideoHeight.Location = new System.Drawing.Point(42, 80);
            this.tbVideoHeight.Name = "tbVideoHeight";
            this.tbVideoHeight.Size = new System.Drawing.Size(84, 21);
            this.tbVideoHeight.TabIndex = 9;
            this.tbVideoHeight.Text = "300";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "宽：";
            // 
            // tbVideoWidth
            // 
            this.tbVideoWidth.Location = new System.Drawing.Point(42, 50);
            this.tbVideoWidth.Name = "tbVideoWidth";
            this.tbVideoWidth.Size = new System.Drawing.Size(84, 21);
            this.tbVideoWidth.TabIndex = 10;
            this.tbVideoWidth.Text = "400";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "高：";
            // 
            // pbPercent
            // 
            this.pbPercent.Location = new System.Drawing.Point(7, 142);
            this.pbPercent.Name = "pbPercent";
            this.pbPercent.Size = new System.Drawing.Size(330, 17);
            this.pbPercent.TabIndex = 5;
            // 
            // lbTip
            // 
            this.lbTip.AutoSize = true;
            this.lbTip.ForeColor = System.Drawing.Color.Red;
            this.lbTip.Location = new System.Drawing.Point(8, 141);
            this.lbTip.Name = "lbTip";
            this.lbTip.Size = new System.Drawing.Size(0, 12);
            this.lbTip.TabIndex = 12;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 189);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Converter";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSourcePath;
        private System.Windows.Forms.TextBox tbSourcePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbXNum;
        private System.Windows.Forms.TextBox tbYNum;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbVideoPath;
        private System.Windows.Forms.Button btnConvertVideo;
        private System.Windows.Forms.Button btnVideoPath;
        private System.Windows.Forms.TextBox tbVideoHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbVideoWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar pbPercent;
        private System.Windows.Forms.Label lbTip;
    }
}

