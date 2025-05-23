using Guna.UI2.WinForms;
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
    public partial class UC_Contract : UserControl
    {

        private int UserID;
        private String functionName = "Admin";

        int HopDongID;
        int NhanVienID;
        String LoaiHopDong;
        String NgayKy;
        String NgayHetHan;
        String hoTenNhanVien;
        int chucVuID;

        public UC_Contract(int UserID)
        {
            InitializeComponent();
            this.UserID = UserID;
            LoadData();
        }

        public void LoadData()
        {
            HopDongLaoDong hopDongLaoDong = new HopDongLaoDong(this.UserID, this.functionName);
            string err = "";

            NhanVien nhanVien = new NhanVien(this.UserID, this.functionName);
            this.NhanVienID = nhanVien.LayNhanVienIDtheoUserID(ref err);
            DataSet thongtinNhanVien = nhanVien.LayNhanVienTheoID(this.NhanVienID);
            if (thongtinNhanVien != null && thongtinNhanVien.Tables.Count > 0 && thongtinNhanVien.Tables[0].Rows.Count > 0)
            {
                this.hoTenNhanVien = thongtinNhanVien.Tables[0].Rows[0]["HoTen"].ToString();
                this.chucVuID = Convert.ToInt32(thongtinNhanVien.Tables[0].Rows[0]["ChucVuID"]);

            }

            DataSet ds = hopDongLaoDong.TimKiemHopDongTheoNhanVien(this.NhanVienID);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                this.HopDongID = Convert.ToInt32(ds.Tables[0].Rows[0]["HopDongID"]);
                this.LoaiHopDong = ds.Tables[0].Rows[0]["LoaiHopDong"].ToString();
                this.NgayKy = ds.Tables[0].Rows[0]["NgayKy"].ToString();
                this.NgayHetHan = ds.Tables[0].Rows[0]["NgayHetHan"].ToString();
            }
            else
            {
                String message = "Không tìm thấy hợp đồng lao động cho nhân viên này.";
                MessageDialog.Show(message);

            }
        }

        private void UC_Contract_Load(object sender, EventArgs e)
        {
            this.lbEmployeeName.Text = this.hoTenNhanVien;
            this.lbEployeeID.Text = this.NhanVienID.ToString();
            ChucVu chucVu = new ChucVu(this.UserID, this.functionName);
            this.lbChucVu.Text = chucVu.LayTenChucVuTheoID(this.chucVuID);
            this.lbFullName.Text = this.hoTenNhanVien;
            this.lbLoaiHopDong.Text = this.LoaiHopDong;
            this.lbNgayKy.Text = this.NgayKy;
            this.lbNgayHetHan.Text = this.NgayHetHan;
        }
    }
}
