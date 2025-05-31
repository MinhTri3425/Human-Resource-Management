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
    public partial class A_UC_LeaveItem : UserControl
    {
        private int UserID;
        private string functionName;
        private int NghiPhepID;
        private int NhanVienID;
        private string ngaybatdau;
        private string ngayketthuc;
        private string loai;
        private string trangthai;

        private Action reloadCallback;
        public A_UC_LeaveItem(int UserID, string functionName, int nghiPhepID, int nhanVienID, string ngaybatdau, string ngayketthuc, string loai, string trangthai, Action reloadCallback)
        {
            InitializeComponent();
            this.UserID = UserID;
            this.functionName = functionName;
            this.NghiPhepID = nghiPhepID;
            this.NhanVienID = nhanVienID;
            this.ngaybatdau = ngaybatdau;
            this.ngayketthuc = ngayketthuc;
            this.loai = loai;
            this.trangthai = trangthai;
            this.reloadCallback = reloadCallback;

            this.picDuyet.Visible = false;
            this.picTuChoi.Visible = false;
        }

        private void A_UC_LeaveItem_Load(object sender, EventArgs e)
        {
            this.lbnghiphepid.Text = NghiPhepID.ToString();
            this.lbnhanvienid.Text = NhanVienID.ToString();
            DateTime startDate = DateTime.Parse(ngaybatdau);
            this.lbngaybatdau.Text = startDate.ToString("dd/MM/yyyy");
            DateTime endDate = DateTime.Parse(ngayketthuc);
            this.lbngayketthuc.Text = endDate.ToString("dd/MM/yyyy");
            this.lbloainghiphep.Text = loai;
            this.lbtrangthai.Text = trangthai;
        }

        private void A_UC_LeaveItem_MouseEnter(object sender, EventArgs e)
        {
            if (functionName.Equals("Admin", StringComparison.OrdinalIgnoreCase)
        && trangthai.Equals("Chưa duyệt", StringComparison.OrdinalIgnoreCase))
            {
                picDuyet.Visible = true;
                picTuChoi.Visible = true;
            }
        }

        private void A_UC_LeaveItem_MouseLeave(object sender, EventArgs e)
        {
            if (!this.ClientRectangle.Contains(this.PointToClient(Cursor.Position)))
            {
                picDuyet.Visible = false;
                picTuChoi.Visible = false;
            }
        }

        private void picDuyet_Click(object sender, EventArgs e)
        {
            string err = "";
            NghiPhep nghiPhep = new NghiPhep(UserID, functionName);
            bool result = nghiPhep.CapNhatTrangThaiNghiPhep(NghiPhepID, "Đã duyệt", ref err);

            if (result)
            {
                // Cập nhật giao diện
                trangthai = "Đã duyệt";
                lbtrangthai.Text = trangthai;

                // Ghi nhật ký
                NhatKy nhatKy = new NhatKy(UserID, functionName);
                string hanhDong = $"Duyệt nghỉ phép ID: {NghiPhepID}";
                nhatKy.ThemNhatKy(UserID, hanhDong, DateTime.Now, ref err);

                // Ẩn nút
                picDuyet.Visible = false;
                picTuChoi.Visible = false;

                MessageBox.Show("Đã duyệt nghỉ phép!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reload nếu cần
                reloadCallback?.Invoke();
            }
            else
            {
                MessageBox.Show("Duyệt thất bại: " + err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picTuChoi_Click(object sender, EventArgs e)
        {
            string err = "";
            NghiPhep nghiPhep = new NghiPhep(UserID, functionName);
            bool result = nghiPhep.CapNhatTrangThaiNghiPhep(NghiPhepID, "Từ chối", ref err);

            if (result)
            {
                trangthai = "Từ chối";
                lbtrangthai.Text = trangthai;

                NhatKy nhatKy = new NhatKy(UserID, functionName);
                string hanhDong = $"Từ chối nghỉ phép ID: {NghiPhepID}";
                nhatKy.ThemNhatKy(UserID, hanhDong, DateTime.Now, ref err);

                picDuyet.Visible = false;
                picTuChoi.Visible = false;

                MessageBox.Show("Đã từ chối nghỉ phép!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                reloadCallback?.Invoke();
            }
            else
            {
                MessageBox.Show("Từ chối thất bại: " + err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
