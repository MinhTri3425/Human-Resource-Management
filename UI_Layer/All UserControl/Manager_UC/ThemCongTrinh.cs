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
    public partial class ThemCongTrinh : Form
    {
        private int UserID;
        private string functionName;
        private Action reloadCallback;
        int PhongBanID;
        public ThemCongTrinh(int userID, string functionName,int phongBanID, Action reloadCallback )
        {
            InitializeComponent();
            this.UserID = userID;
            this.functionName = functionName;
            this.reloadCallback = reloadCallback;
            this.PhongBanID = phongBanID;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tenCongTrinh = txtTenCongTrinh.Text.Trim();
            string diaDiem = txtDiaDiem.Text.Trim();
            DateTime ngayBatDau = dateNgayBatDau.Value;
            DateTime ngayKetThuc = dateNgayKetThuc.Value;

            if (string.IsNullOrEmpty(tenCongTrinh) || string.IsNullOrEmpty(diaDiem))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ngayKetThuc < ngayBatDau)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn hoặc bằng ngày bắt đầu.", "Ngày không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CongTrinh congTrinh = new CongTrinh(this.UserID, this.functionName);
            string err = "";
            bool res = congTrinh.ThemCongTrinh(tenCongTrinh, this.PhongBanID, diaDiem, ngayBatDau, ngayKetThuc, ref err);

            if (res)
            {
                NhatKy nhatKy = new NhatKy(UserID, functionName);
                string hanhDong = $"Thêm công trình: {tenCongTrinh}";
                nhatKy.ThemNhatKy(UserID, hanhDong, DateTime.Now, ref err);

                MessageBox.Show("Thêm công trình thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reloadCallback?.Invoke();
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm công trình thất bại: " + err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ThemCongTrinh_Load(object sender, EventArgs e)
        {

        }
    }
}
