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
    public partial class FrmYeniDepartman : Form
    {
        public FrmYeniDepartman()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtDepartmanAd.Text==""||txtDepartmanAd.Text== "Departman Adı"||txtDepartmanAd.Text.Length>=51)
            {
                MessageBox.Show("Departman Kayıt Edilemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TBLDEPARTMAN t = new TBLDEPARTMAN();
                t.AD = txtDepartmanAd.Text;
                db.TBLDEPARTMAN.Add(t);
                db.SaveChanges();
                MessageBox.Show("Departman Kayıt Edildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void kapat_Click(object sender, EventArgs e)
        {
            FrmYeniDepartman fr = new FrmYeniDepartman();
            this.Hide();
        }

        private void txtDepartmanAd_Click(object sender, EventArgs e)
        {
            txtDepartmanAd.Text = "";
            txtDepartmanAd.Focus();
        }
    }
}
