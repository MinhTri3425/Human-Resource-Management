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
    }
}
