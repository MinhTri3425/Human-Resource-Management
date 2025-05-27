namespace QLNS.UI_Layer.All_UserControl.Manager_UC
{
    partial class M_ThemTangCa
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
            this.timeGioKetThuc = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.formtangca = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
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
            this.btnHuy.Location = new System.Drawing.Point(1027, 431);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(153, 62);
            this.btnHuy.TabIndex = 51;
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
            this.btnLuu.Location = new System.Drawing.Point(841, 431);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(153, 62);
            this.btnLuu.TabIndex = 50;
            this.btnLuu.Text = "Save";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // dateNgayTangCa
            // 
            this.dateNgayTangCa.Checked = true;
            this.dateNgayTangCa.FillColor = System.Drawing.Color.White;
            this.dateNgayTangCa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateNgayTangCa.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateNgayTangCa.Location = new System.Drawing.Point(710, 145);
            this.dateNgayTangCa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateNgayTangCa.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateNgayTangCa.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateNgayTangCa.Name = "dateNgayTangCa";
            this.dateNgayTangCa.Size = new System.Drawing.Size(472, 53);
            this.dateNgayTangCa.TabIndex = 49;
            this.dateNgayTangCa.Value = new System.DateTime(2025, 5, 26, 12, 3, 2, 965);
            // 
            // timeGioBatDau
            // 
            this.timeGioBatDau.Checked = true;
            this.timeGioBatDau.FillColor = System.Drawing.Color.White;
            this.timeGioBatDau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.timeGioBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeGioBatDau.Location = new System.Drawing.Point(33, 277);
            this.timeGioBatDau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.timeGioBatDau.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.timeGioBatDau.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.timeGioBatDau.Name = "timeGioBatDau";
            this.timeGioBatDau.ShowUpDown = true;
            this.timeGioBatDau.Size = new System.Drawing.Size(460, 53);
            this.timeGioBatDau.TabIndex = 48;
            this.timeGioBatDau.Value = new System.DateTime(2025, 5, 26, 12, 3, 2, 965);
            this.timeGioBatDau.ValueChanged += new System.EventHandler(this.dateNgayBatDau_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(704, 241);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 31);
            this.label3.TabIndex = 45;
            this.label3.Text = "End Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(27, 241);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 31);
            this.label2.TabIndex = 44;
            this.label2.Text = "Start Time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Location = new System.Drawing.Point(704, 106);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 31);
            this.label8.TabIndex = 43;
            this.label8.Text = "Overtime day";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(27, 106);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 31);
            this.label7.TabIndex = 42;
            this.label7.Text = "Employee Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 44);
            this.label1.TabIndex = 41;
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
            this.cmbHoTenNhanVien.Location = new System.Drawing.Point(33, 142);
            this.cmbHoTenNhanVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbHoTenNhanVien.Name = "cmbHoTenNhanVien";
            this.cmbHoTenNhanVien.Size = new System.Drawing.Size(458, 36);
            this.cmbHoTenNhanVien.TabIndex = 52;
            // 
            // timeGioKetThuc
            // 
            this.timeGioKetThuc.Checked = true;
            this.timeGioKetThuc.FillColor = System.Drawing.Color.White;
            this.timeGioKetThuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.timeGioKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeGioKetThuc.Location = new System.Drawing.Point(710, 277);
            this.timeGioKetThuc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.timeGioKetThuc.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.timeGioKetThuc.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.timeGioKetThuc.Name = "timeGioKetThuc";
            this.timeGioKetThuc.ShowUpDown = true;
            this.timeGioKetThuc.Size = new System.Drawing.Size(472, 53);
            this.timeGioKetThuc.TabIndex = 53;
            this.timeGioKetThuc.Value = new System.DateTime(2025, 5, 26, 12, 3, 2, 965);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(36, 379);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 31);
            this.label5.TabIndex = 56;
            this.label5.Text = "Overtime Form";
            // 
            // formtangca
            // 
            this.formtangca.BackColor = System.Drawing.Color.Transparent;
            this.formtangca.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.formtangca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.formtangca.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.formtangca.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.formtangca.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.formtangca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.formtangca.ItemHeight = 40;
            this.formtangca.Items.AddRange(new object[] {
            "Tăng ca thường",
            "Tăng ca lễ"});
            this.formtangca.Location = new System.Drawing.Point(56, 431);
            this.formtangca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.formtangca.Name = "formtangca";
            this.formtangca.Size = new System.Drawing.Size(458, 46);
            this.formtangca.TabIndex = 60;
            // 
            // M_ThemTangCa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 559);
            this.Controls.Add(this.formtangca);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "M_ThemTangCa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "M_ThemTangCa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private Guna.UI2.WinForms.Guna2DateTimePicker timeGioKetThuc;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox formtangca;
    }
}