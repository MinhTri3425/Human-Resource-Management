using QLNS.BL_Layer;
using QLNS.UI_Layer.All_UserControl.Manager_UC;
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
    public partial class M_UC_ManageProjectItem : UserControl
    {
        int projectID;
        string projectName;
        string location;
        string startDate;
        string endDate;
        Action reloadCallback;
        int UserID;
        string functionName = "M.CongTrinh(samePB)";
        public M_UC_ManageProjectItem(int projectID, string projectName, string location, string startDate, string endDate, int UserID, string functionName, Action reloadCallback)
        {
            InitializeComponent();
            this.projectID = projectID;
            this.projectName = projectName;
            this.location = location;
            this.startDate = startDate;
            this.endDate = endDate;
            this.reloadCallback = reloadCallback;
            this.UserID = UserID;
            this.functionName = functionName;
            btnXoa.Visible = false;
            btnSua.Visible = false ;


        }

        private void UC_ManageProjectItem_Load(object sender, EventArgs e)
        {
            this.lbIdProject.Text = projectID.ToString();
            this.lbProjectName.Text = projectName;
            this.lbLocation.Text = location;
            this.lbNgayBatDau.Text = startDate;
            this.lbNgayKetThuc.Text = endDate;
        }

        private void UC_ManageProjectItem_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void UC_ManageProjectItem_MouseLeave(object sender, EventArgs e)
        {
            if (!this.ClientRectangle.Contains(this.PointToClient(Cursor.Position)))
            {
                btnXoa.Visible = false;
                btnSua.Visible = false; 
            }
        }

        private void UC_ManageProjectItem_MouseEnter(object sender, EventArgs e)
        {
            btnXoa.Visible = true;
            btnSua.Visible = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa công trình này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string err = "";
                CongTrinh congTrinh = new CongTrinh(UserID, functionName);
                bool xoaOK = congTrinh.XoaCongTrinh(projectID, ref err);

                if (xoaOK)
                {
                    // Ghi nhật ký (tuỳ chọn)
                    NhatKy nhatKy = new NhatKy(UserID, functionName);
                    nhatKy.ThemNhatKy(UserID, $"Xóa công trình: {projectName}", DateTime.Now, ref err);

                    MessageBox.Show("Xóa công trình thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reloadCallback?.Invoke();
                }
                else
                {
                    MessageBox.Show("Xóa công trình thất bại: " + err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            M_SuaCongTrinh form = new M_SuaCongTrinh(projectID, projectName, location, startDate, endDate, UserID, functionName, () =>
            {
                reloadCallback?.Invoke();
            });
            form.ShowDialog();
        }
    }
}
