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
    public partial class FrmFaturaKalemPopUp : Form
    {
        public FrmFaturaKalemPopUp()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        public int id;
        private void FrmFaturaKalemPopUp_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TBLFATURADETAY
                                       select new
                                       {
                                           x.FATURAID,
                                           x.FATURADETAYID,
                                           x.URUN,
                                           x.ADET,
                                           x.FIYAT
                                           
                                       }).ToList();

            gridControl2.DataSource = (from u in db.TBLFATURABILGI
                                      select new
                                      {
                                          u.ID,
                                          u.SERI,
                                          u.SIRANO,
                                          u.TARIH,
                                          u.SAAT,
                                          u.VERGIDAIRE,
                                          MUSTERI = u.TBLCARI.AD + " " + u.TBLCARI.SOYAD,
                                         PERSONEL = u.TBLPERSONEL.AD + " " + u.TBLPERSONEL.SOYAD
                                      }).ToList();

        }
    }
}
