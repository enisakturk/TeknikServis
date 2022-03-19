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
            TBLURUNTAKIP t = new TBLURUNTAKIP();
            t.ACIKLAMA = richTextBox1.Text;
            t.SERINO = txtSeriNo.Text;
            t.TARIH = DateTime.Parse(txtTarih.Text);
            db.TBLURUNTAKIP.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Arıza Detayları Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
