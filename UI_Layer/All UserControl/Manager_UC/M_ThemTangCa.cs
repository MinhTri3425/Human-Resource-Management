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
    public partial class M_ThemTangCa : Form
    {
        private int userID;
        private string functionName;
        private int phongBanID;
        private Action reloadCallback;

        public M_ThemTangCa(int userID, string functionName, int phongBanID, Action reloadCallback)
        {
            InitializeComponent();
            this.userID = userID;
            this.functionName = functionName;
            this.phongBanID = phongBanID;
            this.reloadCallback = reloadCallback;

            LoadDanhSachNhanVien();
        }

        public void LoadDanhSachNhanVien()
        {
            NhanVien nv = new NhanVien(userID, functionName);
            DataSet ds = nv.LayNhanVienTheoPhongBanID(phongBanID);
            cmbHoTenNhanVien.DisplayMember = "HoTen";
            cmbHoTenNhanVien.ValueMember = "NhanVienID";
            cmbHoTenNhanVien.DataSource = ds.Tables[0];
        }

        private void dateNgayBatDau_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int nhanVienID = Convert.ToInt32(cmbHoTenNhanVien.SelectedValue);
            DateTime ngayTangCa = dateNgayTangCa.Value.Date;
            string gioBatDau = timeGioBatDau.Value.ToString("HH:mm");
            string gioKetThuc = timeGioKetThuc.Value.ToString("HH:mm");
            string loaiTangCa = "Phân công";
            string hinhThuc = formtangca.SelectedItem.ToString();
            string trangThai = "Đã duyệt";

            string err = "";
            TangCa tangCa = new TangCa(userID, functionName);
            bool result = tangCa.ThemTangCa(nhanVienID, ngayTangCa, gioBatDau, gioKetThuc, loaiTangCa, hinhThuc, trangThai, ref err);

            if (result)
            {
                new NhatKy(userID, functionName).ThemNhatKy(userID, $"Thêm tăng ca cho NVID {nhanVienID} ngày {ngayTangCa:dd/MM/yyyy}", DateTime.Now, ref err);
                MessageBox.Show("Thêm tăng ca thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reloadCallback?.Invoke();
                this.Close();
            }
            else
            {
                MessageBox.Show("Lỗi: " + err, "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
