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
    public partial class FrmArızalıUrunAcıklama : Form
    {
        public FrmArızalıUrunAcıklama()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        private void kapat_Click(object sender, EventArgs e)
        {
            FrmArızalıUrunAcıklama fr = new FrmArızalıUrunAcıklama();
            this.Hide();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtSeriNo.Text == "" || cmbDurum.Text == "" || txtAcıklama.Text == "")
            {
                MessageBox.Show("İlgili Alanları Eksizksiz Doldurun", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TBLURUNTAKIP t = new TBLURUNTAKIP();
                t.ACIKLAMA = txtAcıklama.Text;
                t.SERINO = txtSeriNo.Text;
                t.TARIH = DateTime.Parse(txtTarih.Text);
                db.TBLURUNTAKIP.Add(t);


                TBLURUNKABUL x = new TBLURUNKABUL();
                int urunid = int.Parse(id.ToString());
                var deger = db.TBLURUNKABUL.Find(urunid);
                deger.URUNDURUMDETAY = cmbDurum.Text;

                db.SaveChanges();

                MessageBox.Show("Ürün Arıza Detayları Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void txtSeriNo_Click(object sender, EventArgs e)
        {
            txtSeriNo.Text = "";
            txtSeriNo.Focus();
        }

        public string id, serino;
        private void FrmArızalıUrunAcıklama_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtSeriNo.Text = serino;
        }

        private void txtAcıklama_Click(object sender, EventArgs e)
        {
            txtAcıklama.Text = "";
            txtAcıklama.Focus();
        }
    }
}
