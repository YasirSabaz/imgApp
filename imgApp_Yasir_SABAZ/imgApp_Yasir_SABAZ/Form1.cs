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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void renkAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 renkalmaFormu = new Form2();
            renkalmaFormu.ShowDialog();
        }

        private void griYöntemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 griyöntemleri = new Form3();
            griyöntemleri.ShowDialog();
        }
    }
}
