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
    public partial class FormThemNhanVien : Form
    {
        string functionName = "Admin";
        int userID;
        public FormThemNhanVien(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string HoTen = TbxHoten.Text;
            DateTime ngaySinh = NgaySinh.Value;
            string cmnd = TbxCMND.Text;
            string mst = TbxMaThue.Text;
            int id_PhongBan = Convert.ToInt32(TbxIDPhong.Text);
            int id_ChucVu = Convert.ToInt32(TbxIDChucVu.Text);
            string trangthai = CboxTrangThai.SelectedItem?.ToString();
            string err = "";
            NhanVien nv = new NhanVien(userID, "HR.NhanVien");
            bool result = nv.ThemNhanVien(HoTen, ngaySinh, cmnd, mst, id_PhongBan, id_ChucVu, trangthai, ref err);

            if (result)
            {
                MessageBox.Show("Thêm thành công!");
                this.DialogResult = DialogResult.OK;
                NhatKy nhatKy = new NhatKy(userID, functionName);
                string hanhDong = $"Thêm nhân viên có họ tên: {HoTen}";
                DateTime recentTime = DateTime.Now;
                nhatKy.ThemNhatKy(this.userID, hanhDong, recentTime, ref err);
            }
            else
            {
                MessageBox.Show("Lỗi: " + err);
            }
        }

        private void ThemNhanVien_Load(object sender, EventArgs e)
        {
            CboxTrangThai.Items.Clear();
            CboxTrangThai.Items.Add("Đang công tác");
            CboxTrangThai.Items.Add("Dừng công tác");
            CboxTrangThai.SelectedIndex = 0; 
        }
    }
}
