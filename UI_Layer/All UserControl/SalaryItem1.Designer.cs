namespace QLNS.UI_Layer.All_UserControl
{
    partial class SalaryItem1
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
            this.lbThang = new System.Windows.Forms.Label();
            this.lbNam = new System.Windows.Forms.Label();
            this.lbLuongCoBan = new System.Windows.Forms.Label();
            this.lbPhuCap = new System.Windows.Forms.Label();
            this.lbTong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbThang
            // 
            this.lbThang.AutoSize = true;
            this.lbThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThang.Location = new System.Drawing.Point(42, 14);
            this.lbThang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbThang.Name = "lbThang";
            this.lbThang.Size = new System.Drawing.Size(140, 31);
            this.lbThang.TabIndex = 19;
            this.lbThang.Text = "Nhân Viên";
            // 
            // lbNam
            // 
            this.lbNam.AutoSize = true;
            this.lbNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNam.Location = new System.Drawing.Point(233, 14);
            this.lbNam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNam.Name = "lbNam";
            this.lbNam.Size = new System.Drawing.Size(140, 31);
            this.lbNam.TabIndex = 20;
            this.lbNam.Text = "Nhân Viên";
            this.lbNam.Click += new System.EventHandler(this.lbNam_Click);
            // 
            // lbLuongCoBan
            // 
            this.lbLuongCoBan.AutoSize = true;
            this.lbLuongCoBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLuongCoBan.Location = new System.Drawing.Point(493, 14);
            this.lbLuongCoBan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLuongCoBan.Name = "lbLuongCoBan";
            this.lbLuongCoBan.Size = new System.Drawing.Size(140, 31);
            this.lbLuongCoBan.TabIndex = 21;
            this.lbLuongCoBan.Text = "Nhân Viên";
            // 
            // lbPhuCap
            // 
            this.lbPhuCap.AutoSize = true;
            this.lbPhuCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhuCap.Location = new System.Drawing.Point(854, 14);
            this.lbPhuCap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPhuCap.Name = "lbPhuCap";
            this.lbPhuCap.Size = new System.Drawing.Size(140, 31);
            this.lbPhuCap.TabIndex = 22;
            this.lbPhuCap.Text = "Nhân Viên";
            this.lbPhuCap.Click += new System.EventHandler(this.lbPhuCap_Click);
            // 
            // lbTong
            // 
            this.lbTong.AutoSize = true;
            this.lbTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTong.Location = new System.Drawing.Point(1208, 14);
            this.lbTong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTong.Name = "lbTong";
            this.lbTong.Size = new System.Drawing.Size(140, 31);
            this.lbTong.TabIndex = 23;
            this.lbTong.Text = "Nhân Viên";
            // 
            // SalaryItem1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbTong);
            this.Controls.Add(this.lbPhuCap);
            this.Controls.Add(this.lbLuongCoBan);
            this.Controls.Add(this.lbNam);
            this.Controls.Add(this.lbThang);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SalaryItem1";
            this.Size = new System.Drawing.Size(1456, 59);
            this.Load += new System.EventHandler(this.SalaryItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbThang;
        private System.Windows.Forms.Label lbNam;
        private System.Windows.Forms.Label lbLuongCoBan;
        private System.Windows.Forms.Label lbPhuCap;
        private System.Windows.Forms.Label lbTong;
    }
}
