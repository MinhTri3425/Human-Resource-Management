﻿namespace QLNS.UI_Layer.HR
{
    partial class H_HopDong
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
            this.lbIDHopDong = new System.Windows.Forms.Label();
            this.lbLoaiHD = new System.Windows.Forms.Label();
            this.lbIDNhanVien = new System.Windows.Forms.Label();
            this.lbNgayKy = new System.Windows.Forms.Label();
            this.lbNgayHetHan = new System.Windows.Forms.Label();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // lbIDHopDong
            // 
            this.lbIDHopDong.AutoSize = true;
            this.lbIDHopDong.Location = new System.Drawing.Point(40, 14);
            this.lbIDHopDong.Name = "lbIDHopDong";
            this.lbIDHopDong.Size = new System.Drawing.Size(83, 16);
            this.lbIDHopDong.TabIndex = 0;
            this.lbIDHopDong.Text = "ID Hợp đồng";
            // 
            // lbLoaiHD
            // 
            this.lbLoaiHD.AutoSize = true;
            this.lbLoaiHD.Location = new System.Drawing.Point(380, 14);
            this.lbLoaiHD.Name = "lbLoaiHD";
            this.lbLoaiHD.Size = new System.Drawing.Size(93, 16);
            this.lbLoaiHD.TabIndex = 1;
            this.lbLoaiHD.Text = "Loại hợp đồng";
            // 
            // lbIDNhanVien
            // 
            this.lbIDNhanVien.AutoSize = true;
            this.lbIDNhanVien.Location = new System.Drawing.Point(216, 14);
            this.lbIDNhanVien.Name = "lbIDNhanVien";
            this.lbIDNhanVien.Size = new System.Drawing.Size(85, 16);
            this.lbIDNhanVien.TabIndex = 2;
            this.lbIDNhanVien.Text = "ID Nhân Viên";
            // 
            // lbNgayKy
            // 
            this.lbNgayKy.AutoSize = true;
            this.lbNgayKy.Location = new System.Drawing.Point(616, 14);
            this.lbNgayKy.Name = "lbNgayKy";
            this.lbNgayKy.Size = new System.Drawing.Size(57, 16);
            this.lbNgayKy.TabIndex = 3;
            this.lbNgayKy.Text = "Ngày ký";
            // 
            // lbNgayHetHan
            // 
            this.lbNgayHetHan.AutoSize = true;
            this.lbNgayHetHan.Location = new System.Drawing.Point(782, 14);
            this.lbNgayHetHan.Name = "lbNgayHetHan";
            this.lbNgayHetHan.Size = new System.Drawing.Size(86, 16);
            this.lbNgayHetHan.TabIndex = 4;
            this.lbNgayHetHan.Text = "Ngày hết hạn";
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
            this.btnSua.Location = new System.Drawing.Point(1004, 14);
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
            this.btnXoa.Location = new System.Drawing.Point(922, 14);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(61, 24);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Visible = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // H_HopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.lbNgayHetHan);
            this.Controls.Add(this.lbNgayKy);
            this.Controls.Add(this.lbIDNhanVien);
            this.Controls.Add(this.lbLoaiHD);
            this.Controls.Add(this.lbIDHopDong);
            this.Name = "H_HopDong";
            this.Size = new System.Drawing.Size(1081, 44);
            this.Load += new System.EventHandler(this.H_HopDong_Load);
            this.MouseEnter += new System.EventHandler(this.MouseEnter_HopDong);
            this.MouseLeave += new System.EventHandler(this.MouseLeave_HopDong);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIDHopDong;
        private System.Windows.Forms.Label lbLoaiHD;
        private System.Windows.Forms.Label lbIDNhanVien;
        private System.Windows.Forms.Label lbNgayKy;
        private System.Windows.Forms.Label lbNgayHetHan;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
    }
}
