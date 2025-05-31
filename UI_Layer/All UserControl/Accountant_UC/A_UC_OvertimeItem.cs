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

namespace QLNS.UI_Layer.All_UserControl
{
    public partial class A_UC_OvertimeItem : UserControl
    {
        private int UserID;
        private string functionName;
        private int TangCaID;
        private int NhanVienID;
        private string ngay;
        private string gioBatDau;
        private string gioKetThuc;
        private string loaiTangCa;
        private string hinhThuc;
        private string trangThai;
        public A_UC_OvertimeItem(int UserID, string functionName, int TangCaID, int NhanVienID, string ngay, string gioBatDau, string gioKetThuc, string loaiTangCa, string hinhThuc, string trangThai)
        {
            InitializeComponent();
            this.UserID = UserID;
            this.functionName = functionName;
            this.TangCaID = TangCaID;
            this.NhanVienID = NhanVienID;
            this.ngay = ngay;
            this.gioBatDau = gioBatDau;
            this.gioKetThuc = gioKetThuc;
            this.loaiTangCa = loaiTangCa;
            this.hinhThuc = hinhThuc;
            this.trangThai = trangThai;

            this.picDuyet.Visible = false;
            this.picTuChoi.Visible = false; 
        }
        public A_UC_OvertimeItem()
        {
            InitializeComponent();
        }

        private void A_UC_OvertimeItem_Load(object sender, EventArgs e)
        {
            lbtangcaid.Text = TangCaID.ToString();
            lbnhanvienid.Text = NhanVienID.ToString();
            DateTime Date = DateTime.Parse(ngay);
            lbngay.Text = Date.ToString("dd/MM/yyyy");
            lbgiobatdau.Text = gioBatDau;
            lbgioketthuc.Text = gioKetThuc;
            lbloaitangca.Text = loaiTangCa;
            lbhinhthuc.Text = hinhThuc;
            lbtrangthai.Text = trangThai;
        }

        private void lbngay_Click(object sender, EventArgs e)
        {

        }

        private void lbgiobatdau_Click(object sender, EventArgs e)
        {

        }

        private void A_UC_OvertimeItem_MouseEnter(object sender, EventArgs e)
        {
            if (functionName.Equals("Admin", StringComparison.OrdinalIgnoreCase)
        && trangThai.Equals("Chưa duyệt", StringComparison.OrdinalIgnoreCase))
            {
                picDuyet.Visible = true;
                picTuChoi.Visible = true;
            }
        }

        private void A_UC_OvertimeItem_MouseLeave(object sender, EventArgs e)
        {
            if (!this.ClientRectangle.Contains(this.PointToClient(Cursor.Position)))
            {
                picDuyet.Visible = false;
                picTuChoi.Visible = false;
            }
        }

        private void picDuyet_Click(object sender, EventArgs e)
        {
            TangCa tangCa = new TangCa(UserID, functionName);
            string err = "";

            if (tangCa.CapNhatTrangThaiTangCa(TangCaID, "Đã duyệt", ref err))
            {
                MessageBox.Show("Duyệt tăng ca thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                trangThai = "Đã duyệt"; // Cập nhật trạng thái trong biến
                lbtrangthai.Text = trangThai;

                // Ghi nhật ký
                NhatKy nhatKy = new NhatKy(UserID, "A.TangCa");
                string hanhDong = $"Duyệt tăng ca ID: {TangCaID}";
                nhatKy.ThemNhatKy(UserID, hanhDong, DateTime.Now, ref err);

                // Ẩn nút sau khi duyệt
                picDuyet.Visible = false;
                picTuChoi.Visible = false;
            }
            else
            {
                MessageBox.Show("Duyệt thất bại!\n" + err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picTuChoi_Click(object sender, EventArgs e)
        {
            TangCa tangCa = new TangCa(UserID, functionName);
            string err = "";

            if (tangCa.CapNhatTrangThaiTangCa(TangCaID, "Từ chối", ref err))
            {
                MessageBox.Show("Từ chối tăng ca thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                trangThai = "Từ chối";
                lbtrangthai.Text = trangThai;

                NhatKy nhatKy = new NhatKy(UserID, "A.TangCa");
                string hanhDong = $"Từ chối tăng ca ID: {TangCaID}";
                nhatKy.ThemNhatKy(UserID, hanhDong, DateTime.Now, ref err);

                picDuyet.Visible = false;
                picTuChoi.Visible = false;
            }
            else
            {
                MessageBox.Show("Từ chối thất bại!\n" + err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
