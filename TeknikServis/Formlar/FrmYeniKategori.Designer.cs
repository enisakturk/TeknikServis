
namespace TeknikServis.Formlar
{
    partial class FrmYeniKategori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYeniKategori));
            this.textEdit7 = new DevExpress.XtraEditors.TextEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtKategoriAd = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.kapat = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKategoriAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kapat.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textEdit7
            // 
            this.textEdit7.EditValue = "Yeni Kategori Ekleme";
            this.textEdit7.Enabled = false;
            this.textEdit7.Location = new System.Drawing.Point(105, 16);
            this.textEdit7.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit7.Name = "textEdit7";
            this.textEdit7.Properties.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.textEdit7.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit7.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.textEdit7.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit7.Properties.Appearance.Options.UseFont = true;
            this.textEdit7.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit7.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textEdit7.Size = new System.Drawing.Size(175, 26);
            this.textEdit7.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(102, 102);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 3);
            this.panel1.TabIndex = 22;
            // 
            // txtKategoriAd
            // 
            this.txtKategoriAd.EditValue = "Kategori Adı";
            this.txtKategoriAd.Location = new System.Drawing.Point(105, 75);
            this.txtKategoriAd.Margin = new System.Windows.Forms.Padding(2);
            this.txtKategoriAd.Name = "txtKategoriAd";
            this.txtKategoriAd.Properties.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.txtKategoriAd.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKategoriAd.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtKategoriAd.Properties.Appearance.Options.UseBackColor = true;
            this.txtKategoriAd.Properties.Appearance.Options.UseFont = true;
            this.txtKategoriAd.Properties.Appearance.Options.UseForeColor = true;
            this.txtKategoriAd.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtKategoriAd.Size = new System.Drawing.Size(170, 26);
            this.txtKategoriAd.TabIndex = 1;
            this.txtKategoriAd.Click += new System.EventHandler(this.txtKategoriAd_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(68, 72);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(30, 32);
            this.pictureEdit1.TabIndex = 20;
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(115, 129);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(143, 28);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kategori Ekle";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // kapat
            // 
            this.kapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kapat.EditValue = ((object)(resources.GetObject("kapat.EditValue")));
            this.kapat.Location = new System.Drawing.Point(347, 10);
            this.kapat.Margin = new System.Windows.Forms.Padding(2);
            this.kapat.Name = "kapat";
            this.kapat.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.kapat.Properties.Appearance.Options.UseBackColor = true;
            this.kapat.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.kapat.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.kapat.Size = new System.Drawing.Size(20, 23);
            this.kapat.TabIndex = 66;
            this.kapat.Click += new System.EventHandler(this.kapat_Click);
            // 
            // FrmYeniKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(376, 188);
            this.Controls.Add(this.kapat);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.textEdit7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtKategoriAd);
            this.Controls.Add(this.pictureEdit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmYeniKategori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmYeniKategori";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKategoriAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kapat.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEdit7;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit txtKategoriAd;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.PictureEdit kapat;
    }
}