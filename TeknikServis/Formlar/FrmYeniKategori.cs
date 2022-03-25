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
    public partial class FrmYeniKategori : Form
    {
        public FrmYeniKategori()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtKategoriAd.Text!=""&&txtKategoriAd.Text.Length<=30)
            {
                TBLKATEGORI t = new TBLKATEGORI();
                t.AD = txtKategoriAd.Text;
                db.TBLKATEGORI.Add(t);
                db.SaveChanges();
                MessageBox.Show("Kategori Kayıt Edildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen Karakter Sayısını 0-30 Arasında Giriniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void kapat_Click(object sender, EventArgs e)
        {
            FrmYeniKategori fr = new FrmYeniKategori();
            this.Hide();
        }
    }
}
