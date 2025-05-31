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
    public partial class Users_UC : UserControl
    {
        private int UserID;
        private string functionName = "Admin";

        public Users_UC(int userID)
        {
            InitializeComponent();
            UserID = userID;
            LoadData();
        }
        public void LoadData()
        {
            Users users = new Users(UserID, functionName);
            DataSet ds = users.LayUsers();
            if (ds != null)
            {
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        DataRow row = ds.Tables[0].Rows[i];
                        int userid = Convert.ToInt32(row["UserID"]);
                        string username = row["Username"].ToString();
                        string roleid = row["RoleID"].ToString();
                        string nhanvienid = row["NhanVienID"].ToString();
                        ItemUser itemUser = new ItemUser(UserID, userid, username, roleid, nhanvienid, () => {
                            this.panelQuanLiUSer.Controls.Clear(); // Xóa các điều khiển hiện tại trong panel
                            LoadData(); // Tải lại dữ liệu để cập nhật danh sách người dùng
                        });
                        itemUser.Dock = DockStyle.Top;
                        this.panelQuanLiUSer.Controls.Add(itemUser);

                    }
                }
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = guna2TextBox1.Text.Trim();
            Users users = new Users(UserID, functionName);
            DataSet ds = users.TimKiemUsers(searchText); // Assuming TimKiemUser is the method in Users.cs  

            this.panelQuanLiUSer.Controls.Clear(); // Clear current controls in the panel  

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int userid = Convert.ToInt32(row["UserID"]);
                    string username = row["Username"].ToString();
                    string roleid = row["RoleID"].ToString();
                    string nhanvienid = row["NhanVienID"].ToString();

                    ItemUser itemUser = new ItemUser(UserID, userid, username, roleid, nhanvienid, () =>
                    {
                        this.panelQuanLiUSer.Controls.Clear();
                        LoadData();
                    });
                    itemUser.Dock = DockStyle.Top;
                    this.panelQuanLiUSer.Controls.Add(itemUser);
                }
            }
        }

        private void cbbtrangthai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRoleID = cbbtrangthai.SelectedItem?.ToString(); // Get the selected RoleID from the ComboBox  

            if (!string.IsNullOrEmpty(selectedRoleID))
            {
                Users users = new Users(UserID, functionName);
                DataSet ds = users.LayUsersTheoRoleID(selectedRoleID); // Assuming LocUsersTheoRoleID is the method in Users.cs  

                this.panelQuanLiUSer.Controls.Clear(); // Clear current controls in the panel  

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        int userid = Convert.ToInt32(row["UserID"]);
                        string username = row["Username"].ToString();
                        string roleid = row["RoleID"].ToString();
                        string nhanvienid = row["NhanVienID"].ToString();

                        ItemUser itemUser = new ItemUser(UserID, userid, username, roleid, nhanvienid, () =>
                        {
                            this.panelQuanLiUSer.Controls.Clear();
                            LoadData();
                        });
                        itemUser.Dock = DockStyle.Top;
                        this.panelQuanLiUSer.Controls.Add(itemUser);
                    }
                }
            }
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            ThemUser form = new ThemUser(UserID, functionName, () =>
            {
                this.panelQuanLiUSer.Controls.Clear(); // Clear current controls in the panel
                LoadData(); // Reload data to update the user list
            });
            form.ShowDialog();
        }
    }
}
