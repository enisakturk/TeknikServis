
namespace TeknikServis.Formlar
{
    partial class FrmArızaListesi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArızaListesi));
            this.marka_istatistik = new DevExpress.XtraCharts.ChartControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.panel8 = new System.Windows.Forms.Panel();
            this.İptal_Edilen_İslem = new DevExpress.XtraEditors.LabelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.panel9 = new System.Windows.Forms.Panel();
            this.toplam_urun_sayısı = new DevExpress.XtraEditors.LabelControl();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.panel10 = new System.Windows.Forms.Panel();
            this.mesaj_beklenen_musteri = new DevExpress.XtraEditors.LabelControl();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.parça_bekleyen_urun = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.arızası_bitmis_sayısı = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.arızalı_urun_sayısı = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.marka_istatistik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // marka_istatistik
            // 
            this.marka_istatistik.Legend.Name = "Default Legend";
            this.marka_istatistik.Location = new System.Drawing.Point(-2, 61);
            this.marka_istatistik.Margin = new System.Windows.Forms.Padding(8);
            this.marka_istatistik.Name = "marka_istatistik";
            this.marka_istatistik.PaletteName = "Office 2013";
            series1.LegendTextPattern = "{A}";
            series1.Name = "Ürünler";
            series1.View = pieSeriesView1;
            this.marka_istatistik.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.marka_istatistik.Size = new System.Drawing.Size(657, 233);
            this.marka_istatistik.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(18, 8);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(8);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(185, 21);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Arızalı Ürün İstatistikleri";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(22, 42);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(8);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(294, 13);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Bu grafikte her bir markanın kaç adet ürünü olduğunu gösterir\r\n";
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.marka_istatistik);
            this.panelControl1.Location = new System.Drawing.Point(600, 271);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(8);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(655, 282);
            this.panelControl1.TabIndex = 12;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.Gainsboro;
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.WhiteSmoke;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.DetailHeight = 865;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(8);
            this.gridControl1.Location = new System.Drawing.Point(1, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(8);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(590, 552);
            this.gridControl1.TabIndex = 11;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel8.Controls.Add(this.İptal_Edilen_İslem);
            this.panel8.Controls.Add(this.labelControl16);
            this.panel8.Location = new System.Drawing.Point(1048, 141);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(206, 119);
            this.panel8.TabIndex = 18;
            // 
            // İptal_Edilen_İslem
            // 
            this.İptal_Edilen_İslem.Appearance.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.İptal_Edilen_İslem.Appearance.ForeColor = System.Drawing.Color.White;
            this.İptal_Edilen_İslem.Appearance.Options.UseFont = true;
            this.İptal_Edilen_İslem.Appearance.Options.UseForeColor = true;
            this.İptal_Edilen_İslem.Location = new System.Drawing.Point(97, 46);
            this.İptal_Edilen_İslem.Margin = new System.Windows.Forms.Padding(2);
            this.İptal_Edilen_İslem.Name = "İptal_Edilen_İslem";
            this.İptal_Edilen_İslem.Size = new System.Drawing.Size(20, 46);
            this.İptal_Edilen_İslem.TabIndex = 1;
            this.İptal_Edilen_İslem.Text = "9";
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl16.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl16.Appearance.Options.UseFont = true;
            this.labelControl16.Appearance.Options.UseForeColor = true;
            this.labelControl16.Location = new System.Drawing.Point(54, 13);
            this.labelControl16.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(118, 19);
            this.labelControl16.TabIndex = 0;
            this.labelControl16.Text = "İptal Edilen İşlemler";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel9.Controls.Add(this.toplam_urun_sayısı);
            this.panel9.Controls.Add(this.labelControl18);
            this.panel9.Location = new System.Drawing.Point(825, 141);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(206, 119);
            this.panel9.TabIndex = 17;
            // 
            // toplam_urun_sayısı
            // 
            this.toplam_urun_sayısı.Appearance.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplam_urun_sayısı.Appearance.ForeColor = System.Drawing.Color.White;
            this.toplam_urun_sayısı.Appearance.Options.UseFont = true;
            this.toplam_urun_sayısı.Appearance.Options.UseForeColor = true;
            this.toplam_urun_sayısı.Location = new System.Drawing.Point(72, 46);
            this.toplam_urun_sayısı.Margin = new System.Windows.Forms.Padding(2);
            this.toplam_urun_sayısı.Name = "toplam_urun_sayısı";
            this.toplam_urun_sayısı.Size = new System.Drawing.Size(40, 46);
            this.toplam_urun_sayısı.TabIndex = 1;
            this.toplam_urun_sayısı.Text = "90";
            // 
            // labelControl18
            // 
            this.labelControl18.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl18.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl18.Appearance.Options.UseFont = true;
            this.labelControl18.Appearance.Options.UseForeColor = true;
            this.labelControl18.Location = new System.Drawing.Point(43, 13);
            this.labelControl18.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(117, 19);
            this.labelControl18.TabIndex = 0;
            this.labelControl18.Text = "Toplam Ürün Sayısı";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel10.Controls.Add(this.mesaj_beklenen_musteri);
            this.panel10.Controls.Add(this.labelControl20);
            this.panel10.Location = new System.Drawing.Point(600, 141);
            this.panel10.Margin = new System.Windows.Forms.Padding(2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(206, 119);
            this.panel10.TabIndex = 16;
            // 
            // mesaj_beklenen_musteri
            // 
            this.mesaj_beklenen_musteri.Appearance.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mesaj_beklenen_musteri.Appearance.ForeColor = System.Drawing.Color.White;
            this.mesaj_beklenen_musteri.Appearance.Options.UseFont = true;
            this.mesaj_beklenen_musteri.Appearance.Options.UseForeColor = true;
            this.mesaj_beklenen_musteri.Location = new System.Drawing.Point(95, 46);
            this.mesaj_beklenen_musteri.Margin = new System.Windows.Forms.Padding(2);
            this.mesaj_beklenen_musteri.Name = "mesaj_beklenen_musteri";
            this.mesaj_beklenen_musteri.Size = new System.Drawing.Size(20, 46);
            this.mesaj_beklenen_musteri.TabIndex = 5;
            this.mesaj_beklenen_musteri.Text = "5";
            // 
            // labelControl20
            // 
            this.labelControl20.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl20.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl20.Appearance.Options.UseFont = true;
            this.labelControl20.Appearance.Options.UseForeColor = true;
            this.labelControl20.Location = new System.Drawing.Point(25, 13);
            this.labelControl20.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(161, 19);
            this.labelControl20.TabIndex = 0;
            this.labelControl20.Text = "Mesaj Beklenen Müşteriler";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel3.Controls.Add(this.parça_bekleyen_urun);
            this.panel3.Controls.Add(this.labelControl6);
            this.panel3.Location = new System.Drawing.Point(1048, 10);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(206, 119);
            this.panel3.TabIndex = 15;
            // 
            // parça_bekleyen_urun
            // 
            this.parça_bekleyen_urun.Appearance.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.parça_bekleyen_urun.Appearance.ForeColor = System.Drawing.Color.White;
            this.parça_bekleyen_urun.Appearance.Options.UseFont = true;
            this.parça_bekleyen_urun.Appearance.Options.UseForeColor = true;
            this.parça_bekleyen_urun.Location = new System.Drawing.Point(97, 46);
            this.parça_bekleyen_urun.Margin = new System.Windows.Forms.Padding(2);
            this.parça_bekleyen_urun.Name = "parça_bekleyen_urun";
            this.parça_bekleyen_urun.Size = new System.Drawing.Size(20, 46);
            this.parça_bekleyen_urun.TabIndex = 1;
            this.parça_bekleyen_urun.Text = "8";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(31, 13);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(163, 19);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Parça Bekleyen Ürün Sayısı";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.arızası_bitmis_sayısı);
            this.panel2.Controls.Add(this.labelControl1);
            this.panel2.Location = new System.Drawing.Point(825, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 119);
            this.panel2.TabIndex = 14;
            // 
            // arızası_bitmis_sayısı
            // 
            this.arızası_bitmis_sayısı.Appearance.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.arızası_bitmis_sayısı.Appearance.ForeColor = System.Drawing.Color.White;
            this.arızası_bitmis_sayısı.Appearance.Options.UseFont = true;
            this.arızası_bitmis_sayısı.Appearance.Options.UseForeColor = true;
            this.arızası_bitmis_sayısı.Location = new System.Drawing.Point(92, 46);
            this.arızası_bitmis_sayısı.Margin = new System.Windows.Forms.Padding(2);
            this.arızası_bitmis_sayısı.Name = "arızası_bitmis_sayısı";
            this.arızası_bitmis_sayısı.Size = new System.Drawing.Size(20, 46);
            this.arızası_bitmis_sayısı.TabIndex = 1;
            this.arızası_bitmis_sayısı.Text = "6";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(22, 13);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(162, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tamiratı Bitmiş Ürün Sayısı";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.arızalı_urun_sayısı);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Location = new System.Drawing.Point(600, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 119);
            this.panel1.TabIndex = 13;
            // 
            // arızalı_urun_sayısı
            // 
            this.arızalı_urun_sayısı.Appearance.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.arızalı_urun_sayısı.Appearance.ForeColor = System.Drawing.Color.White;
            this.arızalı_urun_sayısı.Appearance.Options.UseFont = true;
            this.arızalı_urun_sayısı.Appearance.Options.UseForeColor = true;
            this.arızalı_urun_sayısı.Location = new System.Drawing.Point(95, 46);
            this.arızalı_urun_sayısı.Margin = new System.Windows.Forms.Padding(2);
            this.arızalı_urun_sayısı.Name = "arızalı_urun_sayısı";
            this.arızalı_urun_sayısı.Size = new System.Drawing.Size(20, 46);
            this.arızalı_urun_sayısı.TabIndex = 1;
            this.arızalı_urun_sayısı.Text = "3";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(32, 13);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(158, 19);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Mevcut Arızalı Ürün Sayısı";
            // 
            // FrmArızaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1264, 562);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmArızaListesi";
            this.Text = "Arızalı Ürün Listesi";
            this.Load += new System.EventHandler(this.FrmArızaListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marka_istatistik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraCharts.ChartControl marka_istatistik;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.Panel panel8;
        private DevExpress.XtraEditors.LabelControl İptal_Edilen_İslem;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private System.Windows.Forms.Panel panel9;
        private DevExpress.XtraEditors.LabelControl toplam_urun_sayısı;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private System.Windows.Forms.Panel panel10;
        private DevExpress.XtraEditors.LabelControl mesaj_beklenen_musteri;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.LabelControl parça_bekleyen_urun;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl arızası_bitmis_sayısı;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl arızalı_urun_sayısı;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}