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
namespace QLNS.UI_Layer.HR
{
    public partial class H_NhanVien : UserControl
    {
        private String functionName = "HR.NhanVien";
        int UserID;
        private int ID_NhanVien;
        private string HoTen;
        private string NgaySinh;
        private string cmnd;
        private string MaSoThue;
        private int idPhong;
        private int idChucVu;
        private string TrangThai;
        public H_NhanVien(int userID, int ID_NhanVien, string HoTen, string NgaySinh, string cmnd, string MaSoThue, int idPhong, int idChucVu, string TrangThai)
        {
            InitializeComponent();
            this.UserID = userID;
            this.ID_NhanVien = ID_NhanVien;
            this.HoTen = HoTen;
            this.NgaySinh = NgaySinh;
            this.cmnd = cmnd;
            this.MaSoThue = MaSoThue;
            this.idPhong = idPhong;
            this.idChucVu = idChucVu;
            this.TrangThai = TrangThai;
            RegisterHoverEvents(this);
        }
        private void RegisterHoverEvents(Control parent)
        {
            parent.MouseEnter += MouseEnter_NhanVien;
            parent.MouseLeave += MouseLeave_NhanVien;

            foreach (Control child in parent.Controls)
            {
                RegisterHoverEvents(child); // gán cho tất cả control con
            }
        }
        private void Load_NhanVien(object sender, EventArgs e)
        {
            this.MouseEnter += MouseEnter_NhanVien;
            this.MouseLeave += MouseLeave_NhanVien;
            lbNhanVienID.Text = ID_NhanVien.ToString();
            lbHoTen.Text = HoTen;
            lbNgaySinh.Text = NgaySinh;
            lbCMND.Text = cmnd;
            lbMaSoThue.Text = MaSoThue;
            lbPhongBan.Text = idPhong.ToString(); // Hoặc tra cứu tên phòng nếu cần
            lbChucVu.Text = idChucVu.ToString(); // Hoặc tra cứu tên chức vụ nếu cần
            lbTrangThai.Text = TrangThai;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                string err = "";
                var nv = new NhanVien(1, "Admin");

                if (nv.XoaNhanVien(ID_NhanVien, ref err))
                {
                    MessageBox.Show("Xóa thành công!");
                    NhatKy nhatKy = new NhatKy(UserID, functionName);
                    string hanhDong = $"Xóa nhân viên có họ tên: {HoTen}";
                    DateTime recentTime = DateTime.Now;
                    nhatKy.ThemNhatKy(UserID, hanhDong, recentTime, ref err);
                    if (!string.IsNullOrEmpty(err))
                    {
                        MessageBox.Show("Lỗi ghi nhật ký: " + err);
                    }
                    this.Parent.Controls.Remove(this); 
                    this.Dispose(); 
                }
                else
                {
                    MessageBox.Show("Lỗi: " + err);
                }
            }
        }

        private void MouseEnter_NhanVien(object sender, EventArgs e)
        {
            btnXoa.Visible = true;
            btnSua.Visible = true;
        }

        private void MouseLeave_NhanVien(object sender, EventArgs e)
        {
            if (!this.ClientRectangle.Contains(this.PointToClient(Cursor.Position)))
            {
                btnXoa.Visible = false;
                btnSua.Visible = false;
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (var form = new FormSuaNhanVien(                                                   
                                                    HoTen,
                                                    DateTime.ParseExact(NgaySinh, "dd/MM/yyyy", null),
                                                    cmnd,
                                                    MaSoThue,
                                                    idPhong,
                                                    idChucVu,
                                                    TrangThai))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    string err = "";
                    var nv = new NhanVien(UserID, functionName);

                    if (nv.CapNhatNhanVien(
                        ID_NhanVien,
                        form.HoTenMoi,
                        form.NgaySinhMoi,
                        form.CMNDMoi,
                        form.MaSoThueMoi,
                        form.IDPhongMoi,
                        form.IDChucVuMoi,
                        form.TrangThaiMoi,
                        ref err))
                    {
                        this.HoTen = form.HoTenMoi;
                        this.NgaySinh = form.NgaySinhMoi.ToString("dd/MM/yyyy");
                        this.cmnd = form.CMNDMoi;
                        this.MaSoThue = form.MaSoThueMoi;
                        this.idPhong = form.IDPhongMoi;
                        this.idChucVu = form.IDChucVuMoi;
                        this.TrangThai = form.TrangThaiMoi;

                        Load_NhanVien(null, null); // Cập nhật lại giao diện
                        MessageBox.Show("Cập nhật thành công!");

                        // Ghi nhật ký ở đây khi cập nhật thành công
                        NhatKy nhatKy = new NhatKy(UserID, functionName);
                        string hanhDong = $"Sửa nhân viên có họ tên: {HoTen}";
                        DateTime recentTime = DateTime.Now;
                        nhatKy.ThemNhatKy(UserID, hanhDong, recentTime, ref err);
                        if (!string.IsNullOrEmpty(err))
                        {
                            MessageBox.Show("Lỗi ghi nhật ký: " + err);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lỗi cập nhật: " + err);
                    }
                }
            }
        }
    }
}
