using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace mail_gonderme
{
    public partial class frmMailGonder : Form
    {
        public frmMailGonder()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TextBox'lara form yüklenirken örnek olarak bir kaç değer gir
            txtAlici.Text = "erhan.rgn.54@gmail.com";
            txtKonu.Text = "Demo Konu";
            rtxtMesaj.Text = "Bu bir <b>deneme</b> mesajıdır...";
            rbtnHtmlOk.Checked = true;
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            // Herhangi bir
            try
            {
                string _hataMesaji = "Lütfen gerekli alanları doldurunuz!"; // errorProvider hata mesajı
                string email = "btsmtpdemo@gmail.com";  // Kullanılacak SMTP gmail hesabının mail adresi
                string pass = "Smtp785*?";              // Kullanılacak SMTP gmail hesabının mail adresi'nin şifresi
                string title = cmbGonderici.Text;       // Gönderen kişi / kurum adı
                bool rbtnOkNo = false;                  // Mesaj içerisinde HTML etiketi kullanılacak mı

                if (rbtnHtmlOk.Checked) rbtnOkNo = true;        // HTML kullanılacak
                else if (rbtnHtmlNo.Checked) rbtnOkNo = false;  // HTML kullanılmayacak

                // Eğer tüm veri girişi yapılacak alanlardan herhangi birinin boşsa
                if (cmbGonderici.SelectedIndex == -1 || txtAlici.Text == "" || txtKonu.Text == "" || rtxtMesaj.Text == "")
                {
                    // cmbGonderici ComboBox değeri boşsa hata ver
                    if (cmbGonderici.SelectedIndex == -1)
                        hataMesaji.SetError(cmbGonderici, _hataMesaji);
                    else
                        hataMesaji.SetError(cmbGonderici, "");
                    // txtAlici TextBox değeri boşsa hata ver
                    if (txtAlici.Text == "")
                        hataMesaji.SetError(txtAlici, _hataMesaji);
                    else
                        hataMesaji.SetError(txtAlici, "");
                    // txtKonu TextBox değeri boşsa hata ver
                    if (txtKonu.Text == "")
                        hataMesaji.SetError(txtKonu, _hataMesaji);
                    else
                        hataMesaji.SetError(txtKonu, "");
                    // rtxtMesaj richTextBox değeri boşsa hata ver
                    if (rtxtMesaj.Text == "")
                        hataMesaji.SetError(rtxtMesaj, _hataMesaji);
                    else
                        hataMesaji.SetError(rtxtMesaj, "");
                }
                // Eğer boş alan yoksa
                else
                {
                    // İstemci nesnesi oluştur
                    SmtpClient client = new SmtpClient
                    {
                        Credentials = new NetworkCredential(email, pass), // Kullanılacak SMTP mail adresi ve şifresi
                        Port = 587,                 // TR için kullanılacak istemci portu
                        Host = "smtp.gmail.com",    // Kullanılacak SMTP hizmet domain/ip adresi
                        EnableSsl = true,           // Güvenlik protokollerinin aktif olup olmama durumu
                    };

                    // Mail gönderim için mail nesnesi oluştur
                    MailMessage mail = new MailMessage
                    {
                        From = new MailAddress(email, title), // Gönderenin mail adresi ve gönderici adı
                        Subject = txtKonu.Text,     // Mail konusu
                        Body = rtxtMesaj.Text,      // Mail mesajı
                        IsBodyHtml = rbtnOkNo,      // HTML etiketlerinin kullanılıp kullaanılmayacağını belirleme
                    };

                    // Gönderilecek dosyayı ekle
                    mail.Attachments.Add(new Attachment(@tbxDosyaYolu.Text)); 

                    mail.To.Add(txtAlici.Text);     // Gönderilecek mail adresi
                    client.Send(mail);              // Tüm işlemler onaylandıktan mail gönderim işlemini başlat

                    // Mail gönderme işlemi bittikten sonra bildirim mesajı göster
                    MessageBox.Show("Email gönderme işlemi başarılı bir şekilde tamamlandı!", "BAŞARILI !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exp)
            {
                // Mail gönderme işlemi sırasında oluşan herhangi bir hata olursa uyarı ver
                MessageBox.Show(exp.ToString(), "HATA !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show(exp.ToString());
            }
        }

        private void linkWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // linkLabel'i istene websiteye yönlendir
            System.Diagnostics.Process.Start("https://erhanurgun.com.tr/");
        }

        private void btnDosyaSec_Click(object sender, EventArgs e)
        {
           
            openYolSec.Filter = "Tüm dosyalar (*.*)|*.*";    // Tüm dosya formatlarını şeçebilir olarak ayarlandı
            if (openYolSec.ShowDialog() == DialogResult.OK)
                tbxDosyaYolu.Text = openYolSec.FileName;     // Gönderilecek dosya yolunu seç
        }
    }
}
