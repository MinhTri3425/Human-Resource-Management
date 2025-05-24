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

namespace QLNS.UI_Layer.All_UserControl.Accountant_UC
{
    public partial class A_UC_SalaryItem : UserControl
    {
        int UserID;
        private int luongid;
        private int nhanvienid;
        private int thang;
        private int nam;
        private decimal luongcoban;
        private decimal phucap;
        private decimal tongluong;
        private string trangthai;
        public A_UC_SalaryItem(int UserID, int luongid, int nhanvienid, int thang, int nam, decimal luongcoban, decimal phucap, decimal tongluong, string trangthai)
        {
            InitializeComponent();
            this.UserID = UserID;
            this.luongid = luongid;
            this.nhanvienid = nhanvienid;
            this.thang = thang;
            this.nam = nam;
            this.luongcoban = luongcoban;
            this.phucap = phucap;
            this.tongluong = tongluong;
            this.trangthai = trangthai;
        }

        private void A_UC_SalaryItem_Load(object sender, EventArgs e)
        {
            lbluongid.Text = luongid.ToString();
            lbnhanvienid.Text = nhanvienid.ToString();
            lbthang.Text = thang.ToString();
            lbnam.Text = nam.ToString();
            lbluongcoban.Text = luongcoban.ToString("N0");
            lbphucap.Text = phucap.ToString("N0");
            lbtongluong.Text = this.tinhTongLuong().ToString("N0");
            lbtrangthai.Text = trangthai;
            if (trangthai == "Đã duyệt")
                lbtrangthai.ForeColor = Color.Green;
            else if (trangthai == "Chưa duyệt")
                lbtrangthai.ForeColor = Color.Yellow;
            else if (trangthai == "Từ chối")
                lbtrangthai.ForeColor = Color.Red;
        }
        public decimal tinhTongLuong()
        {
            ChamCong chamCong = new ChamCong(this.UserID, "Admin");
            decimal tonggiolam = chamCong.TinhTongGioLamTrongThang(nhanvienid, thang, nam);

            NghiPhep nghiPhep = new NghiPhep(this.UserID, "Admin");
            decimal tongnghiphep = nghiPhep.LayTongSoNgayNghiPhep(nhanvienid);
            string loaiNghiPhep = nghiPhep.LayLoaiNghiPhep(nhanvienid);

            TangCa tangCa = new TangCa(this.UserID, "Admin");
            decimal tonggiotangca = tangCa.LayTongGioTangCa(nhanvienid);
            string hinhThucTangCa = tangCa.LayHinhThucTangCa(nhanvienid);

            decimal tienChamCong = tonggiolam * luongcoban / 240; // Giả sử 1 tháng có 240 giờ làm việc
            decimal tienNghiPhep = 0;
            if (loaiNghiPhep == "Nghỉ có lương")
            {
                tienNghiPhep = 0;
            }
            else if (loaiNghiPhep == "Nghỉ không lương")
            {
                tienNghiPhep = tongnghiphep * luongcoban / 26;
            }
            decimal tienTangCa = tonggiotangca * luongcoban / 240 * 1.5m;
            if (hinhThucTangCa == "Tăng ca thường")
            {
                tienTangCa = tonggiotangca * luongcoban / 240 * 1.5m; // Tăng ca thường
            }
            else if (hinhThucTangCa == "Tăng ca lễ")
            {
                tienTangCa = tonggiotangca * luongcoban / 240 * 2; // Tăng ca lễ
            }
            return tienChamCong + tienTangCa + phucap - tienNghiPhep;
        }
        private void lbluongcoban_Click(object sender, EventArgs e)
        {

        }
    }
}
