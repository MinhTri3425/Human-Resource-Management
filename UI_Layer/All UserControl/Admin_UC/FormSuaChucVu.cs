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
    public partial class FormSuaChucVu : Form
    {
        public int IDChucVuMoi { get; private set; }
        public string TenChucVuMoi { get; private set; }
        public FormSuaChucVu(int idchucvu, string tencv)
        {
            InitializeComponent();
            // Gán dữ liệu ban đầu
            IDcv.Text = idchucvu.ToString();
            txtTencv.Text = tencv;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            IDChucVuMoi = int.Parse(IDcv.Text);
            TenChucVuMoi = txtTencv.Text.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
