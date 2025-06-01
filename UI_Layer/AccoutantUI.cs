using QLNS.UI_Layer.All_UserControl;
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
    public partial class AccoutantUI : Form
    {
        private int UserID;
        public AccoutantUI(int userID)
        {
            InitializeComponent();
            UserID = userID;
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

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.guna2Panel2.Controls.Clear();
            A_UC_OverTime overtime = new A_UC_OverTime(this.UserID, "A.TangCa");
            int x = (guna2Panel2.Width - overtime.Width) / 2;
            int y = (guna2Panel2.Height - overtime.Height) / 2;
            overtime.Location = new Point(x, y);
            this.guna2Panel2.Controls.Add(overtime);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
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

        private void btnContract_Click(object sender, EventArgs e)
        {
            this.guna2Panel2.Controls.Clear();
            Contract contract = new Contract(this.UserID);
            int x = (guna2Panel2.Width - contract.Width) / 2;
            int y = (guna2Panel2.Height - contract.Height) / 2;
            contract.Location = new Point(x, y);
            this.guna2Panel2.Controls.Add(contract);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.guna2Panel2.Controls.Clear();
            A_UC_Timekeeping timekeeping = new A_UC_Timekeeping(this.UserID, "A.ChamCong");
            int x = (guna2Panel2.Width - timekeeping.Width) / 2;
            int y = (guna2Panel2.Height - timekeeping.Height) / 2;
            timekeeping.Location = new Point(x, y);
            this.guna2Panel2.Controls.Add(timekeeping);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            this.guna2Panel2.Controls.Clear();
            A_UC_Leave leave = new A_UC_Leave(this.UserID, "A.NghiPhep");
            int x = (guna2Panel2.Width - leave.Width) / 2;
            int y = (guna2Panel2.Height - leave.Height) / 2;
            leave.Location = new Point(x, y);
            this.guna2Panel2.Controls.Add(leave);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.guna2Panel2.Controls.Clear();
            A_UC_Salary salary = new A_UC_Salary(this.UserID, "A.Luong");
            int x = (guna2Panel2.Width - salary.Width) / 2;
            int y = (guna2Panel2.Height - salary.Height) / 2;
            salary.Location = new Point(x, y);
            this.guna2Panel2.Controls.Add(salary);
        }
    }
}
