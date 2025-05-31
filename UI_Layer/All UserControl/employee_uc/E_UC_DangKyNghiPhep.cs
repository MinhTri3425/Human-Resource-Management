using QLNS.BL_Layer;
using QLNS.UI_Layer.All_UserControl.Manager_UC;
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
    public partial class E_UC_DangKyNghiPhep : UserControl
    {
        private int UserID;
        private String functionName = "E.NghiPhep(banthan)";

        DataSet ds;

        int nhanVienID;
        String hoTenNhanVien;
        int chucVuIDNhanVien;
        int PhongBanID;

        public E_UC_DangKyNghiPhep(int userID)
        {
            InitializeComponent();
            this.UserID = userID;
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
            NghiPhep nghiPhep = new NghiPhep(this.UserID, this.functionName);
            ds = nghiPhep.LayNghiPhepTheoNhanVienID(this.nhanVienID);
        }

        private void E_UC_DangKyNghiPhep_Load(object sender, EventArgs e)
        {
            lbTenNhanVien.Text = hoTenNhanVien;
            ChucVu chucVu = new ChucVu(this.UserID, this.functionName);
            lbChucVuNhanVien.Text = chucVu.LayTenChucVuTheoID(this.chucVuIDNhanVien);
            PhongBan phongBan = new PhongBan(this.UserID, this.functionName);
            String tenPhongBan = phongBan.LayTenPhongBanTheoID(this.PhongBanID);
            lbTenNhanVien.Text = hoTenNhanVien;

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                int id = Convert.ToInt32(row["NghiPhepID"]);
                int IDNhanVien = Convert.ToInt32(row["NhanVienID"]);
                NhanVien nhanVien = new NhanVien(this.UserID, this.functionName);
                DataSet thongtinNhanVien = nhanVien.LayNhanVienTheoID(IDNhanVien);
                string hoten = "";
                if (thongtinNhanVien != null && thongtinNhanVien.Tables.Count > 0 && thongtinNhanVien.Tables[0].Rows.Count > 0)
                {
                    hoten = thongtinNhanVien.Tables[0].Rows[0]["HoTen"].ToString();
                }
                string loainghiphep = row["Loai"].ToString();
                string ngayBatDau = Convert.ToDateTime(row["NgayBatDau"]).ToString("dd/MM/yyyy");
                string ngayKetThuc = Convert.ToDateTime(row["NgayKetThuc"]).ToString("dd/MM/yyyy");
                string TrangThai = row["TrangThai"].ToString();

                E_UC_ItemNghiPhep nghiPhep = new E_UC_ItemNghiPhep(id, hoten, ngayBatDau, ngayKetThuc, loainghiphep, TrangThai);
                nghiPhep.Dock = DockStyle.Top;
                this.panelNghiPhep.Controls.Add(nghiPhep);
            }
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            E_FormNopNghiPhep form = new E_FormNopNghiPhep(UserID, functionName, nhanVienID, () =>
            {
                panelNghiPhep.Controls.Clear();
                LoadData();
                E_UC_DangKyNghiPhep_Load(null, null);
            });
            form.ShowDialog();
        }
    }
}
