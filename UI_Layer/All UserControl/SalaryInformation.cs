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
    public partial class SalaryInformation : UserControl
    {

        private int UserID;
        private String functionName = "Admin";

        DataSet ds;

        int nhanVienID;
        String hoTenNhanVien;
        int chucVuID; 

        public SalaryInformation(int userID)
        {
            InitializeComponent();
            UserID = userID;
            LoadData();
        }


        public void LoadData()
        {
            NhanVien nhanVien = new NhanVien(this.UserID, this.functionName);
            string err = "";
            nhanVienID = nhanVien.LayNhanVienIDtheoUserID(ref err);
            DataSet thongtinNhanVien = nhanVien.LayNhanVienTheoID(this.nhanVienID);
            if (thongtinNhanVien != null && thongtinNhanVien.Tables.Count > 0 && thongtinNhanVien.Tables[0].Rows.Count > 0)
            {
                this.hoTenNhanVien = thongtinNhanVien.Tables[0].Rows[0]["HoTen"].ToString();
                this.chucVuID = Convert.ToInt32(thongtinNhanVien.Tables[0].Rows[0]["ChucVuID"]);
            }
            LoadSalary();
        }

        private void LoadSalary()
        {
            Luong luong = new Luong(this.UserID, this.functionName);
            ds = luong.LayLuongTheoNhanVienID(this.nhanVienID);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UC_SalaryInformation_Load(object sender, EventArgs e)
        {
            this.lbFullName.Text = this.hoTenNhanVien;
            ChucVu chucVu = new ChucVu(this.UserID, this.functionName);
            this.lbChucVu.Text = chucVu.LayTenChucVuTheoID(this.chucVuID);
            Luong luong = new Luong(this.UserID, this.functionName);
            int luongID = luong.LayLuongIDTheoNhanVienID(this.nhanVienID);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                int thang = Convert.ToInt32(row["Thang"]);
                int nam = Convert.ToInt32(row["Nam"]);
                decimal luongCoBan = Convert.ToDecimal(row["LuongCoBan"]);
                decimal phuCap = Convert.ToDecimal(row["PhuCap"]);
                decimal tongLuong = Convert.ToDecimal(row["TongLuong"]);
                SalaryItem1 salaryItem = new SalaryItem1(UserID, luongID, nhanVienID, thang, nam, luongCoBan, phuCap, tongLuong);
                salaryItem.Dock = DockStyle.Top;
                this.flowLayoutPanel1.Controls.Add(salaryItem);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
