using QLNS.BL_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS.UI_Layer.All_UserControl.Admin_UC
{
    public partial class nhatky : UserControl
    {
       /* int userID;
        int nhatkyid;
        int nhanvienid;
        string hanhdong;
        DateTime thoigian;*/
        public nhatky(int nhatkyid, int nhanvienid, string hanhdong, DateTime thoigian)
        {
            InitializeComponent();
            NkyID.Text = nhatkyid.ToString();
            UserID.Text = nhanvienid.ToString();
            HanhDong.Text = hanhdong;
            Time.Text = thoigian.ToString("dd/MM/yyyy HH:mm:ss");
        }
       /* private void nhatky_Load(object sender, EventArgs e)
        {
            NkyID.Text = nhatkyid.ToString();
            UserID.Text = nhanvienid.ToString();
            HanhDong.Text = hanhdong;
            Time.Text = thoigian.ToString("dd/MM/yyyy HH:mm:ss");
        }*/

    }
}
