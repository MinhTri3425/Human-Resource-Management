using QLNS.BL_Layer;
using QLNS.UI_Layer.All_UserControl.Admin_UC;
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
    public partial class A_UC_OverTime : UserControl
    {
        int UserID;
        String functionName;

        int TangCaID;
        int NhanVienID;
        string ngay;
        string gioBatDau;
        string gioKetThuc;
        string loaiTangCa;
        string hinhThuc;
        string trangThai;
        public A_UC_OverTime(int UserID, string functionName)
        {
            InitializeComponent();
            this.UserID = UserID;
            this.functionName = functionName;
            if (this.functionName.Equals("Admin", StringComparison.OrdinalIgnoreCase))
            {
                btnThem.Visible = true;
            }
            else
            {
                btnThem.Visible = false;
            }
            LoadData();
        }
        public void LoadData()
        {
            TangCa tangCa = new TangCa(this.UserID, this.functionName);
            DataSet dataSet = tangCa.LayTangCa();
            if (dataSet != null)
            {
                if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                    {
                        TangCaID = Convert.ToInt32(dataSet.Tables[0].Rows[i]["TangCaID"]);
                        NhanVienID = Convert.ToInt32(dataSet.Tables[0].Rows[i]["NhanVienID"]);
                        ngay = dataSet.Tables[0].Rows[i]["NgayTangCa"].ToString();
                        gioBatDau = dataSet.Tables[0].Rows[i]["GioBatDau"].ToString();
                        gioKetThuc = dataSet.Tables[0].Rows[i]["GioKetThuc"].ToString();
                        loaiTangCa = dataSet.Tables[0].Rows[i]["LoaiTangCa"].ToString();
                        hinhThuc = dataSet.Tables[0].Rows[i]["HinhThuc"].ToString();
                        trangThai = dataSet.Tables[0].Rows[i]["TrangThai"].ToString();
                        A_UC_OvertimeItem overtimeItem = new A_UC_OvertimeItem(UserID, functionName, TangCaID, NhanVienID, ngay, gioBatDau, gioKetThuc, loaiTangCa, hinhThuc, trangThai);
                        flowLayoutPanel1.Controls.Add(overtimeItem);
                    }
                }
            }
        }
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void A_UC_OverTime_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            A_ThemTangCa form = new A_ThemTangCa(UserID, "Admin", LoadData);
            form.ShowDialog();
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            LoadData();
        }

        private void cbbtrangthai_SelectedIndexChanged(object sender, EventArgs e)
        {
            TangCa tangCa = new TangCa(this.UserID, this.functionName);
            string selectedStatus = cbbtrangthai.SelectedItem.ToString();
            DataSet ds = tangCa.LayTangCaTheoTrangThai(selectedStatus);
            flowLayoutPanel1.Controls.Clear(); // Clear current controls in the panel
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    TangCaID = Convert.ToInt32(ds.Tables[0].Rows[i]["TangCaID"]);
                    NhanVienID = Convert.ToInt32(ds.Tables[0].Rows[i]["NhanVienID"]);
                    ngay = ds.Tables[0].Rows[i]["NgayTangCa"].ToString();
                    gioBatDau = ds.Tables[0].Rows[i]["GioBatDau"].ToString();
                    gioKetThuc = ds.Tables[0].Rows[i]["GioKetThuc"].ToString();
                    loaiTangCa = ds.Tables[0].Rows[i]["LoaiTangCa"].ToString();
                    hinhThuc = ds.Tables[0].Rows[i]["HinhThuc"].ToString();
                    trangThai = ds.Tables[0].Rows[i]["TrangThai"].ToString();
                    A_UC_OvertimeItem overtimeItem = new A_UC_OvertimeItem(UserID, functionName, TangCaID, NhanVienID, ngay, gioBatDau, gioKetThuc, loaiTangCa, hinhThuc, trangThai);
                    flowLayoutPanel1.Controls.Add(overtimeItem);
                }
            }
        }
    }
}
