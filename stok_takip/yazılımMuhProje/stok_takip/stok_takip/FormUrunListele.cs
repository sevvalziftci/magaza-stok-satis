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

namespace stok_takip
{
    public partial class FormUrunListele : Form
    {
        public FormUrunListele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=Stok_takip;Integrated Security=True");
        DataSet daset = new DataSet();
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update urun set UrunAdi=@UrunAdi, Miktari=@Miktari, Fiyati=@Fiyati where BarkodNo=@BarkodNo", baglanti);
            komut.Parameters.AddWithValue("@BarkodNo", textBarkodNo.Text);
            komut.Parameters.AddWithValue("@UrunAdi", textUrunAdi.Text);
            komut.Parameters.AddWithValue("@Miktari", textMiktari.Text);
            komut.Parameters.AddWithValue("@Fiyati", textFiyati.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["urun"].Clear();
            urunleri_goster();
            MessageBox.Show("Urun güncellendi.");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void FormUrunListele_Load(object sender, EventArgs e)
        {
            urunleri_goster();
        }
        private void urunleri_goster()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from urun", baglanti);
            adtr.Fill(daset, "urun");
            dataGridView2.DataSource = daset.Tables["urun"];
            baglanti.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            textBarkodNo.Text = dataGridView2.CurrentRow.Cells["BarkodNo"].Value.ToString();
            textKategori.Text = dataGridView2.CurrentRow.Cells["Kategori"].Value.ToString();
            textUrunAdi.Text = dataGridView2.CurrentRow.Cells["UrunAdi"].Value.ToString();
            textMiktari.Text = dataGridView2.CurrentRow.Cells["Miktari"].Value.ToString();
            textFiyati.Text = dataGridView2.CurrentRow.Cells["Fiyati"].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from urun where BarkodNo='" + dataGridView2.CurrentRow.Cells["BarkodNo"].Value.ToString() + "' ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["urun"].Clear();
            urunleri_goster();
            MessageBox.Show("Urun silindi.");
        }

        private void textBarkodNoAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from urun where BarkodNo like '%" + textBarkodNoAra.Text + "%' ", baglanti);
            adtr.Fill(tablo);
            dataGridView2.DataSource = tablo;
            baglanti.Close();
        }
    }
}
