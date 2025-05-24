using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS.UI_Layer.All_UserControl
{
    public partial class M_UC_ItemHopDong : UserControl
    {
        int HopDongID;
        string tenNhanVien;
        string loaiHopDong;
        string ngayKy;
        string ngayHetHan;

        public M_UC_ItemHopDong(int hopDongID, string tenNhanVien, string loaiHopDong, string ngayKy, string ngayHetHan)
        {
            InitializeComponent();
            this.HopDongID = hopDongID;
            this.tenNhanVien = tenNhanVien;
            this.loaiHopDong = loaiHopDong;
            this.ngayKy = ngayKy;
            this.ngayHetHan = ngayHetHan;
        }

        private void UC_ItemHopDong_Load(object sender, EventArgs e)
        {
            lbIDHopDong.Text = HopDongID.ToString();
            lbTenNhanVien.Text = tenNhanVien;
            lbLoaiHopDong.Text = loaiHopDong;
            lbNgayKy.Text = ngayKy;
            lbNgayHetHan.Text = ngayHetHan;
        }
    }
}
