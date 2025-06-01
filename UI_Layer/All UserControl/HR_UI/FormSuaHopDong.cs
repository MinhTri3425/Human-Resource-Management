using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS.UI_Layer.All_UserControl.HR_UI
{
    public partial class FormSuaHopDong : Form
    {


        public int IDHopDongMoi { get; private set; }
        public int IDNhanVienMoi { get; private set; }
        public DateTime NgayKyMoi { get; private set; }
        public DateTime NgayHetHanMoi { get; private set; }
        public string LoaiHopDongMoi { get; private set; }
        public FormSuaHopDong(int idHopDong, int idNhanVien, DateTime ngayKy, DateTime ngayHetHan, string loaiHopDong)
        {
            InitializeComponent();
            // Gán dữ liệu ban đầu
            txtHopDongID.Text = idHopDong.ToString();
            txtNhanVienID.Text = idNhanVien.ToString();
            NgayKy.Value = ngayKy;
            NgayHetHan.Value = ngayHetHan;
            CbbLoaiHD.Text = loaiHopDong;

            // Tùy chỉnh định dạng ngày
            NgayKy.Format = DateTimePickerFormat.Custom;
            NgayKy.CustomFormat = "dd/MM/yyyy";

            NgayHetHan.Format = DateTimePickerFormat.Custom;
            NgayHetHan.CustomFormat = "dd/MM/yyyy";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            IDHopDongMoi = int.Parse(txtHopDongID.Text);
            IDNhanVienMoi = int.Parse(txtNhanVienID.Text);
            NgayKyMoi = NgayKy.Value;
            NgayHetHanMoi = NgayHetHan.Value;
            LoaiHopDongMoi = CbbLoaiHD.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
