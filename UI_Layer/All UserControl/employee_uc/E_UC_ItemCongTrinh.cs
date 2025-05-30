using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS.UI_Layer.All_UserControl.Employee_UC
{
    public partial class E_UC_ItemCongTrinh : UserControl
    {

        int projectID;
        string projectName;
        string location;
        string startDate;
        string endDate;

        public E_UC_ItemCongTrinh(int projectID, string projectName, string location, string startDate, string endDate)
        {
            InitializeComponent();
            this.projectID = projectID;
            this.projectName = projectName;
            this.location = location;
            this.startDate = startDate;
            this.endDate = endDate;
        }

        private void E_UC_ItemCongTrinh_Load(object sender, EventArgs e)
        {
            this.lbIdProject.Text = projectID.ToString();
            this.lbProjectName.Text = projectName;
            this.lbLocation.Text = location;
            this.lbNgayBatDau.Text = startDate;
            this.lbNgayKetThuc.Text = endDate;
        }
    }
}
