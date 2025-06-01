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
    public partial class FormThemPB : Form
    {
        public string TenpbMoi { get; private set; }
        public FormThemPB()
        {
            InitializeComponent();
            IDpb.ReadOnly = true;
            IDpb.Text = "không cần nhập id";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra tên pb
            string ten = txtTenPb.Text.Trim();
            if (string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Tên phòng ban không được để trống!");
                return;
            }
            TenpbMoi = ten;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
