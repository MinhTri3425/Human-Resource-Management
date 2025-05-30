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
    public partial class E_FormDangKyTangCa : Form
    {
        private int userID;
        private string functionName;
        private int nhanVienID;
        private int? tangCaID; // null nếu là thêm mới
        private Action reloadCallback;

        public E_FormDangKyTangCa(int userID, string functionName, int nhanVienID, int? tangCaID, Action reloadCallback)
        {
            InitializeComponent();
            this.userID = userID;
            this.functionName = functionName;
            this.nhanVienID = nhanVienID;
            this.tangCaID = tangCaID;
            this.reloadCallback = reloadCallback;


        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DateTime ngay = dateNgayTangCa.Value.Date;
            string gioBD = timeGioBatDau.Value.ToString("HH:mm");
            string gioKT = timeGioKetThuc.Value.ToString("HH:mm");
            string loai = txtLoaiTangCa.Text.Trim();
            string hinhThuc = txtHinhThucTangCa.SelectedItem.ToString();
            string trangThai = "Chưa duyệt";
            string err = "";

            if (string.IsNullOrWhiteSpace(loai) || string.IsNullOrWhiteSpace(hinhThuc))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ loại và hình thức tăng ca.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            TimeSpan t1 = TimeSpan.Parse(gioBD);
            TimeSpan t2 = TimeSpan.Parse(gioKT);
            if (t2 <= t1)
            {
                MessageBox.Show("Giờ kết thúc phải sau giờ bắt đầu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TangCa tangCa = new TangCa(userID, functionName);

            
            if (tangCaID == null)
            {
                DataSet ds = tangCa.LayTangCaTheoNhanVienID(nhanVienID);
                bool daDangKyNgayNay = ds.Tables[0].AsEnumerable()
                    .Any(row => Convert.ToDateTime(row["NgayTangCa"]).Date == ngay);

                if (daDangKyNgayNay)
                {
                    MessageBox.Show("Bạn đã đăng ký tăng ca ngày này rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            bool result = tangCaID == null
                ? tangCa.ThemTangCa(nhanVienID, ngay, gioBD, gioKT, loai, hinhThuc, trangThai, ref err)
                : tangCa.CapNhatTangCa((int)tangCaID, nhanVienID, ngay, gioBD, gioKT, loai, hinhThuc, trangThai, ref err);

            if (result)
            {
                new NhatKy(userID, functionName).ThemNhatKy(
                    userID,
                    $"{(tangCaID == null ? "Đăng ký" : "Chỉnh sửa")} tăng ca ngày {ngay:dd/MM/yyyy}",
                    DateTime.Now,
                    ref err
                );

                MessageBox.Show("Đăng ký tăng ca thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reloadCallback?.Invoke();
                this.Close();
            }
            else
            {
                MessageBox.Show("Lỗi: " + err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void E_FormDangKyTangCa_Load(object sender, EventArgs e)
        {
            if (tangCaID != null)
            {
                TangCa tangCa = new TangCa(userID, functionName);
                DataSet ds = tangCa.LayTangCaTheoNhanVienID(nhanVienID);
                var row = ds.Tables[0].AsEnumerable().FirstOrDefault(r => Convert.ToInt32(r["TangCaID"]) == tangCaID);

                if (row != null)
                {
                    dateNgayTangCa.Value = Convert.ToDateTime(row["NgayTangCa"]);
                    timeGioBatDau.Value = DateTime.Parse(row["GioBatDau"].ToString());
                    timeGioKetThuc.Value = DateTime.Parse(row["GioKetThuc"].ToString());
                    txtLoaiTangCa.Text = row["LoaiTangCa"].ToString();
                    txtHinhThucTangCa.Text = row["HinhThuc"].ToString();
                }
            }
        }
    }
}
