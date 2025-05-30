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
    public partial class E_UC_ItemTangCa : UserControl
    {
        int idTangCa;
        string tenNhanVien;
        string ngayTangCa;
        string gioBatDau;
        string gioKetThuc;
        string loaiTangCa;
        string hinhThucTangCa;
        string trangThai;

        int userID;
        string functionName;
        Action reloadCallback;

        public E_UC_ItemTangCa(int idTangCa, string tenNhanVien, string ngayTangCa, string gioBatDau, string gioKetThuc, string loaiTangCa, string hinhThucTangCa, string trangThai, int userID,
    string functionName,Action reloadCallback)
        {
            InitializeComponent();
            this.idTangCa = idTangCa;
            this.tenNhanVien = tenNhanVien;
            this.ngayTangCa = ngayTangCa;
            this.gioBatDau = gioBatDau;
            this.gioKetThuc = gioKetThuc;
            this.loaiTangCa = loaiTangCa;
            this.hinhThucTangCa = hinhThucTangCa;
            this.trangThai = trangThai;

            this.userID = userID;
            this.functionName = functionName;
            this.reloadCallback = reloadCallback;

            this.btnSua.Visible = false;
            this.btnXoa.Visible = false;
        }

        private void E_UC_ItemTangCa_Load(object sender, EventArgs e)
        {
            this.lbIDTangCa.Text = idTangCa.ToString();
            this.lbTenNhanVien.Text = tenNhanVien;
            this.lbNgayTangCa.Text = ngayTangCa;
            this.lbGioBatDau.Text = gioBatDau;
            this.lbGioKetThuc.Text = gioKetThuc;
            this.lbLoaiTangCa.Text = loaiTangCa;
            this.lbHinhThuc.Text = hinhThucTangCa;
            this.lbTrangThai.Text = trangThai;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa đăng ký tăng ca này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string err = "";
                TangCa tangCa = new TangCa(userID, functionName);
                bool result = tangCa.XoaTangCa(idTangCa, ref err);

                if (result)
                {
                    
                    new NhatKy(userID, functionName).ThemNhatKy(userID, $"Xóa tăng ca ID {idTangCa}", DateTime.Now, ref err);

                    MessageBox.Show("Đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reloadCallback?.Invoke();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại: " + err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            E_FormDangKyTangCa form = new E_FormDangKyTangCa(
                userID,
                functionName,
                LayNhanVienID(),      
                idTangCa,             
                reloadCallback
            );

            form.ShowDialog();
        }

        private int LayNhanVienID()
        {
            string err = "";
            NhanVien nv = new NhanVien(userID, functionName);
            return nv.LayNhanVienIDtheoUserID(ref err);
        }
        private void RegisterHoverEvents(Control parent)
        {
            parent.MouseEnter += E_UC_ItemTangCa_MouseEnter;
            parent.MouseLeave += E_UC_ItemTangCa_MouseLeave;

            foreach (Control child in parent.Controls)
            {
                RegisterHoverEvents(child); // gán cho tất cả control con
            }
        }
        private void E_UC_ItemTangCa_MouseLeave(object sender, EventArgs e)
        {
            if (!this.ClientRectangle.Contains(this.PointToClient(Cursor.Position)))
            {
                btnXoa.Visible = false;
                btnSua.Visible = false;
            }
        }

        private void E_UC_ItemTangCa_MouseEnter(object sender, EventArgs e)
        {
            btnSua.Visible = true;
            btnXoa.Visible = true;
        }
    }
}
