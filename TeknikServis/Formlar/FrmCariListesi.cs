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
    public partial class FrmCariListesi : Form
    {
        public FrmCariListesi()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();
        void Listele()
        {
            var degerler = from u in db.TBLCARI
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.TELEFON,
                               u.IL,
                               u.ILCE,
                               u.BANKA,
                               u.VERGIDAIRESI,
                               u.VERGINO,
                               u.STATU,
                               u.ADRES
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmCariListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        
    }
}
