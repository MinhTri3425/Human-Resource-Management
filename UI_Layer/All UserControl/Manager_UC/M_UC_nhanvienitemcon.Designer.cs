namespace QLNS.UI_Layer.All_UserControl.Manager_UC
{
    partial class M_UC_nhanvienitemcon
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
            this.name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNhanVienID
            // 
            this.lbNhanVienID.AutoSize = true;
            this.lbNhanVienID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhanVienID.Location = new System.Drawing.Point(54, 13);
            this.lbNhanVienID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNhanVienID.Name = "lbNhanVienID";
            this.lbNhanVienID.Size = new System.Drawing.Size(140, 31);
            this.lbNhanVienID.TabIndex = 22;
            this.lbNhanVienID.Text = "Nhân Viên";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(317, 13);
            this.name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(140, 31);
            this.name.TabIndex = 23;
            this.name.Text = "Nhân Viên";
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // M_UC_nhanvienitemcon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.name);
            this.Controls.Add(this.lbNhanVienID);
            this.Name = "M_UC_nhanvienitemcon";
            this.Size = new System.Drawing.Size(653, 59);
            this.Load += new System.EventHandler(this.M_UC_nhanvienitemcon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNhanVienID;
        private System.Windows.Forms.Label name;
    }
}
