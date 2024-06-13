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
namespace stok_takip
{
    public partial class FormUrunEkleme : Form
    {
        public FormUrunEkleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=Stok_takip;Integrated Security=True");
        DataSet daset = new DataSet();
        private void FormUrunEkleme_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into urun(BarkodNo, Kategori, UrunAdi, Miktari ,Fiyati) values(@BarkodNo,@Kategori, @UrunAdi, @Miktari, @Fiyati)", baglanti);
            komut.Parameters.AddWithValue("@BarkodNo", textBarkodNo.Text);
            komut.Parameters.AddWithValue("@Kategori", textKategori.Text);
            komut.Parameters.AddWithValue("@UrunAdi", textUrunAdi.Text);
            komut.Parameters.AddWithValue("@Miktari", textMiktari.Text);
            komut.Parameters.AddWithValue("@Fiyati", textFiyati.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Urun eklendi.");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}



