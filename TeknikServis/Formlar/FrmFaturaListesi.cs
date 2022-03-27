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
    public partial class FrmFaturaListesi : Form
    {
        public FrmFaturaListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        void Listele()
        {
            var degerler = from u in db.TBLFATURABILGI
                           select new
                           {
                               u.ID,
                               u.SERI,
                               u.SIRANO,
                               u.TARIH,
                               u.SAAT,
                               u.VERGIDAIRE,
                               MÜŞTERİ = u.TBLCARI.AD + " " + u.TBLCARI.SOYAD,
                               PERSONEL = u.TBLPERSONEL.AD + " " + u.TBLPERSONEL.SOYAD
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmFaturaListesi_Load(object sender, EventArgs e)
        {
            Listele();
            lookUpEdit1.Properties.DataSource = (from u in db.TBLCARI
                                                 select new
                                                 {
                                                     u.ID,
                                                     AD = u.AD + " " + u.SOYAD
                                                 }).ToList();

            lookUpEdit2.Properties.DataSource = (from u in db.TBLPERSONEL
                                                 select new
                                                 {
                                                     u.ID,
                                                     AD = u.AD + " " + u.SOYAD
                                                 }).ToList();
        }

        private void btnGuncel_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (lookUpEdit1.Text==""||lookUpEdit1.Text=="Müşteri Seç"||lookUpEdit2.Text==""||lookUpEdit2.Text=="Personel Seç"||txtSeri.Text=="")
            {
                MessageBox.Show("Fatura Sisteme Kayıt Edilemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TBLFATURABILGI t = new TBLFATURABILGI();
                t.SERI = txtSeri.Text;
                t.SIRANO = txtSıraNo.Text;
                t.TARIH = DateTime.Parse(txtTarih.Text);
                t.SAAT = txtSaat.Text;
                t.VERGIDAIRE = txtVergiDairesi.Text;
                t.CARI = int.Parse(lookUpEdit1.EditValue.ToString());
                t.PERSONEL = short.Parse(lookUpEdit2.EditValue.ToString());
                db.TBLFATURABILGI.Add(t);
                db.SaveChanges();
                Listele();
                MessageBox.Show("Fatura Sisteme Kayıt Edilmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
           
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtSeri.Text = gridView1.GetFocusedRowCellValue("SERI").ToString();
            txtSıraNo.Text = gridView1.GetFocusedRowCellValue("SIRANO").ToString();
            txtTarih.Text = gridView1.GetFocusedRowCellValue("TARIH").ToString();
            txtSaat.Text = gridView1.GetFocusedRowCellValue("SAAT").ToString();
            txtVergiDairesi.Text = gridView1.GetFocusedRowCellValue("VERGIDAIRE").ToString();
            lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("MÜŞTERİ").ToString();
            lookUpEdit2.Text = gridView1.GetFocusedRowCellValue("PERSONEL").ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deger = db.TBLFATURABILGI.Find(id);
            db.TBLFATURABILGI.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Fatura Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deger = db.TBLFATURABILGI.Find(id);
            deger.SERI = txtSeri.Text;
            deger.SIRANO = txtSıraNo.Text;
            deger.TARIH = DateTime.Parse(txtTarih.Text);
            deger.SAAT = txtSaat.Text;
            deger.VERGIDAIRE = txtVergiDairesi.Text;
            db.SaveChanges();
            MessageBox.Show("Fatura Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtSeri.Text = "";
            txtSıraNo.Text = "";
            txtTarih.Text = "";
            txtSaat.Text = "";
            txtVergiDairesi.Text = "";
        }
        
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmFaturaKalemPopUp fr = new FrmFaturaKalemPopUp();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            fr.Show();
        }
    }
}
