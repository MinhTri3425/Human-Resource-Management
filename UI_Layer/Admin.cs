using QLNS.UI_Layer.All_UserControl;
using QLNS.UI_Layer.All_UserControl.Admin_UC;
using QLNS.UI_Layer.All_UserControl.Manager_UC;
using QLNS.UI_Layer.HR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS.UI_Layer
{
    public partial class Admin : Form
    {
        private int UserID;
        public Admin(int userID)
        {
            InitializeComponent();
            UserID = userID;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPersonalInfor_Click(object sender, EventArgs e)
        {
            this.guna2Panel2.Controls.Clear();
            PersonalInformation personalInformation = new PersonalInformation(this.UserID);
            int x = (guna2Panel2.Width - personalInformation.Width) / 2;
            int y = (guna2Panel2.Height - personalInformation.Height) / 2;
            personalInformation.Location = new Point(x, y);
            this.guna2Panel2.Controls.Add(personalInformation);
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            this.guna2Panel2.Controls.Clear();
            SalaryInformation salaryInformation = new SalaryInformation(this.UserID);
            int x = (guna2Panel2.Width - salaryInformation.Width) / 2;
            int y = (guna2Panel2.Height - salaryInformation.Height) / 2;
            salaryInformation.Location = new Point(x, y);
            this.guna2Panel2.Controls.Add(salaryInformation);
        }

        private void phancongcongtrinhbtn_Click(object sender, EventArgs e)
        {
            this.guna2Panel2.Controls.Clear();
            M_UC_QuanLyPhanCongCongTrinh m = new M_UC_QuanLyPhanCongCongTrinh(UserID, 1, "Admin");
            int x = (guna2Panel2.Width - m.Width) / 2;
            int y = (guna2Panel2.Height - m.Height) / 2;
            m.Location = new Point(x, y);
            this.guna2Panel2.Controls.Add(m);
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.guna2Panel2.Controls.Clear();
            Users_UC users_UC = new Users_UC(this.UserID);
            int x = (guna2Panel2.Width - users_UC.Width) / 2;
            int y = (guna2Panel2.Height - users_UC.Height) / 2;
            users_UC.Location = new Point(x, y);
            this.guna2Panel2.Controls.Add(users_UC);
        }

        private void btnTangCa_Click(object sender, EventArgs e)
        {
            this.guna2Panel2.Controls.Clear();
            A_UC_OverTime a_UC_OverTime = new A_UC_OverTime(this.UserID, "Admin");
            int x = (guna2Panel2.Width - a_UC_OverTime.Width) / 2;
            int y = (guna2Panel2.Height - a_UC_OverTime.Height) / 2;
            a_UC_OverTime.Location = new Point(x, y);
            this.guna2Panel2.Controls.Add(a_UC_OverTime);
        }

        private void btnNghiPhep_Click(object sender, EventArgs e)
        {
            this.guna2Panel2.Controls.Clear();
            A_UC_Leave a_UC_NghiPhep = new A_UC_Leave(this.UserID, "Admin");
            int x = (guna2Panel2.Width - a_UC_NghiPhep.Width) / 2;
            int y = (guna2Panel2.Height - a_UC_NghiPhep.Height) / 2;
            a_UC_NghiPhep.Location = new Point(x, y);
            this.guna2Panel2.Controls.Add(a_UC_NghiPhep);
        }

        private void btnCongTrinh_Click(object sender, EventArgs e)
        {
            this.guna2Panel2.Controls.Clear();
            Ad_UC_QuanLiCongTrinh ad_UC_QuanLiCongTrinh = new Ad_UC_QuanLiCongTrinh(this.UserID, "Admin");
            int x = (guna2Panel2.Width - ad_UC_QuanLiCongTrinh.Width) / 2;
            int y = (guna2Panel2.Height - ad_UC_QuanLiCongTrinh.Height) / 2;
            ad_UC_QuanLiCongTrinh.Location = new Point(x, y);
            this.guna2Panel2.Controls.Add(ad_UC_QuanLiCongTrinh);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.guna2Panel2.Controls.Clear();
            ChucVuShow chucVuShow = new ChucVuShow(this.UserID, "Admin");
            int x = (guna2Panel2.Width - chucVuShow.Width) / 2;
            int y = (guna2Panel2.Height - chucVuShow.Height) / 2;
            chucVuShow.Location = new Point(x, y);
            this.guna2Panel2.Controls.Add(chucVuShow);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.guna2Panel2.Controls.Clear();
            NhatKyShow nhatKyShow = new NhatKyShow(this.UserID, "Admin");
            int x = (guna2Panel2.Width - nhatKyShow.Width) / 2;
            int y = (guna2Panel2.Height - nhatKyShow.Height) / 2;
            nhatKyShow.Location = new Point(x, y);
            this.guna2Panel2.Controls.Add(nhatKyShow);
        }

        private void btnEmloyee_Click(object sender, EventArgs e)
        {
            H_NhanVienShow h_NhanVienShow = new H_NhanVienShow(this.UserID, "Admin");
            this.guna2Panel2.Controls.Clear();
            int x = (guna2Panel2.Width - h_NhanVienShow.Width) / 2;
            int y = (guna2Panel2.Height - h_NhanVienShow.Height) / 2;
            h_NhanVienShow.Location = new Point(x, y);
            this.guna2Panel2.Controls.Add(h_NhanVienShow);
        }


        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            A_UC_Salary a_UC_Salary = new A_UC_Salary(this.UserID, "Admin");
            this.guna2Panel2.Controls.Clear();
            int x = (guna2Panel2.Width - a_UC_Salary.Width) / 2;
            int y = (guna2Panel2.Height - a_UC_Salary.Height) / 2;
            a_UC_Salary.Location = new Point(x, y);
            this.guna2Panel2.Controls.Add(a_UC_Salary);
        }

        private void btnContract_Click(object sender, EventArgs e)
        {
            H_HopDongShow h_HopDongShow = new H_HopDongShow(this.UserID, "Admin");
            this.guna2Panel2.Controls.Clear();
            int x = (guna2Panel2.Width - h_HopDongShow.Width) / 2;
            int y = (guna2Panel2.Height - h_HopDongShow.Height) / 2;
            h_HopDongShow.Location = new Point(x, y);
            this.guna2Panel2.Controls.Add(h_HopDongShow);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            A_UC_Timekeeping a_UC_Timekeeping = new A_UC_Timekeeping(this.UserID, "Admin");
            this.guna2Panel2.Controls.Clear();
            int x = (guna2Panel2.Width - a_UC_Timekeeping.Width) / 2;
            int y = (guna2Panel2.Height - a_UC_Timekeeping.Height) / 2;
            a_UC_Timekeeping.Location = new Point(x, y);    
            this.guna2Panel2.Controls.Add(a_UC_Timekeeping);
        }
    }
}
