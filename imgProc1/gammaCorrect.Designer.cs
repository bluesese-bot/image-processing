namespace imgProc1
{
    partial class gammaCorrect
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
            this.hscGamma = new System.Windows.Forms.HScrollBar();
            this.tbGamma = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hscGamma
            // 
            this.hscGamma.Location = new System.Drawing.Point(73, 34);
            this.hscGamma.Maximum = 20;
            this.hscGamma.Name = "hscGamma";
            this.hscGamma.Size = new System.Drawing.Size(429, 21);
            this.hscGamma.TabIndex = 0;
            this.hscGamma.ValueChanged += new System.EventHandler(this.hscGamma_ValueChanged);
            // 
            // tbGamma
            // 
            this.tbGamma.Location = new System.Drawing.Point(572, 35);
            this.tbGamma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbGamma.Name = "tbGamma";
            this.tbGamma.Size = new System.Drawing.Size(57, 22);
            this.tbGamma.TabIndex = 1;
            this.tbGamma.Text = "0";
            this.tbGamma.TextChanged += new System.EventHandler(this.tbGamma_TextChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(73, 96);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(556, 53);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // gammaCorrect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 193);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbGamma);
            this.Controls.Add(this.hscGamma);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "gammaCorrect";
            this.Text = "gammaCorrect";
            this.Load += new System.EventHandler(this.gammaCorrect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar hscGamma;
        public System.Windows.Forms.TextBox tbGamma;
        private System.Windows.Forms.Button btnOk;
    }
}