using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HotelResepsiyon
{
    public partial class RezervasyonGirisi : UserControl
    {
        SqlBaglanti sb = new SqlBaglanti();
        public TimeSpan fark;
        public double fiyat;
        public double toplamGun;

        //GunHesapla methoduyla kalınacak toplam günü hesaplıyoruz.
        public void GunHesapla(TextBox txt)
        {
            DateTime baslangic = Convert.ToDateTime(dateTimePicker1.Text);
            DateTime bitis = Convert.ToDateTime(dateTimePicker2.Text);
            fark = bitis - baslangic;
            toplamGun = fark.TotalDays;
            txt.Text = toplamGun.ToString();
        }

        //Hesaplanan gün sayısına ve oda cinsine göre ödenilecek fiyatı hesaplıyoruz.
        public void FiyatHesapla(Label lbl)
        {
            if (radioButton5.Checked == true)
            {
                fiyat = toplamGun * 100;
            }
            if (radioButton6.Checked == true)
            {
                fiyat = toplamGun * 250;
            }
            if (radioButton7.Checked == true)
            {
                fiyat = toplamGun * 450;
            }

            lbl.Text = fiyat.ToString();
        }
        public RezervasyonGirisi()
        {
            InitializeComponent();
        }

        private void btnGun_Click(object sender, EventArgs e)
        {
            GunHesapla(textBox5);
        }
        //Fiyatı hesaplayıp label a yazdırdık.

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            FiyatHesapla(label10);

            if (radioButton5.Checked == true)
            {
                oda = radioButton5.Text;
            }
            if (radioButton6.Checked == true)
            {
                oda = radioButton6.Text;
            }
            if (radioButton7.Checked == true)
            {
                oda = radioButton7.Text;
            }
        }

        //Veri tabanında odacinsi olarak kaydedebilmek için oda adında string bir değişken tanımlayıp başlangıçta içine boş değer atadık.
        public string oda = "";

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                sb.MusteriEkle(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, oda, dateTimePicker1.Value, dateTimePicker2.Value, textBox5.Text, label10.Text);
                MessageBox.Show("Kayıt Başarılı!");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem sırasında hata oluştu! " + hata.Message, "Hata!");
            }
            finally
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                label10.Text = "";
                dateTimePicker1.Refresh();
            }
        }
    }
}
