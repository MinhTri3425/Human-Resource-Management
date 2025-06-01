using QLNS.BL_Layer;
using QLNS.UI_Layer.All_UserControl.HR_UI;
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
    public partial class H_HopDong : UserControl
    {
        private int UserID;
        private string functionName;
        private int ID_HopDong;
        private int ID_NhanVien;
        private string LoaiHopDong;
        private string NgayBatDau;
        private string NgayKetThuc;
        public H_HopDong(int UserID, string functionName, int iD_HopDong, int iD_NhanVien, string loaiHopDong, string ngayBatDau, string ngayKetThuc)
        {
            InitializeComponent();
            this.UserID = UserID;
            this.functionName = functionName;
            ID_HopDong = iD_HopDong;
            ID_NhanVien = iD_NhanVien;
            LoaiHopDong = loaiHopDong;
            NgayBatDau = ngayBatDau;
            NgayKetThuc = ngayKetThuc;
            RegisterHoverEvents(this);
        }
        private void RegisterHoverEvents(Control parent)
        {
            parent.MouseEnter += MouseEnter_HopDong;
            parent.MouseLeave += MouseLeave_HopDong;

            foreach (Control child in parent.Controls)
            {
                RegisterHoverEvents(child); // gán cho tất cả control con
            }
        }
        private void H_HopDong_Load(object sender, EventArgs e)
        {
            lbIDHopDong.Text = ID_HopDong.ToString();
            lbIDNhanVien.Text = ID_NhanVien.ToString();
            lbLoaiHD.Text = LoaiHopDong;
            lbNgayKy.Text = NgayBatDau;
            lbNgayHetHan.Text = NgayKetThuc;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                string err = "";
                var nv = new HopDongLaoDong(this.UserID, this.functionName);

                if (nv.XoaHopDongLaoDong(ID_NhanVien, ref err))
                {
                    MessageBox.Show("Xóa thành công!");
                    NhatKy nhatKy = new NhatKy(UserID, functionName);
                    string hanhDong = $"Xóa hợp đồng có ID: {ID_HopDong}";
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (var form = new FormSuaHopDong(
            ID_HopDong,
            ID_NhanVien,
            DateTime.ParseExact(NgayBatDau, "dd/MM/yyyy", null),
            DateTime.ParseExact(NgayKetThuc, "dd/MM/yyyy", null),
            LoaiHopDong))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    string err = "";
                    var hd = new HopDongLaoDong(UserID, functionName);

                    // Tính lại ngày kết thúc dựa theo loại hợp đồng
                    DateTime ?ngayKetThucMoi;
                    switch (form.LoaiHopDongMoi)
                    {
                        case "Thử việc":
                            ngayKetThucMoi = form.NgayKyMoi.AddMonths(2);
                            break;
                        case "Thời vụ":
                            ngayKetThucMoi = form.NgayKyMoi.AddMonths(6);
                            break;
                        case "Xác định thời hạn":
                            ngayKetThucMoi = form.NgayKyMoi.AddYears(2);
                            break;
                        case "Không xác định thời hạn":
                            ngayKetThucMoi = null;
                            break;
                        default:
                            MessageBox.Show("Loại hợp đồng không hợp lệ!");
                            return;
                    }

                    if (hd.CapNhatHopDongLaoDong(
                                                    form.IDHopDongMoi,
                                                    form.IDNhanVienMoi,
                                                    form.LoaiHopDongMoi,
                                                    form.NgayKyMoi,
                                                    (DateTime)ngayKetThucMoi, 
                                                    ref err))
                    {
                        this.ID_HopDong = form.IDHopDongMoi;
                        this.ID_NhanVien = form.IDNhanVienMoi;
                        this.NgayBatDau = form.NgayKyMoi.ToString("dd/MM/yyyy");
                        this.NgayKetThuc = ngayKetThucMoi?.ToString("dd/MM/yyyy") ?? "Không xác định";
                        this.LoaiHopDong = form.LoaiHopDongMoi;

                        H_HopDong_Load(null, null);
                        MessageBox.Show("Cập nhật hợp đồng thành công!");

                        NhatKy nhatKy = new NhatKy(UserID, functionName);
                        string hanhDong = $"Sửa hợp đồng ID: {ID_HopDong} cho nhân viên ID: {ID_NhanVien}";
                        nhatKy.ThemNhatKy(UserID, hanhDong, DateTime.Now, ref err);
                        if (!string.IsNullOrEmpty(err))
                        {
                            MessageBox.Show("Lỗi ghi nhật ký: " + err);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lỗi cập nhật hợp đồng: " + err);
                    }
                }
            }

        }

        private void MouseEnter_HopDong(object sender, EventArgs e)
        {
            btnXoa.Visible = true;
            btnSua.Visible = true;
        }

        private void MouseLeave_HopDong(object sender, EventArgs e)
        {
            if (!this.ClientRectangle.Contains(this.PointToClient(Cursor.Position)))
            {
                btnXoa.Visible = false;
                btnSua.Visible = false;
            }
        }
    }
}
