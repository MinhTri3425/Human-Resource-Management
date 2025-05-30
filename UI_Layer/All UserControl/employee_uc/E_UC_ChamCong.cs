using QLNS.BL_Layer;
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
    public partial class E_UC_ChamCong : UserControl
    {
        private int UserID;
        private String functionName = "E.ChamCong(banthan)";

        DataSet ds;

        int nhanVienID;
        String hoTenNhanVien;
        int chucVuIDNhanVien;
        int PhongBanID;

        public E_UC_ChamCong(int UserID)
        {
            InitializeComponent();
            this.UserID = UserID;
            LoadData();
        }

        public void LoadData()
        {
            NhanVien nhanVien = new NhanVien(this.UserID, this.functionName);
            string err = "";
            nhanVienID = nhanVien.LayNhanVienIDtheoUserID(ref err);
            DataSet thongtinNhanVien = nhanVien.LayNhanVienTheoID(this.nhanVienID);
            if (thongtinNhanVien != null && thongtinNhanVien.Tables.Count > 0 && thongtinNhanVien.Tables[0].Rows.Count > 0)
            {
                this.hoTenNhanVien = thongtinNhanVien.Tables[0].Rows[0]["HoTen"].ToString();
                this.chucVuIDNhanVien = Convert.ToInt32(thongtinNhanVien.Tables[0].Rows[0]["ChucVuID"]);
                this.PhongBanID = Convert.ToInt32(thongtinNhanVien.Tables[0].Rows[0]["PhongBanID"]);
            }
            ChamCong chamcong = new ChamCong(this.UserID, this.functionName);
            ds = chamcong.LayChamCongTheoNhanVienID(this.nhanVienID);
        }

        private void E_UC_ChamCong_Load(object sender, EventArgs e)
        {
            lbTenNhanVien.Text = hoTenNhanVien;
            ChucVu chucVu = new ChucVu(this.UserID, this.functionName);
            lbChucVuNhanVien.Text = chucVu.LayTenChucVuTheoID(this.chucVuIDNhanVien);
            PhongBan phongBan = new PhongBan(this.UserID, this.functionName);
            String tenPhongBan = phongBan.LayTenPhongBanTheoID(this.PhongBanID);
            lbTenNhanVien.Text = hoTenNhanVien;


            foreach (DataRow row in ds.Tables[0].Rows)
            {
                int id = Convert.ToInt32(row["ChamCongID"]);
                string ngayChamCong = Convert.ToDateTime(row["Ngay"]).ToString("dd/MM/yyyy");
                string gioVao = DateTime.Parse(row["GioVao"].ToString()).ToString("HH:mm");
                string gioRa = DateTime.Parse(row["GioRa"].ToString()).ToString("HH:mm");
                string TrangThai = row["TrangThai"].ToString();

                E_UC_ItemChamCong chamcong = new E_UC_ItemChamCong(id, hoTenNhanVien, ngayChamCong, gioVao, gioRa, TrangThai);
                chamcong.Dock = DockStyle.Top;
                this.panelChamCong.Controls.Add(chamcong);
            }
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            E_FormChamCong form = new E_FormChamCong(UserID, functionName, nhanVienID, () =>
            {
                panelChamCong.Controls.Clear();
                LoadData();
                E_UC_ChamCong_Load(null, null);
            });
            form.ShowDialog();
        }
    }
}
