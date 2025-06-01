using QLNS.BL_Layer;
using QLNS.UI_Layer.HR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS.UI_Layer.All_UserControl.Admin_UC
{
    public partial class NhatKyShow : UserControl
    {
        int UserID;
        private String functionName;
        /*private int ID_NhatKy;
        private int ID_NhanVien;
        private string ThoiGian;
        private string NoiDung;*/
        public NhatKyShow(int UserID, string functionName)
        {
            InitializeComponent();
            this.UserID = UserID;
            this.functionName = functionName;
            LoadData();
        }
        private void LoadData()
        {
            NhatKy nk = new NhatKy(this.UserID, this.functionName);
            DataSet ds = nk.LayNhatKy(); 
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int ID_NhatKy = Convert.ToInt32(row["NhatKyID"]);
                    int ID_NhanVien = Convert.ToInt32(row["UserID"]);
                    string NoiDung = row["HanhDong"].ToString();
                    DateTime ThoiGian = Convert.ToDateTime(row["ThoiGian"]);               
                    nhatky nkItem = new nhatky(ID_NhatKy, ID_NhanVien, NoiDung, ThoiGian);
                    flowLayoutPanel1.Controls.Add(nkItem);
                }
            }
        }
    }
}
