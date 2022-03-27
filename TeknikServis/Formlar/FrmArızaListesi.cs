using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TeknikServis.Formlar
{
    public partial class FrmArızaListesi : Form
    {
        public FrmArızaListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmArızaListesi_Load(object sender, EventArgs e)
        {
            var degerler = from x in db.TBLURUNKABUL
                           select new
                           { 
                               x.ISLEMID,
                               CARI= x.TBLCARI.AD +" "+ x.TBLCARI.SOYAD,
                               PERSONEL= x.TBLPERSONEL.AD +" "+ x.TBLPERSONEL.SOYAD,
                               x.GELISTARIHI,
                               x.CIKISTARIHI,
                               x.URUNSERINO,
                               x.URUNDURUMDETAY
                           };
            gridControl1.DataSource = degerler.ToList();

            // bilgi panellerindeki ürünlerin tamir edilip edilmediğini sayan kısım
            arızalı_urun_sayısı.Text = db.TBLURUNKABUL.Count(x=>x.URUNDURUM==true).ToString();
            arızası_bitmis_sayısı.Text = db.TBLURUNKABUL.Count(x=>x.URUNDURUM==false).ToString();

            toplam_urun_sayısı.Text = db.TBLURUN.Count().ToString();

            parça_bekleyen_urun.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUMDETAY == "Parça Bekliyor").ToString();
            mesaj_beklenen_musteri.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUMDETAY == "Mesaj Bekliyor").ToString();
            İptal_Edilen_İslem.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUMDETAY == "İptal Bekliyor").ToString();


            SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-CQJ8G3J\\SQLEXPRESS;Initial Catalog=DbTeknikServis;Integrated Security=True");

            // charttaki ürünlerin durumunu çeken sorgu
            baglantı.Open();
            SqlCommand sorgu = new SqlCommand("SELECT URUNDURUMDETAY,COUNT(*) FROM TBLURUNKABUL GROUP BY URUNDURUMDETAY", baglantı);
            SqlDataReader oku = sorgu.ExecuteReader();
            while (oku.Read())
            {
                marka_istatistik.Series["Ürünler"].Points.AddPoint(Convert.ToString(oku[0]), int.Parse(oku[1].ToString()));
            }
            baglantı.Close();
        }
        // grid in içinden ürün açıklaması yapmak için yazıldı
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmArızalıUrunAcıklama fr = new FrmArızalıUrunAcıklama();
            fr.id = gridView1.GetFocusedRowCellValue("ISLEMID").ToString();
            fr.serino = gridView1.GetFocusedRowCellValue("URUNSERINO").ToString();
            fr.Show();
        }
    }
}
