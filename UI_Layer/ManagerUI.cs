using QLNS.UI_Layer.All_UserControl;
using QLNS.UI_Layer.All_UserControl.Manager_UC;
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
    public partial class ManagerUI : Form
    {
        private int UserID;

        public ManagerUI(int UserID)
        {
            InitializeComponent();
            this.UserID = UserID;
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

        private void btnQuanLiNhanVien_Click(object sender, EventArgs e)
        {
            guna2Panel2.Controls.Clear();
            M_UC_ManageEmployees uC_ManageEmployees = new M_UC_ManageEmployees(this.UserID);
            int x = (guna2Panel2.Width - uC_ManageEmployees.Width) / 2;
            int y = (guna2Panel2.Height - uC_ManageEmployees.Height) / 2;
            uC_ManageEmployees.Location = new Point(x, y);
            guna2Panel2.Controls.Add(uC_ManageEmployees);
        }

        private void btnQuanLiCongTrinh_Click(object sender, EventArgs e)
        {
            guna2Panel2.Controls.Clear();
            M_UC_QuanLiCongTrinh quanlicongtrinh = new M_UC_QuanLiCongTrinh(this.UserID);
            int x = (guna2Panel2.Width - quanlicongtrinh.Width) / 2;
            int y = (guna2Panel2.Height - quanlicongtrinh.Height) / 2;
            quanlicongtrinh.Location = new Point(x, y);
            guna2Panel2.Controls.Add(quanlicongtrinh);
        }

        private void btnQuanLiChamCong_Click(object sender, EventArgs e)
        {
            guna2Panel2.Controls.Clear();
            M_UC_QuanLiChamCong quanLiChamCong = new M_UC_QuanLiChamCong(this.UserID);
            int x = (guna2Panel2.Width - quanLiChamCong.Width) / 2;
            int y = (guna2Panel2.Height - quanLiChamCong.Height) / 2;
            quanLiChamCong.Location = new Point(x, y);
            guna2Panel2.Controls.Add(quanLiChamCong);
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            guna2Panel2.Controls.Clear();
            M_UC_HopDongLaoDong hopDongLaoDong = new M_UC_HopDongLaoDong(this.UserID);
            int x = (guna2Panel2.Width - hopDongLaoDong.Width) / 2;
            int y = (guna2Panel2.Height - hopDongLaoDong.Height) / 2;
            hopDongLaoDong.Location = new Point(x, y);
            guna2Panel2.Controls.Add(hopDongLaoDong);
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

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            guna2Panel2.Controls.Clear();
            M_UC_QuanliNghiPhep quanliNghiPhep = new M_UC_QuanliNghiPhep(this.UserID, "M.NghiPhep");
            int x = (guna2Panel2.Width - quanliNghiPhep.Width) / 2;
            int y = (guna2Panel2.Height - quanliNghiPhep.Height) / 2;
            quanliNghiPhep.Location = new Point(x, y);
            guna2Panel2.Controls.Add(quanliNghiPhep);
        }

        private void btnQuanLiTangCa_Click(object sender, EventArgs e)
        {
            guna2Panel2.Controls.Clear();
            M_UC_QuanLiTangCa quanLiTangCa = new M_UC_QuanLiTangCa(this.UserID, "M.TangCa");
            int x = (guna2Panel2.Width - quanLiTangCa.Width) / 2;
            int y = (guna2Panel2.Height - quanLiTangCa.Height) / 2;
            quanLiTangCa.Location = new Point(x, y);
            guna2Panel2.Controls.Add(quanLiTangCa);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            guna2Panel2.Controls.Clear();
            M_UC_QuanLyPhanCongCongTrinh quanLyPhanCongCongTrinh = new M_UC_QuanLyPhanCongCongTrinh(this.UserID, 4, "M.CongTrinh(samePB)");
            int x = (guna2Panel2.Width - quanLyPhanCongCongTrinh.Width) / 2;
            int y = (guna2Panel2.Height - quanLyPhanCongCongTrinh.Height) / 2;
            quanLyPhanCongCongTrinh.Location = new Point(x, y);
            guna2Panel2.Controls.Add(quanLyPhanCongCongTrinh);
        }
    }
}
