namespace QLNS.UI_Layer.All_UserControl.Admin_UC
{
    partial class nhatky
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
            this.NkyID = new System.Windows.Forms.Label();
            this.UserID = new System.Windows.Forms.Label();
            this.HanhDong = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NkyID
            // 
            this.NkyID.AutoSize = true;
            this.NkyID.Location = new System.Drawing.Point(50, 10);
            this.NkyID.Name = "NkyID";
            this.NkyID.Size = new System.Drawing.Size(68, 16);
            this.NkyID.TabIndex = 0;
            this.NkyID.Text = "ID Nhật ký";
            // 
            // UserID
            // 
            this.UserID.AutoSize = true;
            this.UserID.Location = new System.Drawing.Point(211, 10);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(52, 16);
            this.UserID.TabIndex = 1;
            this.UserID.Text = "User ID";
            // 
            // HanhDong
            // 
            this.HanhDong.AutoSize = true;
            this.HanhDong.Location = new System.Drawing.Point(401, 10);
            this.HanhDong.Name = "HanhDong";
            this.HanhDong.Size = new System.Drawing.Size(73, 16);
            this.HanhDong.TabIndex = 2;
            this.HanhDong.Text = "Hành động";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(811, 10);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(63, 16);
            this.Time.TabIndex = 3;
            this.Time.Text = "Thời gian";
            // 
            // nhatky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Time);
            this.Controls.Add(this.HanhDong);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.NkyID);
            this.Name = "nhatky";
            this.Size = new System.Drawing.Size(964, 36);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NkyID;
        private System.Windows.Forms.Label UserID;
        private System.Windows.Forms.Label HanhDong;
        private System.Windows.Forms.Label Time;
    }
}
