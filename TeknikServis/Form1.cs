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

        Formlar.Frmİstatistik fr2;
        private void Btnİstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr2 == null || fr2.IsDisposed)
            {
                fr2 = new Formlar.Frmİstatistik();
                fr2.MdiParent = this;
                fr2.Show();
            }
        }

        Formlar.FrmMarkalar fr4;
        private void btnMarkaİstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr4 == null || fr4.IsDisposed)
            {
                fr4 = new Formlar.FrmMarkalar();
                fr4.MdiParent = this;
                fr4.Show();
            };
        }

        Formlar.FrmCariListesi fr6;
        private void BtnCariListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr6 == null || fr6.IsDisposed)
            {
                fr6 = new Formlar.FrmCariListesi();
                fr6.MdiParent = this;
                fr6.Show();
            };
        }

        Formlar.FrmCariİller fr7;
        private void BtnCariİstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr7 == null || fr7.IsDisposed)
            {
                fr7 = new Formlar.FrmCariİller();
                fr7.MdiParent = this;
                fr7.Show();
            };
        }

        private void YeniCariEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmCariEkle fr = new Formlar.FrmCariEkle();
            fr.Show();
        }

        Formlar.FrmDepartman fr11;
        private void btnDepartmanListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr11 == null || fr11.IsDisposed)
            {
                fr11 = new Formlar.FrmDepartman();
                fr11.MdiParent = this;
                fr11.Show();
            };
        }

        private void BtnYeniDepartman_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmYeniDepartman fr = new Formlar.FrmYeniDepartman();
            fr.Show();
        }

        Formlar.FrmPersonel fr12;
        private void BtnPersonelListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr12 == null || fr12.IsDisposed)
            {
                fr12 = new Formlar.FrmPersonel();
                fr12.MdiParent = this;
                fr12.Show();
            };
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

        Formlar.FrmArızaListesi fr5;
        private void btnArızalıÜrünListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr5 == null || fr5.IsDisposed)
            {
                fr5 = new Formlar.FrmArızaListesi();
                fr5.MdiParent = this;
                fr5.Show();
            }
        }

        private void btnÜrünSatışı_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmUrunSatıs fr = new Formlar.FrmUrunSatıs();
            fr.Show();
        }

        Formlar.FrmSatisListesi fr9;
        private void btnSatısListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr9 == null || fr9.IsDisposed)
            {
                fr9 = new Formlar.FrmSatisListesi();
                fr9.MdiParent = this;
                fr9.Show();
            }
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

        Formlar.FrmArizaliUrunDetayListesi fr8;
        private void btnArızalıUrunDetay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr8 == null || fr8.IsDisposed)
            {
                fr8 = new Formlar.FrmArizaliUrunDetayListesi();
                fr8.MdiParent = this;
                fr8.Show();
            }
        }

        private void btnQRCode_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmQRCode fr = new Formlar.FrmQRCode();
            fr.Show();
        }

        Formlar.FrmFaturaListesi fr10;
        private void btnFaturaListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr10 == null || fr10.IsDisposed)
            {
                fr10 = new Formlar.FrmFaturaListesi();
                fr10.MdiParent = this;
                fr10.Show();
            }
        }

        Formlar.FrmFaturaKalem fr13;
        private void btnFaturaKalem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr13 == null || fr13.IsDisposed)
            {
                fr13 = new Formlar.FrmFaturaKalem();
                fr13.MdiParent = this;
                fr13.Show();
            }
        }

        Formlar.FrmFaturaKalemleri fr14;
        private void btnFaturaDetayListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr14 == null || fr14.IsDisposed)
            {
                fr14 = new Formlar.FrmFaturaKalemleri();
                fr14.MdiParent = this;
                fr14.Show();
            }
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
