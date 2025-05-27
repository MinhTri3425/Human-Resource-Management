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
    public partial class M_SuaCongTrinh : Form
    {
        private int projectID;
        private int userID;
        private string functionName;
        private Action reloadCallback;

        public M_SuaCongTrinh(int projectID, string ten, string diaDiem, string ngayBatDau, string ngayKetThuc, int userID, string functionName, Action reloadCallback)
        {
            InitializeComponent();
            this.projectID = projectID;
            this.userID = userID;
            this.functionName = functionName;
            this.reloadCallback = reloadCallback;

         
            txtTenCongTrinh.Text = ten;
            txtDiaDiem.Text = diaDiem;
            dateNgayBatDau.Value = DateTime.ParseExact(ngayBatDau, "dd/MM/yyyy", null);
            dateNgayKetThuc.Value = DateTime.ParseExact(ngayKetThuc, "dd/MM/yyyy", null);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ten = txtTenCongTrinh.Text.Trim();
            string diaDiem = txtDiaDiem.Text.Trim();
            DateTime ngayBD = dateNgayBatDau.Value;
            DateTime ngayKT = dateNgayKetThuc.Value;

            if (string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(diaDiem))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ngayKT < ngayBD)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn hoặc bằng ngày bắt đầu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string err = "";
            NhanVien nv = new NhanVien(userID, functionName);
            int nhanVienID = nv.LayNhanVienIDtheoUserID(ref err);
            DataSet ds = nv.LayNhanVienTheoID(nhanVienID);
            int phongBanID = Convert.ToInt32(ds.Tables[0].Rows[0]["PhongBanID"]);

            CongTrinh congTrinh = new CongTrinh(userID, functionName);
            bool result = congTrinh.CapNhatCongTrinh(projectID, ten, phongBanID, diaDiem, ngayBD, ngayKT, ref err);

            if (result)
            {
                NhatKy nhatKy = new NhatKy(userID, functionName);
                nhatKy.ThemNhatKy(userID, $"Sửa công trình: {ten}", DateTime.Now, ref err);
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reloadCallback?.Invoke();
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại: " + err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
