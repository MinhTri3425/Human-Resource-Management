using QLNS.BL_Layer;
using QLNS.UI_Layer.All_UserControl.Accountant_UC;
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
    public partial class A_UC_Salary : UserControl
    {
        int UserID;
        string functionName = "A.Luong";
        int LuongID;
        int NhanVienID;
        int Thang;
        int Nam;
        decimal LuongCoBan;
        decimal PhuCap;
        decimal TongLuong;
        string TrangThai;
        public A_UC_Salary(int UserID)
        {
            InitializeComponent();
            this.UserID = UserID;
            LoadData();
        }
        public void LoadData()
        {
            Luong luong = new Luong(this.UserID, this.functionName);
            DataSet dataSet = luong.LayLuong();
            if (dataSet != null)
            {
                if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                    {
                        LuongID = Convert.ToInt32(dataSet.Tables[0].Rows[i]["LuongID"]);
                        NhanVienID = Convert.ToInt32(dataSet.Tables[0].Rows[i]["NhanVienID"]);
                        Thang = Convert.ToInt32(dataSet.Tables[0].Rows[i]["Thang"]);
                        Nam = Convert.ToInt32(dataSet.Tables[0].Rows[i]["Nam"]);
                        LuongCoBan = Convert.ToDecimal(dataSet.Tables[0].Rows[i]["LuongCoBan"]);
                        PhuCap = Convert.ToDecimal(dataSet.Tables[0].Rows[i]["PhuCap"]);
                        TongLuong = Convert.ToDecimal(dataSet.Tables[0].Rows[i]["TongLuong"]);
                        TrangThai = dataSet.Tables[0].Rows[i]["TrangThai"].ToString();
                        A_UC_SalaryItem salaryItem = new A_UC_SalaryItem(UserID, LuongID, NhanVienID, Thang, Nam, LuongCoBan, PhuCap, TongLuong, TrangThai);
                        flowLayoutPanel1.Controls.Add(salaryItem);
                    }
                }
            }
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
