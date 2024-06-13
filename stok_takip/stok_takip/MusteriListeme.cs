using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace stok_takip
{
    public partial class MusteriListeme : Form
    {
        public MusteriListeme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=Stok_takip;Integrated Security=True");
        DataSet daset = new DataSet();
        private void MusteriListeme_Load(object sender, EventArgs e)
        {
            kayit_goster();
        }

        private void kayit_goster()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from musteri", baglanti);
            adtr.Fill(daset, "musteri");
            dataGridView1.DataSource = daset.Tables["musteri"];
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textMusteriID.Text = dataGridView1.CurrentRow.Cells["MusteriID"].Value.ToString();
            textAdSoyad.Text = dataGridView1.CurrentRow.Cells["AdSoyad"].Value.ToString();
            textTelefon.Text = dataGridView1.CurrentRow.Cells["Telefon"].Value.ToString();
            textAdres.Text = dataGridView1.CurrentRow.Cells["Adres"].Value.ToString();

        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update musteri set Telefon=@Telefon, Adres=@Adres where MusteriID=@MusteriID", baglanti);
            komut.Parameters.AddWithValue("@MusteriID", textMusteriID.Text);
            komut.Parameters.AddWithValue("@AdSoyad", textAdSoyad.Text);
            komut.Parameters.AddWithValue("@Telefon", textTelefon.Text);
            komut.Parameters.AddWithValue("@Adres", textAdres.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["musteri"].Clear();
            kayit_goster();
            MessageBox.Show("Musteri kaydi güncellendi.");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

        }

        private void button_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from musteri where MusteriID='" + dataGridView1.CurrentRow.Cells["MusteriID"].Value.ToString() + "' ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["musteri"].Clear();
            kayit_goster();
            MessageBox.Show("Musteri kaydi silindi.");
        }

        private void textMusteriIDara_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from musteri where musteriID like '%" + textMusteriIDara.Text + "%' ", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textMusteriID_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
