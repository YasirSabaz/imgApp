using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imgApp_Yasir_SABAZ
{
    public partial class Form3 : Form
    {
        Bitmap resimkaynagi, islemyap;
        public Form3()
        {
            InitializeComponent();
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult img = openFileDialog1.ShowDialog();
            if (img == DialogResult.OK)
            {
                resimkaynagi = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = resimkaynagi;
            }
        }

        private void ortalamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
            if (pictureBox1.Image != null)
            {
                int genislik = resimkaynagi.Width;
                int yükseklik = resimkaynagi.Height;
                islemyap = new Bitmap(genislik, yükseklik);
                for (int y = 0; y < yükseklik; y++)
                {
                    for (int x = 0; x < genislik; x++)
                    {
                        Color renkal = resimkaynagi.GetPixel(x, y);
                        double ort = (renkal.R + renkal.G + renkal.B) / 3;
                        int ortInt = Convert.ToInt32(ort);
                        Color gri = Color.FromArgb(ortInt, ortInt, ortInt);
                        islemyap.SetPixel(x, y, gri);
                    }
                }
                pictureBox2.Image = islemyap;
            }
            else
            {
                MessageBox.Show("RESİM AÇMADINIZ","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void açıklıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
            if (pictureBox1.Image != null)
            {
                int genislik = resimkaynagi.Width;
                int yükseklik = resimkaynagi.Height;
                islemyap = new Bitmap(genislik, yükseklik);
                for (int y = 0; y < yükseklik; y++)
                {
                    for (int x = 0; x < genislik; x++)
                    {
                        Color renkal = resimkaynagi.GetPixel(x, y);
                        int[] rgbArray = { renkal.R, renkal.G, renkal.B };
                        double aciklik = (rgbArray.Max() + rgbArray.Min()) / 2;
                        int aciklikInt = Convert.ToInt32(aciklik);
                        Color grey = Color.FromArgb(aciklikInt, aciklikInt, aciklikInt);
                        islemyap.SetPixel(x, y, grey);
                    }
                }
                pictureBox2.Image = islemyap;
            }
            else
            {
                MessageBox.Show("RESİM AÇMADINIZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void kanalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
            if (pictureBox1.Image != null)
            {
                int genislik = resimkaynagi.Width;
                int yükseklik = resimkaynagi.Height;
                islemyap = new Bitmap(genislik, yükseklik);
                for (int y = 0; y < yükseklik; y++)
                {
                    for (int x = 0; x < genislik; x++)
                    {
                        Color renkal = resimkaynagi.GetPixel(x, y);
                        double extCh = renkal.B;
                        int extChInt = Convert.ToInt32(extCh);
                        Color gri = Color.FromArgb(extChInt, extChInt, extChInt);
                        islemyap.SetPixel(x, y, gri);
                    }
                }
                pictureBox2.Image = islemyap;
            }
            else
            {
                MessageBox.Show("RESİM AÇMADINIZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bT709ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
            if (pictureBox1.Image != null)
            {
                int genislik = resimkaynagi.Width;
                int yükseklik = resimkaynagi.Height;
                islemyap = new Bitmap(genislik, yükseklik);
                for (int y = 0; y < yükseklik; y++)
                {
                    for (int x = 0; x < genislik; x++)
                    {
                        Color renkal = resimkaynagi.GetPixel(x, y);
                        double bt709 = (renkal.R * 0.2125) + (renkal.G * 0.7154) + (renkal.B * 0.072);
                        int bt709Int = Convert.ToInt32(bt709);
                        Color gri = Color.FromArgb(bt709Int, bt709Int, bt709Int);
                        islemyap.SetPixel(x, y, gri);
                    }
                }
                pictureBox2.Image = islemyap;
            }
            else
            {
                MessageBox.Show("RESİM AÇMADINIZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
            if (pictureBox1.Image != null)
            {
                int genislik = resimkaynagi.Width;
                int yükseklik = resimkaynagi.Height;
                islemyap = new Bitmap(genislik, yükseklik);
                for (int y = 0; y < yükseklik; y++)
                {
                    for (int x = 0; x < genislik; x++)
                    {
                        Color renkal = resimkaynagi.GetPixel(x, y);
                        double luma = (renkal.R * 0.3) + (renkal.G * 0.59) + (renkal.B * 0.11);
                        int lumaInt = Convert.ToInt32(luma);
                        Color gri = Color.FromArgb(lumaInt, lumaInt, lumaInt);
                        islemyap.SetPixel(x, y, gri);
                    }
                }
                pictureBox2.Image = islemyap;
            }
            else
            {
                MessageBox.Show("RESİM AÇMADINIZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PNG|*.png";
            DialogResult result = saveFileDialog1.ShowDialog();
            ImageFormat format = ImageFormat.Png;

            if (result == DialogResult.OK)
            {
                islemyap.Save(saveFileDialog1.FileName, format);
            }
        }
    }
}
