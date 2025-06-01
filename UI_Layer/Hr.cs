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

        private void btnPersonalInfor_Click(object sender, EventArgs e)
        {
            this.Panel2.Controls.Clear();
            PersonalInformation uC_PersonalInformation = new PersonalInformation(this.UserID);
            int x = (Panel2.Width - uC_PersonalInformation.Width) / 2;
            int y = (Panel2.Height - uC_PersonalInformation.Height) / 2;
            uC_PersonalInformation.Location = new Point(x, y);
            this.Panel2.Controls.Add(uC_PersonalInformation);
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            this.Panel2.Controls.Clear();
            SalaryInformation uC_SalaryInformation = new SalaryInformation(this.UserID);
            int x = (Panel2.Width - uC_SalaryInformation.Width) / 2;
            int y = (Panel2.Height - uC_SalaryInformation.Height) / 2;
            uC_SalaryInformation.Location = new Point(x, y);
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
            int x = (Panel2.Width - h_NhanVienShow.Width) / 2;
            int y = (Panel2.Height - h_NhanVienShow.Height) / 2;
            h_NhanVienShow.Location = new Point(x, y);
            this.Panel2.Controls.Add(h_NhanVienShow);
        }

        private void btnContract_Click(object sender, EventArgs e)
        {
            this.Panel2.Controls.Clear();
            H_HopDongShow h_hopdongshow = new H_HopDongShow(this.UserID, "HR.HopDong");
            int x = (Panel2.Width - h_hopdongshow.Width) / 2;
            int y = (Panel2.Height - h_hopdongshow.Height) / 2;
            h_hopdongshow.Location = new Point(x, y);
            this.Panel2.Controls.Add(h_hopdongshow);
        }
    }
}
