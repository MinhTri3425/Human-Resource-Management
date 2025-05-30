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
    public partial class M_UC_ItemQuanLiNghiPhep : UserControl
    {
        int idNghiPhep;
        string hoTenNhanVien;
        string ngayBatDau;
        string ngayKetThuc;
        string loaiNghiPhep;
        string trangThai;

        int userID;
        string functionName;
        Action reloadCallback;


        public M_UC_ItemQuanLiNghiPhep(int idNghiPhep, string hoTenNhanVien, string ngayBatDau, string ngayKetThuc, string loaiNghiPhep, string trangThai, int userID, string functionName, Action reloadCallback)
        {
            InitializeComponent();
            this.idNghiPhep = idNghiPhep;
            this.hoTenNhanVien = hoTenNhanVien;
            this.ngayBatDau = ngayBatDau;
            this.ngayKetThuc = ngayKetThuc;
            this.loaiNghiPhep = loaiNghiPhep;
            this.trangThai = trangThai;
            this.userID = userID;
            this.functionName = functionName;
            this.reloadCallback = reloadCallback;
            this.guna2PictureBox1.Visible = false;
            this.guna2PictureBox2.Visible = false;
        }

        private void M_UC_ItemQuanLiNghiPhep_Load(object sender, EventArgs e)
        {
            lbIDNghiPhep.Text = idNghiPhep.ToString();
            lbTenNhanVien.Text = hoTenNhanVien;
            lbNgayBatDau.Text = ngayBatDau;
            lbNgayKetThuc.Text = ngayKetThuc;
            lbLoai.Text = loaiNghiPhep;
            lbTrangThai.Text = trangThai;
        }
        private void M_UC_ItemQuanLiNghiPhep_MouseLeave(object sender, EventArgs e)
        {
            if (!this.ClientRectangle.Contains(this.PointToClient(Cursor.Position)))
            {
                this.guna2PictureBox1.Visible = false;
                this.guna2PictureBox2.Visible = false;
            }
        }

        private void M_UC_ItemQuanLiNghiPhep_MouseEnter(object sender, EventArgs e)
        {
            NghiPhep nghiPhep = new NghiPhep(userID, functionName);
            if (nghiPhep.LayTrangThaiNghiPhepTheoNghiPhepID(this.idNghiPhep) == "Chưa duyệt")
            {
                this.guna2PictureBox1.Visible = true;
                this.guna2PictureBox2.Visible = true;
            }
            else
            {
                this.guna2PictureBox1.Visible = false;
                this.guna2PictureBox2.Visible = false;
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            NghiPhep nghiPhep = new NghiPhep(this.userID, this.functionName);
            string err = "";
            if (nghiPhep.CapNhatTrangThaiNghiPhep(idNghiPhep, "Đã duyệt", ref err))
            {
                MessageBox.Show("Cập nhật trạng thái thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbTrangThai.Text = "Đã duyệt";
                NhatKy nhatKy = new NhatKy(this.userID, this.functionName);
                string hanhDong = $"Cập nhật trạng thái nghỉ phép ID: {this.idNghiPhep} thành 'Đã duyệt'";
                DateTime recentTime = DateTime.Now;
                nhatKy.ThemNhatKy(this.userID, hanhDong, recentTime, ref err);
            }
            else
            {
                MessageBox.Show("Cập nhật trạng thái thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            NghiPhep nghiPhep = new NghiPhep(this.userID, this.functionName);
            string err = "";
            if (nghiPhep.CapNhatTrangThaiNghiPhep(idNghiPhep, "Từ chối", ref err))
            {
                MessageBox.Show("Cập nhật trạng thái thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbTrangThai.Text = "Từ chối";
                NhatKy nhatKy = new NhatKy(this.userID, this.functionName);
                string hanhDong = $"Cập nhật trạng thái nghỉ phép ID: {this.idNghiPhep} thành 'Từ chối'";
                DateTime recentTime = DateTime.Now;
                nhatKy.ThemNhatKy(this.userID, hanhDong, recentTime, ref err);
            }
            else
            {
                MessageBox.Show("Cập nhật trạng thái thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
