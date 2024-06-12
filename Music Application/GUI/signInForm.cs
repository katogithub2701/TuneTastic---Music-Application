using Music_Application.BLL;
using Music_Application.GUI;
using System;
using System.Windows.Forms;

namespace Music_Application
{
    public partial class signInForm : Form
    {
        public signInForm()
        {
            InitializeComponent();
        }

        private void closeBt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signUpBt_Click(object sender, EventArgs e)
        {
            signUpForm form2 = new signUpForm();
            form2.FormClosed += (s, args) => Show();
            Hide();
            form2.Show();
        }
        private void logInBt_Click(object sender, EventArgs e)
        {
            string account = accountTextBox.Text;
            string password = passwordTextBox.Text;
            if (account == "" || password == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                bool check = BLL_Users.Instance.checkLogIn(accountTextBox.Text, passwordTextBox.Text);
                if (check)
                {
                    Hide();
                    MainForm.Instance.Show();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu");
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ForgetPasswordForm forgetPasswordForm = new ForgetPasswordForm();
            forgetPasswordForm.FormClosed += (s, args) => Show();
            Hide();
            forgetPasswordForm.Show();
        }
    }
}
