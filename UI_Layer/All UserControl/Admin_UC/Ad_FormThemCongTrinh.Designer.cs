namespace QLNS.UI_Layer.All_UserControl.Admin_UC
{
    partial class Ad_FormThemCongTrinh
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
            this.dateNgayKetThuc = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dateNgayBatDau = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtDiaDiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenCongTrinh = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDepartment = new Guna.UI2.WinForms.Guna2ComboBox();
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
            this.btnHuy.Location = new System.Drawing.Point(549, 264);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(102, 40);
            this.btnHuy.TabIndex = 40;
            this.btnHuy.Text = "Cancel";
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
            this.btnLuu.Location = new System.Drawing.Point(391, 264);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(102, 40);
            this.btnLuu.TabIndex = 39;
            this.btnLuu.Text = "Save";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // dateNgayKetThuc
            // 
            this.dateNgayKetThuc.Checked = true;
            this.dateNgayKetThuc.FillColor = System.Drawing.Color.White;
            this.dateNgayKetThuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateNgayKetThuc.Location = new System.Drawing.Point(391, 177);
            this.dateNgayKetThuc.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateNgayKetThuc.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateNgayKetThuc.Name = "dateNgayKetThuc";
            this.dateNgayKetThuc.Size = new System.Drawing.Size(260, 34);
            this.dateNgayKetThuc.TabIndex = 38;
            this.dateNgayKetThuc.Value = new System.DateTime(2025, 5, 26, 12, 3, 2, 965);
            // 
            // dateNgayBatDau
            // 
            this.dateNgayBatDau.Checked = true;
            this.dateNgayBatDau.FillColor = System.Drawing.Color.White;
            this.dateNgayBatDau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateNgayBatDau.Location = new System.Drawing.Point(18, 177);
            this.dateNgayBatDau.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateNgayBatDau.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateNgayBatDau.Name = "dateNgayBatDau";
            this.dateNgayBatDau.Size = new System.Drawing.Size(260, 34);
            this.dateNgayBatDau.TabIndex = 37;
            this.dateNgayBatDau.Value = new System.DateTime(2025, 5, 26, 12, 3, 2, 965);
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaDiem.DefaultText = "";
            this.txtDiaDiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiaDiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiaDiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaDiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaDiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaDiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDiaDiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaDiem.Location = new System.Drawing.Point(391, 92);
            this.txtDiaDiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.PlaceholderText = "";
            this.txtDiaDiem.SelectedText = "";
            this.txtDiaDiem.Size = new System.Drawing.Size(265, 30);
            this.txtDiaDiem.TabIndex = 36;
            // 
            // txtTenCongTrinh
            // 
            this.txtTenCongTrinh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenCongTrinh.DefaultText = "";
            this.txtTenCongTrinh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenCongTrinh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenCongTrinh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenCongTrinh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenCongTrinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenCongTrinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenCongTrinh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenCongTrinh.Location = new System.Drawing.Point(18, 92);
            this.txtTenCongTrinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenCongTrinh.Name = "txtTenCongTrinh";
            this.txtTenCongTrinh.PlaceholderText = "";
            this.txtTenCongTrinh.SelectedText = "";
            this.txtTenCongTrinh.Size = new System.Drawing.Size(265, 30);
            this.txtTenCongTrinh.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(387, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "End Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(14, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Start Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Location = new System.Drawing.Point(387, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "Location";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(14, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Project Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 29);
            this.label1.TabIndex = 30;
            this.label1.Text = "Add Project";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(18, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Department";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.BackColor = System.Drawing.Color.Transparent;
            this.cmbDepartment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDepartment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDepartment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbDepartment.ItemHeight = 30;
            this.cmbDepartment.Location = new System.Drawing.Point(22, 264);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(256, 36);
            this.cmbDepartment.TabIndex = 42;
            // 
            // Ad_FormThemCongTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 393);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dateNgayKetThuc);
            this.Controls.Add(this.dateNgayBatDau);
            this.Controls.Add(this.txtDiaDiem);
            this.Controls.Add(this.txtTenCongTrinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ad_FormThemCongTrinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ad_FormThemCongTrinh";
            this.Load += new System.EventHandler(this.Ad_FormThemCongTrinh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnHuy;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateNgayKetThuc;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateNgayBatDau;
        private Guna.UI2.WinForms.Guna2TextBox txtDiaDiem;
        private Guna.UI2.WinForms.Guna2TextBox txtTenCongTrinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cmbDepartment;
    }
}