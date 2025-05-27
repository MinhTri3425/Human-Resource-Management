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

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void Manager_Load(object sender, EventArgs e)
        {

        }

        private void btnQuanLiNhanVien_Click(object sender, EventArgs e)
        {
            guna2Panel2.Controls.Clear();

            M_UC_ManageEmployees uC_ManageEmployees = new M_UC_ManageEmployees(this.UserID);
            uC_ManageEmployees.Location = new Point(0, 0);
            guna2Panel2.Controls.Add(uC_ManageEmployees);
        }

        private void btnQuanLiCongTrinh_Click(object sender, EventArgs e)
        {
            guna2Panel2.Controls.Clear();

            M_UC_QuanLiCongTrinh quanlicongtrinh = new M_UC_QuanLiCongTrinh(this.UserID);
            quanlicongtrinh.Location = new Point(0, 0);
            guna2Panel2.Controls.Add(quanlicongtrinh);
        }

        private void btnQuanLiChamCong_Click(object sender, EventArgs e)
        {
            guna2Panel2.Controls.Clear();

            M_UC_QuanLiChamCong quanLiChamCong = new M_UC_QuanLiChamCong(this.UserID);
            quanLiChamCong.Location = new Point(0, 0);
            guna2Panel2.Controls.Add(quanLiChamCong);
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            guna2Panel2.Controls.Clear();

            M_UC_HopDongLaoDong hopDongLaoDong = new M_UC_HopDongLaoDong(this.UserID);
            hopDongLaoDong.Location = new Point(0, 0);
            guna2Panel2.Controls.Add(hopDongLaoDong);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void btnPersonalInfor_Click(object sender, EventArgs e)
        {
            this.guna2Panel2.Controls.Clear();
            PersonalInformation personalInformation = new PersonalInformation(this.UserID);
            personalInformation.Location = new Point(0, 0);
            this.guna2Panel2.Controls.Add(personalInformation);
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            this.guna2Panel2.Controls.Clear();
            SalaryInformation salaryInformation = new SalaryInformation(this.UserID);
            salaryInformation.Location = new Point(0, 0);
            this.guna2Panel2.Controls.Add(salaryInformation);
        }

        private void btnContract_Click(object sender, EventArgs e)
        {
            this.guna2Panel2.Controls.Clear();
            Contract uC_Contract = new Contract(this.UserID);
            uC_Contract.Location = new Point(0, 0);
            this.guna2Panel2.Controls.Add(uC_Contract);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            guna2Panel2.Controls.Clear();
            M_UC_QuanliNghiPhep quanliNghiPhep = new M_UC_QuanliNghiPhep(this.UserID);
            quanliNghiPhep.Location = new Point(0, 0);
            guna2Panel2.Controls.Add(quanliNghiPhep);

        }

        private void btnQuanLiTangCa_Click(object sender, EventArgs e)
        {
            guna2Panel2.Controls.Clear();
            M_UC_QuanLiTangCa quanLiTangCa = new M_UC_QuanLiTangCa(this.UserID);
            quanLiTangCa.Location = new Point(0, 0);
            guna2Panel2.Controls.Add(quanLiTangCa);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            guna2Panel2.Controls.Clear();
            M_UC_QuanLyPhanCongCongTrinh quanLyPhanCongCongTrinh = new M_UC_QuanLyPhanCongCongTrinh(this.UserID);
            quanLyPhanCongCongTrinh.Location = new Point(0, 0);
            guna2Panel2.Controls.Add(quanLyPhanCongCongTrinh);
        }
    }
}
