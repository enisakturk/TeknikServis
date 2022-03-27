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
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();

        private void Frmİstatistik_Load(object sender, EventArgs e)
        {
            toplam_urun.Text = db.TBLURUN.Count().ToString();
            toplam_kategori.Text = db.TBLKATEGORI.Count().ToString();
            kritik_seviye.Text = "10";
            //tblurun tablosunda stoktaki ürünleri topla
            toplam_stok.Text = db.TBLURUN.Sum(x => x.STOK).ToString();
            //tblurun içinde x diye bir deger tanımlandı bu sayede tablo içindeki değerlere ulaştım
            en_fazla_stok_urunu.Text = (from x in db.TBLURUN orderby x.STOK descending select x.AD).FirstOrDefault(); 
            en_az_stoklu_urun.Text= (from x in db.TBLURUN orderby x.STOK ascending select x.AD).FirstOrDefault();
            en_yuksek_fiyatlı_urun.Text = (from x in db.TBLURUN orderby x.SATISFIYAT descending select x.AD).FirstOrDefault();
            en_dusuk_fiyatlı_urun.Text = (from x in db.TBLURUN orderby x.SATISFIYAT ascending select x.AD).FirstOrDefault();
            beyaz_esya_stok_adet.Text = db.TBLURUN.Count(x => x.KATEGORI == 4).ToString();
            laptop_stok_adet.Text= db.TBLURUN.Count(x => x.KATEGORI == 1).ToString();
            tv_stok_sayısı.Text = db.TBLURUN.Count(x => x.KATEGORI == 5).ToString();
            kucuk_ev_aleti_stok_sayısı.Text= db.TBLURUN.Count(x => x.KATEGORI == 3).ToString();
            toplam_marka_sayısı.Text = (from x in db.TBLURUN select x.MARKA).Distinct().Count().ToString();
            Arızalı_Urun_Sayısı.Text = db.TBLURUNKABUL.Count().ToString();
            En_Fazla_Urun_Kat.Text = db.MaxKategoriUrun().FirstOrDefault();
        }
    }
}
