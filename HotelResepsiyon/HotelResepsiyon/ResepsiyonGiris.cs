using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelResepsiyon
{
    public class ResepsiyonGiris
    {
        public string kullaniciAdi;
        public string sifre;

        //constructor ile private değişkenlerimize ulaşıyoruz.
        public ResepsiyonGiris(string kullaniciAdi_, string sifre_)
        {
            kullaniciAdi = kullaniciAdi_;
            sifre = sifre_;
        }
        public SqlDataReader oku;

        //Giris methodunda kullanıcı adı ve şifreyi veri tabanımıza aktarıyoruz.
        public void Giris()
        {
            //MusterilerSayfası ms = new MusterilerSayfası();
            SqlBaglanti baglanti_ = new SqlBaglanti();
            baglanti_.baglanti();
            string giris = "select * from ResepsiyonGirisi where kullaniciAdi= '" + kullaniciAdi + "' and sifre = '" + sifre + "'";
            SqlCommand cmd = new SqlCommand(giris, baglanti_.conn);
            oku = cmd.ExecuteReader();            
        }
    }
}
