using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace HotelResepsiyon
{
    //Sql bağlantıları için bir class tanımladık.
    public class SqlBaglanti
    {
        public SqlConnection conn= new SqlConnection(@"Data Source=DESKTOP-OSKESNA; Initial Catalog= HotelResepsiyon; Integrated Security=true;");
        public SqlCommand cmd;
        public SqlDataReader dr;
        public SqlDataAdapter da;
        //Bağlantıyı gerçekleştirmesi için bir yordam tanımladık.
        public void baglanti()
        {
            conn.Open();
        }
        //Bağlantıyı kapatmak için bir yordam tanımladık
        public void baglantiKapat()
        {
            conn.Close();
        }

        //Musteri bilgilerini veri tabanına ekleyebilmek için method oluşturduk.
        public void MusteriEkle(string isim, string soyisim, string kimlik, string telefon, string oda, DateTime giris, DateTime cikis, string gun, string odeme)
        {
            cmd = new SqlCommand("insert into MusteriBilgi(isim,soyisim,kimlikno,telefon,odacinsi,giristarihi,cikistarihi,gunsayisi,odeme) values (@isim_,@soyisim_,@kimlikno_,@telefon_,@oda_,@giris_,@cikis_,@gun_,@odeme_)", conn);
            cmd.Parameters.AddWithValue("@isim_", isim);
            cmd.Parameters.AddWithValue("@soyisim_", soyisim);
            cmd.Parameters.AddWithValue("@kimlikno_", kimlik);
            cmd.Parameters.AddWithValue("@telefon_", telefon);
            cmd.Parameters.AddWithValue("@oda_", oda);
            cmd.Parameters.AddWithValue("@giris_", giris);
            cmd.Parameters.AddWithValue("@cikis_", cikis);
            cmd.Parameters.AddWithValue("@gun_", gun);
            cmd.Parameters.AddWithValue("@odeme_", odeme);

            baglanti();
            cmd.ExecuteNonQuery();
            baglantiKapat();
        }

        //Musteri bilgilerini datagridviewda gösterebilmek için
        public void MusteriGoruntule(DataGridView dgv)
        {
            da = new SqlDataAdapter("Select isim,soyisim,kimlikno,telefon,odacinsi,giristarihi,cikistarihi,gunsayisi,odeme from MusteriBilgi", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
        }
        
        //Herhangi bir veri tabanı parametresine göre silme işlemi yapıyoruz. Seçilen satırları silebilmek için
        //method tanımladık.
        public void MusteriSil(string isim_)
        {
            string sql = "DELETE FROM MusteriBilgi WHERE isim=@isim";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@isim", isim_);
            baglanti();
            cmd.ExecuteNonQuery(); // ExevuteNonQuery geriye int olarak update, insert, delete sorgusundan etkilenen satır sayısını döndürür.
            baglantiKapat();            
        }


    }

}
