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
    public partial class E_FormChamCong : Form
    {
        private int userID;
        private string functionName;
        private int nhanVienID;
        private Action reloadCallback;

        public E_FormChamCong(int userID, string functionName, int nhanVienID, Action reloadCallback)
        {
            InitializeComponent();
            this.userID = userID;
            this.functionName = functionName;
            this.nhanVienID = nhanVienID;
            this.reloadCallback = reloadCallback;

            dateNgay.Value = DateTime.Now;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DateTime ngay = dateNgay.Value.Date;
            string gioVao = timeGioVao.Value.ToString("HH:mm");
            string gioRa = timeGioRa.Value.ToString("HH:mm");
            string trangThai = "Có mặt";

            string err = "";
            ChamCong chamCong = new ChamCong(userID, functionName);

            DataSet dsChamCong = chamCong.LayChamCongTheoNhanVienID(nhanVienID);
            bool daChamCong = dsChamCong.Tables[0].AsEnumerable()
                .Any(row => Convert.ToDateTime(row["Ngay"]).Date == ngay);

            if (daChamCong)
            {
                MessageBox.Show("Bạn đã chấm công ngày này rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            bool result = chamCong.ThemChamCong(nhanVienID, ngay, gioVao, gioRa, trangThai, ref err);

            if (result)
            {
                new NhatKy(userID, functionName).ThemNhatKy(userID, $"Chấm công ngày {ngay:dd/MM/yyyy}", DateTime.Now, ref err);
                MessageBox.Show("Chấm công thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reloadCallback?.Invoke();
                this.Close();
            }
            else
            {
                MessageBox.Show("Chấm công thất bại: " + err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void E_FormChamCong_Load(object sender, EventArgs e)
        {

        }
    }
}
