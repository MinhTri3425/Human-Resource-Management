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

namespace QLNS.UI_Layer.All_UserControl.Admin_UC
{
    public partial class SuaUser : Form
    {
        private int UserID;
        private int userid;
        private string functionName = "Admin";

        private string username;
        private string password;
        private Action reloadCallback;
        public SuaUser(int UserID, int userid, string username, Action reloadCallback)
        {
            InitializeComponent();
            this.UserID = UserID;
            this.userid = userid;
            this.username = username;
            this.usernametxt.Text = this.username;
            this.passtxt.Enabled = false; // Không cho phép chỉnh sửa mật khẩu ban đầu
            this.reloadCallback = reloadCallback;
        }

        private void changecheck_CheckedChanged(object sender, EventArgs e)
        {
            this.passtxt.Enabled = changecheck.Checked; // Cho phép chỉnh sửa mật khẩu nếu checkbox được chọn
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Users users = new Users(this.UserID, this.functionName);
            string err = "";
            if (changecheck.Checked)
            {
                password = passtxt.Text;
                string hashPass = users.HashPassword(password); // Mã hóa mật khẩu nếu checkbox được chọn
                if (users.CapNhatUsers(UserID, userid, usernametxt.Text, hashPass, ref err))
                {
                    MessageBox.Show("Cập nhật User thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NhatKy nhatKy = new NhatKy(UserID, functionName);
                    string hanhDong = $"Đã cập nhật User ID: {userid}";
                    DateTime recentTime = DateTime.Now;
                    nhatKy.ThemNhatKy(UserID, hanhDong, recentTime, ref err);
                    reloadCallback?.Invoke(); // Gọi lại hàm reload nếu có
                    this.Close(); // Đóng form sau khi cập nhật thành công
                }
                else
                {
                    MessageBox.Show("Cập nhật User thất bại: " + err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                password = null; // Không thay đổi mật khẩu nếu checkbox không được chọn
                if (users.CapNhatUsers(UserID, userid, usernametxt.Text, password, ref err))
                {
                    MessageBox.Show("Cập nhật User thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NhatKy nhatKy = new NhatKy(UserID, functionName);
                    string hanhDong = $"Đã cập nhật User ID: {userid}";
                    DateTime recentTime = DateTime.Now;
                    nhatKy.ThemNhatKy(UserID, hanhDong, recentTime, ref err);
                    reloadCallback?.Invoke(); // Gọi lại hàm reload nếu có
                    this.Close(); // Đóng form sau khi cập nhật thành công
                }
                else
                {
                    MessageBox.Show("Cập nhật User thất bại: " + err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng form nếu người dùng không muốn cập nhật
        }
    }
}
