using QLNS.BL_Layer;
using QLNS.UI_Layer.All_UserControl;
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

namespace QLNS.UI_Layer.HR
{
    public partial class H_NhanVienShow : UserControl
    {
        private String functionName;
        int UserID;
        private int ID_NhanVien;
        private string HoTen;
        private string NgaySinh;
        private string cmnd;
        private string MaSoThue;
        private int idPhong;
        private int idChucVu;
        private string TrangThai;
        public H_NhanVienShow(int userID, string functionName)
        {
            InitializeComponent();
            this.UserID = userID;
            this.functionName = functionName;
            LoadData();
        }
        public void LoadData()
        {
            NhanVien nhanVien = new NhanVien(this.UserID, this.functionName);
            DataSet ds = nhanVien.LayNhanVien();
            if (ds != null)
            {
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        DataRow row = ds.Tables[0].Rows[i];
                        this.ID_NhanVien = Convert.ToInt32(row["NhanVienID"]);
                        this.HoTen = row["HoTen"].ToString();
                        DateTime ngaySinh = Convert.ToDateTime(row["NgaySinh"]);
                        this.NgaySinh = ngaySinh.ToString("dd/MM/yyyy");
                        this.cmnd = row["CMND"].ToString();
                        this.MaSoThue = row["MaSoThue"].ToString();
                        this.idPhong = Convert.ToInt32(row["PhongBanID"]);
                        this.idChucVu = Convert.ToInt32(row["ChucVuID"]);
                        this.TrangThai = row["TrangThai"].ToString();
                        H_NhanVien nv = new H_NhanVien(UserID, functionName ,ID_NhanVien, HoTen, NgaySinh, cmnd, MaSoThue, idPhong, idChucVu, TrangThai);
                        this.flowLayoutPanel1.Controls.Add(nv);
                    }
                }
            }
        }


        private void H_NhanVienShow_Load(object sender, EventArgs e)
        {
            
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var form = new FormThemNhanVien(this.UserID))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData(); 
                }
            }

        }
    }
}
