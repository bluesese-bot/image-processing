namespace imgProc1
{
    partial class LogContrast
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
            this.hscLogContrast = new System.Windows.Forms.HScrollBar();
            this.tbLogContrast = new System.Windows.Forms.TextBox();
            this.btnLogContrast = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hscLogContrast
            // 
            this.hscLogContrast.Location = new System.Drawing.Point(25, 36);
            this.hscLogContrast.Maximum = 105;
            this.hscLogContrast.Name = "hscLogContrast";
            this.hscLogContrast.Size = new System.Drawing.Size(452, 20);
            this.hscLogContrast.TabIndex = 0;
            this.hscLogContrast.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hscLogContrast_Scroll);
            // 
            // tbLogContrast
            // 
            this.tbLogContrast.Location = new System.Drawing.Point(527, 36);
            this.tbLogContrast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLogContrast.Name = "tbLogContrast";
            this.tbLogContrast.Size = new System.Drawing.Size(132, 22);
            this.tbLogContrast.TabIndex = 1;
            this.tbLogContrast.Text = "0";
            this.tbLogContrast.TextChanged += new System.EventHandler(this.tbLogContrast_TextChanged);
            // 
            // btnLogContrast
            // 
            this.btnLogContrast.Location = new System.Drawing.Point(25, 90);
            this.btnLogContrast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogContrast.Name = "btnLogContrast";
            this.btnLogContrast.Size = new System.Drawing.Size(634, 39);
            this.btnLogContrast.TabIndex = 2;
            this.btnLogContrast.Text = "OK";
            this.btnLogContrast.UseVisualStyleBackColor = true;
            this.btnLogContrast.Click += new System.EventHandler(this.btnLogContrast_Click);
            // 
            // LogContrast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 158);
            this.Controls.Add(this.btnLogContrast);
            this.Controls.Add(this.tbLogContrast);
            this.Controls.Add(this.hscLogContrast);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LogContrast";
            this.Text = "LogContrast";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar hscLogContrast;
        public System.Windows.Forms.TextBox tbLogContrast;
        private System.Windows.Forms.Button btnLogContrast;
    }
}