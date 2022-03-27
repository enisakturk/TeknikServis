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
    public partial class FrmCariListesi : Form
    {
        public FrmCariListesi()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();
        int seçilen;
        void Listele()
        {
            var degerler = from u in db.TBLCARI
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.SOYAD,
                               u.IL,
                               u.ILCE
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        
        //il-ilçe çekmek için kullanılan linq sorguları
        private void FrmCariListesi_Load(object sender, EventArgs e)
        {
            Listele();
            toplam_musteri.Text = db.TBLCARI.Count().ToString();
            toplam_il.Text = db.TBLCARI.Select(x => x.IL).Distinct().Count().ToString();
            toplam_ılce.Text = db.TBLCARI.Select(x => x.ILCE).Distinct().Count().ToString();

            lookUpİl.Properties.DataSource = (from u in db.TBLILLER
                                                 select new
                                                 {
                                                     u.id,
                                                     u.sehir
                                                 }).ToList();
        }
        
        private void lookUpİl_EditValueChanged(object sender, EventArgs e)
        {
            seçilen = int.Parse(lookUpİl.EditValue.ToString());
            lookUpİlçe.Properties.DataSource = (from x in db.TBLILCELER
                                                select new
                                                {  
                                                    x.id,
                                                    x.ilce,
                                                    x.sehir

                                                }).Where(y=>y.sehir==seçilen).ToList();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtCariAd.Text==""||TxtSoyad.Text==""||lookUpİl.Text== "İl Seçin" || lookUpİlçe.Text== "İlçe Seçin")
            {
                MessageBox.Show("Ad-Soyad-İl-İlçe Girilmesi Zorunludur", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else 
            {
                TBLCARI t = new TBLCARI();
                t.AD = TxtCariAd.Text;
                t.SOYAD = TxtSoyad.Text;
                t.IL = lookUpİl.Text;
                t.ILCE = lookUpİlçe.Text;
                t.TELEFON = TxtTelefon.Text;
                t.BANKA = txtBanka.Text;
                t.VERGIDAIRESI = txtVergiDairesi.Text;
                t.VERGINO = txtVergiNo.Text;
                t.STATU = txtStatü.Text;
                t.ADRES = txtAdress.Text;
                db.TBLCARI.Add(t);
                db.SaveChanges();
                Listele();
                MessageBox.Show("Müşteri Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text);
            var deger = db.TBLCARI.Find(id);
            db.TBLCARI.Remove(deger);
            db.SaveChanges();
            Listele();
            MessageBox.Show("Müşteri Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text);
            var degerler = db.TBLCARI.Find(id);
            degerler.AD = TxtCariAd.Text;
            degerler.SOYAD = TxtSoyad.Text;
            degerler.IL = lookUpİl.Text.ToString();
            degerler.ILCE = lookUpİlçe.Text.ToString();
            degerler.TELEFON = TxtTelefon.Text;
            degerler.BANKA = txtBanka.Text;
            degerler.VERGIDAIRESI = txtVergiDairesi.Text;
            degerler.VERGIDAIRESI = txtVergiNo.Text;
            degerler.STATU = txtStatü.Text;
            degerler.ADRES = txtAdress.Text;
            db.SaveChanges();
            Listele();
            MessageBox.Show("Müşteri Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void BtnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            TxtId.Text = "";
            TxtCariAd.Text = "";
            TxtSoyad.Text = "";
            TxtTelefon.Text = "";
            txtBanka.Text = "";
            txtVergiDairesi.Text = "";
            txtVergiNo.Text = "";
            txtStatü.Text = "";
            txtAdress.Text = "";      
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                TxtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
                TxtCariAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
                TxtSoyad.Text = gridView1.GetFocusedRowCellValue("SOYAD").ToString();
                lookUpİl.Text = gridView1.GetFocusedRowCellValue("IL").ToString();
                lookUpİlçe.Text = gridView1.GetFocusedRowCellValue("ILCE").ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Tüm Değerlerin Girildiğine Emin Olun", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

       
    }
}
