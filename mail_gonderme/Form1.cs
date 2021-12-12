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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage();
            SmtpClient client = new SmtpClient();
            client.Credentials = new NetworkCredential("btsmtpdemo@gmail.com", "Smtp785*?");
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            mail.To.Add(textBox1.Text);
            mail.From = new MailAddress("btsmtpdemo@gmail.com");
            mail.Subject = textBox2.Text;
            mail.Body = textBox3.Text;
            client.Send(mail);
        }
    }
}
