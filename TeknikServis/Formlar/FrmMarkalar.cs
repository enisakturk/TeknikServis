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
    public partial class FrmMarkalar : Form
    {
        public FrmMarkalar()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();

        private void FrmMarkalar_Load(object sender, EventArgs e)
        {
            // hangi markalar ve markalardan kaç tane ürün var sorgusu
            var degerler = db.TBLURUN.OrderBy(x => x.MARKA).GroupBy(y => y.MARKA).Select(z => new { Marka = z.Key, Toplam = z.Count() });
            gridControl1.DataSource = degerler.ToList();
           
            marka_istatistik.Series["Ürünler"].Points.AddPoint("Siemens", 4);
            marka_istatistik.Series["Ürünler"].Points.AddPoint("Arcelik", 6);
            marka_istatistik.Series["Ürünler"].Points.AddPoint("Beko", 2);
            marka_istatistik.Series["Ürünler"].Points.AddPoint("Asus", 1);
            marka_istatistik.Series["Ürünler"].Points.AddPoint("Samsung",4);
            marka_istatistik.Series["Ürünler"].Points.AddPoint("Lenova",1);

            kategori_istatistik.Series["Kategoriler"].Points.AddPoint("Beyaz Eşya", 4);
            kategori_istatistik.Series["Kategoriler"].Points.AddPoint("Bilgisayar", 6);
            kategori_istatistik.Series["Kategoriler"].Points.AddPoint("Küçük Ev Aletleri", 2);
            kategori_istatistik.Series["Kategoriler"].Points.AddPoint("TV", 2);
            kategori_istatistik.Series["Kategoriler"].Points.AddPoint("Telefon", 3);
            kategori_istatistik.Series["Kategoriler"].Points.AddPoint("Tablet", 8);

        }
    }
}
