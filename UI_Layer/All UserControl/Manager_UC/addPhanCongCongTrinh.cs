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

namespace QLNS.UI_Layer.All_UserControl.Manager_UC
{
    public partial class addPhanCongCongTrinh : Form
    {
        int UserID;
        string functionName = "M.CongTrinh(samePB)";

        int PhongBanID;
        int CongTrinhID;
        int NhanVienID;
        DateTime NgayPhanCong;
        string loaiPhanCong;
        string TrangThai;
        Action reloadCallback;
        public addPhanCongCongTrinh(int userID, int phongBanID, Action reloadCallback)
        {
            InitializeComponent();
            UserID = userID;
            PhongBanID = phongBanID;
            this.reloadCallback = reloadCallback;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            CongTrinhID = Convert.ToInt32(projectid.Text);
            NhanVienID = Convert.ToInt32(txtNhanvienid.Text);
            NhanVien nhanVien = new NhanVien(UserID, functionName);
            string err = "";
            if (nhanVien.NhanVienCoCungPhongBan(NhanVienID, PhongBanID, ref err))
            {
                if (!nhanVien.NhanVienIDDaTonTai(NhanVienID, ref err))
                {
                    MessageBox.Show("Nhân viên không tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Dừng xử lý nếu không tồn tại
                }
            }
            else
            {
                MessageBox.Show("Nhân viên không thuộc phòng ban này!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng xử lý nếu không thuộc phòng ban
            }

            CongTrinh congTrinh = new CongTrinh(UserID, functionName);
            PhanCongCongTrinh phanCong = new PhanCongCongTrinh(UserID, functionName);

            if (congTrinh.CongTrinhCoCungPhongBan(CongTrinhID, PhongBanID, ref err))
            {
                if (!congTrinh.CongTrinhIDDaTonTai(CongTrinhID, ref err))
                {
                    MessageBox.Show("Công trình không tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Dừng xử lý nếu công trình không tồn tại
                }
            }
            else
            {
                MessageBox.Show("Công trình không thuộc phòng ban này!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng xử lý nếu không thuộc phòng ban
            }

            NgayPhanCong = dateNgayPhanCong.Value.Date;
            loaiPhanCong = "Phân công";
            TrangThai = "Đã duyệt";
            bool res = phanCong.ThemPhanCongCongTrinh(CongTrinhID, NhanVienID, NgayPhanCong, loaiPhanCong, TrangThai, ref err);
            if (res)
            {
                NhatKy nhatKy = new NhatKy(UserID, functionName);
                string hanhDong = $"Thêm phân công công trình: {CongTrinhID} cho nhân viên: {NhanVienID}";
                nhatKy.ThemNhatKy(UserID, hanhDong, DateTime.Now, ref err);
                MessageBox.Show("Thêm phân công công trình thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reloadCallback?.Invoke(); // Gọi lại hàm reload để cập nhật dữ liệu
                this.Close();
            }
            else
            {
                MessageBox.Show($"Lỗi khi thêm phân công công trình: {err}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
