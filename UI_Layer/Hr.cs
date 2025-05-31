using QLNS.UI_Layer.All_UserControl;
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
    public partial class Hr : Form
    {
        int UserID;
        public Hr(int UserID)
        {
            InitializeComponent();
            this.UserID = UserID;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnPersonalInfor_Click(object sender, EventArgs e)
        {
            this.Panel2.Controls.Clear();

            PersonalInformation uC_PersonalInformation = new PersonalInformation(this.UserID);
            uC_PersonalInformation.Dock = DockStyle.Fill;
            this.Panel2.Controls.Add(uC_PersonalInformation);
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            this.Panel2.Controls.Clear();

            SalaryInformation uC_SalaryInformation = new SalaryInformation(this.UserID);
            uC_SalaryInformation.Dock = DockStyle.Fill;
            this.Panel2.Controls.Add(uC_SalaryInformation);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void btnEmloyee_Click(object sender, EventArgs e)
        {
            this.Panel2.Controls.Clear();
            H_NhanVienShow h_NhanVienShow = new H_NhanVienShow(this.UserID, "HR.NhanVien");
            h_NhanVienShow.Dock = DockStyle.Fill;
            this.Panel2.Controls.Add(h_NhanVienShow);
        }

        private void btnContract_Click(object sender, EventArgs e)
        {
            this.Panel2.Controls.Clear();
            H_HopDongShow h_hopdongshow = new H_HopDongShow(this.UserID, "HR.HopDong");
            h_hopdongshow.Dock = DockStyle.Fill;
            this.Panel2.Controls.Add(h_hopdongshow);
        }
    }
}
