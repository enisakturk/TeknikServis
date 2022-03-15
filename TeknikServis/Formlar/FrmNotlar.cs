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
    public partial class FrmNotlar : Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        void Listele()
        {
            //okuma notun okunup okunmadığını gösterir
            gridControl1.DataSource = db.TBLNOTLARIM.Where(x => x.OKUMA == false).ToList();
            gridControl2.DataSource = db.TBLNOTLARIM.Where(y => y.OKUMA == true).ToList();
        }
        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLNOTLARIM t = new TBLNOTLARIM();
            t.BASLIK = TxtBaşlık.Text;
            t.ICERIK = txtİçerik.Text;
            t.OKUMA = false;
            db.TBLNOTLARIM.Add(t);
            db.SaveChanges();
            MessageBox.Show("Not Kayıt Edildi","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (checkEdit1.Checked==true)
            {
                int id = int.Parse(TxtId.Text);
                var deger = db.TBLNOTLARIM.Find(id);
                deger.OKUMA = true;
                db.SaveChanges();
                MessageBox.Show("Not Durumu Güncelleştirildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
        }
    }
}
