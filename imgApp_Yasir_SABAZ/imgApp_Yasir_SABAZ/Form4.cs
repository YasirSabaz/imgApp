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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            int koyulukTespiti = clsGenel.renktonu;
            
            this.BackColor= clsGenel.renk;
            label1.Text = clsGenel.renkkodu;
            if (koyulukTespiti < 430)
            {
                label1.ForeColor = System.Drawing.Color.White;
            }
            else
            {
                label1.ForeColor = System.Drawing.Color.Black;
            }
        }
    }
}
