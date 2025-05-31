namespace QLNS.UI_Layer.All_UserControl.Employee_UC
{
    partial class E_FormNopNghiPhep
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
            this.dateNgayBatDau = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateNgayKetThuc = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbLoaiNghiPhep = new Guna.UI2.WinForms.Guna2ComboBox();
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
            this.btnHuy.Location = new System.Drawing.Point(473, 285);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(102, 40);
            this.btnHuy.TabIndex = 78;
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
            this.btnLuu.Location = new System.Drawing.Point(228, 285);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(102, 40);
            this.btnLuu.TabIndex = 77;
            this.btnLuu.Text = "Submit";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // dateNgayBatDau
            // 
            this.dateNgayBatDau.Checked = true;
            this.dateNgayBatDau.FillColor = System.Drawing.Color.White;
            this.dateNgayBatDau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateNgayBatDau.Location = new System.Drawing.Point(28, 91);
            this.dateNgayBatDau.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateNgayBatDau.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateNgayBatDau.Name = "dateNgayBatDau";
            this.dateNgayBatDau.Size = new System.Drawing.Size(307, 34);
            this.dateNgayBatDau.TabIndex = 76;
            this.dateNgayBatDau.Value = new System.DateTime(2025, 5, 26, 12, 3, 2, 965);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(24, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 74;
            this.label2.Text = "Start date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(469, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 72;
            this.label7.Text = "End Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 29);
            this.label1.TabIndex = 71;
            this.label1.Text = "Submit Leave Requests";
            // 
            // dateNgayKetThuc
            // 
            this.dateNgayKetThuc.Checked = true;
            this.dateNgayKetThuc.FillColor = System.Drawing.Color.White;
            this.dateNgayKetThuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateNgayKetThuc.Location = new System.Drawing.Point(473, 91);
            this.dateNgayKetThuc.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateNgayKetThuc.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateNgayKetThuc.Name = "dateNgayKetThuc";
            this.dateNgayKetThuc.Size = new System.Drawing.Size(307, 34);
            this.dateNgayKetThuc.TabIndex = 79;
            this.dateNgayKetThuc.Value = new System.DateTime(2025, 5, 26, 12, 3, 2, 965);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(24, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 80;
            this.label3.Text = "Type";
            // 
            // cmbLoaiNghiPhep
            // 
            this.cmbLoaiNghiPhep.BackColor = System.Drawing.Color.Transparent;
            this.cmbLoaiNghiPhep.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLoaiNghiPhep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiNghiPhep.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbLoaiNghiPhep.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbLoaiNghiPhep.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbLoaiNghiPhep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbLoaiNghiPhep.ItemHeight = 30;
            this.cmbLoaiNghiPhep.Items.AddRange(new object[] {
            "Nghỉ phép năm",
            "Nghỉ không lương",
            "Nghỉ ốm",
            "Nghỉ thai sản",
            "Nghỉ việc riêng",
            "Nghỉ tang",
            "Nghỉ kết hôn",
            "Nghỉ có lương"});
            this.cmbLoaiNghiPhep.Location = new System.Drawing.Point(30, 215);
            this.cmbLoaiNghiPhep.Name = "cmbLoaiNghiPhep";
            this.cmbLoaiNghiPhep.Size = new System.Drawing.Size(304, 36);
            this.cmbLoaiNghiPhep.TabIndex = 81;
            // 
            // E_FormNopNghiPhep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 369);
            this.Controls.Add(this.cmbLoaiNghiPhep);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateNgayKetThuc);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dateNgayBatDau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "E_FormNopNghiPhep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E_FormNopNghiPhep";
            this.Load += new System.EventHandler(this.E_FormNopNghiPhep_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnHuy;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateNgayBatDau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateNgayKetThuc;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cmbLoaiNghiPhep;
    }
}