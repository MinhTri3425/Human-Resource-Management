using QLNS.BL_Layer;
using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLNS.UI_Layer.All_UserControl.Admin_UC
{
    public partial class ThemUser : Form
    {
        private int UserID;
        private string functionName = "Admin";
        private Action reloadCallback;
        private string username;
        private string password;
        private int roleID;
        private int NhanVienID;

        public ThemUser(int userID, string functionName, Action reloadCallback)
        {
            InitializeComponent();
            UserID = userID;
            this.functionName = functionName;
            this.reloadCallback = reloadCallback;
            cbbRole.Enabled = true; // Cho phép chọn vai trò khi thêm mới user

        }

        private void ThemUser_Load(object sender, EventArgs e)
        {
            try
            {
                LoadComboBoxNhanVien();
                
                cbbnhanvienid.SelectedIndexChanged += cbbnhanvienid_SelectedIndexChanged_1;

                if (cbbnhanvienid.Items.Count > 0)
                    cbbnhanvienid.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải form: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadComboBoxNhanVien()
        {   
            string err = "";
            NhanVien nhanVien = new NhanVien(UserID, functionName);
            DataSet ds = nhanVien.LayTatCaNhanVienChuaCoUser(ref err);

            if (string.IsNullOrEmpty(err))
            {
                cbbnhanvienid.Items.Clear();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    cbbnhanvienid.Items.Add(row["NhanVienID"].ToString());
                }
            }
            else
            {
                MessageBox.Show($"Lỗi khi tải nhân viên: {err}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidateInput()
        {
            username = usernametxt.Text;
            password = passtxt.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                throw new Exception("Username và Password không được để trống.");

            if (username.Any(c => !char.IsLetterOrDigit(c)))
                throw new Exception("Username không được chứa ký tự đặc biệt hoặc dấu cách.");

            if (password.Any(c => !char.IsLetterOrDigit(c)))
                throw new Exception("Password không được chứa ký tự đặc biệt hoặc dấu cách.");

            if (HasUnicode(username) || HasUnicode(password))
                throw new Exception("Username và Password không được chứa tiếng Việt có dấu.");
        }
        private bool HasUnicode(string input)
        {
            string normalized = input.Normalize(NormalizationForm.FormD);
            foreach (char c in normalized)
            {
                UnicodeCategory uc = CharUnicodeInfo.GetUnicodeCategory(c);
                if (uc == UnicodeCategory.NonSpacingMark) // là dấu tiếng Việt
                    return true;
            }
            return false;
        }


        private void SetRoleTheoPhongBan()
        {
            string err = "";
            PhongBan phongBan = new PhongBan(UserID, functionName);
            int phongBanID = phongBan.LayPhongBanIDTheoNhanVienID(NhanVienID, ref err);
            
            switch (phongBanID)
            {
                case 10:
                    SetRole("HR", 2);
                    break;
                case 11:
                    SetRole("Accountant", 3);
                    break;
                case 12:
                    SetRole("Admin", 1);
                    break;
            }
            //GetRoleIDFromComboBox();
        }


        private void SetRole(string roleName, int id)
        {
            cbbRole.Text = roleName;
            cbbRole.SelectedItem = roleName;
             // Đặt lại text để hiển thị đúng
            roleID = id;

        }

        private int GetRoleIDFromComboBox()
        {
            string selectedRole = cbbRole.SelectedItem?.ToString();
            if (selectedRole == "Admin") return 1;
            if (selectedRole == "HR") return 2;
            if (selectedRole == "Accountant") return 3;
            if (selectedRole == "Manager") return 4;
            if (selectedRole == "Employee") return 5;
            throw new Exception("Vai trò không hợp lệ.");
        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            try
            {
                ValidateInput();

                if (cbbnhanvienid.SelectedItem == null)
                    throw new Exception("Bạn phải chọn một nhân viên.");

                NhanVienID = Convert.ToInt32(cbbnhanvienid.SelectedItem.ToString());

                SetRoleTheoPhongBan();

                string err = "";
                Users users = new Users(UserID, functionName);
                string hashPass = users.HashPassword(password);
                roleID = GetRoleIDFromComboBox();
                if (users.ThemUsers(UserID, username, hashPass, roleID, NhanVienID, ref err))
                {
                    MessageBox.Show("Thêm User thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NhatKy nhatKy = new NhatKy(UserID, functionName);
                    nhatKy.ThemNhatKy(UserID, $"Đã thêm User: {username}", DateTime.Now, ref err);
                    reloadCallback?.Invoke();
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Lỗi khi thêm User: {err}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbbnhanvienid_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbbnhanvienid.SelectedItem == null) return;

            try
            {
                NhanVienID = Convert.ToInt32(cbbnhanvienid.SelectedItem.ToString());
                
                SetRoleTheoPhongBan();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật vai trò: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
