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
    public partial class H_HopDong : UserControl
    {
        private int ID_HopDong;
        private int ID_NhanVien;
        private string LoaiHopDong;
        private string NgayBatDau;
        private string NgayKetThuc;
        public H_HopDong(int iD_HopDong, int iD_NhanVien, string loaiHopDong, string ngayBatDau, string ngayKetThuc)
        {
            InitializeComponent();
            ID_HopDong = iD_HopDong;
            ID_NhanVien = iD_NhanVien;
            LoaiHopDong = loaiHopDong;
            NgayBatDau = ngayBatDau;
            NgayKetThuc = ngayKetThuc;
        }

        private void H_HopDong_Load(object sender, EventArgs e)
        {
            lbIDHopDong.Text = ID_HopDong.ToString();
            lbIDNhanVien.Text = ID_NhanVien.ToString();
            lbLoaiHD.Text = LoaiHopDong;
            lbNgayKy.Text = NgayBatDau;
            lbNgayHetHan.Text = NgayKetThuc;
        }
    }
}
