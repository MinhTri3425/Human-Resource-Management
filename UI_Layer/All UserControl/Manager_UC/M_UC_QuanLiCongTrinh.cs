using QLNS.BL_Layer;
using QLNS.UI_Layer.All_UserControl.Manager_UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS.UI_Layer.All_UserControl
{
    public partial class M_UC_QuanLiCongTrinh : UserControl
    {
        private int UserID;
        private String functionName = "M.CongTrinh(samePB)";

        DataSet ds;

        int nhanVienID;
        string hoTenQuanLi;
        int chucVuIDQuanLi;
        int PhongBanID;


        public M_UC_QuanLiCongTrinh(int UserID)
        {
            InitializeComponent();
            this.UserID = UserID;
            LoadData();

        }

        public void LoadData()
        {
            NhanVien nhanVien = new NhanVien(this.UserID, this.functionName);
            string err = "";
            nhanVienID = nhanVien.LayNhanVienIDtheoUserID(ref err);
            DataSet thongtinNhanVien = nhanVien.LayNhanVienTheoID(this.nhanVienID);
            if (thongtinNhanVien != null && thongtinNhanVien.Tables.Count > 0 && thongtinNhanVien.Tables[0].Rows.Count > 0)
            {
                this.hoTenQuanLi = thongtinNhanVien.Tables[0].Rows[0]["HoTen"].ToString();
                this.chucVuIDQuanLi = Convert.ToInt32(thongtinNhanVien.Tables[0].Rows[0]["ChucVuID"]);
                this.PhongBanID = Convert.ToInt32(thongtinNhanVien.Tables[0].Rows[0]["PhongBanID"]);
            }

            CongTrinh congTrinh = new CongTrinh(this.UserID, this.functionName);
            ds = congTrinh.LayCongTrinhTheoPhongBan(this.PhongBanID);
        }

        private void UC_QuanLiCongTrinh_Load(object sender, EventArgs e)
        {
            lbTenQuanli.Text = hoTenQuanLi;
            ChucVu chucVu = new ChucVu(this.UserID, this.functionName);
            lbChucVuquanli.Text = chucVu.LayTenChucVuTheoID(this.chucVuIDQuanLi);
            PhongBan phongBan = new PhongBan(this.UserID, this.functionName);
            String tenPhongBan = phongBan.LayTenPhongBanTheoID(this.PhongBanID);
            lbPhongBanQuanLi.Text = tenPhongBan;

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
                    UC_QuanLiCongTrinh_Load(null, null);
                });
                congTrinh.Dock = DockStyle.Top;
                this.panelQuanLiCongTrinh.Controls.Add(congTrinh);
            }
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThemCongTrinh_Click(object sender, EventArgs e)
        {
            ThemCongTrinh form = new ThemCongTrinh(UserID, functionName, PhongBanID,() =>
            {
                this.panelQuanLiCongTrinh.Controls.Clear(); 
                LoadData(); 
                UC_QuanLiCongTrinh_Load(null, null); 
            });
            form.ShowDialog();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            CongTrinh congTrinh = new CongTrinh(this.UserID, this.functionName);
            string searchText = guna2TextBox1.Text.Trim();
            DataSet dataSet = congTrinh.TimKiemCongTrinhCungPhongBan(PhongBanID, searchText);
            panelQuanLiCongTrinh.Controls.Clear();
            LoadData();
            if (dataSet != null)
            {
                if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        int id = Convert.ToInt32(row["CongTrinhID"]);
                        string tenCongTrinh = row["TenCongTrinh"].ToString();
                        string diaDiem = row["DiaDiem"].ToString();
                        string ngayBatDau = Convert.ToDateTime(row["NgayBatDau"]).ToString("dd/MM/yyyy");
                        string ngayKetThuc = Convert.ToDateTime(row["NgayKetThuc"]).ToString("dd/MM/yyyy");
                        M_UC_ManageProjectItem congTrinhItem = new M_UC_ManageProjectItem(id, tenCongTrinh, diaDiem, ngayBatDau, ngayKetThuc, UserID, functionName, () =>
                        {
                            this.panelQuanLiCongTrinh.Controls.Clear();
                            LoadData();
                            UC_QuanLiCongTrinh_Load(null, null);
                        });
                        congTrinhItem.Dock = DockStyle.Top;
                        this.panelQuanLiCongTrinh.Controls.Add(congTrinhItem);
                    }
                }
            }
        }
    }
}
