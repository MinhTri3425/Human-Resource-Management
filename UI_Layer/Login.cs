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
    }
}
