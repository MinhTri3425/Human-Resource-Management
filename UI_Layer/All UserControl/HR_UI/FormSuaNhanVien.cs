using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS.UI_Layer.HR
{
    public partial class FormSuaNhanVien : Form
    { 

        public string HoTenMoi { get; set; }
        public DateTime NgaySinhMoi { get; set; }
        public string CMNDMoi { get; set; }
        public string MaSoThueMoi { get; set; }
        public int IDPhongMoi { get; set; }
        public int IDChucVuMoi { get; set; }
        public string TrangThaiMoi { get; set; }

        public FormSuaNhanVien(string hoTen, DateTime ngaySinh, string cmnd, string maSoThue, int phongID, int chucVuID, string trangThai)
        {
            InitializeComponent();

  

            TbxHoten.Text = hoTen;
            NgaySinh.Value = ngaySinh;
            TbxCMND.Text = cmnd;
            TbxMaThue.Text = maSoThue;
            TbxIDPhong.Text = phongID.ToString();
            TbxIDChucVu.Text = chucVuID.ToString();
            CboxTrangThai.Text = trangThai;
        }
        public FormSuaNhanVien()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            HoTenMoi = TbxHoten.Text;
            NgaySinhMoi = NgaySinh.Value;
            CMNDMoi = TbxCMND.Text;
            MaSoThueMoi = TbxMaThue.Text;
            IDPhongMoi = int.Parse(TbxIDPhong.Text);
            IDChucVuMoi = int.Parse(TbxIDChucVu.Text);
            TrangThaiMoi = CboxTrangThai.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
