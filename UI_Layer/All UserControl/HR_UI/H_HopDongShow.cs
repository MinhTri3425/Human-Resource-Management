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

namespace QLNS.UI_Layer.HR
{
    public partial class H_HopDongShow : UserControl
    {
        int UserID;
        private String functionName;
        private int ID_HopDong;
        private int ID_NhanVien;
        private string LoaiHopDong;
        private string NgayBatDau;
        private string NgayKetThuc;
        public H_HopDongShow(int UserID, string functionName)
        {
            InitializeComponent();
            this.UserID = UserID;
            this.functionName = functionName;
            LoadData();
        }
        private void LoadData()
        {
            HopDongLaoDong hopDong = new HopDongLaoDong(this.UserID, this.functionName);
            DataSet ds = hopDong.LayHopDongLaoDong();
            if (ds != null)
            {
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        DataRow row = ds.Tables[0].Rows[i];
                        this.ID_HopDong = Convert.ToInt32(row["HopDongID"]);
                        this.ID_NhanVien = Convert.ToInt32(row["NhanVienID"]);
                        this.LoaiHopDong = row["LoaiHopDong"].ToString();
                        DateTime ngayBatDau = Convert.ToDateTime(row["NgayKy"]);
                        this.NgayBatDau = ngayBatDau.ToString("dd/MM/yyyy");
                        DateTime? ngayKetThuc = null;
                        if (row["NgayHetHan"] != DBNull.Value)
                        {
                            ngayKetThuc = Convert.ToDateTime(row["NgayHetHan"]);
                            this.NgayKetThuc = ngayKetThuc.Value.ToString("dd/MM/yyyy");
                        }
                        H_HopDong hd = new H_HopDong(UserID, functionName, ID_HopDong, ID_NhanVien, LoaiHopDong, NgayBatDau, NgayKetThuc);
                        this.flowLayoutPanel1.Controls.Add(hd);
                    }
                }
            }
        }
    }
}
