namespace QLNS.UI_Layer.All_UserControl.Admin_UC
{
    partial class NhatKyShow
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbNgayKy = new System.Windows.Forms.Label();
            this.lbLoaiHD = new System.Windows.Forms.Label();
            this.lbIDNhanVien = new System.Windows.Forms.Label();
            this.lbnkyID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2Panel1.BorderRadius = 2;
            this.guna2Panel1.BorderThickness = 3;
            this.guna2Panel1.Controls.Add(this.flowLayoutPanel1);
            this.guna2Panel1.Controls.Add(this.lbNgayKy);
            this.guna2Panel1.Controls.Add(this.lbLoaiHD);
            this.guna2Panel1.Controls.Add(this.lbIDNhanVien);
            this.guna2Panel1.Controls.Add(this.lbnkyID);
            this.guna2Panel1.Location = new System.Drawing.Point(8, 64);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1036, 356);
            this.guna2Panel1.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(14, 59);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(996, 273);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // lbNgayKy
            // 
            this.lbNgayKy.AutoSize = true;
            this.lbNgayKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayKy.Location = new System.Drawing.Point(866, 26);
            this.lbNgayKy.Name = "lbNgayKy";
            this.lbNgayKy.Size = new System.Drawing.Size(68, 18);
            this.lbNgayKy.TabIndex = 6;
            this.lbNgayKy.Text = "Thời gian";
            // 
            // lbLoaiHD
            // 
            this.lbLoaiHD.AutoSize = true;
            this.lbLoaiHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiHD.Location = new System.Drawing.Point(423, 26);
            this.lbLoaiHD.Name = "lbLoaiHD";
            this.lbLoaiHD.Size = new System.Drawing.Size(80, 18);
            this.lbLoaiHD.TabIndex = 2;
            this.lbLoaiHD.Text = "Hành động";
            // 
            // lbIDNhanVien
            // 
            this.lbIDNhanVien.AutoSize = true;
            this.lbIDNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDNhanVien.Location = new System.Drawing.Point(229, 26);
            this.lbIDNhanVien.Name = "lbIDNhanVien";
            this.lbIDNhanVien.Size = new System.Drawing.Size(91, 18);
            this.lbIDNhanVien.TabIndex = 1;
            this.lbIDNhanVien.Text = "ID Nhân viên";
            // 
            // lbnkyID
            // 
            this.lbnkyID.AutoSize = true;
            this.lbnkyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnkyID.Location = new System.Drawing.Point(66, 26);
            this.lbnkyID.Name = "lbnkyID";
            this.lbnkyID.Size = new System.Drawing.Size(76, 18);
            this.lbnkyID.TabIndex = 0;
            this.lbnkyID.Text = "ID Nhật ký";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Diary";
            // 
            // NhatKyShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label1);
            this.Name = "NhatKyShow";
            this.Size = new System.Drawing.Size(1075, 448);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbNgayKy;
        private System.Windows.Forms.Label lbLoaiHD;
        private System.Windows.Forms.Label lbIDNhanVien;
        private System.Windows.Forms.Label lbnkyID;
        private System.Windows.Forms.Label label1;
    }
}
