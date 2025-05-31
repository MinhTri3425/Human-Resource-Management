namespace QLNS.UI_Layer.All_UserControl.Admin_UC
{
    partial class A_ThemTangCa
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbLoaiTangCa = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.timeGioKetThuc = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.dateNgayTangCa = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.timeGioBatDau = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbHoTenNhanVien = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // cmbLoaiTangCa
            // 
            this.cmbLoaiTangCa.BackColor = System.Drawing.Color.Transparent;
            this.cmbLoaiTangCa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLoaiTangCa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiTangCa.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbLoaiTangCa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbLoaiTangCa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbLoaiTangCa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbLoaiTangCa.ItemHeight = 40;
            this.cmbLoaiTangCa.Items.AddRange(new object[] {
            "Tăng ca thường",
            "Tăng ca lễ"});
            this.cmbLoaiTangCa.Location = new System.Drawing.Point(22, 276);
            this.cmbLoaiTangCa.Name = "cmbLoaiTangCa";
            this.cmbLoaiTangCa.Size = new System.Drawing.Size(307, 46);
            this.cmbLoaiTangCa.TabIndex = 73;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(24, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 72;
            this.label5.Text = "Overtime Form";
            // 
            // timeGioKetThuc
            // 
            this.timeGioKetThuc.Checked = true;
            this.timeGioKetThuc.FillColor = System.Drawing.Color.White;
            this.timeGioKetThuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.timeGioKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeGioKetThuc.Location = new System.Drawing.Point(473, 177);
            this.timeGioKetThuc.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.timeGioKetThuc.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.timeGioKetThuc.Name = "timeGioKetThuc";
            this.timeGioKetThuc.ShowUpDown = true;
            this.timeGioKetThuc.Size = new System.Drawing.Size(315, 34);
            this.timeGioKetThuc.TabIndex = 71;
            this.timeGioKetThuc.Value = new System.DateTime(2025, 5, 26, 12, 3, 2, 965);
            // 
            // btnHuy
            // 
            this.btnHuy.BorderRadius = 12;
            this.btnHuy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHuy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHuy.FillColor = System.Drawing.Color.Black;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(685, 276);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(102, 40);
            this.btnHuy.TabIndex = 69;
            this.btnHuy.Text = "Cancel";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BorderRadius = 12;
            this.btnLuu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuu.FillColor = System.Drawing.Color.Black;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(561, 276);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(102, 40);
            this.btnLuu.TabIndex = 68;
            this.btnLuu.Text = "Save";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // dateNgayTangCa
            // 
            this.dateNgayTangCa.Checked = true;
            this.dateNgayTangCa.FillColor = System.Drawing.Color.White;
            this.dateNgayTangCa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateNgayTangCa.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateNgayTangCa.Location = new System.Drawing.Point(473, 93);
            this.dateNgayTangCa.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateNgayTangCa.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateNgayTangCa.Name = "dateNgayTangCa";
            this.dateNgayTangCa.Size = new System.Drawing.Size(315, 34);
            this.dateNgayTangCa.TabIndex = 67;
            this.dateNgayTangCa.Value = new System.DateTime(2025, 5, 26, 12, 3, 2, 965);
            // 
            // timeGioBatDau
            // 
            this.timeGioBatDau.Checked = true;
            this.timeGioBatDau.FillColor = System.Drawing.Color.White;
            this.timeGioBatDau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.timeGioBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeGioBatDau.Location = new System.Drawing.Point(22, 177);
            this.timeGioBatDau.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.timeGioBatDau.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.timeGioBatDau.Name = "timeGioBatDau";
            this.timeGioBatDau.ShowUpDown = true;
            this.timeGioBatDau.Size = new System.Drawing.Size(307, 34);
            this.timeGioBatDau.TabIndex = 66;
            this.timeGioBatDau.Value = new System.DateTime(2025, 5, 26, 12, 3, 2, 965);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(469, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 65;
            this.label3.Text = "End Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(18, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 64;
            this.label2.Text = "Start Time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Location = new System.Drawing.Point(469, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 20);
            this.label8.TabIndex = 63;
            this.label8.Text = "Overtime day";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(18, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 20);
            this.label7.TabIndex = 62;
            this.label7.Text = "Employee Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 29);
            this.label1.TabIndex = 61;
            this.label1.Text = "Add Overtime";
            // 
            // cmbHoTenNhanVien
            // 
            this.cmbHoTenNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.cmbHoTenNhanVien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbHoTenNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHoTenNhanVien.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbHoTenNhanVien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbHoTenNhanVien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbHoTenNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbHoTenNhanVien.ItemHeight = 30;
            this.cmbHoTenNhanVien.Location = new System.Drawing.Point(22, 91);
            this.cmbHoTenNhanVien.Name = "cmbHoTenNhanVien";
            this.cmbHoTenNhanVien.Size = new System.Drawing.Size(307, 36);
            this.cmbHoTenNhanVien.TabIndex = 70;
            // 
            // A_ThemTangCa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbLoaiTangCa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.timeGioKetThuc);
            this.Controls.Add(this.cmbHoTenNhanVien);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dateNgayTangCa);
            this.Controls.Add(this.timeGioBatDau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "A_ThemTangCa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A_ThemTangCa";
            this.Load += new System.EventHandler(this.A_ThemTangCa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cmbLoaiTangCa;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DateTimePicker timeGioKetThuc;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateNgayTangCa;
        private Guna.UI2.WinForms.Guna2DateTimePicker timeGioBatDau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbHoTenNhanVien;
    }
}