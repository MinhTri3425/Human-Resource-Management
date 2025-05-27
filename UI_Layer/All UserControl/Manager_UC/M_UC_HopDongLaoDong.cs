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
    public partial class M_UC_HopDongLaoDong : UserControl
    {

        private int UserID;
        private String functionName = "M.HopDong";

        DataSet ds;

        int nhanVienID;
        String hoTenQuanLi;
        int chucVuIDQuanLi;
        int PhongBanID;

        public M_UC_HopDongLaoDong(int UserID)
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
            HopDongLaoDong hopDongLaoDong = new HopDongLaoDong(this.UserID, this.functionName);
            ds = hopDongLaoDong.LayHopDongTheoPhongBan(this.PhongBanID);
        }

        private void UC_HopDongLaoDong_Load(object sender, EventArgs e)
        {
            lbTenQuanli.Text = hoTenQuanLi;
            ChucVu chucVu = new ChucVu(this.UserID, this.functionName);
            lbChucVuquanli.Text = chucVu.LayTenChucVuTheoID(this.chucVuIDQuanLi);
            PhongBan phongBan = new PhongBan(this.UserID, this.functionName);
            String tenPhongBan = phongBan.LayTenPhongBanTheoID(this.PhongBanID);
            lbPhongBanQuanLi.Text = tenPhongBan;

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                int id = Convert.ToInt32(row["HopDongID"]);
                int IDNhanVien = Convert.ToInt32(row["NhanVienID"]);
                NhanVien nhanVien = new NhanVien(this.UserID, this.functionName);
                DataSet thongtinNhanVien = nhanVien.LayNhanVienTheoID(IDNhanVien);
                string hoten = "";
                if (thongtinNhanVien != null && thongtinNhanVien.Tables.Count > 0 && thongtinNhanVien.Tables[0].Rows.Count > 0)
                {
                    hoten = thongtinNhanVien.Tables[0].Rows[0]["HoTen"].ToString();
                }
                string loaiHopDong = row["LoaiHopDong"].ToString();
                string ngayChamCong = Convert.ToDateTime(row["NgayKy"]).ToString("dd/MM/yyyy");
                string ngayHetHopDong = "";
                if (row["NgayHetHan"] != DBNull.Value)
                {
                    ngayHetHopDong = Convert.ToDateTime(row["NgayHetHan"]).ToString("dd/MM/yyyy");
                }
                else
                {
                    ngayHetHopDong = "--"; 
                }

                M_UC_ItemHopDong hopDong = new M_UC_ItemHopDong(id, hoten, loaiHopDong, ngayChamCong, ngayHetHopDong);
                hopDong.Dock = DockStyle.Top;
                this.panelHopDongNhanVien.Controls.Add(hopDong);
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
