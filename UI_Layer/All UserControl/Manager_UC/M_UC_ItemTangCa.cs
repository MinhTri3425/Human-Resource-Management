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
    public partial class M_UC_ItemTangCa : UserControl
    {
        int UserID;
        int idTangCa;
        string tenNhanVien;
        string ngayTangCa;
        string gioBatDau;
        string gioKetThuc;
        string loaiTangCa;
        string hinhThucTangCa;
        string trangThai;

        public M_UC_ItemTangCa(int UserID,int idTangCa, string tenNhanVien, string ngayTangCa, string gioBatDau, string gioKetThuc, string loaiTangCa, string hinhThucTangCa, string trangThai)
        {
            InitializeComponent();
            this.UserID = UserID;
            this.idTangCa = idTangCa;
            this.tenNhanVien = tenNhanVien;
            this.ngayTangCa = ngayTangCa;
            this.gioBatDau = gioBatDau;
            this.gioKetThuc = gioKetThuc;
            this.loaiTangCa = loaiTangCa;
            this.hinhThucTangCa = hinhThucTangCa;
            this.trangThai = trangThai;
            guna2PictureBox1.Visible = false; // Biểu tượng duyệt
            guna2PictureBox2.Visible = false; // Biểu tượng từ chối
        }

        private void M_UC_ItemTangCa_Load(object sender, EventArgs e)
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

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            TangCa tangCa = new TangCa(UserID, "M.TangCa");
            string err = "";
            if (tangCa.CapNhatTrangThaiTangCa(idTangCa, "Đã duyệt", ref err))
            {
                MessageBox.Show("Cập nhật trạng thái thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbTrangThai.Text = "Đã duyệt";
                NhatKy nhatKy = new NhatKy(UserID, "M.TangCa");
                string hanhDong = $"Cập nhật trạng thái tăng ca ID: {idTangCa} thành 'Đã duyệt'";
                DateTime recentTime = DateTime.Now;
                nhatKy.ThemNhatKy(UserID, hanhDong, recentTime, ref err);
            }
            else
            {
                MessageBox.Show("Cập nhật trạng thái thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            TangCa tangCa = new TangCa(UserID, "M.TangCa");
            string err = "";
            if (tangCa.CapNhatTrangThaiTangCa(idTangCa, "Từ chối", ref err))
            {
                MessageBox.Show("Cập nhật trạng thái thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbTrangThai.Text = "Từ chối";
                NhatKy nhatKy = new NhatKy(UserID, "M.TangCa");
                string hanhDong = $"Cập nhật trạng thái tăng ca ID: {idTangCa} thành 'Từ chối'";
                DateTime recentTime = DateTime.Now;
                nhatKy.ThemNhatKy(UserID, hanhDong, recentTime, ref err);
            }
            else
            {
                MessageBox.Show("Cập nhật trạng thái thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void M_UC_ItemTangCa_MouseLeave(object sender, EventArgs e)
        {
            if (!this.ClientRectangle.Contains(this.PointToClient(Cursor.Position)))
            {
                guna2PictureBox1.Visible = false;
                guna2PictureBox2.Visible = false;
            }
        }

        private void M_(object sender, EventArgs e)
        {
            TangCa tangCa = new TangCa(UserID, "M.TangCa");
            if (tangCa.LayTrangThaiTangCaTheoTangCaID(this.idTangCa) == "Chưa duyệt")
            {
                guna2PictureBox1.Visible = true; // Hiển thị biểu tượng duyệt
                guna2PictureBox2.Visible = true; // Hiển thị biểu tượng từ chối
            }
            else
            {
                guna2PictureBox1.Visible = false;
                guna2PictureBox2.Visible = false;
            }
        }
    }
}
