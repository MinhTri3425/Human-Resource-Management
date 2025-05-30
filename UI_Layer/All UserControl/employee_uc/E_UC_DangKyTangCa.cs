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
    public partial class E_UC_DangKyTangCa : UserControl
    {
        private int UserID;
        private string functionName = "E.TangCa(banthan)";

        DataSet ds;

        int nhanVienID;
        string hoTenNhanVien;
        int chucVuIDNhanVien;
        int PhongBanID;

        public E_UC_DangKyTangCa(int userID)
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
            TangCa tangca = new TangCa(this.UserID, this.functionName);
            ds = tangca.LayTangCaTheoNhanVienID(this.nhanVienID);
        }
        private void E_UC_DangKyTangCa_Load(object sender, EventArgs e)
        {
            lbTenNhanVien.Text = hoTenNhanVien;
            ChucVu chucVu = new ChucVu(this.UserID, this.functionName);
            lbChucVuNhanVien.Text = chucVu.LayTenChucVuTheoID(this.chucVuIDNhanVien);
            PhongBan phongBan = new PhongBan(this.UserID, this.functionName);
            String tenPhongBan = phongBan.LayTenPhongBanTheoID(this.PhongBanID);
            lbPhongBanNhaVien.Text = tenPhongBan;

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                int id = Convert.ToInt32(row["TangCaID"]);
                String ngayTangCa = Convert.ToDateTime(row["NgayTangCa"]).ToString("dd/MM/yyyy");
                string gioBatDau = DateTime.Parse(row["GioBatDau"].ToString()).ToString("HH:mm");
                string gioKetThuc = DateTime.Parse(row["GioKetThuc"].ToString()).ToString("HH:mm");
                string loaiTangCa = row["LoaiTangCa"].ToString();
                string hinhThuc = row["HinhThuc"].ToString();
                string trangThai = row["TrangThai"].ToString();

                E_UC_ItemTangCa tangca = new E_UC_ItemTangCa(
                id,
                hoTenNhanVien,
                ngayTangCa,
                gioBatDau,
                gioKetThuc,
                loaiTangCa,
                hinhThuc,
                trangThai,
                UserID,
                functionName,
                () =>
                {
                    this.panelQuanLiTangCa.Controls.Clear();
                    LoadData();
                    E_UC_DangKyTangCa_Load(null, null);
                });
                tangca.Dock = DockStyle.Top;
                this.panelQuanLiTangCa.Controls.Add(tangca);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            E_FormDangKyTangCa form = new E_FormDangKyTangCa(
            UserID,
            functionName,
            nhanVienID,
            null, 
            () =>
            {
                panelQuanLiTangCa.Controls.Clear();
                LoadData();
                E_UC_DangKyTangCa_Load(null, null);
            });

            form.ShowDialog();
        }
    }
}
