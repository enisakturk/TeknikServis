﻿
namespace TeknikServis.İletişim
{
    partial class FrmMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMail));
            this.txtAlıcı = new DevExpress.XtraEditors.TextEdit();
            this.btnGonder = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.txtKonu = new DevExpress.XtraEditors.TextEdit();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.txtMesaj = new DevExpress.XtraEditors.TextEdit();
            this.btnVazgec = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlıcı.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKonu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMesaj.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVazgec.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAlıcı
            // 
            this.txtAlıcı.EditValue = "Alıcı";
            this.txtAlıcı.Location = new System.Drawing.Point(56, 76);
            this.txtAlıcı.Name = "txtAlıcı";
            this.txtAlıcı.Properties.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.txtAlıcı.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAlıcı.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtAlıcı.Properties.Appearance.Options.UseBackColor = true;
            this.txtAlıcı.Properties.Appearance.Options.UseFont = true;
            this.txtAlıcı.Properties.Appearance.Options.UseForeColor = true;
            this.txtAlıcı.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtAlıcı.Size = new System.Drawing.Size(200, 26);
            this.txtAlıcı.TabIndex = 0;
            // 
            // btnGonder
            // 
            this.btnGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.Image")));
            this.btnGonder.Location = new System.Drawing.Point(82, 239);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(133, 33);
            this.btnGonder.TabIndex = 2;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(14, 75);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(36, 33);
            this.pictureEdit1.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(54, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(190, 25);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Mail Gönderme Paneli";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(56, 107);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 3);
            this.panel2.TabIndex = 88;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(56, 161);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 3);
            this.panel1.TabIndex = 91;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(14, 129);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit2.Size = new System.Drawing.Size(36, 33);
            this.pictureEdit2.TabIndex = 90;
            // 
            // txtKonu
            // 
            this.txtKonu.EditValue = "Konu";
            this.txtKonu.Location = new System.Drawing.Point(56, 130);
            this.txtKonu.Name = "txtKonu";
            this.txtKonu.Properties.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.txtKonu.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKonu.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtKonu.Properties.Appearance.Options.UseBackColor = true;
            this.txtKonu.Properties.Appearance.Options.UseFont = true;
            this.txtKonu.Properties.Appearance.Options.UseForeColor = true;
            this.txtKonu.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtKonu.Size = new System.Drawing.Size(200, 26);
            this.txtKonu.TabIndex = 89;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(56, 215);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 3);
            this.panel3.TabIndex = 94;
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(14, 185);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit3.Size = new System.Drawing.Size(36, 33);
            this.pictureEdit3.TabIndex = 93;
            // 
            // txtMesaj
            // 
            this.txtMesaj.EditValue = "Mesaj";
            this.txtMesaj.Location = new System.Drawing.Point(56, 184);
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Properties.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.txtMesaj.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMesaj.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtMesaj.Properties.Appearance.Options.UseBackColor = true;
            this.txtMesaj.Properties.Appearance.Options.UseFont = true;
            this.txtMesaj.Properties.Appearance.Options.UseForeColor = true;
            this.txtMesaj.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtMesaj.Size = new System.Drawing.Size(200, 26);
            this.txtMesaj.TabIndex = 92;
            // 
            // btnVazgec
            // 
            this.btnVazgec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVazgec.EditValue = ((object)(resources.GetObject("btnVazgec.EditValue")));
            this.btnVazgec.Location = new System.Drawing.Point(291, 11);
            this.btnVazgec.Margin = new System.Windows.Forms.Padding(2);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.btnVazgec.Properties.Appearance.Options.UseBackColor = true;
            this.btnVazgec.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.btnVazgec.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.btnVazgec.Size = new System.Drawing.Size(20, 23);
            this.btnVazgec.TabIndex = 95;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // FrmMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(322, 302);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureEdit3);
            this.Controls.Add(this.txtMesaj);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.txtKonu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.txtAlıcı);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail";
            ((System.ComponentModel.ISupportInitialize)(this.txtAlıcı.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKonu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMesaj.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVazgec.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtAlıcı;
        private DevExpress.XtraEditors.SimpleButton btnGonder;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.TextEdit txtKonu;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private DevExpress.XtraEditors.TextEdit txtMesaj;
        private DevExpress.XtraEditors.PictureEdit btnVazgec;
    }
}