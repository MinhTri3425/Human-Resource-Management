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
    public partial class M_UC_PAMItem : UserControl
    {
        int UserID;
        string functionName;
        int CongTrinhID;
        int NhanVienID;
        DateTime NgayPhanCong;
        string loaiPhanCong;
        string trangThai;

        public M_UC_PAMItem(int UserID, string functionName, int congTrinhID, int nhanVienID, DateTime ngayPhanCong, string loaiPhanCong, string trangThai)
        {
            InitializeComponent();
            this.UserID = UserID;
            this.functionName = functionName;
            this.CongTrinhID = congTrinhID;
            this.NhanVienID = nhanVienID;
            this.NgayPhanCong = ngayPhanCong;
            this.loaiPhanCong = loaiPhanCong;
            this.trangThai = trangThai;
            this.guna2PictureBox1.Visible = false;
            this.guna2PictureBox2.Visible = false;
        }

        private void M_UC_PAMItem_Load(object sender, EventArgs e)
        {

            this.lbCongTrinhID.Text = CongTrinhID.ToString();
            this.lbNhanVienID.Text = NhanVienID.ToString();
            this.lbngay.Text = NgayPhanCong.ToString("dd/MM/yyyy");
            this.lbloai.Text = loaiPhanCong;
            this.lbstatus.Text = trangThai;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            PhanCongCongTrinh phanCongCongTrinh = new PhanCongCongTrinh(UserID, functionName);
            string err = "";
            if (phanCongCongTrinh.CapNhatPhanCongCongTrinh(NhanVienID,CongTrinhID, NgayPhanCong, loaiPhanCong, "Đã duyệt", ref err))
            {
                MessageBox.Show("Cập nhật trạng thái thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbstatus.Text = "Đã duyệt";
                NhatKy nhatKy = new NhatKy(UserID, "M.TangCa");
                string hanhDong = $"Đã duyệt phân công công trình ID: {CongTrinhID}";
                DateTime recentTime = DateTime.Now;
                nhatKy.ThemNhatKy(UserID, hanhDong, recentTime, ref err);
            }
        }

        private void guna2PictureBox2_Click_1(object sender, EventArgs e)
        {
            PhanCongCongTrinh phanCongCongTrinh = new PhanCongCongTrinh(UserID, functionName);
            string err = "";
            if (phanCongCongTrinh.CapNhatPhanCongCongTrinh(NhanVienID, CongTrinhID, NgayPhanCong, loaiPhanCong, "Từ chối", ref err))
            {
                MessageBox.Show("Cập nhật trạng thái thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbstatus.Text = "Từ chối";
                NhatKy nhatKy = new NhatKy(UserID, "M.TangCa");
                string hanhDong = $"Đã từ chối phân công công trình ID: {CongTrinhID}";
                DateTime recentTime = DateTime.Now;
                nhatKy.ThemNhatKy(UserID, hanhDong, recentTime, ref err);
            }
            else
            {
                MessageBox.Show("Cập nhật trạng thái thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Leave1(object sender, EventArgs e)
        {
            if (!this.ClientRectangle.Contains(this.PointToClient(Cursor.Position)))
            {
                guna2PictureBox1.Visible = false;
                guna2PictureBox2.Visible = false;
            }
        }

        private void Enter1(object sender, EventArgs e)
        {
            PhanCongCongTrinh phanCongCongTrinh = new PhanCongCongTrinh(UserID, functionName);
            string err = "";
            if (phanCongCongTrinh.LayTrangThaiPhanCong(NhanVienID, CongTrinhID, ref err) == "Chưa duyệt")
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
