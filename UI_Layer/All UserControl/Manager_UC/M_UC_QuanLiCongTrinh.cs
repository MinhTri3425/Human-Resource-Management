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

namespace QLNS.UI_Layer.All_UserControl
{
    public partial class H_UC_QuanLiCongTrinh : UserControl
    {
        private int UserID;
        private String functionName = "Admin";

        DataSet ds;

        int nhanVienID;
        string hoTenQuanLi;
        int chucVuIDQuanLi;
        int PhongBanID;


        public H_UC_QuanLiCongTrinh(int UserID)
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

                H_UC_ManageProjectItem congTrinh = new H_UC_ManageProjectItem(id, tenCongTrinh, diaDiem, ngayBatDau, ngayKetThuc);
                congTrinh.Dock = DockStyle.Top;
                this.panelQuanLiCongTrinh.Controls.Add(congTrinh);
            }
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
