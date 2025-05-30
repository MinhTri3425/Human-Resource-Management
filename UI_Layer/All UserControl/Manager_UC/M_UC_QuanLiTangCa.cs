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
    public partial class M_UC_QuanLiTangCa : UserControl
    {
        private int UserID;
        private string functionName;

        DataSet ds;

        int nhanVienID;
        string hoTenQuanLi;
        int chucVuIDQuanLi;
        int PhongBanID;

        public M_UC_QuanLiTangCa(int UserID, string functionName)
        {
            InitializeComponent();
            this.UserID = UserID;
            this.functionName = functionName;
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
            TangCa tangca = new TangCa(this.UserID, this.functionName);
            ds = tangca.LayTangCaTheoPhongBanID(this.PhongBanID);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void M_UC_QuanLiTangCa_Load(object sender, EventArgs e)
        {
            lbTenQuanli.Text = hoTenQuanLi;
            ChucVu chucVu = new ChucVu(this.UserID, this.functionName);
            lbChucVuquanli.Text = chucVu.LayTenChucVuTheoID(this.chucVuIDQuanLi);
            PhongBan phongBan = new PhongBan(this.UserID, this.functionName);
            String tenPhongBan = phongBan.LayTenPhongBanTheoID(this.PhongBanID);
            lbPhongBanQuanLi.Text = tenPhongBan;

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                int id = Convert.ToInt32(row["TangCaID"]);
                int IDNhanVien = Convert.ToInt32(row["NhanVienID"]);
                NhanVien nhanVien = new NhanVien(this.UserID, this.functionName);
                DataSet thongtinNhanVien = nhanVien.LayNhanVienTheoID(IDNhanVien);
                string hoten = "";
                if (thongtinNhanVien != null && thongtinNhanVien.Tables.Count > 0 && thongtinNhanVien.Tables[0].Rows.Count > 0)
                {
                    hoten = thongtinNhanVien.Tables[0].Rows[0]["HoTen"].ToString();
                }
                String ngayTangCa = Convert.ToDateTime(row["NgayTangCa"]).ToString("dd/MM/yyyy");
                string gioBatDau = DateTime.Parse(row["GioBatDau"].ToString()).ToString("HH:mm");
                string gioKetThuc = DateTime.Parse(row["GioKetThuc"].ToString()).ToString("HH:mm");
                string loaiTangCa = row["LoaiTangCa"].ToString();
                string hinhThuc = row["HinhThuc"].ToString();
                string trangThai = row["TrangThai"].ToString();

                M_UC_ItemTangCa tangca = new M_UC_ItemTangCa(UserID, functionName, id, hoten, ngayTangCa, gioBatDau, gioKetThuc, loaiTangCa, hinhThuc, trangThai);
                tangca.Dock = DockStyle.Top;
                this.panelQuanLiTangCa.Controls.Add(tangca);
            }
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            M_ThemTangCa form = new M_ThemTangCa(UserID, functionName, PhongBanID, () =>
            {
                this.panelQuanLiTangCa.Controls.Clear();
                LoadData();
                M_UC_QuanLiTangCa_Load(null, null);
            });
            form.ShowDialog();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            TangCa tangCa = new TangCa(this.UserID, this.functionName);
            string searchText = guna2TextBox1.Text.Trim();
            DataSet dataSet = tangCa.TimKiemTangCaTheoTenNhanVienCungPhongBan(this.PhongBanID, searchText);
            panelQuanLiTangCa.Controls.Clear();
            LoadData();
            if (dataSet != null)
            {
                if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        int id = Convert.ToInt32(row["TangCaID"]);
                        int IDNhanVien = Convert.ToInt32(row["NhanVienID"]);
                        NhanVien nhanVien = new NhanVien(this.UserID, this.functionName);
                        DataSet thongtinNhanVien = nhanVien.LayNhanVienTheoID(IDNhanVien);
                        string hoten = "";
                        if (thongtinNhanVien != null && thongtinNhanVien.Tables.Count > 0 && thongtinNhanVien.Tables[0].Rows.Count > 0)
                        {
                            hoten = thongtinNhanVien.Tables[0].Rows[0]["HoTen"].ToString();
                        }
                        String ngayTangCa = Convert.ToDateTime(row["NgayTangCa"]).ToString("dd/MM/yyyy");
                        string gioBatDau = DateTime.Parse(row["GioBatDau"].ToString()).ToString("HH:mm");
                        string gioKetThuc = DateTime.Parse(row["GioKetThuc"].ToString()).ToString("HH:mm");
                        string loaiTangCa = row["LoaiTangCa"].ToString();
                        string hinhThuc = row["HinhThuc"].ToString();
                        string trangThai = row["TrangThai"].ToString();
                        M_UC_ItemTangCa tangcaItem = new M_UC_ItemTangCa(UserID, functionName, id, hoten, ngayTangCa, gioBatDau, gioKetThuc, loaiTangCa, hinhThuc, trangThai);
                        tangcaItem.Dock = DockStyle.Top;
                        this.panelQuanLiTangCa.Controls.Add(tangcaItem);
                    }
                }
            }
        }

        private void cbbtrangthai_SelectedIndexChanged(object sender, EventArgs e)
        {
            TangCa tangCa = new TangCa(this.UserID, this.functionName);
            string trangThai = cbbtrangthai.SelectedItem.ToString();
            DataSet dataSet = tangCa.LayTangCaTheoTrangThaiCungPhongBan(this.PhongBanID, trangThai);
            panelQuanLiTangCa.Controls.Clear();
            LoadData();
            if (dataSet != null)
            {
                if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        int id = Convert.ToInt32(row["TangCaID"]);
                        int IDNhanVien = Convert.ToInt32(row["NhanVienID"]);
                        NhanVien nhanVien = new NhanVien(this.UserID, this.functionName);
                        DataSet thongtinNhanVien = nhanVien.LayNhanVienTheoID(IDNhanVien);
                        string hoten = "";
                        if (thongtinNhanVien != null && thongtinNhanVien.Tables.Count > 0 && thongtinNhanVien.Tables[0].Rows.Count > 0)
                        {
                            hoten = thongtinNhanVien.Tables[0].Rows[0]["HoTen"].ToString();
                        }
                        String ngayTangCa = Convert.ToDateTime(row["NgayTangCa"]).ToString("dd/MM/yyyy");
                        string gioBatDau = DateTime.Parse(row["GioBatDau"].ToString()).ToString("HH:mm");
                        string gioKetThuc = DateTime.Parse(row["GioKetThuc"].ToString()).ToString("HH:mm");
                        string loaiTangCa = row["LoaiTangCa"].ToString();
                        string hinhThuc = row["HinhThuc"].ToString();
                        string trangThaiItem = row["TrangThai"].ToString();
                        M_UC_ItemTangCa tangcaItem = new M_UC_ItemTangCa(UserID, functionName, id, hoten, ngayTangCa, gioBatDau, gioKetThuc, loaiTangCa, hinhThuc, trangThaiItem);
                        tangcaItem.Dock = DockStyle.Top;
                        this.panelQuanLiTangCa.Controls.Add(tangcaItem);
                    }
                }
            }
        }
    }
}
