using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS.UI_Layer.All_UserControl
{
    public partial class H_UC_ManageProjectItem : UserControl
    {
        int projectID;
        string projectName;
        string location;
        string startDate;
        string endDate;
        public H_UC_ManageProjectItem(int projectID, string projectName, string location, string startDate, string endDate)
        {
            InitializeComponent();
            this.projectID = projectID;
            this.projectName = projectName;
            this.location = location;
            this.startDate = startDate;
            this.endDate = endDate;
            //guna2Button1.Visible = false;


        }

        private void UC_ManageProjectItem_Load(object sender, EventArgs e)
        {
            this.lbIdProject.Text = projectID.ToString();
            this.lbProjectName.Text = projectName;
            this.lbLocation.Text = location;
            this.lbNgayBatDau.Text = startDate;
            this.lbNgayKetThuc.Text = endDate;
        }

        private void UC_ManageProjectItem_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void UC_ManageProjectItem_MouseLeave(object sender, EventArgs e)
        {
            //if (!this.ClientRectangle.Contains(this.PointToClient(Cursor.Position)))
            //{
            //    guna2Button1.Visible = false;
            //}
        }

        private void UC_ManageProjectItem_MouseEnter(object sender, EventArgs e)
        {
            //guna2Button1.Visible = true;
        }
    }
}
