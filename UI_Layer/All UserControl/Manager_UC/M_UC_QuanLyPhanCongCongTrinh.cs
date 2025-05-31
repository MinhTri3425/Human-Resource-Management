using QLNS.BL_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace QLNS.UI_Layer.All_UserControl.Manager_UC
{
    public partial class M_UC_QuanLyPhanCongCongTrinh : UserControl
    {
        int roleID;
        int UserID;
        int PhongBanID;
        string functionName;
        int CongTrinhID;
        int NhanVienID;
        string ngay;
        string loai;
        string trangthai;
        public M_UC_QuanLyPhanCongCongTrinh(int UserID, int roleID, string functionName)
        {
            InitializeComponent();
            this.UserID = UserID;
            this.roleID = roleID;
            this.functionName = functionName;
            LoadData();
        }
        public void LoadData()
        {
            NhanVien nhanVien = new NhanVien(this.UserID, this.functionName);
            string err = "";
            int nhanVienID = nhanVien.LayNhanVienIDtheoUserID(ref err);
            DataSet thongtinNhanVien = nhanVien.LayNhanVienTheoID(nhanVienID);
            if (thongtinNhanVien != null && thongtinNhanVien.Tables.Count > 0 && thongtinNhanVien.Tables[0].Rows.Count > 0)
            {
                string hoTenQuanLi = thongtinNhanVien.Tables[0].Rows[0]["HoTen"].ToString();
                int chucVuIDQuanLi = Convert.ToInt32(thongtinNhanVien.Tables[0].Rows[0]["ChucVuID"]);
                this.PhongBanID = Convert.ToInt32(thongtinNhanVien.Tables[0].Rows[0]["PhongBanID"]);
            }
            DataSet dataSet = null;
            PhanCongCongTrinh phanCongCongTrinh = new PhanCongCongTrinh(UserID, functionName);
            if (roleID == 4)
            {
                dataSet = phanCongCongTrinh.LayPhanCongCongTrinhCungPhongBan(PhongBanID, ref err);
            }
            else if (roleID == 1)
            {
                dataSet = phanCongCongTrinh.LayPhanCongCongTrinh();
            }

            if (dataSet != null)
            {
                if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                    {
                        CongTrinhID = Convert.ToInt32(dataSet.Tables[0].Rows[i]["CongTrinhID"]);
                        NhanVienID = Convert.ToInt32(dataSet.Tables[0].Rows[i]["NhanVienID"]);
                        ngay = dataSet.Tables[0].Rows[i]["NgayPhanCong"].ToString();
                        loai = dataSet.Tables[0].Rows[i]["Loai"].ToString();
                        trangthai = dataSet.Tables[0].Rows[i]["TrangThai"].ToString();
                        M_UC_PAMItem pamItem = new M_UC_PAMItem(UserID, functionName, CongTrinhID, NhanVienID, Convert.ToDateTime(ngay), loai, trangthai);
                        panelQuanLiCongTrinh.Controls.Add(pamItem);
                    }
                }
            }
            //NhanVien nhanVien = new NhanVien(this.UserID, this.functionName);

            DataSet dsNV = null;
            if (roleID == 4)
            {
                dsNV = nhanVien.LayNhanVienTheoPhongBanID(PhongBanID);
            }
            else if (roleID == 1)
            {
                dsNV = nhanVien.LayNhanVien();
            }
            if (dsNV != null)
            {
                if (dsNV.Tables.Count > 0 && dsNV.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < dsNV.Tables[0].Rows.Count; i++)
                    {
                        int NhanVienID1 = Convert.ToInt32(dsNV.Tables[0].Rows[i]["NhanVienID"]);
                        string hoTen = dsNV.Tables[0].Rows[i]["HoTen"].ToString();
                        M_UC_nhanvienitemcon m_UC_Nhanvienitemcon = new M_UC_nhanvienitemcon(NhanVienID1, hoTen);
                        flowLayoutPanel2.Controls.Add(m_UC_Nhanvienitemcon);
                    }
                }
            }
            CongTrinh congTrinh = new CongTrinh(this.UserID, this.functionName);
            DataSet dsCT = null;
            if (roleID == 4)
            {
                dsCT = congTrinh.LayCongTrinhTheoPhongBan(PhongBanID);
            }
            else if (roleID == 1)
            {
                dsCT = congTrinh.LayCongTrinh();
            }
            if (dsCT != null)
            {
                if (dsCT.Tables.Count > 0 && dsCT.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < dsCT.Tables[0].Rows.Count; i++)
                    {
                        int CongTrinhID1 = Convert.ToInt32(dsCT.Tables[0].Rows[i]["CongTrinhID"]);
                        string tenCongTrinh = dsCT.Tables[0].Rows[i]["TenCongTrinh"].ToString();
                        M_UC_Congtrinhitemcon congTrinhItem = new M_UC_Congtrinhitemcon(CongTrinhID1, tenCongTrinh);
                        flowLayoutPanel1.Controls.Add(congTrinhItem);
                    }
                }
            }
        }
        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            addPhanCongCongTrinh addPhanCongCongTrinh = new addPhanCongCongTrinh(UserID, functionName, roleID, PhongBanID, () =>
            {
                this.panelQuanLiCongTrinh.Controls.Clear();
                LoadData();
            });
            addPhanCongCongTrinh.ShowDialog();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panelQuanLiCongTrinh_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
