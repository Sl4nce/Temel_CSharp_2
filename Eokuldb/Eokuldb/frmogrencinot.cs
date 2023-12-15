using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Eokuldb
{
    public partial class frmogrencinot : Form
    {
        SqlConnection baglanti=new SqlConnection("Data Source=HPVictus;Initial Catalog=Okul;Integrated Security=True");
        public frmogrencinot()
        {
            InitializeComponent();
        }
        public string numara;
        private void frmogrencinot_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select dersad,sınav1,sınav2,sınav3,proje,ortalama,durum from tbl_not INNER JOIN tbl_ders on tbl_not.dersid=tbl_ders.dersid where ogrid=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", numara);
            //this.Text=numara.ToString();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }
    }
}
