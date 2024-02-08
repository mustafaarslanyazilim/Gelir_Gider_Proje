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

namespace Gelir_Gider_Proje
{
    public partial class Cari : Form
    {
        public Cari()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-657OBKD\\SQLEXPRESS;Initial Catalog=Gelir_Gider_Proje;Integrated Security=True;");

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'gelir_Gider_ProjeDataSet11.Tbl_Cari' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_CariTableAdapter.Fill(this.gelir_Gider_ProjeDataSet11.Tbl_Cari);

        }
        //temizle metodu
        void temizle()
        {
            MskCariID.Text = "";
            TxtCariAd.Text = "";
            TxtCariSoyad.Text = "";
            MskCariTel.Text = "";
            MskCariID.Focus();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            MskCariID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtCariAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtCariSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            MskCariTel.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();


        }

        private void BtnGiderListele_Click(object sender, EventArgs e)
        {
            this.tbl_CariTableAdapter.Fill(this.gelir_Gider_ProjeDataSet11.Tbl_Cari);
        }

        private void BtnGiderKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut=new SqlCommand("insert into Tbl_Cari(CariId,CariAd,CariSoyad,CariTel) values(@a1,@a2,@a3,@a4) ",baglanti);
            komut.Parameters.AddWithValue("@a1",MskCariID.Text);
            komut.Parameters.AddWithValue("@a2", TxtCariAd.Text);
            komut.Parameters.AddWithValue("@a3", TxtCariSoyad.Text);
            komut.Parameters.AddWithValue("@a4", MskCariTel.Text);
            komut.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Cari EKlendi");
        }

        private void BtnGiderSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutSil = new SqlCommand("Delete From Tbl_Cari where CariID=@s1", baglanti);
            komutSil.Parameters.AddWithValue("@s1", MskCariID.Text);
            komutSil.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Cari Silindi");
        }

        private void BtnGiderGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutGüncelle = new SqlCommand("update Tbl_Cari Set CariAd=@a1, CariSoyad=@a2,CariTel=@a3 where CariID=@a4 ", baglanti);
            komutGüncelle.Parameters.AddWithValue("@a1",TxtCariAd.Text);
            komutGüncelle.Parameters.AddWithValue("@a2", TxtCariSoyad.Text);
            komutGüncelle.Parameters.AddWithValue("@a3", MskCariTel.Text);
            komutGüncelle.Parameters.AddWithValue("@a4", MskCariID.Text);
            komutGüncelle.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Kayıt Güncellendi");
        }

        private void BtnGiderTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void BtnGiderRaporlar_Click(object sender, EventArgs e)
        {

            Rapor rp = new Rapor();
            rp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaGiris anaGiris = new AnaGiris();
            anaGiris.Show();
        }
    }
}
