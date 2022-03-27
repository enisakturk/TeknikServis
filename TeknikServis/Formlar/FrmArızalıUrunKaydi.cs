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
    public partial class FrmArızalıUrunKaydi : Form
    {
        public FrmArızalıUrunKaydi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmArızalıUrunKaydi_Load(object sender, EventArgs e)
        {
            //Müşteri
            lookUpEdit1.Properties.DataSource = (from u in db.TBLCARI
                                                 select new
                                                 {
                                                     u.ID,
                                                    AD= u.AD+" "+u.SOYAD
                                                 }).ToList();

            //Personel
            lookUpEdit2.Properties.DataSource = (from u in db.TBLPERSONEL
                                                 select new
                                                 {
                                                     u.ID,
                                                     AD = u.AD + " " + u.SOYAD
                                                 }).ToList();

            txtTarih.Text = DateTime.Now.ToShortDateString();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (lookUpEdit1.Text==""|| lookUpEdit1.Text== "Müşteri Seç" ||lookUpEdit2.Text==""|| lookUpEdit2.Text== "Personel Seç"|| txtSeriNo.Text=="")
            {
                MessageBox.Show("İlgili Alanları Eksizksiz Doldurun", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TBLURUNKABUL t = new TBLURUNKABUL();
                t.CARI = int.Parse(lookUpEdit1.EditValue.ToString());
                t.GELISTARIHI = DateTime.Parse(txtTarih.Text);
                t.PERSONEL = short.Parse(lookUpEdit2.EditValue.ToString());
                t.URUNSERINO = txtSeriNo.Text;
                t.URUNDURUMDETAY = "Ürün Kaydoldu";
                t.URUNDURUM = true;
                db.TBLURUNKABUL.Add(t);
                db.SaveChanges();
                MessageBox.Show("Arıza Girişi Yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void kapat_Click(object sender, EventArgs e)
        {
            FrmArızalıUrunKaydi fr = new FrmArızalıUrunKaydi();
            this.Hide();
        }

        private void txtSeriNo_Click(object sender, EventArgs e)
        {
            txtSeriNo.Text = "";
            txtSeriNo.Focus();
        }
    }
}
