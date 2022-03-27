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
    public partial class FrmCariEkle : Form
    {
        public FrmCariEkle()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        int secilen;
        private void FrmCariEkle_Load(object sender, EventArgs e)
        {
            lookUpİl.Properties.DataSource = (from u in db.TBLILLER
                                              select new
                                              {
                                                  u.id,
                                                  u.sehir
                                              }).ToList();
        }
        private void lookUpİl_EditValueChanged(object sender, EventArgs e)
        {
            secilen = int.Parse(lookUpİl.EditValue.ToString());
            lookupIlce.Properties.DataSource = (from x in db.TBLILCELER
                                                select new
                                                {
                                                    x.id,
                                                    x.ilce,
                                                    x.sehir

                                                }).Where(y => y.sehir == secilen).ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAd.Text==""||txtAd.Text=="Ad"||txtSoyad.Text==""||txtSoyad.Text=="Soyad"||lookUpİl.Text==""||lookUpİl.Text=="İl"||lookupIlce.Text==""||lookupIlce.Text=="İlçe")
            {
                MessageBox.Show("Yeni Cari Eklenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TBLCARI t = new TBLCARI();
                t.AD = txtAd.Text;
                t.SOYAD = txtSoyad.Text;
                t.TELEFON = txtTelefon.Text;
                t.MAIL = txtMail.Text;
                t.IL = lookUpİl.Text;
                t.ILCE = lookupIlce.Text;
                t.ADRES = txtAdress.Text;
                t.BANKA = txtBanka.Text;
                t.VERGIDAIRESI = txtVergiDairesi.Text;
                t.VERGINO = txtVergiNo.Text;
                t.STATU = txtStatu.Text;
                db.TBLCARI.Add(t);
                db.SaveChanges();
                MessageBox.Show("Yeni Cari Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void kapat_Click(object sender, EventArgs e)
        {
            FrmCariEkle fr = new FrmCariEkle();
            this.Hide();
        }

        private void txtAd_Click(object sender, EventArgs e)
        {
            txtAd.Text = "";
            txtAd.Focus();
        }

        private void txtSoyad_Click(object sender, EventArgs e)
        {
            txtSoyad.Text = "";
            txtSoyad.Focus();
        }

        private void txtTelefon_Click(object sender, EventArgs e)
        {
            txtTelefon.Text = "";
            txtTelefon.Focus();
        }

        private void txtMail_Click(object sender, EventArgs e)
        {
            txtMail.Text = "";
            txtMail.Focus();
        }

        private void lookUpİl_Click(object sender, EventArgs e)
        {
            lookUpİl.Text = "";
            lookUpİl.Focus();
        }

        private void lookupIlce_Click(object sender, EventArgs e)
        {
            lookupIlce.Text = "";
            lookupIlce.Focus();
        }

        private void txtAdress_Click(object sender, EventArgs e)
        {
            txtAdress.Text = "";
            txtAdress.Focus();
        }

        private void txtBanka_Click(object sender, EventArgs e)
        {
            txtBanka.Text = "";
            txtBanka.Focus();
        }

        private void txtVergiDairesi_Click(object sender, EventArgs e)
        {
            txtVergiDairesi.Text = "";
            txtVergiDairesi.Focus();
        }

        private void txtVergiNo_Click(object sender, EventArgs e)
        {
            txtVergiNo.Text = "";
            txtVergiNo.Focus();
        }

        private void txtStatu_Click(object sender, EventArgs e)
        {
            txtStatu.Text = "";
            txtStatu.Focus();
        }
    }
}
