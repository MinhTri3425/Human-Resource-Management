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
    public partial class FormSuaPB : Form
    {
        public int IDPhongBanMoi { get; private set; }
        public string TenPbMoi { get; private set; }
        public FormSuaPB(int idphongban, string tenPb)
        {
            InitializeComponent();
            // Gán dữ liệu ban đầu
            IDpb.Text = idphongban.ToString();
            txtTenPb.Text = tenPb;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            IDPhongBanMoi = int.Parse(IDpb.Text);
            TenPbMoi = txtTenPb.Text.Trim();
            if (string.IsNullOrEmpty(TenPbMoi))
            {
                MessageBox.Show("Tên phòng ban không được để trống!");
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
