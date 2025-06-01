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
    public partial class FormThemChucVu : Form
    {
        public string TenChucVuMoi { get; private set; }
        public FormThemChucVu()
        {
            InitializeComponent();
            txtIDChucVu.ReadOnly = true;
            txtIDChucVu.Text = "không cần nhập id";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {           
            // Kiểm tra tên chức vụ
            string ten = txtTenChucVu.Text.Trim();
            if (string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Tên chức vụ không được để trống!");
                return;
            }
            TenChucVuMoi = ten;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
 }
