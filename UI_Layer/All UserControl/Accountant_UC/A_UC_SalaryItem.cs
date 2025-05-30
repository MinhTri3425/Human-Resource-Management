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
        string funcionName;
        private int luongid;
        private int nhanvienid;
        private int thang;
        private int nam;
        private decimal luongcoban;
        private decimal phucap;
        private decimal tongluong;
        private string trangthai;
        private Action reloadCallback;
        public A_UC_SalaryItem(int UserID, string functionName, int luongid, int nhanvienid, int thang, int nam, decimal luongcoban, decimal phucap, decimal tongluong, string trangthai, Action reloadCallback)
        {
            InitializeComponent();
            this.UserID = UserID;
            this.funcionName = functionName;
            this.luongid = luongid;
            this.nhanvienid = nhanvienid;
            this.thang = thang;
            this.nam = nam;
            this.luongcoban = luongcoban;
            this.phucap = phucap;
            this.tongluong = tongluong;
            this.trangthai = trangthai;
            this.guna2PictureBox1.Visible = false;
            this.guna2PictureBox2.Visible = false;
            this.reloadCallback = reloadCallback;
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
            ChamCong chamCong = new ChamCong(this.UserID, "A.ChamCong");
            decimal tonggiolam = chamCong.TinhTongGioLamTrongThang(nhanvienid, thang, nam);

            NghiPhep nghiPhep = new NghiPhep(this.UserID, "A.NghiPhep");
            decimal tongnghiphep = nghiPhep.LayTongSoNgayNghiPhep(nhanvienid);
            string loaiNghiPhep = nghiPhep.LayLoaiNghiPhep(nhanvienid);
            string trangthainghiphep = nghiPhep.LayTrangThaiNghiPhep(nhanvienid);

            TangCa tangCa = new TangCa(this.UserID, "A.TangCa");
            decimal tonggiotangca = tangCa.LayTongGioTangCa(nhanvienid);
            string hinhThucTangCa = tangCa.LayHinhThucTangCa(nhanvienid);
            string trangThaiTangCa = tangCa.LayTrangThaiTangCa(nhanvienid);

            decimal tienChamCong = tonggiolam * luongcoban / 240; // Giả sử 1 tháng có 240 giờ làm việc
            decimal tienNghiPhep = 0;
            decimal tienTangCa = 0;
            if (trangthainghiphep != null && trangThaiTangCa != null && trangthainghiphep == "Đã duyệt" && trangThaiTangCa == "Đã duyệt")
            {
                if (loaiNghiPhep == "Nghỉ có lương")
                {
                    tienNghiPhep = 0;
                }
                else if (loaiNghiPhep == "Nghỉ không lương")
                {
                    tienNghiPhep = tongnghiphep * luongcoban / 26;
                }

                if (hinhThucTangCa == "Tăng ca thường")
                {
                    tienTangCa = tonggiotangca * luongcoban / 240 * 1.5m;
                }
                else if (hinhThucTangCa == "Tăng ca lễ")
                {
                    tienTangCa = tonggiotangca * luongcoban / 240 * 2;
                }
            }
            return tienChamCong + tienTangCa + phucap - tienNghiPhep;
        }
        private void lbluongcoban_Click(object sender, EventArgs e)
        {

        }

        private void A_UC_SalaryItem_MouseEnter(object sender, EventArgs e)
        {
            if (trangthai == "Chưa duyệt")
            {
                guna2PictureBox1.Visible = true;
                guna2PictureBox2.Visible = true;
            }
            else
            {
                guna2PictureBox1.Visible = false;
                guna2PictureBox2.Visible = false;
            }
        }

        private void A_UC_SalaryItem_MouseLeave(object sender, EventArgs e)
        {
            if (!this.ClientRectangle.Contains(this.PointToClient(Cursor.Position)))
            {
                guna2PictureBox1.Visible = false;
                guna2PictureBox2.Visible = false;
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Luong luong = new Luong(this.UserID, this.funcionName);
            string err = "";
            if (luong != null)
            {
                if (luong.CapNhatTrangThaiLuong(luongid, "Đã duyệt", ref err))
                {
                    NhatKy nhatKy = new NhatKy(UserID, "A.Luong");
                    string hanhDong = $"Duyệt lương ID: {luongid}";
                    DateTime recentTime = DateTime.Now;
                    nhatKy.ThemNhatKy(this.UserID, hanhDong, recentTime, ref err);
                    MessageBox.Show("Duyệt lương thành công!");
                    reloadCallback?.Invoke(); // Gọi lại hàm reload để cập nhật giao diện
                }
                else
                {
                    MessageBox.Show("Lỗi: " + err);
                }
            }
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            Luong luong = new Luong(this.UserID, this.funcionName);
            string err = "";
            if (luong != null)
            {
                if (luong.CapNhatTrangThaiLuong(luongid, "Từ chối", ref err))
                {
                    NhatKy nhatKy = new NhatKy(UserID, "A.Luong");
                    string hanhDong = $"Từ chối lương ID: {luongid}";
                    DateTime recentTime = DateTime.Now;
                    nhatKy.ThemNhatKy(this.UserID, hanhDong, recentTime, ref err);
                    MessageBox.Show("Từ chối lương thành công!");
                    reloadCallback?.Invoke(); // Gọi lại hàm reload để cập nhật giao diện
                }
                else
                {
                    MessageBox.Show("Lỗi: " + err);
                }
            }
        }
    }
}

