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
    public partial class FrmKategori : Form
    {
        public FrmKategori()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        void Listele()
        {
            var degerler = from k in db.TBLKATEGORI
                           select new
                           {
                               k.ID,
                               k.AD
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmKategori_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtAd.Text != "" && TxtAd.Text.Length <= 30)
            {
                TBLKATEGORI t = new TBLKATEGORI();
                t.AD = TxtAd.Text;
                db.TBLKATEGORI.Add(t);
                db.SaveChanges();
                MessageBox.Show("Kategori Başarıyla Kayıt Edildi");
                Listele();
            }
            else
            {
                MessageBox.Show("Kategori Adı Boş Geçilemez Ve Kategori Adı 30 Karakterden Uzun Olamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Kategoriyi Silmek İstiyormusunuz", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (secenek==DialogResult.Cancel)
            {
                MessageBox.Show("İşlem İptal Edildi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int id = int.Parse(TxtId.Text);
                var deger = db.TBLKATEGORI.Find(id);
                db.TBLKATEGORI.Remove(deger);
                db.SaveChanges();
                MessageBox.Show("Kategori Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
            
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text);
            var deger = db.TBLKATEGORI.Find(id);
            deger.AD = TxtAd.Text;

            db.SaveChanges();
            MessageBox.Show("Kategori Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            TxtAd.Text = "";
            TxtId.Text = "";
        }
    }
}
