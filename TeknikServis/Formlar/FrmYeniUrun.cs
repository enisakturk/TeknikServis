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
    public partial class FrmYeniUrun : Form
    {
        public FrmYeniUrun()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (lookUpEdit1.Text==""|| lookUpEdit1.Text== "Kategori Seç"|| txtUrunAd.Text==""||txtMarka.Text=="")
            {
                MessageBox.Show("İlgili Alanları Eksizksiz Doldurun", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TBLURUN t = new TBLURUN();
                t.AD = txtUrunAd.Text;
                t.ALISFIYAT = decimal.Parse(txtAlısFiyat.Text);
                t.SATISFIYAT = decimal.Parse(txtSatısFiyat.Text);
                t.STOK = short.Parse(txtStok.Text);
                t.KATEGORI = byte.Parse(lookUpEdit1.EditValue.ToString());
                t.MARKA = txtMarka.Text;
                db.TBLURUN.Add(t);
                db.SaveChanges();
                MessageBox.Show("Ürünler Kayıt Edildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           

        }

        private void kapat_Click(object sender, EventArgs e)
        {
            FrmYeniUrun fr = new FrmYeniUrun();
            this.Hide();
            
        }

        private void txtUrunAd_Click(object sender, EventArgs e)
        {
            txtUrunAd.Text = "";
            txtUrunAd.Focus();
        }

        private void txtMarka_Click(object sender, EventArgs e)
        {
            txtMarka.Text = "";
            txtMarka.Focus();
        }

        private void txtAlısFiyat_Click(object sender, EventArgs e)
        {
            txtAlısFiyat.Text = "";
            txtAlısFiyat.Focus();
        }

        private void txtSatısFiyat_Click(object sender, EventArgs e)
        {
            txtSatısFiyat.Text = "";
            txtSatısFiyat.Focus();
        }

        private void txtStok_Click(object sender, EventArgs e)
        {
            txtStok.Text = "";
            txtStok.Focus();
        }

        private void FrmYeniUrun_Load(object sender, EventArgs e)
        {
            lookUpEdit1.Properties.DataSource = (from u in db.TBLKATEGORI
                                                 select new
                                                 {
                                                     u.ID,
                                                     u.AD
                                                 }).ToList();
        }

        private void txtAlısFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtSatısFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtStok_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
