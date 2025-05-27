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

namespace QLNS.UI_Layer.All_UserControl
{
    public partial class M_UC_QuanLiChamCong : UserControl
    {
        private int UserID;
        private String functionName = "M.ChamCong";

        DataSet ds;

        int nhanVienID;
        String hoTenQuanLi;
        int chucVuIDQuanLi;
        int PhongBanID;

        public M_UC_QuanLiChamCong(int UserID)
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
                this.hoTenQuanLi = thongtinNhanVien.Tables[0].Rows[0]["HoTen"].ToString();
                this.chucVuIDQuanLi = Convert.ToInt32(thongtinNhanVien.Tables[0].Rows[0]["ChucVuID"]);
                this.PhongBanID = Convert.ToInt32(thongtinNhanVien.Tables[0].Rows[0]["PhongBanID"]);
            }
            ChamCong chamcong = new ChamCong(this.UserID, this.functionName);
            ds = chamcong.LayChamCongTheoPhongBanID(this.PhongBanID);


        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UC_QuanLiChamCong_Load(object sender, EventArgs e)
        {
            lbTenQuanli.Text = hoTenQuanLi;
            ChucVu chucVu = new ChucVu(this.UserID, this.functionName);
            lbChucVuquanli.Text = chucVu.LayTenChucVuTheoID(this.chucVuIDQuanLi);
            PhongBan phongBan = new PhongBan(this.UserID, this.functionName);
            String tenPhongBan = phongBan.LayTenPhongBanTheoID(this.PhongBanID);
            lbPhongBanQuanLi.Text = tenPhongBan;

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                int id = Convert.ToInt32(row["ChamCongID"]);
                int IDNhanVien = Convert.ToInt32(row["NhanVienID"]);
                NhanVien nhanVien = new NhanVien(this.UserID, this.functionName);
                DataSet thongtinNhanVien = nhanVien.LayNhanVienTheoID(IDNhanVien);
                string hoten = "";
                if (thongtinNhanVien != null && thongtinNhanVien.Tables.Count > 0 && thongtinNhanVien.Tables[0].Rows.Count > 0)
                {
                    hoten = thongtinNhanVien.Tables[0].Rows[0]["HoTen"].ToString();
                }
                string ngayChamCong = Convert.ToDateTime(row["Ngay"]).ToString("dd/MM/yyyy");
                string gioVao = DateTime.Parse(row["GioVao"].ToString()).ToString("HH:mm");
                string gioRa = DateTime.Parse(row["GioRa"].ToString()).ToString("HH:mm");
                string TrangThai = row["TrangThai"].ToString();

                M_UC_ItemChamCong chamcong = new M_UC_ItemChamCong(id, hoten, ngayChamCong, gioVao, gioRa, TrangThai);
                chamcong.Dock = DockStyle.Top;
                this.panelQuanLiChamCong.Controls.Add(chamcong);
            }

            
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            ChamCong chamCong = new ChamCong(this.UserID, this.functionName);
            string searchText = guna2TextBox1.Text.Trim();
            DataSet dataSet = chamCong.TimKiemChamCongCungPhongBan(PhongBanID, searchText);
            panelQuanLiChamCong.Controls.Clear();

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                int id = Convert.ToInt32(row["ChamCongID"]);
                int IDNhanVien = Convert.ToInt32(row["NhanVienID"]);
                NhanVien nhanVien = new NhanVien(this.UserID, this.functionName);
                DataSet thongtinNhanVien = nhanVien.LayNhanVienTheoID(IDNhanVien);
                string hoten = "";
                if (thongtinNhanVien != null && thongtinNhanVien.Tables.Count > 0 && thongtinNhanVien.Tables[0].Rows.Count > 0)
                {
                    hoten = thongtinNhanVien.Tables[0].Rows[0]["HoTen"].ToString();
                }
                string ngayChamCong = Convert.ToDateTime(row["Ngay"]).ToString("dd/MM/yyyy");
                string gioVao = DateTime.Parse(row["GioVao"].ToString()).ToString("HH:mm");
                string gioRa = DateTime.Parse(row["GioRa"].ToString()).ToString("HH:mm");
                string TrangThai = row["TrangThai"].ToString();

                M_UC_ItemChamCong chamcong = new M_UC_ItemChamCong(id, hoten, ngayChamCong, gioVao, gioRa, TrangThai);
                chamcong.Dock = DockStyle.Top;
                this.panelQuanLiChamCong.Controls.Add(chamcong);
            }
        }
    }
}
