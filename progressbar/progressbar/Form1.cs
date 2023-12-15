using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progressbar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            
        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }
        int sayac2= 0;
        int sayac3= 0;
        

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar2.Value++;
            if (progressBar2.Value==100)
            {
                timer2.Stop();
                timer3.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            progressBar3.Value++;
            if (progressBar3.Value == 100)
            {
                timer3.Stop();
                MessageBox.Show("Kekiniz Hazır");
                MessageBox.Show("Afiyet Olsun");
                

            }
        }
    }
}
