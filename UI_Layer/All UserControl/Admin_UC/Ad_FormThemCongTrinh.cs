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

namespace QLNS.UI_Layer.All_UserControl.Admin_UC
{
    public partial class Ad_FormThemCongTrinh : Form
    {
        private int UserID;
        private string functionName;
        private Action reloadCallback;

        public Ad_FormThemCongTrinh(int userID, string functionName, Action reloadCallback)
        {
            InitializeComponent();
            this.UserID = userID;
            this.functionName = functionName;
            this.reloadCallback = reloadCallback;
        }


        private void Ad_FormThemCongTrinh_Load(object sender, EventArgs e)
        {
            PhongBan phongBan = new PhongBan(UserID, functionName);
            DataSet ds = phongBan.LayPhongBan();

            if (ds != null && ds.Tables.Count > 0)
            {
                cmbDepartment.DisplayMember = "TenPhongBan";
                cmbDepartment.ValueMember = "PhongBanID";
                cmbDepartment.DataSource = ds.Tables[0];
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tenCongTrinh = txtTenCongTrinh.Text.Trim();
            string diaDiem = txtDiaDiem.Text.Trim();
            DateTime ngayBatDau = dateNgayBatDau.Value;
            DateTime ngayKetThuc = dateNgayKetThuc.Value;

            if (cmbDepartment.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn phòng ban.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int phongBanID = Convert.ToInt32(cmbDepartment.SelectedValue);

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

            string err = "";
            CongTrinh congTrinh = new CongTrinh(UserID, functionName);
            bool res = congTrinh.ThemCongTrinh(tenCongTrinh, phongBanID, diaDiem, ngayBatDau, ngayKetThuc, ref err);

            if (res)
            {
                new NhatKy(UserID, functionName).ThemNhatKy(UserID, $"Thêm công trình: {tenCongTrinh}", DateTime.Now, ref err);
                MessageBox.Show("Thêm công trình thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reloadCallback?.Invoke();
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm công trình thất bại: " + err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
