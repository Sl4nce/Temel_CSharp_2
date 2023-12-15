using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eokuldb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmogrencinot frmogrencinot = new frmogrencinot();
            frmogrencinot.numara=textBox1.Text;
            frmogrencinot.Show();
            this.Hide();
        }
    }
}
