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
    public partial class M_UC_nhanvienitemcon : UserControl
    {
        private int NhanVienID;
        private string HoTen;
        public M_UC_nhanvienitemcon(int NhanVienID, string hoten)
        {
            InitializeComponent();
            this.NhanVienID = NhanVienID;
            this.HoTen = hoten;
        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void M_UC_nhanvienitemcon_Load(object sender, EventArgs e)
        {
            this.lbNhanVienID.Text = this.NhanVienID.ToString();
            this.name.Text = this.HoTen;
        }
    }
}
