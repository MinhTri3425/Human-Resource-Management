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
    public partial class All : Form
    {
        private int UserID;
        public All(int UserID)
        {
            InitializeComponent();
            this.UserID = UserID;
        }
        public All()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void All_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.guna2Panel2.Controls.Clear();

            UC_PersonalInformation uC_PersonalInformation = new UC_PersonalInformation(this.UserID);
            uC_PersonalInformation.Location = new Point(0,0);
            this.guna2Panel2.Controls.Add(uC_PersonalInformation);
        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
           
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            
        }

        private void btnContract_Click(object sender, EventArgs e)
        {
            this.guna2Panel2.Controls.Clear();

            UC_Contract uC_Contract = new UC_Contract(this.UserID);
            uC_Contract.Location = new Point(0, 0);
            this.guna2Panel2.Controls.Add(uC_Contract);
        }

        private void uC_Contract1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }
    }
}
