using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace örnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i = 0;
        double[] ortalamalar = new double[5];
        public void button1_Click(object sender, EventArgs e)
        {
            
            
            string a=maskedTextBox2.Text;
            double vize =Convert.ToDouble(maskedTextBox2.Text);
            double final = Convert.ToDouble(maskedTextBox3.Text);
            double ort = final * 0.60 + vize * 0.40;
            ortalamalar[i] = ort;
            comboBox1.Items.Add(textBox1.Text);
            i++;


        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            int s1 = comboBox1.SelectedIndex;
            MessageBox.Show(Convert.ToString("İsim: " + comboBox1.SelectedItem +"\n"+"Ortalaması: " + Convert.ToString(ortalamalar[s1])));
          
        }

        
    }
}
