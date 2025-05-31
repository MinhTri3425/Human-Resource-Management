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
    public partial class A_ThemTangCa : Form
    {
        int userID;
        string functionName;
        Action reloadCallback;

        public A_ThemTangCa(int userID, string functionName, Action reloadCallback)
        {
            InitializeComponent();
            this.userID = userID;
            this.functionName = functionName;
            this.reloadCallback = reloadCallback;

        }

        private void A_ThemTangCa_Load(object sender, EventArgs e)
        {
            LoadNhanVien();

        }

        private void LoadNhanVien()
        { 
            NhanVien nv = new NhanVien(userID, functionName);
            DataSet ds = nv.LayNhanVien();
            if (ds != null && ds.Tables.Count > 0)
            {
                cmbHoTenNhanVien.DataSource = ds.Tables[0];
                cmbHoTenNhanVien.DisplayMember = "HoTen";
                cmbHoTenNhanVien.ValueMember = "NhanVienID";
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int nhanVienID = Convert.ToInt32(cmbHoTenNhanVien.SelectedValue);
            DateTime ngayTangCa = dateNgayTangCa.Value.Date;
            string gioBatDau = timeGioBatDau.Value.ToString("HH:mm");
            string gioKetThuc = timeGioKetThuc.Value.ToString("HH:mm");
            string loaiTangCa = cmbLoaiTangCa.SelectedItem.ToString();
            string hinhThuc = "Đăng ký"; 
            string trangThai = "Đã duyệt";

            string err = "";
            TangCa tangCa = new TangCa(userID, functionName);
            bool result = tangCa.ThemTangCa(nhanVienID, ngayTangCa, gioBatDau, gioKetThuc, loaiTangCa, hinhThuc, trangThai, ref err);

            if (result)
            {
                string hanhDong = $"Đăng ký tăng ca cho nhân viên ID: {nhanVienID}, Ngày: {ngayTangCa:dd/MM/yyyy}, Giờ: {gioBatDau} - {gioKetThuc}, Loại: {loaiTangCa}";
                NhatKy nhatKy = new NhatKy(userID, functionName);
                nhatKy.ThemNhatKy(userID, hanhDong, DateTime.Now, ref err);

                MessageBox.Show("Đăng ký tăng ca thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reloadCallback?.Invoke(); 
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm thất bại: " + err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
