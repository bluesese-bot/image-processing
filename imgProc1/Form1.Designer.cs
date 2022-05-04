namespace imgProc1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rGBHistogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputOutputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greyScaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.averageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.luminanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightnessToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inverseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logBrightnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logContrastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitDepthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.bitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bitToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.bitToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.bitToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.bitToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yellowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cyanToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.purpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gammaCorrectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeDetectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.pbOutput = new System.Windows.Forms.PictureBox();
            this.pbInput = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.blackAndWhiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramEqualizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInput)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.colorsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1466, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem1,
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Image = global::imgProc1.Properties.Resources.open;
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(242, 26);
            this.openToolStripMenuItem1.Text = "&Open";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::imgProc1.Properties.Resources.save_icon_5;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.saveToolStripMenuItem.Text = "&Save As...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem1_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Image = global::imgProc1.Properties.Resources.Oxygen480_actions_dialog_close;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rGBHistogramToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // rGBHistogramToolStripMenuItem
            // 
            this.rGBHistogramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputToolStripMenuItem,
            this.outputToolStripMenuItem,
            this.inputOutputToolStripMenuItem});
            this.rGBHistogramToolStripMenuItem.Name = "rGBHistogramToolStripMenuItem";
            this.rGBHistogramToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.rGBHistogramToolStripMenuItem.Text = "RGB Histogram";
            // 
            // inputToolStripMenuItem
            // 
            this.inputToolStripMenuItem.Name = "inputToolStripMenuItem";
            this.inputToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.inputToolStripMenuItem.Text = "&Input";
            this.inputToolStripMenuItem.Click += new System.EventHandler(this.inputToolStripMenuItem_Click_1);
            // 
            // outputToolStripMenuItem
            // 
            this.outputToolStripMenuItem.Name = "outputToolStripMenuItem";
            this.outputToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.outputToolStripMenuItem.Text = "&Output";
            this.outputToolStripMenuItem.Click += new System.EventHandler(this.outputToolStripMenuItem_Click_1);
            // 
            // inputOutputToolStripMenuItem
            // 
            this.inputOutputToolStripMenuItem.Name = "inputOutputToolStripMenuItem";
            this.inputOutputToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.inputOutputToolStripMenuItem.Text = "&InputOutput";
            this.inputOutputToolStripMenuItem.Click += new System.EventHandler(this.inputOutputToolStripMenuItem_Click);
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.greyScaleToolStripMenuItem,
            this.brightnessToolStripMenuItem1,
            this.inverseToolStripMenuItem,
            this.logBrightnessToolStripMenuItem,
            this.logContrastToolStripMenuItem,
            this.bitDepthToolStripMenuItem,
            this.redToolStripMenuItem,
            this.yellowToolStripMenuItem,
            this.cyanToolStripMenuItem1,
            this.purpleToolStripMenuItem,
            this.greyToolStripMenuItem,
            this.brownToolStripMenuItem,
            this.gammaCorrectionToolStripMenuItem,
            this.edgeDetectionToolStripMenuItem,
            this.blackAndWhiteToolStripMenuItem,
            this.histogramEqualizationToolStripMenuItem});
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.colorsToolStripMenuItem.Text = "&Colors";
            this.colorsToolStripMenuItem.Click += new System.EventHandler(this.colorsToolStripMenuItem_Click);
            // 
            // greyScaleToolStripMenuItem
            // 
            this.greyScaleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.averageToolStripMenuItem,
            this.lightnessToolStripMenuItem,
            this.luminanceToolStripMenuItem});
            this.greyScaleToolStripMenuItem.Image = global::imgProc1.Properties.Resources.brightness_png_image_90523;
            this.greyScaleToolStripMenuItem.Name = "greyScaleToolStripMenuItem";
            this.greyScaleToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.greyScaleToolStripMenuItem.Text = "Gray&Scale";
            this.greyScaleToolStripMenuItem.Click += new System.EventHandler(this.greyScaleToolStripMenuItem_Click);
            // 
            // averageToolStripMenuItem
            // 
            this.averageToolStripMenuItem.Name = "averageToolStripMenuItem";
            this.averageToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.averageToolStripMenuItem.Text = "&Average";
            this.averageToolStripMenuItem.Click += new System.EventHandler(this.averageToolStripMenuItem_Click);
            // 
            // lightnessToolStripMenuItem
            // 
            this.lightnessToolStripMenuItem.Name = "lightnessToolStripMenuItem";
            this.lightnessToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.lightnessToolStripMenuItem.Text = "&Lightness";
            this.lightnessToolStripMenuItem.Click += new System.EventHandler(this.lightnessToolStripMenuItem_Click);
            // 
            // luminanceToolStripMenuItem
            // 
            this.luminanceToolStripMenuItem.Name = "luminanceToolStripMenuItem";
            this.luminanceToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.luminanceToolStripMenuItem.Text = "&Luminosity";
            this.luminanceToolStripMenuItem.Click += new System.EventHandler(this.luminanceToolStripMenuItem_Click);
            // 
            // brightnessToolStripMenuItem1
            // 
            this.brightnessToolStripMenuItem1.Name = "brightnessToolStripMenuItem1";
            this.brightnessToolStripMenuItem1.Size = new System.Drawing.Size(248, 26);
            this.brightnessToolStripMenuItem1.Text = "&Brightnes - Contrast";
            this.brightnessToolStripMenuItem1.Click += new System.EventHandler(this.brightnessToolStripMenuItem1_Click);
            // 
            // inverseToolStripMenuItem
            // 
            this.inverseToolStripMenuItem.Name = "inverseToolStripMenuItem";
            this.inverseToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.inverseToolStripMenuItem.Text = "Inverse";
            this.inverseToolStripMenuItem.Click += new System.EventHandler(this.inverseToolStripMenuItem_Click);
            // 
            // logBrightnessToolStripMenuItem
            // 
            this.logBrightnessToolStripMenuItem.Name = "logBrightnessToolStripMenuItem";
            this.logBrightnessToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.logBrightnessToolStripMenuItem.Text = "Log Brightness";
            this.logBrightnessToolStripMenuItem.Click += new System.EventHandler(this.logBrightnessToolStripMenuItem_Click);
            // 
            // logContrastToolStripMenuItem
            // 
            this.logContrastToolStripMenuItem.Name = "logContrastToolStripMenuItem";
            this.logContrastToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.logContrastToolStripMenuItem.Text = "Log Contrast";
            this.logContrastToolStripMenuItem.Click += new System.EventHandler(this.logContrastToolStripMenuItem_Click);
            // 
            // bitDepthToolStripMenuItem
            // 
            this.bitDepthToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bitToolStripMenuItem6,
            this.bitToolStripMenuItem,
            this.bitToolStripMenuItem1,
            this.bitToolStripMenuItem2,
            this.bitToolStripMenuItem3,
            this.bitToolStripMenuItem4,
            this.bitToolStripMenuItem5});
            this.bitDepthToolStripMenuItem.Name = "bitDepthToolStripMenuItem";
            this.bitDepthToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.bitDepthToolStripMenuItem.Text = "Bit Depth";
            this.bitDepthToolStripMenuItem.Click += new System.EventHandler(this.bitDepthToolStripMenuItem_Click);
            // 
            // bitToolStripMenuItem6
            // 
            this.bitToolStripMenuItem6.Name = "bitToolStripMenuItem6";
            this.bitToolStripMenuItem6.Size = new System.Drawing.Size(122, 26);
            this.bitToolStripMenuItem6.Text = "1 Bit";
            this.bitToolStripMenuItem6.Click += new System.EventHandler(this.bitToolStripMenuItem6_Click);
            // 
            // bitToolStripMenuItem
            // 
            this.bitToolStripMenuItem.Name = "bitToolStripMenuItem";
            this.bitToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.bitToolStripMenuItem.Text = "2 Bit";
            this.bitToolStripMenuItem.Click += new System.EventHandler(this.bitToolStripMenuItem_Click);
            // 
            // bitToolStripMenuItem1
            // 
            this.bitToolStripMenuItem1.Name = "bitToolStripMenuItem1";
            this.bitToolStripMenuItem1.Size = new System.Drawing.Size(122, 26);
            this.bitToolStripMenuItem1.Text = "3 Bit";
            this.bitToolStripMenuItem1.Click += new System.EventHandler(this.bitToolStripMenuItem1_Click);
            // 
            // bitToolStripMenuItem2
            // 
            this.bitToolStripMenuItem2.Name = "bitToolStripMenuItem2";
            this.bitToolStripMenuItem2.Size = new System.Drawing.Size(122, 26);
            this.bitToolStripMenuItem2.Text = "4 Bit";
            this.bitToolStripMenuItem2.Click += new System.EventHandler(this.bitToolStripMenuItem2_Click);
            // 
            // bitToolStripMenuItem3
            // 
            this.bitToolStripMenuItem3.Name = "bitToolStripMenuItem3";
            this.bitToolStripMenuItem3.Size = new System.Drawing.Size(122, 26);
            this.bitToolStripMenuItem3.Text = "5 Bit";
            this.bitToolStripMenuItem3.Click += new System.EventHandler(this.bitToolStripMenuItem3_Click);
            // 
            // bitToolStripMenuItem4
            // 
            this.bitToolStripMenuItem4.Name = "bitToolStripMenuItem4";
            this.bitToolStripMenuItem4.Size = new System.Drawing.Size(122, 26);
            this.bitToolStripMenuItem4.Text = "6 Bit";
            this.bitToolStripMenuItem4.Click += new System.EventHandler(this.bitToolStripMenuItem4_Click);
            // 
            // bitToolStripMenuItem5
            // 
            this.bitToolStripMenuItem5.Name = "bitToolStripMenuItem5";
            this.bitToolStripMenuItem5.Size = new System.Drawing.Size(122, 26);
            this.bitToolStripMenuItem5.Text = "7 Bit";
            this.bitToolStripMenuItem5.Click += new System.EventHandler(this.bitToolStripMenuItem5_Click);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.redToolStripMenuItem.Text = "&Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // yellowToolStripMenuItem
            // 
            this.yellowToolStripMenuItem.Name = "yellowToolStripMenuItem";
            this.yellowToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.yellowToolStripMenuItem.Text = "&Yellow";
            this.yellowToolStripMenuItem.Click += new System.EventHandler(this.yellowToolStripMenuItem_Click);
            // 
            // cyanToolStripMenuItem1
            // 
            this.cyanToolStripMenuItem1.Name = "cyanToolStripMenuItem1";
            this.cyanToolStripMenuItem1.Size = new System.Drawing.Size(248, 26);
            this.cyanToolStripMenuItem1.Text = "&Cyan";
            this.cyanToolStripMenuItem1.Click += new System.EventHandler(this.cyanToolStripMenuItem1_Click);
            // 
            // purpleToolStripMenuItem
            // 
            this.purpleToolStripMenuItem.Name = "purpleToolStripMenuItem";
            this.purpleToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.purpleToolStripMenuItem.Text = "&Purple";
            this.purpleToolStripMenuItem.Click += new System.EventHandler(this.purpleToolStripMenuItem_Click);
            // 
            // greyToolStripMenuItem
            // 
            this.greyToolStripMenuItem.Name = "greyToolStripMenuItem";
            this.greyToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.greyToolStripMenuItem.Text = "&Green";
            this.greyToolStripMenuItem.Click += new System.EventHandler(this.greyToolStripMenuItem_Click);
            // 
            // brownToolStripMenuItem
            // 
            this.brownToolStripMenuItem.Name = "brownToolStripMenuItem";
            this.brownToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.brownToolStripMenuItem.Text = "&Blue";
            this.brownToolStripMenuItem.Click += new System.EventHandler(this.brownToolStripMenuItem_Click);
            // 
            // gammaCorrectionToolStripMenuItem
            // 
            this.gammaCorrectionToolStripMenuItem.Name = "gammaCorrectionToolStripMenuItem";
            this.gammaCorrectionToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.gammaCorrectionToolStripMenuItem.Text = "&Gamma Correction";
            this.gammaCorrectionToolStripMenuItem.Click += new System.EventHandler(this.gammaCorrectionToolStripMenuItem_Click_1);
            // 
            // edgeDetectionToolStripMenuItem
            // 
            this.edgeDetectionToolStripMenuItem.Name = "edgeDetectionToolStripMenuItem";
            this.edgeDetectionToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.edgeDetectionToolStripMenuItem.Text = "&Edge Detection";
            this.edgeDetectionToolStripMenuItem.Click += new System.EventHandler(this.edgeDetectionToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.progressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 563);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1466, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(130, 20);
            this.toolStripStatusLabel1.Text = "File Path | Resolusi";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(133, 18);
            // 
            // pbOutput
            // 
            this.pbOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbOutput.Location = new System.Drawing.Point(0, 0);
            this.pbOutput.Margin = new System.Windows.Forms.Padding(4);
            this.pbOutput.Name = "pbOutput";
            this.pbOutput.Size = new System.Drawing.Size(736, 535);
            this.pbOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOutput.TabIndex = 3;
            this.pbOutput.TabStop = false;
            // 
            // pbInput
            // 
            this.pbInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbInput.Location = new System.Drawing.Point(0, 0);
            this.pbInput.Margin = new System.Windows.Forms.Padding(4);
            this.pbInput.Name = "pbInput";
            this.pbInput.Size = new System.Drawing.Size(730, 535);
            this.pbInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbInput.TabIndex = 2;
            this.pbInput.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbOutput);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(730, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 535);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pbInput);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(730, 535);
            this.panel2.TabIndex = 5;
            // 
            // blackAndWhiteToolStripMenuItem
            // 
            this.blackAndWhiteToolStripMenuItem.Name = "blackAndWhiteToolStripMenuItem";
            this.blackAndWhiteToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.blackAndWhiteToolStripMenuItem.Text = "Black And White";
            this.blackAndWhiteToolStripMenuItem.Click += new System.EventHandler(this.blackAndWhiteToolStripMenuItem_Click);
            // 
            // histogramEqualizationToolStripMenuItem
            // 
            this.histogramEqualizationToolStripMenuItem.Name = "histogramEqualizationToolStripMenuItem";
            this.histogramEqualizationToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.histogramEqualizationToolStripMenuItem.Text = "Histogram Equalization";
            this.histogramEqualizationToolStripMenuItem.Click += new System.EventHandler(this.histogramEqualizationToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 589);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Garuda Image Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInput)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbInput;
        private System.Windows.Forms.PictureBox pbOutput;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem greyScaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem averageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem luminanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brightnessToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yellowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cyanToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem purpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brownToolStripMenuItem;
        private System.Windows.Forms.ToolStripProgressBar progressBar1;
        private System.Windows.Forms.ToolStripMenuItem inverseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logBrightnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logContrastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitDepthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bitToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem bitToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem bitToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem bitToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem bitToolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem gammaCorrectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rGBHistogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputOutputToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem edgeDetectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackAndWhiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramEqualizationToolStripMenuItem;
    }
}

