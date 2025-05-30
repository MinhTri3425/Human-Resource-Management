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
    public partial class A_UC_Leave : UserControl
    {
        int UserID;
        String functionName;
        int NghiPhepID;
        int NhanVienID;
        string ngaybatdau;
        string ngayketthuc;
        string loai;
        string trangthai;
        public A_UC_Leave(int UserID, string functionName)
        {
            InitializeComponent();
            this.UserID = UserID;
            this.functionName = functionName;
            LoadData();
        }
        public void LoadData()
        {
            NghiPhep nghiPhep = new NghiPhep(this.UserID, this.functionName);
            DataSet dataSet = nghiPhep.LayNghiPhep();
            if (dataSet != null)
            {
                if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                    {
                        NghiPhepID = Convert.ToInt32(dataSet.Tables[0].Rows[i]["NghiPhepID"]);
                        NhanVienID = Convert.ToInt32(dataSet.Tables[0].Rows[i]["NhanVienID"]);
                        ngaybatdau = dataSet.Tables[0].Rows[i]["NgayBatDau"].ToString();
                        ngayketthuc = dataSet.Tables[0].Rows[i]["NgayKetThuc"].ToString();
                        loai = dataSet.Tables[0].Rows[i]["Loai"].ToString();
                        trangthai = dataSet.Tables[0].Rows[i]["TrangThai"].ToString();
                        A_UC_LeaveItem leaveItem = new A_UC_LeaveItem(UserID, functionName, NghiPhepID, NhanVienID, ngaybatdau, ngayketthuc, loai, trangthai);
                        flowLayoutPanel1.Controls.Add(leaveItem);
                    }
                }
            }
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void A_UC_Leave_Load(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cbbtrangthai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
