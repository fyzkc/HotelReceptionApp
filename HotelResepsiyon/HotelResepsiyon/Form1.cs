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

namespace HotelResepsiyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Silver;
        }
        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.ForeColor = Color.White;
        }
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Silver;
        }
        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.ForeColor = Color.White;
        }
        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.ForeColor = Color.Silver;
        }

        //Form açıldığında AnaSayfa user control sayfasının en öne gelmesi için
        private void Form1_Load(object sender, EventArgs e)
        {
            AnaSayfa ana = new AnaSayfa();
            SayfalarArasiGecis.Sayfalar(ana,Content);
        }

        //Resepsiyon girişi butonuna basıldığında ResepsiyonGirisSayfasi user control sayfasının en öne gelmesi için
        private void button1_Click(object sender, EventArgs e)
        {
            ResepsiyonGirisSayfasi rg = new ResepsiyonGirisSayfasi();
            SayfalarArasiGecis.Sayfalar(rg, Content);
        }

        //Ana Sayfa butonuna basıldığında AnaSayfa user control sayfasının en öne gelmesi için
        private void button4_Click(object sender, EventArgs e)
        {
            AnaSayfa ana = new AnaSayfa();
            SayfalarArasiGecis.Sayfalar(ana, Content);
        }

        //Rezervasyon girişi butonuna basıldığında RezervasyonGirisi user control sayfasının en öne gelmesi için
        private void button2_Click(object sender, EventArgs e)
        {
            RezervasyonGirisi rezg = new RezervasyonGirisi();
            SayfalarArasiGecis.Sayfalar(rezg, Content);
        }        
    }
}
