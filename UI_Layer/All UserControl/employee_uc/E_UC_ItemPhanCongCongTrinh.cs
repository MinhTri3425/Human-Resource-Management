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
    public partial class E_UC_ItemPhanCongCongTrinh : UserControl
    {
        int congTrinhID;
        int nhanVienID;

        string hoTenNhanVien;
        string tenCongTrinh;
        string ngay;
        string loai;
        string trangThai;

        int userID;
        string functionName;
        Action reloadCallback;

        public E_UC_ItemPhanCongCongTrinh(int nhanVienID, int congtrinhID, string hoTenNhanVien, string tenCongTrinh, string ngay, string loai, string trangThai,int userID, string functionName, 
            Action reloadCallback)
        {
            InitializeComponent();
            this.congTrinhID = congtrinhID;
            this.nhanVienID = nhanVienID;
            this.hoTenNhanVien = hoTenNhanVien;
            this.tenCongTrinh = tenCongTrinh;
            this.ngay = ngay;
            this.loai = loai;
            this.trangThai = trangThai;

            this.userID = userID;
            this.functionName = functionName;
            this.reloadCallback = reloadCallback;
            
            this.btnSua.Visible = false;
            this.btnXoa.Visible = false;
        }

        private void E_UC_ItemPhanCongCongTrinh_Load(object sender, EventArgs e)
        {
            lbTenNhanVien.Text = hoTenNhanVien;
            lbTenCongTrinh.Text = tenCongTrinh;
            lbNgayPhanCong.Text = ngay;
            lbLoai.Text = loai;
            lbTrangThai.Text = trangThai;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa phân công công trình này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string err = "";
                PhanCongCongTrinh phanCong = new PhanCongCongTrinh(userID, functionName);
                bool result = phanCong.XoaPhanCongCongTrinh(nhanVienID, congTrinhID, ref err);

                if (result)
                {
                    new NhatKy(userID, functionName).ThemNhatKy(userID, $"Xóa phân công công trình ID {congTrinhID}", DateTime.Now, ref err);
                    MessageBox.Show("Đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reloadCallback?.Invoke();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại: " + err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void E_UC_ItemPhanCongCongTrinh_MouseEnter(object sender, EventArgs e)
        {
            this.btnSua.Visible = true;
            this.btnXoa.Visible = true;
        }

        private void E_UC_ItemPhanCongCongTrinh_MouseLeave(object sender, EventArgs e)
        {
            if (!this.ClientRectangle.Contains(this.PointToClient(Cursor.Position)))
            {
                this.btnXoa.Visible = false;
                this.btnSua.Visible = false;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DateTime ngayPhanCong = DateTime.ParseExact(ngay, "dd/MM/yyyy", null);

           
            var danhSachCongTrinh = new E_UC_DangKyCongTrinh(userID).LayDanhSachCongTrinhCungPhongBan();

            E_Form_DangKyCongTrinh form = new E_Form_DangKyCongTrinh(
                userID,
                functionName,
                nhanVienID,
                danhSachCongTrinh,
                congTrinhID,
                ngayPhanCong,
                loai,
                reloadCallback
            );
            form.ShowDialog();
        }
    }
}
