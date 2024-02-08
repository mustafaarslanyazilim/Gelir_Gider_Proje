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
    public partial class Gelir : Form
    {
        public Gelir()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-657OBKD\\SQLEXPRESS;Initial Catalog=Gelir_Gider_Proje;Integrated Security=True;");

        private void Gelir_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'gelir_Gider_ProjeDataSet8.Tbl_Gelir' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_GelirTableAdapter.Fill(this.gelir_Gider_ProjeDataSet9.Tbl_Gelir);
        }

        //temizle metodu
        void temizle()
        {
            TxtGelirID.Text = "";
            MskGelirTarih.Text = "";
            MskGelirTutar.Text = "";
            TxtGelirAciklama.Text = "";
            TxtGelirID.Focus();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridGELİR_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int secilen = dataGridGELİR.SelectedCells[0].RowIndex;

            TxtGelirID.Text = dataGridGELİR.Rows[secilen].Cells[0].Value.ToString();
            MskGelirTarih.Text = dataGridGELİR.Rows[secilen].Cells[1].Value.ToString();
            MskGelirTutar.Text = dataGridGELİR.Rows[secilen].Cells[2].Value.ToString();
            TxtGelirAciklama.Text = dataGridGELİR.Rows[secilen].Cells[3].Value.ToString();


        }

        private void BtnGelirListele_Click(object sender, EventArgs e)
        {
            this.tbl_GelirTableAdapter.Fill(this.gelir_Gider_ProjeDataSet9.Tbl_Gelir);

        }

        private void BtnGelirRaporlar_Click(object sender, EventArgs e)
        {

            Rapor rp = new Rapor();
            rp.Show();
        }

        private void BtnGelirSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutSil = new SqlCommand("Delete Tbl_Gelir where GelirID=@s1", baglanti);
            komutSil.Parameters.AddWithValue("@s1",TxtGelirID.Text);
            komutSil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Silindi");
        }

        private void BtnGelirKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Gelir (GelirID, GelirTarih,GelirTutar,GelirAciklama,GelirToplam) values (@g1,@g2,@g3,@g4,@g5)", baglanti);
            komut.Parameters.AddWithValue("@g1", TxtGelirID.Text);
            komut.Parameters.AddWithValue("@g2", MskGelirTarih.Text);
            komut.Parameters.AddWithValue("@g3", MskGelirTutar.Text);
            komut.Parameters.AddWithValue("@g4", TxtGelirAciklama.Text);
            komut.Parameters.AddWithValue("@g5", MskToplamGelir.Text);
            komut.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Gelir Eklendi");
        }

        private void BtnGelirGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutGüncelle = new SqlCommand("Update Tbl_Gelir set GelirID=@a1, GelirTarih=@a2, GelirTutar=@a3, GelirAciklama=@a4 , GelirToplam=@a5", baglanti);
            komutGüncelle.Parameters.AddWithValue("@a1", TxtGelirID.Text);
            komutGüncelle.Parameters.AddWithValue("@a2", MskGelirTarih.Text);
            komutGüncelle.Parameters.AddWithValue("@a3", MskGelirTutar.Text);
            komutGüncelle.Parameters.AddWithValue("@a4", TxtGelirAciklama.Text);
            komutGüncelle.Parameters.AddWithValue("@a5", MskToplamGelir.Text);
            komutGüncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Güncellendi ");
        }

        private void BtnGelirTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaGiris anaGiris = new AnaGiris();
            anaGiris.Show();
        }
    }
}
