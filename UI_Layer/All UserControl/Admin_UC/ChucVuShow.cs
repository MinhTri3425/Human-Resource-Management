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
    public partial class ChucVuShow : UserControl
    {
        int UserID;
        private String functionName;
        public ChucVuShow(int UserID, string functionName)
        {
            InitializeComponent();
            this.UserID = UserID;
            this.functionName = functionName;
            LoadData();
        }
        public void LoadData()
        {
            ChucVu cv = new ChucVu(this.UserID, this.functionName);
            DataSet ds = cv.LayChucVu();

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int ID_ChucVu = Convert.ToInt32(row["ChucVuID"]);
                    string TenChucVu = row["TenChucVu"].ToString();
                    chucvu cvItem = new chucvu(UserID ,ID_ChucVu, TenChucVu);
                    flowLayoutPanel1.Controls.Add(cvItem);
                }
            }
            PhongBan pb = new PhongBan(this.UserID, this.functionName);
            DataSet ds1 = pb.LayPhongBan();
            if (ds1 != null && ds1.Tables.Count > 0 && ds1.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds1.Tables[0].Rows)
                {
                    int ID_PhongBan = Convert.ToInt32(row["PhongBanID"]);
                    string TenPhongBan = row["TenPhongBan"].ToString();
                    phongban pbItem = new phongban(ID_PhongBan, TenPhongBan);
                    flowLayoutPanel2.Controls.Add(pbItem);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var form = new FormThemChucVu())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    string err = "";
                    var chucVu = new ChucVu(UserID, "Admin");

                    if (chucVu.ThemChucVu(form.TenChucVuMoi, ref err)) // Không có ID
                    {
                        MessageBox.Show("Thêm chức vụ thành công!");
                        // Ghi nhật ký
                        NhatKy nhatKy = new NhatKy(UserID, functionName);
                        string hanhDong = $"Thêm chức vụ: {form.TenChucVuMoi}";
                        nhatKy.ThemNhatKy(UserID, hanhDong, DateTime.Now, ref err);

                        flowLayoutPanel1.Controls.Clear();
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi thêm chức vụ: " + err);
                    }
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            using (var form = new FormThemPB())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    string err = "";
                    var pb = new PhongBan(UserID, "Admin");

                    if (pb.ThemPhongBan(form.TenpbMoi, ref err)) // Không có ID
                    {
                        MessageBox.Show("Thêm phòng ban thành công!");
                        // Ghi nhật ký
                        NhatKy nhatKy = new NhatKy(UserID, functionName);
                        string hanhDong = $"Thêm phòng ban: {form.TenpbMoi}";
                        nhatKy.ThemNhatKy(UserID, hanhDong, DateTime.Now, ref err);

                        flowLayoutPanel1.Controls.Clear();
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi thêm phòng ban: " + err);
                    }
                }
            }
        }
    }
}
