using Guna.UI2.WinForms;
using QLNS.BL_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS.UI_Layer
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
            guna2ShadowForm1.SetShadowForm(this);
            
        }

        private void ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPass.Checked)
            {
                // Hiện mật khẩu (bỏ ký tự che)
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                // Ẩn mật khẩu bằng dấu *
                txtPassword.PasswordChar = '*';
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void ForgotPass_Click(object sender, EventArgs e)
        {
            string message =
                 "Step 1. Contact the system administrator to request password recovery.\n\n" +
                 "Step 2. Provide your username or email to verify your identity.\n\n" +
                 "Step 3. Receive a new password or a password reset link from the administrator.\n\n" +
                 "Step 4. Log in and change your password immediately to ensure security.\n\n" +
                 "Note:\n" +
                 "Do not share your password with anyone and remember to change your password regularly to protect your account.";
            MessageDialog1.Show(message);
        }

        private void ForgotPass_MouseLeave(object sender, EventArgs e)
        {
            ForgotPass.Font = new Font(ForgotPass.Font, ForgotPass.Font.Style & ~FontStyle.Underline);
        }
        private void ForgotPass_MouseEnter(object sender, EventArgs e)
        {
            ForgotPass.Font = new Font(ForgotPass.Font, ForgotPass.Font.Style | FontStyle.Underline);
        }

        private void LoginApp_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            string err = "";
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageDialog1.Show("Vui lòng nhập tên đăng nhập và mật khẩu.");
                return;
            }
            int userID = 0;
            int roleID = 0;
            if (user.DangNhap(username, password, ref userID, ref roleID, ref err))
            {
                // Lưu thông tin người dùng vào session hoặc biến toàn cục
                // Chuyển đến giao diện chính của ứng dụng
                if (roleID == 1)
                {
                    this.Hide();
                    All all = new All(userID);
                    all.Show();
                }
                if (roleID == 2)
                {
                    this.Hide();
                    Hr hr = new Hr(userID);
                    hr.Show();
                }
                if (roleID == 3)
                {
                    this.Hide();
                    AccoutantUI acc = new AccoutantUI(userID);
                    acc.Show();
                }
                if (roleID == 4)
                {
                    this.Hide();
                    ManagerUI manager = new ManagerUI(userID);
                    manager.Show();
                }
            }
            else
            {
                MessageDialog1.Show(err);
            }
        }
    }
}
