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
    public partial class A_UC_LeaveItem : UserControl
    {
        private int NghiPhepID;
        private int NhanVienID;
        private string ngaybatdau;
        private string ngayketthuc;
        private string loai;
        private string trangthai;
        public A_UC_LeaveItem(int nghiPhepID, int nhanVienID, string ngaybatdau, string ngayketthuc, string loai, string trangthai)
        {
            InitializeComponent();
            NghiPhepID = nghiPhepID;
            NhanVienID = nhanVienID;
            this.ngaybatdau = ngaybatdau;
            this.ngayketthuc = ngayketthuc;
            this.loai = loai;
            this.trangthai = trangthai;
        }

        private void A_UC_LeaveItem_Load(object sender, EventArgs e)
        {
            this.lbnghiphepid.Text = NghiPhepID.ToString();
            this.lbnhanvienid.Text = NhanVienID.ToString();
            this.lbngaybatdau.Text = ngaybatdau;
            this.lbngayketthuc.Text = ngayketthuc;
            this.lbloainghiphep.Text = loai;
            this.lbtrangthai.Text = trangthai;
        }
    }
}
