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
        private int thang;
        private int nam;
        private float luongCoBan;
        private float phuCap;
        private float tongLuong;

        public SalaryItem1(int thang, int nam, float luongCoBan, float phuCap, float tongLuong)
        {
            InitializeComponent();
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
            lbTong.Text = tongLuong.ToString("N0");
        }

        private void lbNam_Click(object sender, EventArgs e)
        {

        }

        private void lbPhuCap_Click(object sender, EventArgs e)
        {

        }
    }
}
