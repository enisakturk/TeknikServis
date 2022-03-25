using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Formlar.FrmUrunListesi fr3;
        private void BtnUrunListesiFormu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr3 == null || fr3.IsDisposed)
            {
                fr3 = new Formlar.FrmUrunListesi();
                fr3.MdiParent = this;
                fr3.Show();
            }

        }

        private void BtnYeniUrun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmYeniUrun fr = new Formlar.FrmYeniUrun();
            fr.Show();
        }

        Formlar.FrmKategori fr1;
        private void BtnKategoriListe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr1 == null || fr1.IsDisposed)
            {
                fr1 = new Formlar.FrmKategori();
                fr1.MdiParent = this;
                fr1.Show();
            }
        }

        private void BtnYeniKategori_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmYeniKategori fr = new Formlar.FrmYeniKategori();
            fr.Show();
        }

        private void Btnİstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Frmİstatistik fr = new Formlar.Frmİstatistik();
            fr.MdiParent = this;
            fr.Show();
        }

        private void btnMarka_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmMarkalar fr = new Formlar.FrmMarkalar();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnCariListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmCariListesi fr = new Formlar.FrmCariListesi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnCariİstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmCariİller fr = new Formlar.FrmCariİller();
            fr.MdiParent = this;
            fr.Show();
        }

        private void YeniCariEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmCariEkle fr = new Formlar.FrmCariEkle();
            fr.Show();
        }

        private void btnDepartmanListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmDepartman fr = new Formlar.FrmDepartman();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnYeniDepartman_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmYeniDepartman fr = new Formlar.FrmYeniDepartman();
            fr.Show();
        }

        private void BtnPersonelListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmPersonel fr = new Formlar.FrmPersonel();
            fr.MdiParent = this;
            fr.Show();
        }

        private void btnYeniPersonel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmYeniPersonel fr = new Formlar.FrmYeniPersonel();
            fr.Show();
        }

        private void btnHesapMakinası_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //diagnostics start fonksiyonu içindeki exe yi execute etmeye yarar birnevi çalıştır işlemi görür
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void btnKurlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmKurlar fr = new Formlar.FrmKurlar();
            fr.MdiParent = this;
            fr.Show();
        }

        private void btnWord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }

        private void btnNotListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmNotlar fr = new Formlar.FrmNotlar();
            fr.MdiParent = this;
            fr.Show();
        }

        private void btnArızalıÜrünListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmArızaListesi fr = new Formlar.FrmArızaListesi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void btnÜrünSatışı_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmUrunSatıs fr = new Formlar.FrmUrunSatıs();
            fr.Show();
        }

        private void btnSatısListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmSatisListesi fr = new Formlar.FrmSatisListesi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void btnYeniArızalıUrunKaydi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmArızalıUrunKaydi fr = new Formlar.FrmArızalıUrunKaydi();
            fr.Show();
        }

        private void btnArızalıUrunAcıklama_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmArızalıUrunAcıklama fr = new Formlar.FrmArızalıUrunAcıklama();
            fr.Show();
        }

        private void btnArızalıUrunDetay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmArizaliUrunDetayListesi fr = new Formlar.FrmArizaliUrunDetayListesi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void btnQRCode_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmQRCode fr = new Formlar.FrmQRCode();
            fr.Show();
        }

        private void btnFaturaListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmFaturaListesi fr = new Formlar.FrmFaturaListesi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void btnFaturaKalem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmFaturaKalem fr = new Formlar.FrmFaturaKalem();
            fr.MdiParent = this;
            fr.Show();
        }

        private void btnFaturaDetayListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmFaturaKalemleri fr = new Formlar.FrmFaturaKalemleri();
            fr.MdiParent = this;
            fr.Show();
        }

        private void btnRaporlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmRapor fr = new Formlar.FrmRapor();
            fr.Show();
        }

        Formlar.FrmAnaSayfa fr;
        private void Form1_Load(object sender, EventArgs e)
        {
            
            if (fr==null||fr.IsDisposed)
            {
                fr = new Formlar.FrmAnaSayfa();
                fr.MdiParent = this;
                fr.Show();
            }
            
        }

        private void btnAnaSayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (fr == null || fr.IsDisposed)
            {
                fr = new Formlar.FrmAnaSayfa();
                fr.MdiParent = this;
                fr.Show();
            }
        }
    }
}
