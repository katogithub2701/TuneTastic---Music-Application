using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using Music_Application.BLL;

namespace Music_Application.GUI
{
    public partial class ForgetPasswordForm : Form
    {
        public ForgetPasswordForm()
        {
            InitializeComponent();
        }

        private void confirmBt_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;
            string password = BLL_Users.Instance.GetPassword(email);
            string loginname = BLL_Users.Instance.GetAccount(email);
            if (email == "")
            {
                MessageBox.Show("Vui lòng nhập email!");
            }
            if (password == null || loginname == null)
            {
                MessageBox.Show("Email chưa được đăng ký!");
            }    
            else
            {
                try
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                    mail.From = new MailAddress("tanvlogxh2@gmail.com");
                    mail.To.Add(email);
                    mail.Subject = "Khôi phục mật khẩu";
                    mail.Body = "Tài khoản của bạn là: " + loginname + " | Mật khẩu của bạn là: " + password;

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new NetworkCredential("tanvlogxh2@gmail.com", "zbmc wlxi ugjg klta");
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);
                    MessageBox.Show("Email đã được gửi thành công!");
                }
                catch (Exception ex)
                {
                    
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
