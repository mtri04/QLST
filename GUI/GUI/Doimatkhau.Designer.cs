namespace GUI
{
    partial class Doimatkhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doimatkhau));
            this.checkbox_hienmatkhau = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_manv = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_reenterpassword = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_matkhaumoi = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.bt_doimatkhau = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkbox_hienmatkhau
            // 
            this.checkbox_hienmatkhau.AutoSize = true;
            this.checkbox_hienmatkhau.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkbox_hienmatkhau.Location = new System.Drawing.Point(73, 564);
            this.checkbox_hienmatkhau.Name = "checkbox_hienmatkhau";
            this.checkbox_hienmatkhau.Size = new System.Drawing.Size(138, 24);
            this.checkbox_hienmatkhau.TabIndex = 50;
            this.checkbox_hienmatkhau.Text = "Hiện mật khẩu";
            this.checkbox_hienmatkhau.UseVisualStyleBackColor = true;
            this.checkbox_hienmatkhau.CheckedChanged += new System.EventHandler(this.checkbox_hienmatkhau_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_manv);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(55, 24);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(332, 97);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mã Nhân Viên";
            // 
            // cmb_manv
            // 
            this.cmb_manv.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_manv.FormattingEnabled = true;
            this.cmb_manv.Location = new System.Drawing.Point(16, 43);
            this.cmb_manv.Name = "cmb_manv";
            this.cmb_manv.Size = new System.Drawing.Size(296, 32);
            this.cmb_manv.TabIndex = 0;
            this.cmb_manv.SelectedIndexChanged += new System.EventHandler(this.cmb_manv_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_reenterpassword);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(55, 433);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(332, 103);
            this.groupBox4.TabIndex = 47;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Nhập lại mật khẩu mới";
            // 
            // txt_reenterpassword
            // 
            this.txt_reenterpassword.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_reenterpassword.Location = new System.Drawing.Point(16, 39);
            this.txt_reenterpassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_reenterpassword.Multiline = true;
            this.txt_reenterpassword.Name = "txt_reenterpassword";
            this.txt_reenterpassword.PasswordChar = '*';
            this.txt_reenterpassword.Size = new System.Drawing.Size(296, 55);
            this.txt_reenterpassword.TabIndex = 0;
            this.txt_reenterpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_matkhaumoi);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(55, 287);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(332, 114);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mật khẩu mới";
            // 
            // txt_matkhaumoi
            // 
            this.txt_matkhaumoi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matkhaumoi.Location = new System.Drawing.Point(16, 39);
            this.txt_matkhaumoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_matkhaumoi.Multiline = true;
            this.txt_matkhaumoi.Name = "txt_matkhaumoi";
            this.txt_matkhaumoi.PasswordChar = '*';
            this.txt_matkhaumoi.Size = new System.Drawing.Size(296, 55);
            this.txt_matkhaumoi.TabIndex = 0;
            this.txt_matkhaumoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_user);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(55, 148);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(332, 112);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tài khoản";
            // 
            // txt_user
            // 
            this.txt_user.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.Location = new System.Drawing.Point(18, 35);
            this.txt_user.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_user.Multiline = true;
            this.txt_user.Name = "txt_user";
            this.txt_user.PasswordChar = '*';
            this.txt_user.Size = new System.Drawing.Size(296, 55);
            this.txt_user.TabIndex = 1;
            this.txt_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_user.UseSystemPasswordChar = true;
            // 
            // bt_doimatkhau
            // 
            this.bt_doimatkhau.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_doimatkhau.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_doimatkhau.BackgroundImage")));
            this.bt_doimatkhau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_doimatkhau.FlatAppearance.BorderSize = 0;
            this.bt_doimatkhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_doimatkhau.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_doimatkhau.ForeColor = System.Drawing.Color.NavajoWhite;
            this.bt_doimatkhau.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bt_doimatkhau.Location = new System.Drawing.Point(250, 546);
            this.bt_doimatkhau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_doimatkhau.Name = "bt_doimatkhau";
            this.bt_doimatkhau.Size = new System.Drawing.Size(137, 57);
            this.bt_doimatkhau.TabIndex = 48;
            this.bt_doimatkhau.Text = "Đổi mật khẩu";
            this.bt_doimatkhau.UseVisualStyleBackColor = false;
            this.bt_doimatkhau.Click += new System.EventHandler(this.bt_doimatkhau_Click);
            // 
            // Doimatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(383, 613);
            this.Controls.Add(this.checkbox_hienmatkhau);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.bt_doimatkhau);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Doimatkhau";
            this.Text = "Doimatkhau";
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkbox_hienmatkhau;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmb_manv;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_reenterpassword;
        private System.Windows.Forms.Button bt_doimatkhau;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_matkhaumoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_user;
    }
}