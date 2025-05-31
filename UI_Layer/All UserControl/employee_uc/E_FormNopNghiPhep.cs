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
    public partial class E_FormNopNghiPhep : Form
    {
        private int userID;
        private string functionName;
        private int nhanVienID;
        private Action reloadCallback;

        public E_FormNopNghiPhep(int userID, string functionName, int nhanVienID, Action reloadCallback)
        {
            InitializeComponent();
            this.userID = userID;
            this.functionName = functionName;
            this.nhanVienID = nhanVienID;
            this.reloadCallback = reloadCallback;

            dateNgayBatDau.Value = DateTime.Today;
            dateNgayKetThuc.Value = DateTime.Today;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string loai = cmbLoaiNghiPhep.Text;
            DateTime ngayBatDau = dateNgayBatDau.Value.Date;
            DateTime ngayKetThuc = dateNgayKetThuc.Value.Date;

            if (string.IsNullOrEmpty(loai))
            {
                MessageBox.Show("Vui lòng nhập loại nghỉ phép.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ngayKetThuc < ngayBatDau)
            {
                MessageBox.Show("Ngày kết thúc không được nhỏ hơn ngày bắt đầu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string err = "";
            NghiPhep nghiPhep = new NghiPhep(userID, functionName);
            bool result = nghiPhep.ThemNghiPhep(nhanVienID, ngayBatDau, ngayKetThuc, loai, "Chưa duyệt", ref err);

            if (result)
            {
                new NhatKy(userID, functionName).ThemNhatKy(userID, $"Đăng ký nghỉ phép từ {ngayBatDau:dd/MM/yyyy} đến {ngayKetThuc:dd/MM/yyyy}", DateTime.Now, ref err);
                MessageBox.Show("Gửi đơn nghỉ phép thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reloadCallback?.Invoke();
                this.Close();
            }
            else
            {
                MessageBox.Show("Lỗi: " + err, "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void E_FormNopNghiPhep_Load(object sender, EventArgs e)
        {

        }
    }
}
