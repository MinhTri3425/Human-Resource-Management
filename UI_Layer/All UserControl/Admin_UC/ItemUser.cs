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
    public partial class ItemUser : UserControl
    {
        int UserID;
        string functionName = "Admin";
        int userid;
        string username;
        string roleid;
        string nhanvienid;
        Action reloadCallback;
        public ItemUser(int UserID, int userid, string username, string roleid, string nhanvienid, Action reloadCallback)
        {
            InitializeComponent();
            this.UserID = UserID;
            this.userid = userid;
            this.username = username;
            this.roleid = roleid;
            this.nhanvienid = nhanvienid;
            this.reloadCallback = reloadCallback;
            RegisterHoverEvents(this); // Gọi hàm để đăng ký sự kiện hover cho tất cả control trong UserControl
        }

        private void ItemUser_Load(object sender, EventArgs e)
        {
            this.userIDlb.Text = userid.ToString();
            this.usernamelb.Text = username;
            this.roleidil.Text = roleid.ToString();
            this.nhanvienidlb.Text = nhanvienid.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Users users = new Users(this.UserID, this.functionName);
            string err = "";
            if (users.XoaUsers(this.userid, ref err))
            {
                MessageBox.Show("Xóa User thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NhatKy nhatKy = new NhatKy(UserID, functionName);
                string hanhDong = $"Đã xóa User ID: {userid}";
                DateTime recentTime = DateTime.Now;
                nhatKy.ThemNhatKy(UserID, hanhDong, recentTime, ref err);
            }
            else
            {
                MessageBox.Show("Xóa User thất bại: " + err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SuaUser suaUser = new SuaUser(UserID, userid, username, () => { reloadCallback?.Invoke(); });
            suaUser.ShowDialog();
        }
        private void RegisterHoverEvents(Control parent)
        {
            parent.MouseEnter += Enter1;
            parent.MouseLeave += Leave1;

            foreach (Control child in parent.Controls)
            {
                RegisterHoverEvents(child); // gán cho tất cả control con
            }
        }
        private void Enter1(object sender, EventArgs e)
        {
            btnXoa.Visible = true;
            btnSua.Visible = true;
        }
        
        private void Leave1(object sender, EventArgs e)
        {
            if (!this.ClientRectangle.Contains(this.PointToClient(Cursor.Position)))
            {
                btnXoa.Visible = false;
                btnSua.Visible = false;
            }
        }
    }
}
