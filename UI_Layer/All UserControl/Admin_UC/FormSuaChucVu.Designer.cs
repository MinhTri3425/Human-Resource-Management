namespace QLNS.UI_Layer.All_UserControl.Admin_UC
{
    partial class FormSuaChucVu
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
            this.lbIDNhanVien = new System.Windows.Forms.Label();
            this.lbnkyID = new System.Windows.Forms.Label();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.txtTencv = new Guna.UI2.WinForms.Guna2TextBox();
            this.IDcv = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // lbIDNhanVien
            // 
            this.lbIDNhanVien.AutoSize = true;
            this.lbIDNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDNhanVien.Location = new System.Drawing.Point(27, 109);
            this.lbIDNhanVien.Name = "lbIDNhanVien";
            this.lbIDNhanVien.Size = new System.Drawing.Size(88, 18);
            this.lbIDNhanVien.TabIndex = 3;
            this.lbIDNhanVien.Text = "Tên chức vụ";
            // 
            // lbnkyID
            // 
            this.lbnkyID.AutoSize = true;
            this.lbnkyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnkyID.Location = new System.Drawing.Point(27, 33);
            this.lbnkyID.Name = "lbnkyID";
            this.lbnkyID.Size = new System.Drawing.Size(80, 18);
            this.lbnkyID.TabIndex = 2;
            this.lbnkyID.Text = "ID Chức vụ";
            // 
            // btnLuu
            // 
            this.btnLuu.BorderRadius = 10;
            this.btnLuu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(222, 170);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(84, 45);
            this.btnLuu.TabIndex = 51;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtTencv
            // 
            this.txtTencv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTencv.DefaultText = "";
            this.txtTencv.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTencv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTencv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTencv.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTencv.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTencv.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTencv.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTencv.Location = new System.Drawing.Point(183, 97);
            this.txtTencv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTencv.Name = "txtTencv";
            this.txtTencv.PlaceholderText = "";
            this.txtTencv.SelectedText = "";
            this.txtTencv.Size = new System.Drawing.Size(212, 32);
            this.txtTencv.TabIndex = 52;
            // 
            // IDcv
            // 
            this.IDcv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IDcv.DefaultText = "";
            this.IDcv.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.IDcv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.IDcv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IDcv.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IDcv.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IDcv.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IDcv.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IDcv.Location = new System.Drawing.Point(183, 19);
            this.IDcv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IDcv.Name = "IDcv";
            this.IDcv.PlaceholderText = "";
            this.IDcv.SelectedText = "";
            this.IDcv.Size = new System.Drawing.Size(212, 32);
            this.IDcv.TabIndex = 53;
            // 
            // FormSuaChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 227);
            this.Controls.Add(this.IDcv);
            this.Controls.Add(this.txtTencv);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.lbIDNhanVien);
            this.Controls.Add(this.lbnkyID);
            this.Name = "FormSuaChucVu";
            this.Text = "SuaChucVu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIDNhanVien;
        private System.Windows.Forms.Label lbnkyID;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2TextBox txtTencv;
        private Guna.UI2.WinForms.Guna2TextBox IDcv;
    }
}