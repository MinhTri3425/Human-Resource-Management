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
    public partial class A_UC_TimekeepingItem : UserControl
    {
        private int ChamCongID;
        private int NhanVienID;
        private string ngay;
        private string gioBatDau;
        private string gioKetThuc;
        private string trangThai;
        public A_UC_TimekeepingItem(int chamCongID, int nhanVienID, string ngay, string gioBatDau, string gioKetThuc, string trangThai)
        {
            InitializeComponent();
            ChamCongID = chamCongID;
            NhanVienID = nhanVienID;
            this.ngay = ngay;
            this.gioBatDau = gioBatDau;
            this.gioKetThuc = gioKetThuc;
            this.trangThai = trangThai;
        }

        private void A_UC_TimekeepingItem_Load(object sender, EventArgs e)
        {
            lbchamcongid.Text = ChamCongID.ToString();
            lbnhanvienid.Text = NhanVienID.ToString();
            lbngay.Text = ngay;
            lbgiobatdau.Text = gioBatDau;
            lbgioketthuc.Text = gioKetThuc;
            lbtrangthai.Text = trangThai;
        }
    }
}
