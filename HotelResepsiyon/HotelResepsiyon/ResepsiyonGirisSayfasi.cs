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
    public partial class ResepsiyonGirisSayfasi : UserControl
    {
        public ResepsiyonGirisSayfasi()
        {
            InitializeComponent();
        }        
        private void Content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            MusterilerSayfası ms = new MusterilerSayfası();
            ResepsiyonGiris rg = new ResepsiyonGiris(textBox1.Text, textBox2.Text);
            rg.Giris();
            //ResepsiyonGiris classında tanımladığımız Giris methoduyla kullanıcı adı ve şifreyi veri tabanına aktardık.
            //Girilen kullanıcı adı ve şifre veri tabanımızdaki kullanıcı adı ve şifreyle uyuşuyorsa, MusterilerSayfası sayfasını öne getiriyoruz.
            if (rg.oku.Read())
            {
                MessageBox.Show("Giriş Başarılı!");
                SayfalarArasiGecis.Sayfalar(ms, Content);
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
            }
            SqlBaglanti sb = new SqlBaglanti();
            sb.baglantiKapat();
        }
    }
}
