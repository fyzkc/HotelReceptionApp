using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelResepsiyon
{
    class SayfalarArasiGecis
    {
        //control parametresi öne getirmek istediğimiz user control sınıfları için; content parametresi de sayfanın içini dolduracağı panel için tanımlanmış.
        //nesne türetmeden kullanabilmek ve her yerden hemen ulaşabilmek için methodu static tanımladık.
        public static void Sayfalar(Control control, Control Content)
        {
            //Content ten yani panelden eğer mevcut bir user control sayfası varsa temizliyoruz.
            Content.Controls.Clear();
            //öne getirmek istediğimiz user control sayfasını panelin tamamını kaplamak için dockstyle.fill yapıyoruz.
            control.Dock = DockStyle.Fill;
            //user control sayfasımızı öne getiriyoruz.
            control.BringToFront();
            //Program açılır açılmaz giriş denetimini öne getirdiğimiz user control sayfasına ayarlar.
            control.Focus();
            //Content'e user control sayfamızı ekliyoruz.
            Content.Controls.Add(control);
        }
    }
}
