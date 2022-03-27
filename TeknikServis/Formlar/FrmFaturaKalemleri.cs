﻿using System;
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
    public partial class FrmFaturaKalemleri : Form
    {
        public FrmFaturaKalemleri()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();




        private void btnAra_Click(object sender, EventArgs e)
        {
            if (txtFaturaId.Text=="")
            {
                MessageBox.Show("Boş Geçilemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int id = Convert.ToInt32(txtFaturaId.Text);
                var degerler = (from u in db.TBLFATURADETAY
                                select new
                                {
                                    u.FATURADETAYID,
                                    u.URUN,
                                    u.ADET,
                                    u.FIYAT,
                                    u.TUTAR,
                                    u.FATURAID,
                                }).Where(x => x.FATURAID == id);
                gridControl1.DataSource = degerler.ToList();
            }
           
        }

        private void txtFaturaId_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }
    }
}
