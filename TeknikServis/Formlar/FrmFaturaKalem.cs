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
    public partial class FrmFaturaKalem : Form
    {
        public FrmFaturaKalem()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        void Listele()
        {
            var degerler = from u in db.TBLFATURADETAY
                           select new
                           {
                               u.FATURADETAYID,
                               u.URUN,
                               u.ADET,
                               u.FIYAT,
                               u.TUTAR,
                               u.FATURAID,
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmFaturaKalem_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBLFATURADETAY t = new TBLFATURADETAY();
            t.URUN = txtUrun.Text;
            t.ADET = short.Parse(txtAdet.Text);
            t.FIYAT = decimal.Parse(txtFiyat.Text);
            t.TUTAR = decimal.Parse(txtTutar.Text);
            t.FATURAID = int.Parse(txtFaturaId.Text);
            db.TBLFATURADETAY.Add(t);
            db.SaveChanges();
            MessageBox.Show("Faturaya Ait Kalem Başarıyla Kayıt Edildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void btnGuncel_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtDetayId.Text);
            var deger = db.TBLFATURADETAY.Find(id);
            db.TBLFATURADETAY.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Faturaya Ait Kalem Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtDetayId.Text);
            var deger = db.TBLFATURADETAY.Find(id);
            deger.URUN = txtUrun.Text;
            deger.ADET = short.Parse(txtAdet.Text);
            deger.FIYAT = decimal.Parse(txtFiyat.Text);
            deger.TUTAR = decimal.Parse(txtTutar.Text);
            deger.FATURAID = int.Parse(txtFaturaId.Text);
            db.SaveChanges();
            MessageBox.Show("Faturaya Ait Kalem Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtDetayId.Text = gridView1.GetFocusedRowCellValue("FATURADETAYID").ToString();
            txtUrun.Text = gridView1.GetFocusedRowCellValue("URUN").ToString();
            txtAdet.Text = gridView1.GetFocusedRowCellValue("ADET").ToString();
            txtFiyat.Text = gridView1.GetFocusedRowCellValue("FIYAT").ToString();
            txtTutar.Text = gridView1.GetFocusedRowCellValue("TUTAR").ToString();
            txtFaturaId.Text = gridView1.GetFocusedRowCellValue("FATURAID").ToString();
        }
    }
}
