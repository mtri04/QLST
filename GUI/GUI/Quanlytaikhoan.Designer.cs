namespace GUI
{
    partial class Quanlytaikhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quanlytaikhoan));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.datetimepacket_datecreate = new System.Windows.Forms.DateTimePicker();
            this.cmb_chucvu = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_nhaplai = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.dgv_taikhoan = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_body = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_taikhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.datetimepacket_datecreate);
            this.groupBox2.Controls.Add(this.cmb_chucvu);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_user);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_password);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_manv);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(447, 309);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin tài khoản nhân viên";
            // 
            // datetimepacket_datecreate
            // 
            this.datetimepacket_datecreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimepacket_datecreate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimepacket_datecreate.Location = new System.Drawing.Point(188, 210);
            this.datetimepacket_datecreate.Name = "datetimepacket_datecreate";
            this.datetimepacket_datecreate.Size = new System.Drawing.Size(138, 26);
            this.datetimepacket_datecreate.TabIndex = 123;
            // 
            // cmb_chucvu
            // 
            this.cmb_chucvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_chucvu.FormattingEnabled = true;
            this.cmb_chucvu.Location = new System.Drawing.Point(188, 261);
            this.cmb_chucvu.Name = "cmb_chucvu";
            this.cmb_chucvu.Size = new System.Drawing.Size(215, 28);
            this.cmb_chucvu.TabIndex = 119;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(39, 38);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 19);
            this.label8.TabIndex = 38;
            this.label8.Text = "Mã NV:";
            // 
            // txt_user
            // 
            this.txt_user.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.Location = new System.Drawing.Point(188, 87);
            this.txt_user.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_user.Multiline = true;
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(215, 31);
            this.txt_user.TabIndex = 51;
            this.txt_user.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_user_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(39, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 39;
            this.label2.Text = "User: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(39, 147);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 43;
            this.label4.Text = "Password:";
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(188, 147);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_password.Multiline = true;
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(215, 33);
            this.txt_password.TabIndex = 44;
            this.txt_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_password_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(39, 210);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 45;
            this.label5.Text = "Ngày tạo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(39, 265);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 19);
            this.label6.TabIndex = 47;
            this.label6.Text = "Chức vụ:";
            // 
            // txt_manv
            // 
            this.txt_manv.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_manv.Location = new System.Drawing.Point(188, 35);
            this.txt_manv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_manv.Multiline = true;
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(215, 30);
            this.txt_manv.TabIndex = 37;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Controls.Add(this.bt_nhaplai);
            this.groupBox1.Controls.Add(this.bt_xoa);
            this.groupBox1.Controls.Add(this.bt_sua);
            this.groupBox1.Controls.Add(this.bt_them);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(490, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(189, 309);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức Năng";
            // 
            // bt_nhaplai
            // 
            this.bt_nhaplai.BackgroundImage = global::GUI.Properties.Resources._3d;
            this.bt_nhaplai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_nhaplai.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_nhaplai.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_nhaplai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_nhaplai.Location = new System.Drawing.Point(42, 240);
            this.bt_nhaplai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_nhaplai.Name = "bt_nhaplai";
            this.bt_nhaplai.Size = new System.Drawing.Size(97, 52);
            this.bt_nhaplai.TabIndex = 12;
            this.bt_nhaplai.Text = "Refesh";
            this.bt_nhaplai.UseVisualStyleBackColor = true;
            this.bt_nhaplai.Click += new System.EventHandler(this.bt_nhaplai_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.BackgroundImage = global::GUI.Properties.Resources._3d;
            this.bt_xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_xoa.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_xoa.Location = new System.Drawing.Point(42, 172);
            this.bt_xoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(97, 52);
            this.bt_xoa.TabIndex = 11;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.BackgroundImage = global::GUI.Properties.Resources._3d;
            this.bt_sua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_sua.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_sua.Location = new System.Drawing.Point(42, 103);
            this.bt_sua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(97, 53);
            this.bt_sua.TabIndex = 9;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_them
            // 
            this.bt_them.BackgroundImage = global::GUI.Properties.Resources._3d;
            this.bt_them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_them.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_them.Location = new System.Drawing.Point(42, 35);
            this.bt_them.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(97, 53);
            this.bt_them.TabIndex = 8;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // dgv_taikhoan
            // 
            this.dgv_taikhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_taikhoan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgv_taikhoan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_taikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_taikhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv_taikhoan.Location = new System.Drawing.Point(12, 331);
            this.dgv_taikhoan.Name = "dgv_taikhoan";
            this.dgv_taikhoan.RowHeadersWidth = 62;
            this.dgv_taikhoan.RowTemplate.Height = 28;
            this.dgv_taikhoan.Size = new System.Drawing.Size(667, 365);
            this.dgv_taikhoan.TabIndex = 72;
            this.dgv_taikhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_taikhoan_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã NV";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 93;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "User";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 79;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Password";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 114;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ngày Tạo";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 112;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Chức Vụ";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 106;
            // 
            // panel_body
            // 
            this.panel_body.BackgroundImage = global::GUI.Properties.Resources.bảo_mật;
            this.panel_body.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_body.Location = new System.Drawing.Point(696, 73);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(447, 623);
            this.panel_body.TabIndex = 75;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(696, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(447, 55);
            this.button1.TabIndex = 74;
            this.button1.Text = "ĐỔI MẬT KHẨU";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Quanlytaikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 717);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_taikhoan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Quanlytaikhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quanlytaikhoan";
            this.Load += new System.EventHandler(this.Quanlytaikhoan_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_taikhoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker datetimepacket_datecreate;
        private System.Windows.Forms.ComboBox cmb_chucvu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_manv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_nhaplai;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.DataGridView dgv_taikhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel_body;
    }
}