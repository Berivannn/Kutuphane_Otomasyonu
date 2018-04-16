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


namespace KutuphaneOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            TabloDoldur();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=.; Integrated Security = True; Initial Catalog = Kitaplar; ");

            SqlCommand komut = new SqlCommand
            {
                Connection = baglanti,
                CommandText = "INSERT INTO Kitaplar(BarkodNo,Adi,Yazari,Fiyat)VALUES(@BarkodNo,@Adi,@Yazari,@Fiyati)"
            };
            komut.Parameters.Add("@BarkodNo", SqlDbType.NChar);
            komut.Parameters["@BarkodNo"].Value = txtBarkodno.Text.Trim();
            komut.Parameters.Add("@Adi", SqlDbType.NVarChar);
            komut.Parameters["@Adi"].Value = txtAd.Text.Trim();
            komut.Parameters.Add("@Yazari", SqlDbType.NVarChar);
            komut.Parameters["@Yazari"].Value = txtYazar.Text.Trim();
            komut.Parameters.Add("@Fiyati", SqlDbType.Int);
            komut.Parameters["@Fiyati"].Value = Convert.ToInt32(txtFiyat.Text.Trim());
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            txtSil();

        }

        private void txtSil()
        {
            txtBarkodno.Text = "";
            txtAd.Text = "";
            txtYazar.Text = "";
            txtFiyat.Text = "";
        }
        private void TabloDoldur()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=.; Integrated Security = True; Initial Catalog = Kitaplar; ");
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Kitaplar", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);  //dataseti doldur demek
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }
    }
}
