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
    public partial class A_UC_Timekeeping : UserControl
    {
        int UserID;
        String functionName;
        int ChamCongID;
        int NhanVienID;
        string ngay;
        string gioBatDau;
        string gioKetThuc;
        string trangThai;
        public A_UC_Timekeeping(int UserID, string functionName)
        {
            InitializeComponent();
            this.UserID = UserID;
            this.functionName = functionName;
            LoadData();

        }
        public void LoadData()
        {
            ChamCong chamCong = new ChamCong(this.UserID, this.functionName);
            DataSet dataSet = chamCong.LayChamCong();
            if (dataSet != null)
            {
                if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                    {
                        ChamCongID = Convert.ToInt32(dataSet.Tables[0].Rows[i]["ChamCongID"]);
                        NhanVienID = Convert.ToInt32(dataSet.Tables[0].Rows[i]["NhanVienID"]);
                        ngay = dataSet.Tables[0].Rows[i]["Ngay"].ToString();
                        gioBatDau = dataSet.Tables[0].Rows[i]["GioVao"].ToString();
                        gioKetThuc = dataSet.Tables[0].Rows[i]["GioRa"].ToString();
                        trangThai = dataSet.Tables[0].Rows[i]["TrangThai"].ToString();
                        A_UC_TimekeepingItem Item = new A_UC_TimekeepingItem(ChamCongID, NhanVienID, ngay, gioBatDau, gioKetThuc, trangThai);
                        flowLayoutPanel1.Controls.Add(Item);
                    }
                }
            }
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
