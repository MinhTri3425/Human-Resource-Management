namespace QLNS.UI_Layer.HR
{
    partial class H_NhanVien
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbNhanVienID = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.lbCMND = new System.Windows.Forms.Label();
            this.lbMaSoThue = new System.Windows.Forms.Label();
            this.lbPhongBan = new System.Windows.Forms.Label();
            this.lbChucVu = new System.Windows.Forms.Label();
            this.lbTrangThai = new System.Windows.Forms.Label();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // lbNhanVienID
            // 
            this.lbNhanVienID.AutoSize = true;
            this.lbNhanVienID.Location = new System.Drawing.Point(30, 11);
            this.lbNhanVienID.Name = "lbNhanVienID";
            this.lbNhanVienID.Size = new System.Drawing.Size(80, 16);
            this.lbNhanVienID.TabIndex = 0;
            this.lbNhanVienID.Text = "ID nhân viên";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Location = new System.Drawing.Point(150, 11);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(46, 16);
            this.lbHoTen.TabIndex = 1;
            this.lbHoTen.Text = "Họ tên";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Location = new System.Drawing.Point(319, 11);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(67, 16);
            this.lbNgaySinh.TabIndex = 2;
            this.lbNgaySinh.Text = "Ngày sinh";
            // 
            // lbCMND
            // 
            this.lbCMND.AutoSize = true;
            this.lbCMND.Location = new System.Drawing.Point(480, 11);
            this.lbCMND.Name = "lbCMND";
            this.lbCMND.Size = new System.Drawing.Size(47, 16);
            this.lbCMND.TabIndex = 3;
            this.lbCMND.Text = "CMND";
            // 
            // lbMaSoThue
            // 
            this.lbMaSoThue.AutoSize = true;
            this.lbMaSoThue.Location = new System.Drawing.Point(576, 11);
            this.lbMaSoThue.Name = "lbMaSoThue";
            this.lbMaSoThue.Size = new System.Drawing.Size(72, 16);
            this.lbMaSoThue.TabIndex = 4;
            this.lbMaSoThue.Text = "Mã số thuế";
            // 
            // lbPhongBan
            // 
            this.lbPhongBan.AutoSize = true;
            this.lbPhongBan.Location = new System.Drawing.Point(686, 11);
            this.lbPhongBan.Name = "lbPhongBan";
            this.lbPhongBan.Size = new System.Drawing.Size(88, 16);
            this.lbPhongBan.TabIndex = 5;
            this.lbPhongBan.Text = "ID Phòng ban";
            // 
            // lbChucVu
            // 
            this.lbChucVu.AutoSize = true;
            this.lbChucVu.Location = new System.Drawing.Point(823, 11);
            this.lbChucVu.Name = "lbChucVu";
            this.lbChucVu.Size = new System.Drawing.Size(70, 16);
            this.lbChucVu.TabIndex = 6;
            this.lbChucVu.Text = "ID Chức vụ";
            // 
            // lbTrangThai
            // 
            this.lbTrangThai.AutoSize = true;
            this.lbTrangThai.Location = new System.Drawing.Point(899, 11);
            this.lbTrangThai.Name = "lbTrangThai";
            this.lbTrangThai.Size = new System.Drawing.Size(67, 16);
            this.lbTrangThai.TabIndex = 7;
            this.lbTrangThai.Text = "Trạng thái";
            // 
            // btnXoa
            // 
            this.btnXoa.BorderRadius = 10;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.FillColor = System.Drawing.Color.Black;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(1006, 11);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(61, 24);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Visible = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BorderRadius = 10;
            this.btnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSua.FillColor = System.Drawing.Color.Black;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(1079, 11);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(61, 24);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.Visible = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // H_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.lbTrangThai);
            this.Controls.Add(this.lbChucVu);
            this.Controls.Add(this.lbPhongBan);
            this.Controls.Add(this.lbMaSoThue);
            this.Controls.Add(this.lbCMND);
            this.Controls.Add(this.lbNgaySinh);
            this.Controls.Add(this.lbHoTen);
            this.Controls.Add(this.lbNhanVienID);
            this.Name = "H_NhanVien";
            this.Size = new System.Drawing.Size(1159, 41);
            this.Load += new System.EventHandler(this.Load_NhanVien);
            this.MouseEnter += new System.EventHandler(this.MouseEnter_NhanVien);
            this.MouseLeave += new System.EventHandler(this.MouseLeave_NhanVien);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNhanVienID;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.Label lbCMND;
        private System.Windows.Forms.Label lbMaSoThue;
        private System.Windows.Forms.Label lbPhongBan;
        private System.Windows.Forms.Label lbChucVu;
        private System.Windows.Forms.Label lbTrangThai;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnSua;
    }
}
