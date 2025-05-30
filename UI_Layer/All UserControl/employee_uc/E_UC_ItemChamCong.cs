using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS.UI_Layer.All_UserControl.Employee_UC
{
    public partial class E_UC_ItemChamCong : UserControl
    {
        int idChamCong;
        string hoTenNhanVien;
        string ngayChamCong;
        string gioVao;
        string gioRa;
        string trangThai;

        public E_UC_ItemChamCong(int idChamCong, string hoTenNhanVien, string ngayChamCong, string gioVao, string gioRa, string trangThai)
        {
            InitializeComponent();
            this.idChamCong = idChamCong;
            this.hoTenNhanVien = hoTenNhanVien;
            this.ngayChamCong = ngayChamCong;
            this.gioVao = gioVao;
            this.gioRa = gioRa;
            this.trangThai = trangThai;
        }

        private void E_UC_ItemChamCong_Load(object sender, EventArgs e)
        {
            lbIDChamCong.Text = idChamCong.ToString();
            lbTenNhanVien.Text = hoTenNhanVien;
            lbNgay.Text = ngayChamCong;
            lbGioVao.Text = gioVao;
            lbGioRa.Text = gioRa;
            lbTrangThai.Text = trangThai;
        }
    }
}
