namespace QLNS.UI_Layer.All_UserControl.Admin_UC
{
    partial class chucvu
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
            this.TenCV = new System.Windows.Forms.Label();
            this.IDChucVu = new System.Windows.Forms.Label();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // TenCV
            // 
            this.TenCV.AutoSize = true;
            this.TenCV.Location = new System.Drawing.Point(214, 11);
            this.TenCV.Name = "TenCV";
            this.TenCV.Size = new System.Drawing.Size(79, 16);
            this.TenCV.TabIndex = 3;
            this.TenCV.Text = "Tên chức vụ";
            // 
            // IDChucVu
            // 
            this.IDChucVu.AutoSize = true;
            this.IDChucVu.Location = new System.Drawing.Point(50, 11);
            this.IDChucVu.Name = "IDChucVu";
            this.IDChucVu.Size = new System.Drawing.Size(70, 16);
            this.IDChucVu.TabIndex = 2;
            this.IDChucVu.Text = "ID Chức vụ";
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
            this.btnSua.Location = new System.Drawing.Point(441, 11);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(61, 24);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.Visible = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
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
            this.btnXoa.Location = new System.Drawing.Point(368, 11);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(61, 24);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Visible = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // chucvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.TenCV);
            this.Controls.Add(this.IDChucVu);
            this.Name = "chucvu";
            this.Size = new System.Drawing.Size(528, 38);
            this.MouseEnter += new System.EventHandler(this.MouseEnter_ChucVu);
            this.MouseLeave += new System.EventHandler(this.MouseLeave_ChucVu);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TenCV;
        private System.Windows.Forms.Label IDChucVu;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
    }
}
