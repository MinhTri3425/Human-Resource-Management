using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS.UI_Layer.All_UserControl.Employee_UC
{
    public partial class E_UC_ItemNghiPhep : UserControl
    {
        int idNghiPhep;
        string hoTenNhanVien;
        string ngayBatDau;
        string ngayKetThuc;
        string loaiNghiPhep;
        string trangThai;

        public E_UC_ItemNghiPhep(int idNghiPhep, string hoTenNhanVien, string ngayBatDau, string ngayKetThuc, string loaiNghiPhep, string trangThai)
        {
            InitializeComponent();
            this.idNghiPhep = idNghiPhep;
            this.hoTenNhanVien = hoTenNhanVien;
            this.ngayBatDau = ngayBatDau;
            this.ngayKetThuc = ngayKetThuc;
            this.loaiNghiPhep = loaiNghiPhep;
            this.trangThai = trangThai;
            
        }

        private void E_UC_ItemNghiPhep_Load(object sender, EventArgs e)
        {
            lbIDNghiPhep.Text = idNghiPhep.ToString();
            lbTenNhanVien.Text = hoTenNhanVien;
            lbNgayBatDau.Text = ngayBatDau;
            lbNgayKetThuc.Text = ngayKetThuc;
            lbLoai.Text = loaiNghiPhep;
            lbTrangThai.Text = trangThai;
        }
    }
}
