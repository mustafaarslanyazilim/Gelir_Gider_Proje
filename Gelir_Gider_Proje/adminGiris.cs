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
    public partial class adminGiris : Form
    {
        public adminGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-657OBKD\\SQLEXPRESS;Initial Catalog=Gelir_Gider_Proje;Integrated Security=True;");

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutgiris = new SqlCommand("Select * From Tbl_Yonetici Where KullaniciAdi=@p1 and Sifre=@p2", baglanti);
            komutgiris.Parameters.AddWithValue("@p1", TxtKullaniciAdi.Text);
            komutgiris.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = komutgiris.ExecuteReader();

            if (dr.Read())
            {
                AnaGiris frm = new AnaGiris();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış ! ", "HATALI GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
