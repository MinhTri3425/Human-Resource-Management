using QLNS.UI_Layer.All_UserControl.Accountant_UC;
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
    public partial class SalaryItem1 : UserControl
    {
        private int userID;
        private int luongID;
        private int nhanVienID;
        private int thang;
        private int nam;
        private decimal luongCoBan;
        private decimal phuCap;
        private decimal tongLuong;

        public SalaryItem1(int userID, int luongID, int nhanVienID, int thang, int nam, decimal luongCoBan, decimal phuCap, decimal tongLuong)
        {
            InitializeComponent();
            this.userID = userID;
            this.luongID = luongID;
            this.nhanVienID = nhanVienID;
            this.thang = thang;
            this.nam = nam;
            this.luongCoBan = luongCoBan;
            this.phuCap = phuCap;
            this.tongLuong = tongLuong;
        }

        private void SalaryItem_Load(object sender, EventArgs e)
        {
            lbThang.Text = thang.ToString();
            lbNam.Text = nam.ToString();
            lbLuongCoBan.Text = luongCoBan.ToString("N0");
            lbPhuCap.Text = phuCap.ToString("N0");
            A_UC_SalaryItem a_UC_SalaryItem = new A_UC_SalaryItem(userID, luongID, nhanVienID, thang, nam, luongCoBan, phuCap, tongLuong, "Đã duyệt", null);
            lbTong.Text = a_UC_SalaryItem.tinhTongLuong().ToString("N0");
        }

        private void lbNam_Click(object sender, EventArgs e)
        {

        }

        private void lbPhuCap_Click(object sender, EventArgs e)
        {

        }
    }
}
