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
    public partial class MusterilerSayfası : UserControl
    {
        //SqlBaglanti sınıfındaki üyeleri kullanabilmek için nesne türettik.
        SqlBaglanti sb = new SqlBaglanti();
        public MusterilerSayfası()
        {
            InitializeComponent();
        }

        //Sayfa açıldığında SqlBaglanti sayfasındaki MusteriGoruntule methodunu çalıştırıyoruz.
        private void MusterilerSayfası_Load(object sender, EventArgs e)
        {            
            sb.MusteriGoruntule(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlBaglanti sb = new SqlBaglanti();
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)  //Seçili Satırları Silme
            {
                string isim_ = (drow.Cells[0].Value).ToString();
                sb.MusteriSil(isim_);
            }
            sb.MusteriGoruntule(dataGridView1);            
        }
    }
}
