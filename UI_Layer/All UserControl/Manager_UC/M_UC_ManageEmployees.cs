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
    public partial class M_UC_ManageEmployees : UserControl
    {
        private int UserID;
        private String functionName = "Admin";

        DataSet ds;

        int nhanVienID;
        String hoTenQuanLi;
        int chucVuIDQuanLi;
        int PhongBanID;

        public M_UC_ManageEmployees(int UserID)
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

            ds = nhanVien.LayNhanVienTheoPhongBanID(this.PhongBanID);
        }

        private void UC_ManageEmployees_Load(object sender, EventArgs e)
        {
            lbTenQuanli.Text = hoTenQuanLi;
            ChucVu chucVu = new ChucVu(this.UserID, this.functionName);
            lbChucVuquanli.Text = chucVu.LayTenChucVuTheoID(this.chucVuIDQuanLi);
            PhongBan phongBan = new PhongBan(this.UserID, this.functionName);
            String tenPhongBan = phongBan.LayTenPhongBanTheoID(this.PhongBanID);
            lbPhongBanQuanLi.Text = tenPhongBan;
            
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                int id = Convert.ToInt32(row["NhanVienID"]);
                String hoTen = row["HoTen"].ToString();
                String ngaySinh = Convert.ToDateTime(row["NgaySinh"]).ToString("dd/MM/yyyy");
                String cmnd = row["CMND"].ToString();
                String maSoThue = row["MaSoThue"].ToString();
                int ChucVuID = Convert.ToInt32(row["ChucVuID"]);
                ChucVu chucVuNhanVien = new ChucVu(this.UserID, this.functionName);
                String tenChucVu = chucVuNhanVien.LayTenChucVuTheoID(ChucVuID);
                String trangThai = row["TrangThai"].ToString();

                M_UC_NhanVienItem nhanVien = new M_UC_NhanVienItem(id, hoTen, ngaySinh, cmnd, maSoThue, tenPhongBan ,tenChucVu, trangThai);
                nhanVien.Dock = DockStyle.Top;
                this.panelQuanLiNhanVien.Controls.Add(nhanVien);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panelQuanLiNhanVien_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
