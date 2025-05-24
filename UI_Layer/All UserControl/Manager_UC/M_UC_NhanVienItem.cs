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
    public partial class M_UC_NhanVienItem : UserControl
    {
        int nhanVienID;
        string hoTenNhanVien;
        string ngaySinh;
        string CMND;
        string maSoThue;
        string tenPhongBan;
        string tenChucVu;
        string trangThai;


        public M_UC_NhanVienItem(int nhanVienID, string hoTenNhanVien, string ngaySinh, string cMND, string maSoThue, string tenPhongBan, string tenChucVu, string trangThai)
        {
            InitializeComponent();
            this.nhanVienID = nhanVienID;
            this.hoTenNhanVien = hoTenNhanVien;
            this.ngaySinh = ngaySinh;
            CMND = cMND;
            this.maSoThue = maSoThue;
            this.tenPhongBan = tenPhongBan;
            this.tenChucVu = tenChucVu;
            this.trangThai = trangThai;
        }

        private void UC_NhanVienItem_Load(object sender, EventArgs e)
        {
            lbIDNhanVien.Text = nhanVienID.ToString();
            lbTenNhanVien.Text = hoTenNhanVien;
            lbNgaySinh.Text = ngaySinh;
            lbCMND.Text = CMND;
            lbMaSoThue.Text = maSoThue;
            lbPhongBan.Text = tenPhongBan;
            lbChucVu.Text = tenChucVu;
            lbTrangThai.Text = trangThai;
        }
    }
}
