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
            personalInformation.Dock = DockStyle.Fill;
            personalInformation.Location = new Point(0, 0);
            this.guna2Panel2.Controls.Add(personalInformation);
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            this.guna2Panel2.Controls.Clear();
            SalaryInformation salaryInformation = new SalaryInformation(this.UserID);
            salaryInformation.Dock = DockStyle.Fill;
            salaryInformation.Location = new Point(0, 0);
            this.guna2Panel2.Controls.Add(salaryInformation);
        }

        private void btnPhongBan_Click(object sender, EventArgs e)
        {
            this.guna2Panel2.Controls.Clear();

        }

        private void phancongcongtrinhbtn_Click(object sender, EventArgs e)
        {
            this.guna2Panel2.Controls.Clear();
            M_UC_QuanLyPhanCongCongTrinh m = new M_UC_QuanLyPhanCongCongTrinh(UserID, 1, "Admin");
            m.Dock = DockStyle.Fill;
            m.Location = new Point(0, 0);
            this.guna2Panel2.Controls.Add(m);
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.guna2Panel2.Controls.Clear();
            Users_UC users_UC = new Users_UC(this.UserID);
            users_UC.Dock = DockStyle.Fill;
            users_UC.Location = new Point(0, 0);
            this.guna2Panel2.Controls.Add(users_UC);
        }
    }
}
