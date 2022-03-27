
namespace TeknikServis.Formlar
{
    partial class FrmYeniDepartman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYeniDepartman));
            this.kapat = new DevExpress.XtraEditors.PictureEdit();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit7 = new DevExpress.XtraEditors.TextEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDepartmanAd = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.kapat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartmanAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // kapat
            // 
            this.kapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kapat.EditValue = ((object)(resources.GetObject("kapat.EditValue")));
            this.kapat.Location = new System.Drawing.Point(340, 10);
            this.kapat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kapat.Name = "kapat";
            this.kapat.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.kapat.Properties.Appearance.Options.UseBackColor = true;
            this.kapat.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.kapat.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.kapat.Size = new System.Drawing.Size(20, 23);
            this.kapat.TabIndex = 73;
            this.kapat.Click += new System.EventHandler(this.kapat_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(133, 136);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(114, 28);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // textEdit7
            // 
            this.textEdit7.EditValue = "Yeni Departman Ekleme";
            this.textEdit7.Enabled = false;
            this.textEdit7.Location = new System.Drawing.Point(102, 12);
            this.textEdit7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textEdit7.Name = "textEdit7";
            this.textEdit7.Properties.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.textEdit7.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit7.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.textEdit7.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit7.Properties.Appearance.Options.UseFont = true;
            this.textEdit7.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit7.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textEdit7.Size = new System.Drawing.Size(202, 26);
            this.textEdit7.TabIndex = 71;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(110, 109);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 3);
            this.panel1.TabIndex = 69;
            // 
            // txtDepartmanAd
            // 
            this.txtDepartmanAd.EditValue = "Departman Adı";
            this.txtDepartmanAd.Location = new System.Drawing.Point(113, 82);
            this.txtDepartmanAd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDepartmanAd.Name = "txtDepartmanAd";
            this.txtDepartmanAd.Properties.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.txtDepartmanAd.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartmanAd.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtDepartmanAd.Properties.Appearance.Options.UseBackColor = true;
            this.txtDepartmanAd.Properties.Appearance.Options.UseFont = true;
            this.txtDepartmanAd.Properties.Appearance.Options.UseForeColor = true;
            this.txtDepartmanAd.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtDepartmanAd.Size = new System.Drawing.Size(170, 26);
            this.txtDepartmanAd.TabIndex = 1;
            this.txtDepartmanAd.Click += new System.EventHandler(this.txtDepartmanAd_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(76, 79);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(30, 32);
            this.pictureEdit1.TabIndex = 67;
            // 
            // FrmYeniDepartman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(376, 188);
            this.Controls.Add(this.kapat);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.textEdit7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtDepartmanAd);
            this.Controls.Add(this.pictureEdit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmYeniDepartman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmYeniDepartman";
            ((System.ComponentModel.ISupportInitialize)(this.kapat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartmanAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit kapat;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.TextEdit textEdit7;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit txtDepartmanAd;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}