namespace QLNS.UI_Layer.All_UserControl.Manager_UC
{
    partial class M_UC_Congtrinhitemcon
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
            this.lbCongtrinhID = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbCongtrinhID
            // 
            this.lbCongtrinhID.AutoSize = true;
            this.lbCongtrinhID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCongtrinhID.Location = new System.Drawing.Point(54, 13);
            this.lbCongtrinhID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCongtrinhID.Name = "lbCongtrinhID";
            this.lbCongtrinhID.Size = new System.Drawing.Size(140, 31);
            this.lbCongtrinhID.TabIndex = 22;
            this.lbCongtrinhID.Text = "Nhân Viên";
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
            // 
            // M_UC_Congtrinhitemcon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.name);
            this.Controls.Add(this.lbCongtrinhID);
            this.Name = "M_UC_Congtrinhitemcon";
            this.Size = new System.Drawing.Size(653, 59);
            this.Load += new System.EventHandler(this.M_UC_Congtrinhitemcon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCongtrinhID;
        private System.Windows.Forms.Label name;
    }
}
