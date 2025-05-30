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
    public partial class A_UC_OvertimeItem : UserControl
    {
        private int UserID;
        private string functionName;
        private int TangCaID;
        private int NhanVienID;
        private string ngay;
        private string gioBatDau;
        private string gioKetThuc;
        private string loaiTangCa;
        private string hinhThuc;
        private string trangThai;
        public A_UC_OvertimeItem(int UserID, string functionName, int TangCaID, int NhanVienID, string ngay, string gioBatDau, string gioKetThuc, string loaiTangCa, string hinhThuc, string trangThai)
        {
            InitializeComponent();
            this.UserID = UserID;
            this.functionName = functionName;
            this.TangCaID = TangCaID;
            this.NhanVienID = NhanVienID;
            this.ngay = ngay;
            this.gioBatDau = gioBatDau;
            this.gioKetThuc = gioKetThuc;
            this.loaiTangCa = loaiTangCa;
            this.hinhThuc = hinhThuc;
            this.trangThai = trangThai;
        }
        public A_UC_OvertimeItem()
        {
            InitializeComponent();
        }

        private void A_UC_OvertimeItem_Load(object sender, EventArgs e)
        {
            lbtangcaid.Text = TangCaID.ToString();
            lbnhanvienid.Text = NhanVienID.ToString();
            DateTime Date = DateTime.Parse(ngay);
            lbngay.Text = Date.ToString("dd/MM/yyyy");
            lbgiobatdau.Text = gioBatDau;
            lbgioketthuc.Text = gioKetThuc;
            lbloaitangca.Text = loaiTangCa;
            lbhinhthuc.Text = hinhThuc;
            lbtrangthai.Text = trangThai;
        }

        private void lbngay_Click(object sender, EventArgs e)
        {

        }

        private void lbgiobatdau_Click(object sender, EventArgs e)
        {

        }
    }
}
