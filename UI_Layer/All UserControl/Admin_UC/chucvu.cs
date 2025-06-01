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
    public partial class chucvu : UserControl
    {
        private String functionName = "Admin";
        int UserID;
        int IDchucvu;
        public chucvu(int userid, int idchucvu, string tencv)
        {
            InitializeComponent();
            this.UserID = userid;
            this.IDchucvu = idchucvu;
            IDChucVu.Text = idchucvu.ToString();
            TenCV.Text = tencv;
            RegisterHoverEvents(this);
        }
        private void RegisterHoverEvents(Control parent)
        {
            parent.MouseEnter += MouseEnter_ChucVu;
            parent.MouseLeave += MouseLeave_ChucVu;

            foreach (Control child in parent.Controls)
            {
                RegisterHoverEvents(child); // gán cho tất cả control con
            }
        }
        private void MouseEnter_ChucVu(object sender, EventArgs e)
        {
            btnXoa.Visible = true;
            btnSua.Visible = true;
        }

        private void MouseLeave_ChucVu(object sender, EventArgs e)
        {
            if (!this.ClientRectangle.Contains(this.PointToClient(Cursor.Position)))
            {
                btnXoa.Visible = false;
                btnSua.Visible = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa chức vụ?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                string err = "";
                var chucVu = new ChucVu(this.UserID, this.functionName);

                if (chucVu.XoaChucVu(this.IDchucvu, ref err))
                {
                    MessageBox.Show("Xóa chức vụ thành công!");

                    // Ghi nhật ký
                    NhatKy nhatKy = new NhatKy(UserID, functionName);
                    string hanhDong = $"Xóa chức vụ có tên: {TenCV}";
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            int idChucVu = int.Parse(IDChucVu.Text);       // Lấy ID từ label
            string tenChucVu = TenCV.Text.Trim();          // Lấy tên từ label

            using (var form = new FormSuaChucVu(idChucVu, tenChucVu))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    string err = "";
                    var chucVu = new ChucVu(UserID, functionName);

                    if (chucVu.CapNhatChucVu(
                        form.IDChucVuMoi,             // ID mới (thường giống ID cũ)
                        form.TenChucVuMoi,            // Tên mới
                        ref err))
                    {
                        // Cập nhật lại hiển thị trên giao diện
                        IDChucVu.Text = form.IDChucVuMoi.ToString();
                        TenCV.Text = form.TenChucVuMoi;

                        MessageBox.Show("Cập nhật chức vụ thành công!");

                        // Ghi nhật ký
                        NhatKy nhatKy = new NhatKy(UserID, functionName);
                        string hanhDong = $"Sửa chức vụ: {form.TenChucVuMoi}";
                        DateTime recentTime = DateTime.Now;
                        nhatKy.ThemNhatKy(UserID, hanhDong, recentTime, ref err);

                        if (!string.IsNullOrEmpty(err))
                        {
                            MessageBox.Show("Lỗi ghi nhật ký: " + err);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lỗi cập nhật chức vụ: " + err);
                    }
                }
            }
        }
    }
        }
