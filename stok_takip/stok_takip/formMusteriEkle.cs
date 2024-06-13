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
    public partial class formMusteriEkle : Form
    {
        public formMusteriEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=Stok_takip;Integrated Security=True");
        private void formMusteriEkle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into musteri(MusteriID, AdSoyad, Telefon, Adres) values(@MusteriID, @AdSoyad, @Telefon, @Adres)", baglanti);
            komut.Parameters.AddWithValue("@MusteriID", textMusteriID.Text);
            komut.Parameters.AddWithValue("@AdSoyad", textAdSoyad.Text);
            komut.Parameters.AddWithValue("@Telefon", textTelefon.Text);
            komut.Parameters.AddWithValue("@Adres", textAdres.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Musteri kaydi eklendi.");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }


        }
    }
}
