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
        string functionName;
        int roleID;
        int PhongBanID;
        int CongTrinhID;
        int NhanVienID;
        DateTime NgayPhanCong;
        string loaiPhanCong;
        string TrangThai;
        Action reloadCallback;
        public addPhanCongCongTrinh(int userID, string functionName, int roleID, int phongBanID, Action reloadCallback)
        {
            InitializeComponent();
            UserID = userID;
            this.functionName = functionName;
            this.roleID = roleID;
            PhongBanID = phongBanID;
            this.reloadCallback = reloadCallback;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            CongTrinhID = Convert.ToInt32(projectid.Text);
            NhanVienID = Convert.ToInt32(txtNhanvienid.Text);
            NhanVien nhanVien = new NhanVien(UserID, functionName);
            CongTrinh congTrinh = new CongTrinh(UserID, functionName);
            PhanCongCongTrinh phanCong = new PhanCongCongTrinh(UserID, functionName);
            string err = "";
            if (roleID == 4)
            {
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
            }
            else if (roleID == 1)
            {
                if (!nhanVien.NhanVienIDDaTonTai(NhanVienID, ref err))
                {
                    MessageBox.Show("Nhân viên không tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Dừng xử lý nếu không tồn tại
                }
                if (!congTrinh.CongTrinhIDDaTonTai(CongTrinhID, ref err))
                {
                    MessageBox.Show("Công trình không tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Dừng xử lý nếu công trình không tồn tại
                }
            }
            NgayPhanCong = dateNgayPhanCong.Value.Date;
            if (roleID == 4)
            {
                loaiPhanCong = "Phân công";
                cbbLoai.Visible = false; // Ẩn combobox loại phân công cho nhân viên
                TrangThai = "Đã duyệt";
            }
            else if (roleID == 1)
            {
                loaiPhanCong = cbbLoai.SelectedItem.ToString();
                TrangThai = "Chưa duyệt";
            }

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
