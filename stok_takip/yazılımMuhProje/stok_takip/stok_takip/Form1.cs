using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace stok_takip
{
    public partial class FormMagazaSatis : Form
    {
        public FormMagazaSatis()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=Stok_takip;Integrated Security=True");
        DataSet daset = new DataSet();

        private void sepet_listele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from sepet", baglanti);
            adtr.Fill(daset, "sepet");
            dataGridView1.DataSource = daset.Tables["sepet"];
            baglanti.Close();

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void buttonMusteriEkleme_Click(object sender, EventArgs e)
        {
            formMusteriEkle ekle = new formMusteriEkle();
            ekle.ShowDialog();
        }

        private void FormMagazaSatis_Load(object sender, EventArgs e)
        {
            sepet_listele();
        }
        private void hesapla()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select sum(ToplamFiyat) from sepet", baglanti);
                textTutar.Text = komut.ExecuteScalar() + " TL";
                baglanti.Close();

            }
            catch (Exception)
            {
                ;
            }
        }
        private void buttonMusteriListeleme_Click(object sender, EventArgs e)
        {
            MusteriListeme listele = new MusteriListeme();
            listele.ShowDialog();
        }

        private void buttonUrunEkleme_Click(object sender, EventArgs e)
        {
            FormUrunEkleme urunEkle = new FormUrunEkleme();
            urunEkle.ShowDialog();
        }

        private void buttonUrunListeleme_Click(object sender, EventArgs e)
        {
            FormUrunListele urunListele = new FormUrunListele();
            urunListele.ShowDialog();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void textMusteriID_TextChanged(object sender, EventArgs e)

        {

        }

        private void textBarkodNo_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textMiktari_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {

                textTutar.Text = (double.Parse(textMiktari.Text) * double.Parse(textFiyat.Text)).ToString();

            }
            catch (Exception)
            {
                ;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            temizle();
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from urun where BarkodNo like '%" + txtbarkodno.Text + "%' ", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                textUrunadi.Text = read["UrunAdi"].ToString();
                textFiyat.Text = read["Fiyati"].ToString();
            }

            baglanti.Close();
        }

        private void temizle()
        {
            if (txtbarkodno.Text == "")
            {
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != textMiktari)
                        {
                            item.Text = "";
                        }
                    }

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into sepet(BarkodNo,UrunAdi,Miktari,Fiyat,Tarih) values(@BarkodNo,@UrunAdi,@Miktari,@Fiyat,@Tarih)", baglanti);
            komut.Parameters.AddWithValue("BarkodNo", txtbarkodno.Text);
            komut.Parameters.AddWithValue("UrunAdi", textUrunadi.Text);
            komut.Parameters.AddWithValue("Miktari", textMiktari.Text);
            komut.Parameters.AddWithValue("Fiyat", textFiyat.Text);
            komut.Parameters.AddWithValue("Tarih", DateTime.Now.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();
            textMiktari.Text = "1";
            daset.Tables["sepet"].Clear();
            sepet_listele();
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    if (item != textMiktari)
                    {
                        item.Text = "";
                    }
                }

            }
        }

       

        private void textMiktari_TextChanged_1(object sender, EventArgs e)
        {
            try
            {

                textTutar.Text = (double.Parse(textMiktari.Text) * double.Parse(textFiyat.Text)).ToString();

            }
            catch (Exception)
            {
                ;
            }
        }

        private void textFiyat_TextChanged(object sender, EventArgs e)
        {
            try
            {

                textTutar.Text = (double.Parse(textMiktari.Text) * double.Parse(textFiyat.Text)).ToString();

            }
            catch (Exception)
            {
                ;
            }
        }
    }
}