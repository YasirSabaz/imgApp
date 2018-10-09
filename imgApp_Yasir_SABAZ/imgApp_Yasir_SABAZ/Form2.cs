using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imgApp_Yasir_SABAZ
{
    class clsGenel
    {
        public static Color renk;
        public static string renkkodu;
        public static int renktonu;
    }
    public partial class Form2 : Form
    {
      
        public Form2()
        {
            InitializeComponent();
        }
        Bitmap resimkaynagi;
        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resimgetir = openFileDialog1.ShowDialog();
            if (resimgetir == DialogResult.OK)
            {
                resimkaynagi = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = resimkaynagi;
            }
        }

        private void renkgetir_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                int xAl = int.Parse(x.Text);
                int yAl = int.Parse(x.Text);
                Color resimrengial= resimkaynagi.GetPixel(xAl, yAl);
                clsGenel.renk = resimrengial;
                clsGenel.renkkodu = "rgb(" + resimrengial.R + "," + resimrengial.G + "," + resimrengial.B + ");";
                clsGenel.renktonu = (resimrengial.R + resimrengial.G + resimrengial.B);

                Form4 renkgöstermeFormu = new Form4();
                renkgöstermeFormu.ShowDialog();
            }
            else
            {
                MessageBox.Show("RESİM AÇMADINIZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void renkAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                int xAl = int.Parse(x.Text);
                int yAl = int.Parse(x.Text);
                Color resimrengial = resimkaynagi.GetPixel(xAl, yAl);
                renkgetir.BackColor = resimrengial;
            }
            else
            {
                MessageBox.Show("RESİM AÇMADINIZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
        }
    }
}
