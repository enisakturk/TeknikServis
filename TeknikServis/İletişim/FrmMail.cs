using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace TeknikServis.İletişim
{
    public partial class FrmMail : Form
    {
        public FrmMail()
        {
            InitializeComponent();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            MailMessage mail =  new MailMessage();
            string form_mail = "gonderici";
            string sifre = "sifreniz";
            string alici = txtAlıcı.Text;
            string konu = txtKonu.Text;
            string icerik = txtMesaj.Text;
            //mailin geleceği adres
            mail.From=new MailAddress(form_mail);
            //mailin içine alıcıyı-konuyu-ve içeriği ekle
            mail.To.Add(alici);
            mail.Subject = konu;
            mail.Body = icerik;
            //malinin html biçiminde olup olmadığı belirliyor
            mail.IsBodyHtml = true;
            //mail protokol istemcisi ve host ve port bilgileri
            SmtpClient smpt = new SmtpClient("smtp.gmail.com",587);
            //göndericinin kimlik bilgileri
            smpt.Credentials = new NetworkCredential(form_mail, sifre);
            //maili şifrelemeye yarıyor
            smpt.EnableSsl = true;
            smpt.Send(mail);
            MessageBox.Show("Mail Gönderildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
