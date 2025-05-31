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
    public partial class Ad_UC_QuanLiCongTrinh : UserControl
    {
        private int UserID;
        private String functionName;

        private DataSet ds;

        public Ad_UC_QuanLiCongTrinh(int userID, string functionName)
        {
            InitializeComponent();
            this.UserID = userID;
            this.functionName = functionName;
            LoadData();
        }

        public void LoadData()
        {
            CongTrinh congTrinh = new CongTrinh(this.UserID, this.functionName);
            ds = congTrinh.LayCongTrinh();
        }

        private void Ad_UC_QuanLiCongTrinh_Load(object sender, EventArgs e)
        {
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                int id = Convert.ToInt32(row["CongTrinhID"]);
                string tenCongTrinh = row["TenCongTrinh"].ToString();
                string diaDiem = row["DiaDiem"].ToString();
                string ngayBatDau = Convert.ToDateTime(row["NgayBatDau"]).ToString("dd/MM/yyyy");
                string ngayKetThuc = Convert.ToDateTime(row["NgayKetThuc"]).ToString("dd/MM/yyyy");

                M_UC_ManageProjectItem congTrinh = new M_UC_ManageProjectItem(id, tenCongTrinh, diaDiem, ngayBatDau, ngayKetThuc, UserID, functionName, () =>
                {
                    this.panelQuanLiCongTrinh.Controls.Clear();
                    LoadData();
                    Ad_UC_QuanLiCongTrinh_Load(null, null);
                });
                congTrinh.Dock = DockStyle.Top;
                this.panelQuanLiCongTrinh.Controls.Add(congTrinh);
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string keyword = guna2TextBox1.Text.Trim().ToLower();
            panelQuanLiCongTrinh.Controls.Clear();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                string tenCongTrinh = row["TenCongTrinh"].ToString();
                string diaDiem = row["DiaDiem"].ToString();

                if (tenCongTrinh.ToLower().Contains(keyword) || diaDiem.ToLower().Contains(keyword))
                {
                    int id = Convert.ToInt32(row["CongTrinhID"]);
                    string ngayBatDau = Convert.ToDateTime(row["NgayBatDau"]).ToString("dd/MM/yyyy");
                    string ngayKetThuc = Convert.ToDateTime(row["NgayKetThuc"]).ToString("dd/MM/yyyy");

                    M_UC_ManageProjectItem congTrinh = new M_UC_ManageProjectItem(id, tenCongTrinh, diaDiem, ngayBatDau, ngayKetThuc, UserID, functionName, () =>
                    {
                        this.panelQuanLiCongTrinh.Controls.Clear();
                        LoadData();
                        Ad_UC_QuanLiCongTrinh_Load(null, null);
                    });
                    congTrinh.Dock = DockStyle.Top;
                    this.panelQuanLiCongTrinh.Controls.Add(congTrinh);
                }
            }
        }

        private void btnThemCongTrinh_Click(object sender, EventArgs e)
        {
            Ad_FormThemCongTrinh form = new Ad_FormThemCongTrinh(UserID, functionName, () =>
            {
                this.panelQuanLiCongTrinh.Controls.Clear();
                LoadData();
                Ad_UC_QuanLiCongTrinh_Load(null, null);
            });

            form.ShowDialog();
        }
    }
}
