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
    public partial class FrmYeniPersonel : Form
    {
        public FrmYeniPersonel()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmYeniPersonel_Load(object sender, EventArgs e)
        {
            lookUpEdit1.Properties.DataSource = (from u in db.TBLDEPARTMAN
                                                 select new
                                                 {
                                                     u.ID,
                                                     u.AD
                                                 }).ToList();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAd.Text==""||txtSoyad.Text==""||txtTelefon.Text==""||txtMail.Text==""||lookUpEdit1.Text==""||lookUpEdit1.Text== "Departman Seç")
            {
                MessageBox.Show("Personel Kayıt Edilemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TBLPERSONEL t = new TBLPERSONEL();
                t.AD = txtAd.Text;
                t.SOYAD = txtSoyad.Text;
                t.TELEFON = txtTelefon.Text;
                t.MAIL = txtMail.Text;
                t.DEPARTMAN = byte.Parse(lookUpEdit1.EditValue.ToString());
                db.TBLPERSONEL.Add(t);
                db.SaveChanges();
                MessageBox.Show("Personel Başarıyla Kayıt Edildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void kapat_Click(object sender, EventArgs e)
        {
            FrmYeniPersonel fr = new FrmYeniPersonel();
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

       
    }
}
