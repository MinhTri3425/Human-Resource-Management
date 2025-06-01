using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNS.BL_Layer;

namespace QLNS.UI_Layer.All_UserControl.HR_UI
{
    public partial class FormThemHopDong : Form
    {
        string functionName = "HR.HopDong";
        int UserID;
        public FormThemHopDong(int userID)
        {
            InitializeComponent();
            UserID = userID;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra và ép kiểu NhanVienID
            if (!int.TryParse(txtNhanVienID.Text, out int idNhanVien))
            {
                MessageBox.Show("Mã nhân viên không hợp lệ!");
                return;
            }

            string loaiHopDong = CbbLoaiHD.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(loaiHopDong))
            {
                MessageBox.Show("Vui lòng chọn loại hợp đồng!");
                return;
            }

            DateTime ngayBatDau = NgayKy.Value;
            DateTime? ngayKetThuc = null;
            string err = "";

            // Tính ngày kết thúc dựa trên loại hợp đồng
            switch (loaiHopDong)
            {
                case "Thử việc":
                    ngayKetThuc = ngayBatDau.AddMonths(2);
                    break;
                case "Thời vụ":
                    ngayKetThuc = ngayBatDau.AddMonths(6);
                    break;
                case "Xác định thời hạn":
                    ngayKetThuc = ngayBatDau.AddYears(2);
                    break;
                case "Không xác định thời hạn":
                    ngayKetThuc = null;
                    break;
                default:
                    MessageBox.Show("Loại hợp đồng không hợp lệ!");
                    return;
            }

            // Thêm hợp đồng
            HopDongLaoDong hopDong = new HopDongLaoDong(UserID, functionName);
            bool result = hopDong.ThemHopDongLaoDong(idNhanVien, loaiHopDong, ngayBatDau, (DateTime)ngayKetThuc, ref err);

            if (result)
            {
                MessageBox.Show("Thêm hợp đồng thành công!");
                this.DialogResult = DialogResult.OK;

                // Ghi nhật ký thao tác
                string hanhDong = $"Thêm hợp đồng loại '{loaiHopDong}' cho nhân viên ID: {idNhanVien}";
                DateTime thoiGian = DateTime.Now;
                NhatKy nhatKy = new NhatKy(UserID, functionName);
                nhatKy.ThemNhatKy(UserID, hanhDong, thoiGian, ref err);
            }
            else
            {
                MessageBox.Show("Lỗi khi thêm hợp đồng: " + err);
            }
        }
    }
}