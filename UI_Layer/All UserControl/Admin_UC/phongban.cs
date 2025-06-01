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

namespace QLNS.UI_Layer.All_UserControl.Admin_UC
{
    public partial class phongban : UserControl
    {
        int UserID = 1;
        string functionName = "Admin";
        public phongban(int phongbanid, string Tenpb)
        {
            InitializeComponent();
            IDPBan.Text = phongbanid.ToString();
            TenPB.Text = Tenpb;
            RegisterHoverEvents(this);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (FormSuaPB formSuaPB = new FormSuaPB(int.Parse(IDPBan.Text), TenPB.Text))
            {
                if (formSuaPB.ShowDialog() == DialogResult.OK)
                {
                    string err = "";
                    IDPBan.Text = formSuaPB.IDPhongBanMoi.ToString();
                    TenPB.Text = formSuaPB.TenPbMoi;
                    MessageBox.Show("Cập nhật thành công!");
                    // Ghi nhật ký
                    NhatKy nhatKy = new NhatKy(UserID, functionName);
                    string hanhDong = $"Sửa phòng ban: {formSuaPB.TenPbMoi}";
                    DateTime recentTime = DateTime.Now;
                    nhatKy.ThemNhatKy(UserID, hanhDong, recentTime, ref err);
                }
            }
        }
        private void RegisterHoverEvents(Control parent)
        {
            parent.MouseEnter += MouseEnter_Pb;
            parent.MouseLeave += MouseLeave_Pb;

            foreach (Control child in parent.Controls)
            {
                RegisterHoverEvents(child); // gán cho tất cả control con
            }
        }
        private void MouseEnter_Pb(object sender, EventArgs e)
        {
            btnXoa.Visible = true;
            btnSua.Visible = true;
        }

        private void MouseLeave_Pb(object sender, EventArgs e)
        {
            if (!this.ClientRectangle.Contains(this.PointToClient(Cursor.Position)))
            {
                btnXoa.Visible = false;
                btnSua.Visible = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa phòng ban?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                string err = "";
                var pb = new PhongBan(this.UserID,this.functionName);
                int idpb = IDPBan.Text == "" ? 0 : int.Parse(IDPBan.Text);
                if (pb.XoaPhongBan(idpb, ref err))
                {
                    MessageBox.Show("Xóa chức vụ thành công!");

                    // Ghi nhật ký
                    NhatKy nhatKy = new NhatKy(UserID, functionName);
                    string hanhDong = $"Xóa chức vụ có tên: {TenPB}";
                    DateTime recentTime = DateTime.Now;
                    nhatKy.ThemNhatKy(UserID, hanhDong, recentTime, ref err);

                    if (!string.IsNullOrEmpty(err))
                    {
                        MessageBox.Show("Lỗi ghi nhật ký: " + err);
                    }

                    this.Parent.Controls.Remove(this);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Lỗi: " + err);
                }
            }
        }
    }
}
