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

namespace QLNS.UI_Layer.All_UserControl.Employee_UC
{
    public partial class E_Form_DangKyCongTrinh : Form
    {
        private int userID;
        private string functionName;
        private int nhanVienID;
        private List<(int ID, string Ten)> congTrinhs;
        private Action reloadCallback;



        public E_Form_DangKyCongTrinh(int userID, string functionName, int nhanVienID, List<(int ID, string Ten)> congTrinhs, Action reloadCallback)
        {
            InitializeComponent();
            this.userID = userID;
            this.functionName = functionName;
            this.nhanVienID = nhanVienID;
            this.congTrinhs = congTrinhs;
            this.reloadCallback = reloadCallback;
        }

        private int? congTrinhID = null;
        private DateTime? ngayPhanCongCu;
        private string loaiCu;

        public E_Form_DangKyCongTrinh(
            int userID,
            string functionName,
            int nhanVienID,
            List<(int ID, string Ten)> congTrinhs,
            int congTrinhID,
            DateTime ngayPhanCong,
            string loai,
            Action reloadCallback
        ) : this(userID, functionName, nhanVienID, congTrinhs, reloadCallback) // gọi constructor 5 tham số ở trên
        {
            this.congTrinhID = congTrinhID;
            this.ngayPhanCongCu = ngayPhanCong;
            this.loaiCu = loai;
        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void E_Form_DangKyCongTrinh_Load(object sender, EventArgs e)
        {
            cmbTenCongTrinh.DisplayMember = "Ten";
            cmbTenCongTrinh.ValueMember = "ID";
            cmbTenCongTrinh.DataSource = congTrinhs.Select(ct => new { ct.ID, ct.Ten }).ToList();

            if (congTrinhID != null)
            {
                cmbTenCongTrinh.SelectedValue = congTrinhID.Value;
                cmbTenCongTrinh.Enabled = false;
                dateNgayPhanCong.Value = ngayPhanCongCu ?? DateTime.Today;
                txtLoai.Text = loaiCu;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int congTrinhIDChon = Convert.ToInt32(cmbTenCongTrinh.SelectedValue);
            DateTime ngay = dateNgayPhanCong.Value;
            string loai = txtLoai.Text.Trim();
            string trangThai = "Chưa duyệt";

            string err = "";
            PhanCongCongTrinh phancong = new PhanCongCongTrinh(userID, functionName);
            bool result;

            if (congTrinhID == null)
            {
                // Thêm mới
                result = phancong.ThemPhanCongCongTrinh(nhanVienID, congTrinhIDChon, ngay, loai, trangThai, ref err);
            }
            else
            {
                // Cập nhật
                result = phancong.CapNhatPhanCongCongTrinh(nhanVienID, congTrinhIDChon, ngay, loai, trangThai, ref err);
            }

            if (result)
            {
                string action = congTrinhID == null ? "Đăng ký" : "Chỉnh sửa";
                new NhatKy(userID, functionName).ThemNhatKy(userID, $"{action} công trình ID {congTrinhIDChon}", DateTime.Now, ref err);
                MessageBox.Show($"{action} thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reloadCallback?.Invoke();
                this.Close();
            }
            else
            {
                MessageBox.Show("Lỗi: " + err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtLoai_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
