using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Formlar
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TBLURUN
                                       select new
                                       {
                                           x.AD,
                                           x.STOK,
                                       }).Where(x => x.STOK < 30).ToList();


            gridControl2.DataSource = (from y in db.TBLCARI
                                       select new
                                       {
                                           y.AD,
                                           y.SOYAD,
                                           y.IL
                                       }).ToList();


            gridControl3.DataSource = db.UrunKategori().ToList();


            DateTime bugun = DateTime.Today;
            var deger = (from x in db.TBLNOTLARIM.OrderBy(y => y.ID)
                         where (x.TARIH == bugun)
                         select new
                         {
                             x.BASLIK,
                             x.ICERIK
                         });
            gridControl4.DataSource = deger.ToList();

            string mesaj1, ad1, mesaj2, ad2, mesaj3, ad3, mesaj4, ad4, mesaj5, ad5, mesaj6, ad6, mesaj7, ad7, mesaj8, ad8, mesaj9, ad9, mesaj10, ad10;

            mesaj1 = db.TBLILETISIM.First(x => x.ID == 1).MESAJ;
            ad1 = db.TBLILETISIM.First(x => x.ID == 1).ADSOYAD;
            labelControl1.Text = mesaj1 + " - " + ad1;


            mesaj2 = db.TBLILETISIM.First(x => x.ID == 2).MESAJ;
            ad2  = db.TBLILETISIM.First(x => x.ID == 2).ADSOYAD;
            labelControl2.Text = mesaj2 + " - " + ad2;

            mesaj3 = db.TBLILETISIM.First(x => x.ID == 3).MESAJ;
            ad3 = db.TBLILETISIM.First(x => x.ID == 3).ADSOYAD;
            labelControl3.Text = mesaj3 + " - " + ad3;

            mesaj4 = db.TBLILETISIM.First(x => x.ID == 4).MESAJ;
            ad4 = db.TBLILETISIM.First(x => x.ID == 4).ADSOYAD;
            labelControl4.Text = mesaj4 + " - " + ad4;

            mesaj5 = db.TBLILETISIM.First(x => x.ID == 5).MESAJ;
            ad5 = db.TBLILETISIM.First(x => x.ID == 5).ADSOYAD;
            labelControl5.Text = mesaj5 + " - " + ad5;

            mesaj6 = db.TBLILETISIM.First(x => x.ID == 6).MESAJ;
            ad6= db.TBLILETISIM.First(x => x.ID == 6).ADSOYAD;
            labelControl6.Text = mesaj6 + " - " + ad6;

            mesaj7 = db.TBLILETISIM.First(x => x.ID == 7).MESAJ;
            ad7 = db.TBLILETISIM.First(x => x.ID == 7).ADSOYAD;
            labelControl7.Text = mesaj7 + " - " + ad7;

            mesaj8 = db.TBLILETISIM.First(x => x.ID == 8).MESAJ;
            ad8 = db.TBLILETISIM.First(x => x.ID == 8).ADSOYAD;
            labelControl8.Text = mesaj8 + " - " + ad8;

            mesaj9 = db.TBLILETISIM.First(x => x.ID == 9).MESAJ;
            ad9 = db.TBLILETISIM.First(x => x.ID == 9).ADSOYAD;
            labelControl9.Text = mesaj9 + " - " + ad9;

            mesaj10 = db.TBLILETISIM.First(x => x.ID == 10).MESAJ;
            ad10 = db.TBLILETISIM.First(x => x.ID == 10).ADSOYAD;
            labelControl10.Text = mesaj10 + " - " + ad10;
        }
    }
}
