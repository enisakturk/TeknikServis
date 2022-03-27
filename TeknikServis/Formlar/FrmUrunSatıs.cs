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
    public partial class FrmUrunSatıs : Form
    {
        public FrmUrunSatıs()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmUrunSatıs_Load(object sender, EventArgs e)
        {
            urun_id.Properties.DataSource = (from u in db.TBLURUN
                                              select new
                                              {
                                                  u.ID,
                                                  u.AD
                                              }).ToList();

            musteri_id.Properties.DataSource = (from u in db.TBLCARI
                                             select new
                                             {
                                                 u.ID,
                                                AD= u.AD + " "+ u.SOYAD
                                             }).ToList();

            personel_id.Properties.DataSource = (from u in db.TBLPERSONEL
                                             select new
                                             {
                                                 u.ID,
                                                AD= u.AD + " "+ u.SOYAD
                                             }).ToList();
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBLURUNHAREKET t = new TBLURUNHAREKET();
            t.URUN = int.Parse(urun_id.EditValue.ToString());
            t.MUSTERI = int.Parse(musteri_id.EditValue.ToString());
            t.PERSONEL = short.Parse(personel_id.EditValue.ToString());
            t.TARIH = DateTime.Parse(txtTarih.Text);
            t.ADET = short.Parse(txtAdet.Text);
            t.FIYAT = decimal.Parse(txtFiyat.Text);
            t.URUNSERINO = txtSeriNo.Text;
            db.TBLURUNHAREKET.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Satışı Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void kapat_Click(object sender, EventArgs e)
        {
            FrmUrunSatıs fr = new FrmUrunSatıs();
            this.Hide();
        }

        private void txtAdet_Click(object sender, EventArgs e)
        {
            txtAdet.Text = "";
            txtAdet.Focus();
        }

        private void txtFiyat_Click(object sender, EventArgs e)
        {
            txtFiyat.Text = "";
            txtFiyat.Focus();
        }

        private void txtSeriNo_Click(object sender, EventArgs e)
        {
            txtSeriNo.Text = "";
            txtSeriNo.Focus();
        }
    }
}
