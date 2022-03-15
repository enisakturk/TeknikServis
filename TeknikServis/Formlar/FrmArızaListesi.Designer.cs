
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
            DevExpress.XtraCharts.Series series7 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView7 = new DevExpress.XtraCharts.PieSeriesView();
            this.marka_istatistik = new DevExpress.XtraCharts.ChartControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.panel8 = new System.Windows.Forms.Panel();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.panel9 = new System.Windows.Forms.Panel();
            this.en_az_stoklu_urun = new DevExpress.XtraEditors.LabelControl();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.panel10 = new System.Windows.Forms.Panel();
            this.en_fazla_stok_urunu = new DevExpress.XtraEditors.LabelControl();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.toplam_stok = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toplam_kategori = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toplam_urun = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.marka_istatistik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView7)).BeginInit();
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
            this.marka_istatistik.Location = new System.Drawing.Point(-2, 75);
            this.marka_istatistik.Margin = new System.Windows.Forms.Padding(10);
            this.marka_istatistik.Name = "marka_istatistik";
            this.marka_istatistik.PaletteName = "Office 2013";
            series7.LegendTextPattern = "{A}";
            series7.Name = "Ürünler";
            series7.View = pieSeriesView7;
            this.marka_istatistik.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series7};
            this.marka_istatistik.Size = new System.Drawing.Size(968, 287);
            this.marka_istatistik.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(24, 10);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(10);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(232, 28);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Arızalı Ürün İstatistikleri";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(29, 52);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(10);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(353, 16);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Bu grafikte her bir markanın kaç adet ürünü olduğunu gösterir\r\n";
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.marka_istatistik);
            this.panelControl1.Location = new System.Drawing.Point(800, 334);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(10);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(873, 347);
            this.panelControl1.TabIndex = 12;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.Gainsboro;
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.WhiteSmoke;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.DetailHeight = 1065;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(10);
            this.gridControl1.Location = new System.Drawing.Point(1, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(10);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(786, 679);
            this.gridControl1.TabIndex = 11;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel8.Controls.Add(this.labelControl15);
            this.panel8.Controls.Add(this.labelControl16);
            this.panel8.Location = new System.Drawing.Point(1398, 174);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(275, 147);
            this.panel8.TabIndex = 18;
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl15.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Appearance.Options.UseForeColor = true;
            this.labelControl15.Location = new System.Drawing.Point(24, 57);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(218, 59);
            this.labelControl15.TabIndex = 1;
            this.labelControl15.Text = "Beyaz Eşya";
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl16.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl16.Appearance.Options.UseFont = true;
            this.labelControl16.Appearance.Options.UseForeColor = true;
            this.labelControl16.Location = new System.Drawing.Point(24, 16);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(217, 23);
            this.labelControl16.TabIndex = 0;
            this.labelControl16.Text = "En Fazla Ağrıza Veren Marka";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel9.Controls.Add(this.en_az_stoklu_urun);
            this.panel9.Controls.Add(this.labelControl18);
            this.panel9.Location = new System.Drawing.Point(1100, 174);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(275, 147);
            this.panel9.TabIndex = 17;
            // 
            // en_az_stoklu_urun
            // 
            this.en_az_stoklu_urun.Appearance.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.en_az_stoklu_urun.Appearance.ForeColor = System.Drawing.Color.White;
            this.en_az_stoklu_urun.Appearance.Options.UseFont = true;
            this.en_az_stoklu_urun.Appearance.Options.UseForeColor = true;
            this.en_az_stoklu_urun.Location = new System.Drawing.Point(82, 57);
            this.en_az_stoklu_urun.Name = "en_az_stoklu_urun";
            this.en_az_stoklu_urun.Size = new System.Drawing.Size(89, 59);
            this.en_az_stoklu_urun.TabIndex = 1;
            this.en_az_stoklu_urun.Text = "Fırın";
            // 
            // labelControl18
            // 
            this.labelControl18.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl18.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl18.Appearance.Options.UseFont = true;
            this.labelControl18.Appearance.Options.UseForeColor = true;
            this.labelControl18.Location = new System.Drawing.Point(57, 16);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(146, 23);
            this.labelControl18.TabIndex = 0;
            this.labelControl18.Text = "Toplam Ürün Sayısı";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel10.Controls.Add(this.en_fazla_stok_urunu);
            this.panel10.Controls.Add(this.labelControl20);
            this.panel10.Location = new System.Drawing.Point(800, 174);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(275, 147);
            this.panel10.TabIndex = 16;
            // 
            // en_fazla_stok_urunu
            // 
            this.en_fazla_stok_urunu.Appearance.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.en_fazla_stok_urunu.Appearance.ForeColor = System.Drawing.Color.White;
            this.en_fazla_stok_urunu.Appearance.Options.UseFont = true;
            this.en_fazla_stok_urunu.Appearance.Options.UseForeColor = true;
            this.en_fazla_stok_urunu.Location = new System.Drawing.Point(34, 57);
            this.en_fazla_stok_urunu.Name = "en_fazla_stok_urunu";
            this.en_fazla_stok_urunu.Size = new System.Drawing.Size(202, 59);
            this.en_fazla_stok_urunu.TabIndex = 1;
            this.en_fazla_stok_urunu.Text = "Buzdolabı";
            // 
            // labelControl20
            // 
            this.labelControl20.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl20.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl20.Appearance.Options.UseFont = true;
            this.labelControl20.Appearance.Options.UseForeColor = true;
            this.labelControl20.Location = new System.Drawing.Point(55, 16);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(148, 23);
            this.labelControl20.TabIndex = 0;
            this.labelControl20.Text = "Arızalı Ürün Kazanç";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel3.Controls.Add(this.toplam_stok);
            this.panel3.Controls.Add(this.labelControl6);
            this.panel3.Location = new System.Drawing.Point(1398, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(275, 147);
            this.panel3.TabIndex = 15;
            // 
            // toplam_stok
            // 
            this.toplam_stok.Appearance.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplam_stok.Appearance.ForeColor = System.Drawing.Color.White;
            this.toplam_stok.Appearance.Options.UseFont = true;
            this.toplam_stok.Appearance.Options.UseForeColor = true;
            this.toplam_stok.Location = new System.Drawing.Point(93, 57);
            this.toplam_stok.Name = "toplam_stok";
            this.toplam_stok.Size = new System.Drawing.Size(100, 59);
            this.toplam_stok.TabIndex = 1;
            this.toplam_stok.Text = "1350";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(41, 16);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(203, 23);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Parça Bekleyen Ürün Sayısı";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.toplam_kategori);
            this.panel2.Controls.Add(this.labelControl1);
            this.panel2.Location = new System.Drawing.Point(1100, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 147);
            this.panel2.TabIndex = 14;
            // 
            // toplam_kategori
            // 
            this.toplam_kategori.Appearance.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplam_kategori.Appearance.ForeColor = System.Drawing.Color.White;
            this.toplam_kategori.Appearance.Options.UseFont = true;
            this.toplam_kategori.Appearance.Options.UseForeColor = true;
            this.toplam_kategori.Location = new System.Drawing.Point(103, 57);
            this.toplam_kategori.Name = "toplam_kategori";
            this.toplam_kategori.Size = new System.Drawing.Size(50, 59);
            this.toplam_kategori.TabIndex = 1;
            this.toplam_kategori.Text = "26";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(30, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(202, 23);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tamiratı Bitmiş Ürün Sayısı";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.toplam_urun);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Location = new System.Drawing.Point(800, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 147);
            this.panel1.TabIndex = 13;
            // 
            // toplam_urun
            // 
            this.toplam_urun.Appearance.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplam_urun.Appearance.ForeColor = System.Drawing.Color.White;
            this.toplam_urun.Appearance.Options.UseFont = true;
            this.toplam_urun.Appearance.Options.UseForeColor = true;
            this.toplam_urun.Location = new System.Drawing.Point(93, 57);
            this.toplam_urun.Name = "toplam_urun";
            this.toplam_urun.Size = new System.Drawing.Size(75, 59);
            this.toplam_urun.TabIndex = 1;
            this.toplam_urun.Text = "584";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(42, 16);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(196, 23);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Mevcut Arızalı Ürün Sayısı";
            // 
            // FrmArızaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1686, 692);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmArızaListesi";
            this.Text = "FrmArızaListesi";
            this.Load += new System.EventHandler(this.FrmArızaListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series7)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private System.Windows.Forms.Panel panel9;
        private DevExpress.XtraEditors.LabelControl en_az_stoklu_urun;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private System.Windows.Forms.Panel panel10;
        private DevExpress.XtraEditors.LabelControl en_fazla_stok_urunu;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.LabelControl toplam_stok;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl toplam_kategori;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl toplam_urun;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}