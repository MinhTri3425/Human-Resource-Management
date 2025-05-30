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
    public partial class E_UC_XemCongTrinh : UserControl
    {
        private int UserID;
        private String functionName = "E.CongTrinh(banthan)";

        DataSet ds;

        int nhanVienID;
        string hoTenNhanVien;
        int chucVuIDNhanVien;
        int PhongBanID;

        public E_UC_XemCongTrinh(int userID)
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

            CongTrinh congTrinh = new CongTrinh(this.UserID, this.functionName);
            ds = congTrinh.LayCongTrinhTheoPhongBan(this.PhongBanID);
        }

        private void E_UC_XemCongTrinh_Load(object sender, EventArgs e)
        {
            lbTenNhanVien.Text = hoTenNhanVien;
            ChucVu chucVu = new ChucVu(this.UserID, this.functionName);
            lbChucVuNhanVien.Text = chucVu.LayTenChucVuTheoID(this.chucVuIDNhanVien);
            PhongBan phongBan = new PhongBan(this.UserID, this.functionName);
            String tenPhongBan = phongBan.LayTenPhongBanTheoID(this.PhongBanID);
            lbPhongBanNhanVien.Text = tenPhongBan;

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                int id = Convert.ToInt32(row["CongTrinhID"]);
                string tenCongTrinh = row["TenCongTrinh"].ToString();
                string diaDiem = row["DiaDiem"].ToString();
                string ngayBatDau = Convert.ToDateTime(row["NgayBatDau"]).ToString("dd/MM/yyyy");
                string ngayKetThuc = Convert.ToDateTime(row["NgayKetThuc"]).ToString("dd/MM/yyyy");

                E_UC_ItemCongTrinh congTrinh = new E_UC_ItemCongTrinh(id, tenCongTrinh, diaDiem, ngayBatDau, ngayKetThuc);
                congTrinh.Dock = DockStyle.Top;
                this.panelCongTrinh.Controls.Add(congTrinh);
            }
        }
    }
}
