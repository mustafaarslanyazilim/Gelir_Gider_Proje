using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gelir_Gider_Proje
{
    public partial class AnaGiris : Form
    {
        public AnaGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gelir glr=new Gelir();
            glr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gider gdr=new Gider();
            gdr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cari cr=new Cari();
            cr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Rapor rp=new Rapor();
            rp.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
