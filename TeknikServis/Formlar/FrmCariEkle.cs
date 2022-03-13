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
    public partial class FrmCariEkle : Form
    {
        public FrmCariEkle()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBLCARI t = new TBLCARI();
            t.AD = txtAd.Text;
            t.SOYAD = txtSoyad.Text;
            t.TELEFON = txtTelefon.Text;
            t.MAIL = txtMail.Text;
            t.IL = txtİl.Text;
            t.ILCE = txtİlçe.Text;
            t.ADRES = txtAdress.Text;
            t.BANKA = txtBanka.Text;
            t.VERGIDAIRESI = txtVergiDairesi.Text;
            t.VERGINO = txtVergiNo.Text;
            t.STATU = txtStatu.Text;
            db.TBLCARI.Add(t);
            db.SaveChanges();
            MessageBox.Show("Yeni Cari Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
