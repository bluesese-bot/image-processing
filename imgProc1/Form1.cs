using AForge.Imaging.Filters;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace imgProc1
{
    public partial class Form1 : Form
    {
        private Bitmap Image, Image2;
        private BitmapData ImageData, ImageData2;
        private byte[] buffer, buffer2;
        private int b, g, r, r_x, g_x, b_x, r_y, g_y, b_y, grayscale, location, location2;
        private sbyte weight_x, weight_y;
        private sbyte[,] weights_x;
        private sbyte[,] weights_y;
        private IntPtr pointer, pointer2;
        public Form1()
        {
            InitializeComponent();
            weights_x = new sbyte[,] { { 1, 0, -1 }, { 2, 0, -2 }, { 1, 0, -1 } };
            weights_y = new sbyte[,] { { 1, 2, 1 }, { 0, 0, 0 }, { -1, -2, -1 } };
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image File (*.bmp, *.jpg, *.jpeg)|*.bmp;*.jpg;*.jpeg";

            if (DialogResult.OK == openFile.ShowDialog())
            {
                this.pbInput.Image = new Bitmap(openFile.FileName);
                Image = new Bitmap(openFile.FileName);
                Image2 = new Bitmap(Image.Width, Image.Height);
                toolStripStatusLabel1.Text = openFile.FileName + '|' + pbInput.Image.Width + "X" + pbInput.Image.Height;
            }
        }
        private static int truncate(int x)
        {
            if (x > 255) x = 255;
            else if (x < 0) x = 0;
            return x;
        }
        private void fileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (pbOutput.Image == null)
            {
                MessageBox.Show("Không có tệp nào được lưu");
            }
            else
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Title = "Simpan File Citra";
                saveFile.Filter = "Image File (*.bmp,*.jpg,*.jpeg)|*.bmp;*.jpg;*.jpeg";
                if (DialogResult.OK == saveFile.ShowDialog())
                    this.pbOutput.Image.Save(saveFile.FileName);
            }
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Dispose();
        }
        private void greyScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void brightnessToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (pbInput.Image == null)
            {
                MessageBox.Show("Không có hình ảnh nào được xử lý");
            }
            else
            {
                BrightnessContrast bc = new BrightnessContrast();
                if (bc.ShowDialog() == DialogResult.OK)
                {
                    Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
                    int nilaiBrightness = Convert.ToInt16(bc.tbBrightness.Text);

                    int nilaiContrast = Convert.ToInt16(bc.tbContrast.Text);
                    double a = (259 * (nilaiContrast + 255)) / (255 * (259 - nilaiContrast));
                    progressBar1.Visible = true;
                    for (int i = 0; i < b.Width; i++)
                    {
                        for (int j = 0; j < b.Height; j++)
                        {
                            Color c1 = b.GetPixel(i, j);
                            int r1 = truncate((c1.R + nilaiBrightness) + (Convert.ToInt16(a) * (c1.R - 128) + 128));
                            int g1 = truncate((c1.G + nilaiBrightness) + (Convert.ToInt16(a) * (c1.G - 128) + 128));
                            int b1 = truncate((c1.B + nilaiBrightness) + (Convert.ToInt16(a) * (c1.B - 128) + 128));
                            b.SetPixel(i, j, Color.FromArgb(r1, g1, b1));
                        }
                        progressBar1.Value = Convert.ToInt16(100 * (i + 1) / b.Width);
                    }


                    progressBar1.Visible = false;
                    this.pbOutput.Image = b;
                }
            }

        }
        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.pbInput.Image);
            this.pbOutput.Image = Transform(copy, "Red");
        }
        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.pbInput.Image);
            this.pbOutput.Image = Transform(copy, "Yellow");
        }
        private void orangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.pbInput.Image);
            this.pbOutput.Image = Transform(copy, "Orange");
        }
        private void cyanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.pbInput.Image);
            this.pbOutput.Image = Transform(copy, "Cyan");
        }
        private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.pbInput.Image);
            this.pbOutput.Image = Transform(copy, "Purple");
        }
        private void greyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.pbInput.Image);
            this.pbOutput.Image = Transform(copy, "Green");
        }
        private void brownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.pbInput.Image);
            this.pbOutput.Image = Transform(copy, "Blue");
        }
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
        private void inverseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbInput.Image == null)
            {
                MessageBox.Show("Không có hình ảnh nào được xử lý");
            }
            else
            {
                Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
                progressBar1.Visible = true;
                for (int i = 0; i < b.Width; i++)
                {
                    for (int j = 0; j < b.Height; j++)
                    {
                        Color c1 = b.GetPixel(i, j);

                        int r1 = 255 - c1.R;
                        int g1 = 255 - c1.G;
                        int b1 = 255 - c1.B;

                        b.SetPixel(i, j, Color.FromArgb(r1, g1, b1));
                    }
                    progressBar1.Value = Convert.ToInt16(100 * (i + 1) / b.Width);
                }
                progressBar1.Visible = false;
                this.pbOutput.Image = b;
            }
        }
        private void logBrightnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbInput.Image == null)
            {
                MessageBox.Show("Không có hình ảnh nào được xử lý");
            }
            else
            {
                LogBrightness frmLogBr = new LogBrightness();
                if (frmLogBr.ShowDialog() == DialogResult.Cancel)
                {

                    Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);

                    var nilaiBrighness = Convert.ToSingle(frmLogBr.tbLogBrightness.Text);
                    // Make the ColorMatrix.
                    ColorMatrix cm = new ColorMatrix(new float[][]
                        {
                    new float[] { nilaiBrighness, 0, 0, 0, 0},
                    new float[] {0, nilaiBrighness, 0, 0, 0},
                    new float[] {0, 0, nilaiBrighness, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {0, 0, 0, 0, 1},
                        });
                    ImageAttributes attributes = new ImageAttributes();
                    attributes.SetColorMatrix(cm);

                    // Draw the image onto the new bitmap while applying the new ColorMatrix.
                    Point[] points =
                    {
                        new Point(0, 0),
                        new Point(b.Width, 0),
                        new Point(0, b.Height),
                    };
                    Rectangle rect = new Rectangle(0, 0, b.Width, b.Height);

                    // Make the result bitmap.
                    Bitmap bm = new Bitmap(b.Width, b.Height);
                    using (Graphics gr = Graphics.FromImage(bm))
                    {
                        gr.DrawImage(b, points, rect, GraphicsUnit.Pixel, attributes);
                    }

                    // Return the result
                    this.pbOutput.Image = bm;

                }
            }
        }
        private void logContrastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbInput.Image == null)
            {
                MessageBox.Show("Không có hình ảnh nào được xử lý");
            }
            else
            {
                LogContrast frmLogCo = new LogContrast();
                if (frmLogCo.ShowDialog() == DialogResult.Cancel)
                {
                    double contrast = Convert.ToDouble(frmLogCo.tbLogContrast.Text);
                    Bitmap bmap = new Bitmap((Bitmap)this.pbInput.Image);
                    if (contrast < -100) contrast = -100;
                    if (contrast > 100) contrast = 100;
                    contrast = (100.0 + contrast) / 100.0;
                    contrast *= contrast;
                    Color col;
                    progressBar1.Visible = true;
                    for (int i = 0; i < bmap.Width; i++)
                    {
                        for (int j = 0; j < bmap.Height; j++)
                        {
                            col = bmap.GetPixel(i, j);
                            double pRed = col.R / 255.0;
                            pRed -= 0.5;
                            pRed *= contrast;
                            pRed += 0.5;
                            pRed *= 255;
                            if (pRed < 0) pRed = 0;
                            if (pRed > 255) pRed = 255;

                            double pGreen = col.G / 255.0;
                            pGreen -= 0.5;
                            pGreen *= contrast;
                            pGreen += 0.5;
                            pGreen *= 255;
                            if (pGreen < 0) pGreen = 0;
                            if (pGreen > 255) pGreen = 255;

                            double pBlue = col.B / 255.0;
                            pBlue -= 0.5;
                            pBlue *= contrast;
                            pBlue += 0.5;
                            pBlue *= 255;
                            if (pBlue < 0) pBlue = 0;
                            if (pBlue > 255) pBlue = 255;

                            bmap.SetPixel(i, j,
                    Color.FromArgb((byte)pRed, (byte)pGreen, (byte)pBlue));
                        }
                        progressBar1.Value = Convert.ToInt16(100 * (i + 1) / bmap.Width);
                    }
                    this.pbOutput.Image = bmap;
                }
            }
        }
        private void averageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbInput.Image == null)
            {
                MessageBox.Show("Không có hình ảnh nào được xử lý");
            }
            else
            {
                Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
                progressBar1.Visible = true;
                for (int i = 0; i < b.Width; i++)
                {
                    for (int j = 0; j < b.Height; j++)
                    {
                        Color c1 = b.GetPixel(i, j);
                        int grayAvg = (c1.R + c1.G + c1.B) / 3;
                        b.SetPixel(i, j, Color.FromArgb(grayAvg, grayAvg, grayAvg));
                    }
                    progressBar1.Value = Convert.ToInt16(100 * (i + 1) / b.Width);
                }

                progressBar1.Visible = false;
                this.pbOutput.Image = b;
            }
        }
        private void luminanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbInput.Image == null)
            {
                MessageBox.Show("Không có hình ảnh nào được xử lý");
            }
            else
            {
                Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
                progressBar1.Visible = true;
                for (int i = 0; i < b.Width; i++)
                {
                    for (int j = 0; j < b.Height; j++)
                    {
                        Color c1 = b.GetPixel(i, j);
                        int gLum = Convert.ToInt16(0.21 * c1.R + 0.72 * c1.G + 0.07 * c1.B);
                        b.SetPixel(i, j, Color.FromArgb(gLum, gLum, gLum));
                    }
                    progressBar1.Value = Convert.ToInt16(100 * (i + 1) / b.Width);
                }

                progressBar1.Visible = false;
                this.pbOutput.Image = b;
            }
        }
        private void lightnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbInput.Image == null)
            {
                MessageBox.Show("Không có hình ảnh nào được xử lý");
            }
            else
            {
                Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
                progressBar1.Visible = true;
                for (int i = 0; i < b.Width; i++)
                {
                    for (int j = 0; j < b.Height; j++)
                    {
                        Color c1 = b.GetPixel(i, j);
                        int nilaiMax = Math.Max(c1.R, Math.Max(c1.G, c1.B));
                        int nilaiMin = Math.Min(c1.R, Math.Min(c1.G, c1.B));
                        int gLight = (nilaiMax + nilaiMin) / 2;
                        b.SetPixel(i, j, Color.FromArgb(gLight, gLight, gLight));
                    }
                    progressBar1.Value = Convert.ToInt16(100 * (i + 1) / b.Width);
                }

                progressBar1.Visible = false;
                this.pbOutput.Image = b;
            }
        }
        private void colorsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void bitToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            BitDepth(1);
        }
        private void bitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BitDepth(2);
        }
        private void bitDepthToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void bitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BitDepth(3);
        }
        private void bitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            BitDepth(4);
        }

        private void blackAndWhiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbInput.Image == null)
            {
                MessageBox.Show("Không có hình ảnh nào được xử lý");
            }
            else
            {
                Bitmap bmap = (Bitmap)this.pbInput.Image;
                Color c;
                progressBar1.Visible = true;
                for (int i = 0; i < bmap.Width; i++)
                {
                    for (int j = 0; j < bmap.Height; j++)
                    {
                        c = bmap.GetPixel(i, j);
                        byte gray = (byte)(.299 * c.R + .587 * c.G + .114 * c.B);

                        bmap.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                    }
                    progressBar1.Value = Convert.ToInt16(100 * (i + 1) / bmap.Width);
                }
                progressBar1.Visible = false;
                this.pbOutput.Image = bmap;
            }
        }

        private void histogramEqualizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bmap = (Bitmap)this.pbInput.Image.Clone();
            // create filter
            HistogramEqualization filter = new HistogramEqualization();
            // process image
            filter.ApplyInPlace(bmap);
            pbOutput.Image = bmap;
        }

        private void bitToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            BitDepth(5);
        }
        private void bitToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            BitDepth(6);
        }
        private void bitToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            BitDepth(7);
        }
        private void gammaCorrectionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void gammaCorrectionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (pbInput.Image == null)
            {
                MessageBox.Show("Không có hình ảnh nào được xử lý");
            }
            else
            {
                gammaCorrect gammaCor = new gammaCorrect();
                if (gammaCor.ShowDialog() == DialogResult.Cancel)
                {
                    Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
                    double nilaiGamma = Convert.ToDouble(gammaCor.tbGamma.Text);
                    progressBar1.Visible = true;
                    double r1, g1, b1;

                    double merah, hijau, biru;
                    for (int i = 0; i < b.Width; i++)
                    {
                        for (int j = 0; j < b.Height; j++)
                        {
                            merah = b.GetPixel(i, j).R;
                            hijau = b.GetPixel(i, j).G;
                            biru = b.GetPixel(i, j).B;

                            r1 = 255 * Math.Pow((merah / 255), nilaiGamma);
                            g1 = 255 * Math.Pow((hijau / 255), nilaiGamma);
                            b1 = 255 * Math.Pow((biru / 255), nilaiGamma);
                            b.SetPixel(i, j, Color.FromArgb(Convert.ToInt16(r1), Convert.ToInt16(g1), Convert.ToInt16(b1)));
                        }
                        progressBar1.Value = Convert.ToInt16(100 * (i + 1) / b.Width);
                    }
                    progressBar1.Visible = false;
                    this.pbOutput.Image = b;
                }
            }
        }
        private void inputToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void inputToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            histogram(pbInput, 1);
        }
        private void outputToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            histogram(pbOutput, 0);
        }
        private void inputOutputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            histogram(pbInput, pbOutput, 2);
        }
        private void inputToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        private void outputToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        protected void histogram(PictureBox pictureIMG, int Status)
        {
            if (pictureIMG.Image == null)
                MessageBox.Show("Không có hình ảnh nào được xử lý");
            else
            {
                double[] HistoR = new double[256];
                double[] HistoG = new double[256];
                double[] HistoB = new double[256];
                Bitmap b = new Bitmap((Bitmap)pictureIMG.Image);
                HistogramRGB histogramRGB = new HistogramRGB(Status) { Width = 650, Height = 700 };
                progressBar1.Visible = true;
                for (int i = 0; i < 255; i++)
                {
                    HistoR[i] = 0;
                    HistoG[i] = 0;
                    HistoB[i] = 0;
                }

                for (int i = 0; i <= 255; i++)
                {
                    for (int j = 0; j <= 255; j++)
                    {
                        Color c1 = b.GetPixel(i, j);
                        int merah = c1.R;
                        int hijau = c1.G;
                        int biru = c1.B;
                        HistoR[merah]++;
                        HistoG[hijau]++;
                        HistoB[biru]++;
                    }
                    progressBar1.Value = Convert.ToInt16(100 * (i + 1) / b.Width);
                }

                progressBar1.Visible = false;

                Double sumR = 0;
                for (int i = 0; i < 255; i++)
                {
                    if (HistoG[i] == HistoB[i])
                    {
                        sumR++;
                    }
                }
                switch (Status)
                {
                    case 0:
                        histogramRGB.chart4.Series["Series1"].Color = Color.Gray;
                        histogramRGB.chart4.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                        histogramRGB.chart4.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

                        foreach (Double HstR in HistoR)
                        {
                            for (int i = 0; i <= 255; i++)
                            {
                                histogramRGB.chart4.Series["Series1"].Points.AddXY(i, (HistoR[i] + HistoG[i] + HistoB[i]) / 3);
                            }
                        }
                        histogramRGB.ShowDialog();
                        break;
                    case 1:
                        histogramRGB.chart1.Series["Series1"].Color = Color.Red;
                        histogramRGB.chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                        histogramRGB.chart1.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

                        foreach (Double HstR in HistoR)
                        {
                            for (int i = 0; i <= 255; i++)
                            {
                                histogramRGB.chart1.Series["Series1"].Points.AddXY(i, HistoR[i]);
                            }
                        }

                        histogramRGB.chart2.Series["Series1"].Color = Color.Green;
                        histogramRGB.chart2.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                        histogramRGB.chart2.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

                        foreach (Double HstG in HistoG)
                        {
                            for (int i = 0; i <= 255; i++)
                            {
                                histogramRGB.chart2.Series["Series1"].Points.AddXY(i, HistoG[i]);
                            }
                        }

                        histogramRGB.chart3.Series["Series1"].Color = Color.Blue;
                        histogramRGB.chart3.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                        histogramRGB.chart3.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

                        foreach (Double HstB in HistoB)
                        {
                            for (int i = 0; i <= 255; i++)
                            {
                                histogramRGB.chart3.Series["Series1"].Points.AddXY(i, HistoB[i]);
                            }
                        }
                        histogramRGB.ShowDialog();
                        break;
                    default:
                        histogramRGB.chart1.Series["Series1"].Color = Color.Red;
                        histogramRGB.chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                        histogramRGB.chart1.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

                        foreach (Double HstR in HistoR)
                        {
                            for (int i = 0; i <= 255; i++)
                            {
                                histogramRGB.chart1.Series["Series1"].Points.AddXY(i, HistoR[i]);
                            }
                        }

                        histogramRGB.chart2.Series["Series1"].Color = Color.Green;
                        histogramRGB.chart2.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                        histogramRGB.chart2.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

                        foreach (Double HstG in HistoG)
                        {
                            for (int i = 0; i <= 255; i++)
                            {
                                histogramRGB.chart2.Series["Series1"].Points.AddXY(i, HistoG[i]);
                            }
                        }

                        histogramRGB.chart3.Series["Series1"].Color = Color.Blue;
                        histogramRGB.chart3.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                        histogramRGB.chart3.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

                        foreach (Double HstB in HistoB)
                        {
                            for (int i = 0; i <= 255; i++)
                            {
                                histogramRGB.chart3.Series["Series1"].Points.AddXY(i, HistoB[i]);
                            }
                        }
                        histogramRGB.chart4.Series["Series1"].Color = Color.Gray;
                        histogramRGB.chart4.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                        histogramRGB.chart4.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

                        foreach (Double HstR in HistoR)
                        {
                            for (int i = 0; i <= 255; i++)
                            {
                                histogramRGB.chart4.Series["Series1"].Points.AddXY(i, (HistoR[i] + HistoG[i] + HistoB[i]) / 3);
                            }
                        }
                        histogramRGB.ShowDialog();
                        break;
                }
            }
        }
        protected void histogram(PictureBox pictureIMGinput, PictureBox pictureIMGout, int Status)
        {
            if (pictureIMGinput.Image == null || pictureIMGout.Image == null)
                MessageBox.Show("Không có hình ảnh nào được xử lý");
            else
            {
                double[] HistoR = new double[256];
                double[] HistoG = new double[256];
                double[] HistoB = new double[256];
                double[] iHistoR = new double[256];
                double[] iHistoG = new double[256];
                double[] iHistoB = new double[256];
                Bitmap b = new Bitmap((Bitmap)pictureIMGinput.Image);
                Bitmap ib = new Bitmap((Bitmap)pictureIMGout.Image);
                HistogramRGB histogramRGB = new HistogramRGB(Status) { Height = 700, Width = 1280 };
                progressBar1.Visible = true;
                for (int i = 0; i < 255; i++)
                {
                    HistoR[i] = 0;
                    HistoG[i] = 0;
                    HistoB[i] = 0;
                }

                for (int i = 0; i <= 255; i++)
                {
                    for (int j = 0; j <= 255; j++)
                    {
                        Color c1 = b.GetPixel(i, j);
                        int merah = c1.R;
                        int hijau = c1.G;
                        int biru = c1.B;
                        HistoR[merah]++;
                        HistoG[hijau]++;
                        HistoB[biru]++;
                    }
                    progressBar1.Value = Convert.ToInt16(100 * (i + 1) / b.Width);
                }
                for (int i = 0; i < 255; i++)
                {
                    iHistoR[i] = 0;
                    iHistoG[i] = 0;
                    iHistoB[i] = 0;
                }

                for (int i = 0; i <= 255; i++)
                {
                    for (int j = 0; j <= 255; j++)
                    {
                        Color ic1 = ib.GetPixel(i, j);
                        int imerah = ic1.R;
                        int ihijau = ic1.G;
                        int ibiru = ic1.B;
                        iHistoR[imerah]++;
                        iHistoG[ihijau]++;
                        iHistoB[ibiru]++;
                    }
                    progressBar1.Value = Convert.ToInt16(100 * (i + 1) / ib.Width);
                }

                progressBar1.Visible = false;

                histogramRGB.chart1.Series["Series1"].Color = Color.Red;
                histogramRGB.chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                histogramRGB.chart1.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

                foreach (Double HstR in HistoR)
                {
                    for (int i = 0; i <= 255; i++)
                    {
                        histogramRGB.chart1.Series["Series1"].Points.AddXY(i, HistoR[i]);
                    }
                }

                histogramRGB.chart2.Series["Series1"].Color = Color.Green;
                histogramRGB.chart2.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                histogramRGB.chart2.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

                foreach (Double HstG in HistoG)
                {
                    for (int i = 0; i <= 255; i++)
                    {
                        histogramRGB.chart2.Series["Series1"].Points.AddXY(i, HistoG[i]);
                    }
                }

                histogramRGB.chart3.Series["Series1"].Color = Color.Blue;
                histogramRGB.chart3.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                histogramRGB.chart3.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

                foreach (Double HstB in HistoB)
                {
                    for (int i = 0; i <= 255; i++)
                    {
                        histogramRGB.chart3.Series["Series1"].Points.AddXY(i, HistoB[i]);
                    }
                }
                histogramRGB.chart4.Series["Series1"].Color = Color.Gray;
                histogramRGB.chart4.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                histogramRGB.chart4.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

                foreach (Double iHstR in iHistoR)
                {
                    for (int i = 0; i <= 255; i++)
                    {
                        histogramRGB.chart4.Series["Series1"].Points.AddXY(i, (iHistoR[i] + iHistoG[i] + iHistoB[i]) / 3);
                    }
                }
                histogramRGB.ShowDialog();
            }
        }
        private void edgeDetectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageData = Image.LockBits(new Rectangle(0, 0, Image.Width, Image.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            ImageData2 = Image2.LockBits(new Rectangle(0, 0, Image.Width, Image.Height), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
            buffer = new byte[ImageData.Stride * Image.Height];
            buffer2 = new byte[ImageData.Stride * Image.Height];
            pointer = ImageData.Scan0;
            pointer2 = ImageData2.Scan0;
            Marshal.Copy(pointer, buffer, 0, buffer.Length);
            progressBar1.Visible = true;
            for (int y = 0; y < Image.Height; y++)
            {
                for (int x = 0; x < Image.Width * 3; x += 3)
                {
                    r_x = g_x = b_x = 0; //reset the gradients in x-direcion values
                    r_y = g_y = b_y = 0; //reset the gradients in y-direction values
                    location = x + y * ImageData.Stride; //to get the location of any pixel >> location = x + y * Stride
                    for (int yy = -(int)Math.Floor(weights_y.GetLength(0) / 2.0d), yyy = 0; yy <= (int)Math.Floor(weights_y.GetLength(0) / 2.0d); yy++, yyy++)
                    {
                        if (y + yy >= 0 && y + yy < Image.Height) //to prevent crossing the bounds of the array
                        {
                            for (int xx = -(int)Math.Floor(weights_x.GetLength(1) / 2.0d) * 3, xxx = 0; xx <= (int)Math.Floor(weights_x.GetLength(1) / 2.0d) * 3; xx += 3, xxx++)
                            {
                                if (x + xx >= 0 && x + xx <= Image.Width * 3 - 3) //to prevent crossing the bounds of the array
                                {
                                    location2 = x + xx + (yy + y) * ImageData.Stride; //to get the location of any pixel >> location = x + y * Stride
                                    weight_x = weights_x[yyy, xxx];
                                    weight_y = weights_y[yyy, xxx];
                                    //applying the same weight to all channels
                                    b_x += buffer[location2] * weight_x;
                                    g_x += buffer[location2 + 1] * weight_x; //G_X
                                    r_x += buffer[location2 + 2] * weight_x;
                                    b_y += buffer[location2] * weight_y;
                                    g_y += buffer[location2 + 1] * weight_y;//G_Y
                                    r_y += buffer[location2 + 2] * weight_y;
                                }
                            }
                        }
                    }
                    //getting the magnitude for each channel
                    b = (int)Math.Sqrt(Math.Pow(b_x, 2) + Math.Pow(b_y, 2));
                    g = (int)Math.Sqrt(Math.Pow(g_x, 2) + Math.Pow(g_y, 2));//G
                    r = (int)Math.Sqrt(Math.Pow(r_x, 2) + Math.Pow(r_y, 2));

                    if (b > 255) b = 255;
                    if (g > 255) g = 255;
                    if (r > 255) r = 255;

                    //getting grayscale value
                    grayscale = (b + g + r) / 3;

                    //thresholding to clean up the background
                    //if (grayscale < 80) grayscale = 0;
                    buffer2[location] = (byte)grayscale;
                    buffer2[location + 1] = (byte)grayscale;
                    buffer2[location + 2] = (byte)grayscale;
                    //thresholding to clean up the background
                    //if (b < 100) b = 0;
                    //if (g < 100) g = 0;
                    //if (r < 100) r = 0;

                    //buffer2[location] = (byte)b;
                    //buffer2[location + 1] = (byte)g;
                    //buffer2[location + 2] = (byte)r;
                }
                progressBar1.Value = Convert.ToInt16(100 * (y + 1) / Image.Height);
            }
            progressBar1.Visible = false;
            Marshal.Copy(buffer2, 0, pointer2, buffer.Length);
            Image.UnlockBits(ImageData);
            Image2.UnlockBits(ImageData2);
            pbOutput.Image = Image2;
        }
        public Bitmap Transform(Bitmap Source, string filterColor)
        {
            if (Source == null) MessageBox.Show("Không có hình ảnh nào được xử lý");

            // Extract the bitmap data
            Bitmap Result = new Bitmap(Source);
            BitmapData ResultData = Result.LockBits(new Rectangle(0, 0, Result.Width, Result.Height), ImageLockMode.ReadWrite, Result.PixelFormat);

            // Create a byte array to hold the pixel data
            int BytesPerPixel = System.Drawing.Bitmap.GetPixelFormatSize(Result.PixelFormat) / 8;
            int ByteCount = ResultData.Stride * Result.Height;
            byte[] Pixels = new byte[ByteCount];

            // Copy the bitmap data to the byte array
            IntPtr PtrFirstPixel = ResultData.Scan0;
            Marshal.Copy(PtrFirstPixel, Pixels, 0, Pixels.Length);

            // Calculate step-through information
            int HeightInPixels = ResultData.Height;
            int WidthInBytes = ResultData.Width * BytesPerPixel;

            // Perform the color filtering
            switch (filterColor)
            {
                case "Red":
                    for (int y = 0; y < HeightInPixels; y++)
                    {
                        int CurrentLine = y * ResultData.Stride;
                        for (int x = 0; x < WidthInBytes; x = x + BytesPerPixel)
                        {
                            int OldBlue = Pixels[CurrentLine + x];
                            int OldGreen = Pixels[CurrentLine + x + 1];

                            Pixels[CurrentLine + x] = (byte)(OldBlue - 255);
                            if (OldBlue - 255 < 0) Pixels[CurrentLine + x] = 1;

                            Pixels[CurrentLine + x + 1] = (byte)(OldGreen - 255);
                            if (OldGreen - 255 < 0) Pixels[CurrentLine + x + 1] = 1;
                        }
                    }
                    break;

                case "Green":
                    for (int y = 0; y < HeightInPixels; y++)
                    {
                        int CurrentLine = y * ResultData.Stride;
                        for (int x = 0; x < WidthInBytes; x = x + BytesPerPixel)
                        {
                            int OldBlue = Pixels[CurrentLine + x];
                            int OldRed = Pixels[CurrentLine + x + 2];

                            Pixels[CurrentLine + x] = (byte)(OldBlue - 255);
                            if (OldBlue - 255 < 0) Pixels[CurrentLine + x] = 1;

                            Pixels[CurrentLine + x + 2] = (byte)(OldBlue - 255);
                            if (OldRed - 255 < 0) Pixels[CurrentLine + x + 2] = 1;
                        }
                    }
                    break;

                case "Blue":
                    for (int y = 0; y < HeightInPixels; y++)
                    {
                        int CurrentLine = y * ResultData.Stride;
                        for (int x = 0; x < WidthInBytes; x = x + BytesPerPixel)
                        {
                            int OldGreen = Pixels[CurrentLine + x + 1];
                            int OldRed = Pixels[CurrentLine + x + 2];

                            Pixels[CurrentLine + x + 1] = (byte)(OldGreen - 255);
                            if (OldGreen - 255 < 0) Pixels[CurrentLine + x + 1] = 1;

                            Pixels[CurrentLine + x + 2] = (byte)(OldRed - 255);
                            if (OldRed - 255 < 0) Pixels[CurrentLine + x + 2] = 1;
                        }
                    }
                    break;

                case "Yellow":
                    for (int y = 0; y < HeightInPixels; y++)
                    {
                        int CurrentLine = y * ResultData.Stride;
                        for (int x = 0; x < WidthInBytes; x = x + BytesPerPixel)
                        {
                            int OldBlue = Pixels[CurrentLine + x];

                            Pixels[CurrentLine + x] = (byte)(OldBlue - 255);
                            if (OldBlue - 255 < 0) Pixels[CurrentLine + x] = 1;
                        }
                    }
                    break;

                case "Purple":
                    for (int y = 0; y < HeightInPixels; y++)
                    {
                        int CurrentLine = y * ResultData.Stride;
                        for (int x = 0; x < WidthInBytes; x = x + BytesPerPixel)
                        {
                            int OldGreen = Pixels[CurrentLine + x + 1];

                            Pixels[CurrentLine + x + 1] = (byte)(OldGreen - 255);
                            if (OldGreen - 255 < 0) Pixels[CurrentLine + x + 1] = 1;
                        }
                    }
                    break;

                case "Cyan":
                    for (int y = 0; y < HeightInPixels; y++)
                    {
                        int CurrentLine = y * ResultData.Stride;
                        for (int x = 0; x < WidthInBytes; x = x + BytesPerPixel)
                        {
                            int OldRed = Pixels[CurrentLine + x + 2];

                            Pixels[CurrentLine + x + 2] = (byte)(OldRed - 255);
                            if (OldRed - 255 < 0) Pixels[CurrentLine + x + 2] = 1;
                        }
                    }
                    break;

                default:
                    break;
            }

            // Finalise changes and return
            Marshal.Copy(Pixels, 0, PtrFirstPixel, Pixels.Length);
            Result.UnlockBits(ResultData);
            return Result;
        }
        void BitDepth(int bit)
        {
            if (pbInput.Image == null)
            {
                MessageBox.Show("Không có hình ảnh nào được xử lý");
            }
            else
            {
                Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
                double level = 255 - Math.Pow(2, bit) - 1;
                progressBar1.Visible = true;
                for (int i = 0; i < b.Width; i++)
                {
                    for (int j = 0; j < b.Height; j++)
                    {
                        Color c1 = b.GetPixel(i, j);
                        int R = Convert.ToInt16(Math.Round(c1.R / level) * level);
                        int G = Convert.ToInt16(Math.Round(c1.G / level) * level);
                        int B = Convert.ToInt16(Math.Round(c1.B / level)
                            * level);
                        b.SetPixel(i, j, Color.FromArgb(R, G, B));
                    }
                    progressBar1.Value = Convert.ToInt16(100 * (i + 1) / b.Width);
                }
                progressBar1.Visible = false;
                this.pbOutput.Image = b;
            }
        }
    }
}
