using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imgProc1
{
    public partial class HistogramRGB : Form
    {
        public int iStatus { get; set; }
        public HistogramRGB(int status)
        {
            InitializeComponent();
            iStatus = status;
        }
        public void loadStatus(int status)
        {
            switch (status)
            {
                case 0:
                    panelHistogramRGB.Visible = false;
                    break;
                case 1:
                    panelHistogram.Visible = false;
                    break;
                default:
                    break;
            }
        }
        private void HistogramRGB_Load(object sender, EventArgs e)
        {
            loadStatus(iStatus);
        }
    }
}
