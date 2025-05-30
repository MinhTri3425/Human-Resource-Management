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
    public partial class E_UC_DangKyCongTrinh : UserControl
    {

        private int UserID;
        private String functionName = "E.CongTrinh(banthan)";

        DataSet ds;

        int nhanVienID;
        string hoTenNhanVien;
        int chucVuIDNhanVien;
        int PhongBanID;

        public E_UC_DangKyCongTrinh(int userID)
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
            PhanCongCongTrinh phancong = new PhanCongCongTrinh(this.UserID, this.functionName);
            ds = phancong.LayPhanCongTheoNhanVienID(this.nhanVienID);
        }
        private void E_UC_DangKyCongTrinh_Load(object sender, EventArgs e)
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
                CongTrinh congTrinh = new CongTrinh(this.UserID, this.functionName);
                string tenCongTrinh = congTrinh.LayTenCongTrinhTheoID(id);


                string ngay = Convert.ToDateTime(row["NgayPhanCong"]).ToString("dd/MM/yyyy");
                string loai = row["Loai"].ToString();
                string trangThai = row["TrangThai"].ToString();

                E_UC_ItemPhanCongCongTrinh phancong = new E_UC_ItemPhanCongCongTrinh(
                nhanVienID,
                id,
                hoTenNhanVien,
                tenCongTrinh,
                ngay,
                loai,
                trangThai,
                this.UserID,
                this.functionName,
                () =>
                {
                    this.panelDangKyCongTrinh.Controls.Clear();
                    LoadData();
                    E_UC_DangKyCongTrinh_Load(null, null);
                });
                phancong.Dock = DockStyle.Top;
                this.panelDangKyCongTrinh.Controls.Add(phancong);
            }
        }

        public List<(int ID, string Ten)> LayDanhSachCongTrinhCungPhongBan()
        {
            var result = new List<(int ID, string Ten)>();
            CongTrinh congTrinh = new CongTrinh(this.UserID, this.functionName);
            DataSet dsCongTrinh = congTrinh.LayCongTrinhTheoPhongBan(this.PhongBanID);

            foreach (DataRow row in dsCongTrinh.Tables[0].Rows)
            {
                int id = Convert.ToInt32(row["CongTrinhID"]);
                string ten = row["TenCongTrinh"].ToString();
                result.Add((id, ten));
            }

            return result;
        }


        private void btnThemCongTrinh_Click(object sender, EventArgs e)
        {
            var danhSach = LayDanhSachCongTrinhCungPhongBan();
            E_Form_DangKyCongTrinh form = new E_Form_DangKyCongTrinh(UserID, functionName, nhanVienID, danhSach, () =>
            {
                panelDangKyCongTrinh.Controls.Clear();
                LoadData();
                E_UC_DangKyCongTrinh_Load(null, null);
            });
            form.ShowDialog();
        }
    }
}
