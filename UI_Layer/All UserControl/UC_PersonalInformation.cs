using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNS.BL_Layer;

namespace QLNS.UI_Layer.All_UserControl
{
    public partial class UC_PersonalInformation : UserControl
    {
        private int UserID;
        private String functionName = "Admin";


        int NhanVienID;
        String HoTen;
        String NgaySinh;
        String CMND;
        String MaSoThue;
        int PhongBanID;
        int ChucVuID;
        String TrangThai;
        public UC_PersonalInformation(int UserID)
        {
            InitializeComponent();
            this.UserID = UserID;
            LoadData();
        }
        public void LoadData()
        {
            NhanVien nhanVien = new NhanVien(this.UserID, this.functionName);
            string err = "";
            this.NhanVienID = nhanVien.LayNhanVienIDtheoUserID(ref err);
            DataSet ds = nhanVien.LayNhanVienTheoID(this.NhanVienID);
            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show("Lỗi khi lấy NhanVienID: " + err);
                return;
            }
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                this.HoTen = ds.Tables[0].Rows[0]["HoTen"].ToString();
                this.NgaySinh = ds.Tables[0].Rows[0]["NgaySinh"].ToString();
                this.CMND = ds.Tables[0].Rows[0]["CMND"].ToString();
                this.MaSoThue = ds.Tables[0].Rows[0]["MaSoThue"].ToString();
                this.PhongBanID = Convert.ToInt32(ds.Tables[0].Rows[0]["PhongBanID"]);
                this.ChucVuID = Convert.ToInt32(ds.Tables[0].Rows[0]["ChucVuID"]);
                this.TrangThai = ds.Tables[0].Rows[0]["TrangThai"].ToString();
            }
        }

        private void UC_PersonalInformation_Load(object sender, EventArgs e)
        {
            PhongBan phongBan = new PhongBan(this.UserID, this.functionName);
            this.lbDepartment.Text = phongBan.LayTenPhongBanTheoID(this.PhongBanID);
            ChucVu chucVu = new ChucVu(this.UserID, this.functionName);
            this.lbPos.Text = chucVu.LayTenChucVuTheoID(this.ChucVuID);
            this.lbEployeeID.Text = this.NhanVienID.ToString();
            this.lbEmployeeName.Text = this.HoTen;
            this.lbFullName.Text = this.HoTen;
            this.lbCCCD.Text = this.CMND;
            this.lbMaSoThue.Text = this.MaSoThue;
            DateTime ngaySinh = DateTime.Parse(NgaySinh);
            this.lbDateofBirth.Text = ngaySinh.ToString("dd/MM/yyyy");

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbFullName_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            // Hiển thị MessageBox với 2 nút Yes và No
            DialogResult result = MessageBox.Show(
                "Do you want change?",
                "Choose",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                // Người chơi chọn "Yes" -> đổi ảnh
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Chọn ảnh đại diện";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    guna2PictureBox1.Image = Image.FromFile(filePath);
                }
            }
            else if (result == DialogResult.No)
            {
                //Do noth
            }
        }

    }
}
