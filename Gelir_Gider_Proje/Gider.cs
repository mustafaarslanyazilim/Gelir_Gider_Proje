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
    public partial class Gider : Form
    {
        public Gider()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-657OBKD\\SQLEXPRESS;Initial Catalog=Gelir_Gider_Proje;Integrated Security=True;");

        private void Gider_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'gelir_Gider_ProjeDataSet10.Tbl_Gider' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_GiderTableAdapter.Fill(this.gelir_Gider_ProjeDataSet10.Tbl_Gider);

        }

        //temizle metodu
        void temizle()
        {
            TxtGiderID.Text = "";
            MskGiderTarih.Text = "";
            MskGiderTutar.Text = "";
            TxtGiderAciklama.Text = "";
            TxtGiderID.Focus();
        }
        private void dataGridGİDER_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridGİDER.SelectedCells[0].RowIndex;

            TxtGiderID.Text = dataGridGİDER.Rows[secilen].Cells[0].Value.ToString();
            MskGiderTarih.Text = dataGridGİDER.Rows[secilen].Cells[1].Value.ToString();
            MskGiderTutar.Text = dataGridGİDER.Rows[secilen].Cells[2].Value.ToString();
            TxtGiderAciklama.Text = dataGridGİDER.Rows[secilen].Cells[3].Value.ToString();


        }

        private void BtnGiderListele_Click(object sender, EventArgs e)
        {
            this.tbl_GiderTableAdapter.Fill(this.gelir_Gider_ProjeDataSet10.Tbl_Gider);
        }

        private void BtnGiderKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut =new SqlCommand("insert into Tbl_Gider(GiderID,GiderTarih,GiderTutar,GiderAciklama) values  (@g1,@g2,@g3,@g4)", baglanti);
            komut.Parameters.AddWithValue("@g1", TxtGiderID.Text);
            komut.Parameters.AddWithValue("@g2", MskGiderTarih.Text);
            komut.Parameters.AddWithValue("@g3", MskGiderTutar.Text);
            komut.Parameters.AddWithValue("@g4", TxtGiderAciklama.Text);
            komut.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Gider Eklendi");
        }

        private void BtnGiderSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutSil = new SqlCommand(" Delete From Tbl_Gider where GiderID=@s1", baglanti);
            komutSil.Parameters.AddWithValue("@s1", TxtGiderID.Text);
            komutSil.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Kayıt Silindi");
        }

        private void BtnGiderTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void BtnGiderGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutGüncelle = new SqlCommand("Update Tbl_Gider Set GiderTarih=@a1, GiderTutar=@a2,GiderAciklama=@a3 where GiderID=@a4  ", baglanti);
            komutGüncelle.Parameters.AddWithValue("@a1",MskGiderTarih.Text);
            komutGüncelle.Parameters.AddWithValue("@a2",MskGiderTutar.Text);
            komutGüncelle.Parameters.AddWithValue("@a3",TxtGiderAciklama.Text);
            komutGüncelle.Parameters.AddWithValue("@a4", TxtGiderID.Text);
            komutGüncelle.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Gider Kaydı Güncellendi");
        }

        private void BtnGiderRaporlar_Click(object sender, EventArgs e)
        {
            Rapor rp=new Rapor();
            rp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaGiris anaGiris = new AnaGiris();
            anaGiris.Show();
        }
    }
}
