using QLNS.UI_Layer.All_UserControl;
using QLNS.UI_Layer.All_UserControl.Employee_UC;
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
    public partial class EmployeeUI : Form
    {
        int UserID;
        public EmployeeUI(int userID)
        {
            InitializeComponent();
            this.UserID = userID;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
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

        private void btnContract_Click(object sender, EventArgs e)
        {
            this.guna2Panel2.Controls.Clear();
            Contract uC_Contract = new Contract(this.UserID);
            int x = (guna2Panel2.Width - uC_Contract.Width) / 2;
            int y = (guna2Panel2.Height - uC_Contract.Height) / 2;
            uC_Contract.Location = new Point(x, y);
            this.guna2Panel2.Controls.Add(uC_Contract);
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            this.guna2Panel2.Controls.Clear();
            E_UC_ChamCong e_UC_ChamCong = new E_UC_ChamCong(this.UserID);
            int x = (guna2Panel2.Width - e_UC_ChamCong.Width) / 2;
            int y = (guna2Panel2.Height - e_UC_ChamCong.Height) / 2;
            e_UC_ChamCong.Location = new Point(x, y);
            this.guna2Panel2.Controls.Add(e_UC_ChamCong);
        }

        private void btnDangKyXinNghi_Click(object sender, EventArgs e)
        {
            this.guna2Panel2.Controls.Clear();
            E_UC_DangKyNghiPhep e_UC_DangKyNghiPhep = new E_UC_DangKyNghiPhep(this.UserID);
            int x = (guna2Panel2.Width - e_UC_DangKyNghiPhep.Width) / 2;
            int y = (guna2Panel2.Height - e_UC_DangKyNghiPhep.Height) / 2;
            e_UC_DangKyNghiPhep.Location = new Point(x, y);
            this.guna2Panel2.Controls.Add(e_UC_DangKyNghiPhep);
        }

        private void btnQuanLiTangCa_Click(object sender, EventArgs e)
        {
            this.guna2Panel2.Controls.Clear();
            E_UC_DangKyTangCa e_UC_DangKyTangCa = new E_UC_DangKyTangCa(this.UserID);
            int x = (guna2Panel2.Width - e_UC_DangKyTangCa.Width) / 2;
            int y = (guna2Panel2.Height - e_UC_DangKyTangCa.Height) / 2;
            e_UC_DangKyTangCa.Location = new Point(x, y);
            this.guna2Panel2.Controls.Add(e_UC_DangKyTangCa);
        }

        private void btnXemCongtrinh_Click(object sender, EventArgs e)
        {
            this.guna2Panel2.Controls.Clear();
            E_UC_XemCongTrinh e_UC_XemCongTrinh = new E_UC_XemCongTrinh(this.UserID);
            int x = (guna2Panel2.Width - e_UC_XemCongTrinh.Width) / 2;
            int y = (guna2Panel2.Height - e_UC_XemCongTrinh.Height) / 2;
            e_UC_XemCongTrinh.Location = new Point(x, y);
            this.guna2Panel2.Controls.Add(e_UC_XemCongTrinh);
        }

        private void btnDangKyCongTrinh_Click(object sender, EventArgs e)
        {
            this.guna2Panel2.Controls.Clear();
            E_UC_DangKyCongTrinh e_UC_DangKyCongTrinh = new E_UC_DangKyCongTrinh(this.UserID);
            int x = (guna2Panel2.Width - e_UC_DangKyCongTrinh.Width) / 2;
            int y = (guna2Panel2.Height - e_UC_DangKyCongTrinh.Height) / 2;
            e_UC_DangKyCongTrinh.Location = new Point(x, y);
            this.guna2Panel2.Controls.Add(e_UC_DangKyCongTrinh);
        }
    }
}
