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

namespace QLNS.UI_Layer.All_UserControl.Manager_UC
{
    public partial class M_UC_QuanliNghiPhep : UserControl
    {
        private int UserID;
        private String functionName = "M.NghiPhep";

        DataSet ds;

        int nhanVienID;
        string hoTenQuanLi;
        int chucVuIDQuanLi;
        int PhongBanID;

        public M_UC_QuanliNghiPhep(int UserID)
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

            NghiPhep nghiphep = new NghiPhep(this.UserID, this.functionName);
            ds = nghiphep.LayNghiPhepTheoPhongBanID(this.PhongBanID);
        }

        private void M_UC_QuanliNghiPhep_Load(object sender, EventArgs e)
        {
            lbTenQuanli.Text = hoTenQuanLi;
            ChucVu chucVu = new ChucVu(this.UserID, this.functionName);
            lbChucVuquanli.Text = chucVu.LayTenChucVuTheoID(this.chucVuIDQuanLi);
            PhongBan phongBan = new PhongBan(this.UserID, this.functionName);
            String tenPhongBan = phongBan.LayTenPhongBanTheoID(this.PhongBanID);
            lbPhongBanQuanLi.Text = tenPhongBan;

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

                M_UC_ItemQuanLiNghiPhep nghiPhep = new M_UC_ItemQuanLiNghiPhep(
                    id,
                    hoten,
                    ngayBatDau,
                    ngayKetThuc,
                    loainghiphep,
                    TrangThai, 
                    this.UserID,
                    this.functionName,
                    () =>
                    {
                        this.panelQuanLiNghiPhep.Controls.Clear();
                        LoadData();
                        M_UC_QuanliNghiPhep_Load(null, null);
                    });
                nghiPhep.Dock = DockStyle.Top;
                this.panelQuanLiNghiPhep.Controls.Add(nghiPhep);
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            NghiPhep nghiphep = new NghiPhep(this.UserID, this.functionName);
            string searchText = guna2TextBox1.Text.Trim();
            DataSet dataSet = nghiphep.TimKiemNghiPhepTheoTenNhanVienCungPhongBan(this.PhongBanID, searchText);
            panelQuanLiNghiPhep.Controls.Clear();
            if (dataSet != null)
            {
                if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in dataSet.Tables[0].Rows)
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
                        M_UC_ItemQuanLiNghiPhep nghiPhepItem = new M_UC_ItemQuanLiNghiPhep(
                            id,
                            hoten,
                            ngayBatDau,
                            ngayKetThuc,
                            loainghiphep,
                            TrangThai,
                            this.UserID,
                            this.functionName,
                            () =>
                            {
                                this.panelQuanLiNghiPhep.Controls.Clear();
                                LoadData();
                                M_UC_QuanliNghiPhep_Load(null, null);
                            });
                        nghiPhepItem.Dock = DockStyle.Top;
                        this.panelQuanLiNghiPhep.Controls.Add(nghiPhepItem);
                    }
                }
            }
        }

        private void cbbtrangthai_SelectedIndexChanged(object sender, EventArgs e)
        {
            NghiPhep nghiphep = new NghiPhep(this.UserID, this.functionName);
            string trangThai = cbbtrangthai.SelectedItem.ToString();
            DataSet dataSet = nghiphep.LayNghiPhepTheoTrangThaiCungPhongBan(this.PhongBanID, trangThai);
            panelQuanLiNghiPhep.Controls.Clear();
            if (dataSet != null)
            {
                if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in dataSet.Tables[0].Rows)
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
                        M_UC_ItemQuanLiNghiPhep nghiPhepItem = new M_UC_ItemQuanLiNghiPhep(
                            id,
                            hoten,
                            ngayBatDau,
                            ngayKetThuc,
                            loainghiphep,
                            TrangThai,
                            this.UserID,
                            this.functionName,
                            () =>
                            {
                                this.panelQuanLiNghiPhep.Controls.Clear();
                                LoadData();
                                M_UC_QuanliNghiPhep_Load(null, null);
                            });
                        nghiPhepItem.Dock = DockStyle.Top;
                        this.panelQuanLiNghiPhep.Controls.Add(nghiPhepItem);
                    }
                }
            }
        }
    }
}
