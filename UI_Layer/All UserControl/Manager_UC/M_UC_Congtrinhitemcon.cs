using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS.UI_Layer.All_UserControl.Manager_UC
{
    public partial class M_UC_Congtrinhitemcon : UserControl
    {
        private int CongTrinhID;
        private string TenCongTrinh;
        public M_UC_Congtrinhitemcon(int congTrinhID, string tenCongTrinh)
        {
            InitializeComponent();
            CongTrinhID = congTrinhID;
            TenCongTrinh = tenCongTrinh;
        }

        private void M_UC_Congtrinhitemcon_Load(object sender, EventArgs e)
        {
            this.lbCongtrinhID.Text = this.CongTrinhID.ToString();
            this.name.Text = this.TenCongTrinh;
        }
    }
}
