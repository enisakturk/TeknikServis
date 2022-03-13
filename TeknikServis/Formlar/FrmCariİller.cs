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
    public partial class FrmCariİller : Form
    {
        public FrmCariİller()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        SqlConnection baglantı = new SqlConnection(@"Data Source=DESKTOP-CQJ8G3J\SQLEXPRESS;Initial Catalog=DbTeknikServis;Integrated Security=True");
        private void FrmCariİller_Load(object sender, EventArgs e)
        {
           //grid e veri çeken sorgu
            gridControl1.DataSource = db.TBLCARI.OrderBy(x => x.IL).GroupBy(y => y.IL).
                Select(z => new { İL = z.Key, TOPLAM = z.Count()}).ToList();
            //---------------grafiğe veri çeken sorgu
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select IL,count(*) from TBLCARI group by IL",baglantı);
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                chartControl1.Series["Sehirler"].Points.AddPoint(Convert.ToString(oku[0]),int.Parse(oku[1].ToString()));
            }
            baglantı.Close();
        }
    }
}
