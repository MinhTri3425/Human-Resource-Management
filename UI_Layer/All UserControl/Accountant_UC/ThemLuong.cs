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
    public partial class ThemLuong : Form
    {
        private int UserID;
        private string functionName = "A.Luong";
        public ThemLuong(int UserID)
        {
            InitializeComponent();
            this.UserID = UserID;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ThemLuong_Load(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Luong luong = new Luong(UserID, functionName);
            NhanVien nhanVien = new NhanVien(UserID, functionName);
            string err = "";
            int NhanVienID = Convert.ToInt32(txtNhanVienID.Text);
            if (!nhanVien.NhanVienIDDaTonTai(NhanVienID, ref err))
            {
                MessageBox.Show("Nhân viên không tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng xử lý nếu không tồn tại
            }
            int Thang = int.Parse(cbbmonth.SelectedItem.ToString());
            int Nam = int.Parse(cbbyear.SelectedItem.ToString());
            decimal luongCoBan = luong.LayLuongCoBan(NhanVienID,5, 2025);
            decimal phuCap = luong.LayPhuCap(NhanVienID, 5, 2025);
            decimal tongLuong = luongCoBan + phuCap;
            string trangThai = "Chưa duyệt";
            if (luong.ThemLuong(NhanVienID, Thang, Nam, luongCoBan, phuCap, tongLuong, trangThai, ref err))
            {
                NhatKy nhatKy = new NhatKy(UserID, functionName);
                string hanhDong = $"Thêm lương cho nhân viên ID: {NhanVienID}, Tháng: {Thang}, Năm: {Nam}";
                DateTime recentTime = DateTime.Now;
                nhatKy.ThemNhatKy(this.UserID, hanhDong, recentTime, ref err);
                MessageBox.Show("Thêm lương thành công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Lỗi: " + err);
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
