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
    public partial class Rapor : Form
    {
        public Rapor()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-657OBKD\\SQLEXPRESS;Initial Catalog=Gelir_Gider_Proje;Integrated Security=True;");

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Rapor_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'gelir_Gider_ProjeDataSet7.Tbl_Gider' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_GiderTableAdapter.Fill(this.gelir_Gider_ProjeDataSet7.Tbl_Gider);
            // TODO: Bu kod satırı 'gelir_Gider_ProjeDataSet6.Tbl_Gelir' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_GelirTableAdapter.Fill(this.gelir_Gider_ProjeDataSet6.Tbl_Gelir);

            //Toplam Gelir
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select SUM(GelirTutar) From Tbl_Gelir", baglanti);
            SqlDataReader dr1= komut1.ExecuteReader();
            while(dr1.Read())
            {
                LblToplamGelir.Text = dr1[0].ToString();
            }
            baglanti.Close();

            //Toplam Gider
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select SUM(GiderTutar) From Tbl_Gider ", baglanti);
            SqlDataReader dr2= komut2.ExecuteReader();
            while(dr2.Read())
            {
                LblToplamGider.Text = dr2[0].ToString();    
            }
            baglanti.Close();

            //Net Kalan

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaGiris anaGiris = new AnaGiris();
            anaGiris.Show();
        }
    }
}
