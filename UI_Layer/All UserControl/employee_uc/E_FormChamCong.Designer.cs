namespace QLNS.UI_Layer.All_UserControl.Employee_UC
{
    partial class E_FormChamCong
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
            this.dateNgay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.timeGioVao = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timeGioRa = new Guna.UI2.WinForms.Guna2DateTimePicker();
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
            this.btnHuy.Location = new System.Drawing.Point(473, 257);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(102, 40);
            this.btnHuy.TabIndex = 68;
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
            this.btnLuu.Location = new System.Drawing.Point(227, 257);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(102, 40);
            this.btnLuu.TabIndex = 67;
            this.btnLuu.Text = "Save";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // dateNgay
            // 
            this.dateNgay.Checked = true;
            this.dateNgay.FillColor = System.Drawing.Color.White;
            this.dateNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateNgay.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateNgay.Location = new System.Drawing.Point(23, 184);
            this.dateNgay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateNgay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateNgay.Name = "dateNgay";
            this.dateNgay.Size = new System.Drawing.Size(307, 34);
            this.dateNgay.TabIndex = 66;
            this.dateNgay.Value = new System.DateTime(2025, 5, 26, 12, 3, 2, 965);
            // 
            // timeGioVao
            // 
            this.timeGioVao.Checked = true;
            this.timeGioVao.FillColor = System.Drawing.Color.White;
            this.timeGioVao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.timeGioVao.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeGioVao.Location = new System.Drawing.Point(23, 91);
            this.timeGioVao.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.timeGioVao.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.timeGioVao.Name = "timeGioVao";
            this.timeGioVao.ShowUpDown = true;
            this.timeGioVao.Size = new System.Drawing.Size(307, 34);
            this.timeGioVao.TabIndex = 65;
            this.timeGioVao.Value = new System.DateTime(2025, 5, 26, 12, 3, 2, 965);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(19, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 63;
            this.label2.Text = "Check-in Time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Location = new System.Drawing.Point(469, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 20);
            this.label8.TabIndex = 62;
            this.label8.Text = "Check-out Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(19, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 20);
            this.label7.TabIndex = 61;
            this.label7.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 29);
            this.label1.TabIndex = 60;
            this.label1.Text = "Log Time";
            // 
            // timeGioRa
            // 
            this.timeGioRa.Checked = true;
            this.timeGioRa.FillColor = System.Drawing.Color.White;
            this.timeGioRa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.timeGioRa.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeGioRa.Location = new System.Drawing.Point(473, 91);
            this.timeGioRa.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.timeGioRa.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.timeGioRa.Name = "timeGioRa";
            this.timeGioRa.ShowUpDown = true;
            this.timeGioRa.Size = new System.Drawing.Size(307, 34);
            this.timeGioRa.TabIndex = 70;
            this.timeGioRa.Value = new System.DateTime(2025, 5, 26, 12, 3, 2, 965);
            // 
            // E_FormChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 331);
            this.Controls.Add(this.timeGioRa);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dateNgay);
            this.Controls.Add(this.timeGioVao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "E_FormChamCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E_FormChamCong";
            this.Load += new System.EventHandler(this.E_FormChamCong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnHuy;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateNgay;
        private Guna.UI2.WinForms.Guna2DateTimePicker timeGioVao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker timeGioRa;
    }
}