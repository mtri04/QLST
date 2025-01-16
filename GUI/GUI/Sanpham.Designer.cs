namespace GUI
{
    partial class Sanpham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sanpham));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_manv = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_gianhap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_mancc = new System.Windows.Forms.ComboBox();
            this.bt_addanh = new System.Windows.Forms.Button();
            this.picture_avartar = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_tensp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_giaban = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_noisx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_masp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.dgv_sanpham = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_nhaplai = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_excel = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_avartar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sanpham)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_manv);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.txt_gianhap);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmb_mancc);
            this.groupBox2.Controls.Add(this.bt_addanh);
            this.groupBox2.Controls.Add(this.picture_avartar);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_tensp);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_giaban);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_noisx);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_masp);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(897, 284);
            this.groupBox2.TabIndex = 66;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sản phẩm";
            // 
            // cmb_manv
            // 
            this.cmb_manv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_manv.FormattingEnabled = true;
            this.cmb_manv.Location = new System.Drawing.Point(740, 35);
            this.cmb_manv.Name = "cmb_manv";
            this.cmb_manv.Size = new System.Drawing.Size(140, 28);
            this.cmb_manv.TabIndex = 125;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(631, 35);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 19);
            this.label7.TabIndex = 124;
            this.label7.Text = "Mã NV nhập:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy  ";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(740, 240);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(140, 26);
            this.dateTimePicker1.TabIndex = 123;
            // 
            // txt_gianhap
            // 
            this.txt_gianhap.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gianhap.Location = new System.Drawing.Point(740, 100);
            this.txt_gianhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_gianhap.Multiline = true;
            this.txt_gianhap.Name = "txt_gianhap";
            this.txt_gianhap.Size = new System.Drawing.Size(140, 33);
            this.txt_gianhap.TabIndex = 122;
            this.txt_gianhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_gianhap_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(631, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 121;
            this.label3.Text = "Giá bán:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(631, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 120;
            this.label1.Text = "Giá nhập:";
            // 
            // cmb_mancc
            // 
            this.cmb_mancc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_mancc.FormattingEnabled = true;
            this.cmb_mancc.Location = new System.Drawing.Point(138, 147);
            this.cmb_mancc.Name = "cmb_mancc";
            this.cmb_mancc.Size = new System.Drawing.Size(162, 28);
            this.cmb_mancc.TabIndex = 119;
            // 
            // bt_addanh
            // 
            this.bt_addanh.Location = new System.Drawing.Point(248, 242);
            this.bt_addanh.Name = "bt_addanh";
            this.bt_addanh.Size = new System.Drawing.Size(52, 36);
            this.bt_addanh.TabIndex = 118;
            this.bt_addanh.Text = "...";
            this.bt_addanh.UseVisualStyleBackColor = true;
            this.bt_addanh.Click += new System.EventHandler(this.bt_addanh_Click);
            // 
            // picture_avartar
            // 
            this.picture_avartar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picture_avartar.Image = ((System.Drawing.Image)(resources.GetObject("picture_avartar.Image")));
            this.picture_avartar.Location = new System.Drawing.Point(321, 20);
            this.picture_avartar.Name = "picture_avartar";
            this.picture_avartar.Size = new System.Drawing.Size(303, 258);
            this.picture_avartar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_avartar.TabIndex = 117;
            this.picture_avartar.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(6, 38);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 19);
            this.label8.TabIndex = 38;
            this.label8.Text = "Mã sản phẩm:";
            // 
            // txt_tensp
            // 
            this.txt_tensp.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tensp.Location = new System.Drawing.Point(138, 87);
            this.txt_tensp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_tensp.Multiline = true;
            this.txt_tensp.Name = "txt_tensp";
            this.txt_tensp.Size = new System.Drawing.Size(162, 31);
            this.txt_tensp.TabIndex = 51;
            this.txt_tensp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tensp_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(7, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 39;
            this.label2.Text = "Tên sản phẩm: ";
            // 
            // txt_giaban
            // 
            this.txt_giaban.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_giaban.Location = new System.Drawing.Point(740, 172);
            this.txt_giaban.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_giaban.Multiline = true;
            this.txt_giaban.Name = "txt_giaban";
            this.txt_giaban.Size = new System.Drawing.Size(140, 33);
            this.txt_giaban.TabIndex = 46;
            this.txt_giaban.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_giaban_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(6, 147);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 19);
            this.label4.TabIndex = 43;
            this.label4.Text = "Nhà cung cấp:";
            // 
            // txt_noisx
            // 
            this.txt_noisx.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_noisx.Location = new System.Drawing.Point(138, 199);
            this.txt_noisx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_noisx.Multiline = true;
            this.txt_noisx.Name = "txt_noisx";
            this.txt_noisx.Size = new System.Drawing.Size(162, 33);
            this.txt_noisx.TabIndex = 44;
            this.txt_noisx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_noisx_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(7, 199);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 45;
            this.label5.Text = "Nơi sản xuất:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(631, 242);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 19);
            this.label6.TabIndex = 47;
            this.label6.Text = "Hạn sử dụng:";
            // 
            // txt_masp
            // 
            this.txt_masp.Enabled = false;
            this.txt_masp.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_masp.Location = new System.Drawing.Point(138, 36);
            this.txt_masp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_masp.Multiline = true;
            this.txt_masp.Name = "txt_masp";
            this.txt_masp.Size = new System.Drawing.Size(162, 30);
            this.txt_masp.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Silver;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(13, 320);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 27);
            this.label9.TabIndex = 67;
            this.label9.Text = "Tìm kiếm sản phẩm";
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(232, 316);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_search.Multiline = true;
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(470, 31);
            this.txt_search.TabIndex = 68;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            //this.txt_search.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.txt_search_ControlRemoved);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // dgv_sanpham
            // 
            this.dgv_sanpham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_sanpham.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgv_sanpham.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_sanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgv_sanpham.Location = new System.Drawing.Point(12, 365);
            this.dgv_sanpham.Name = "dgv_sanpham";
            this.dgv_sanpham.RowHeadersWidth = 62;
            this.dgv_sanpham.RowTemplate.Height = 28;
            this.dgv_sanpham.Size = new System.Drawing.Size(1093, 340);
            this.dgv_sanpham.TabIndex = 69;
            this.dgv_sanpham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sanphamp_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã SP";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 92;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên SP";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 97;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mã NCC";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 104;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Giá Nhập";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 112;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Giá Bán";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 103;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Hạn Sử Dụng";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Width = 142;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Nơi Sản Xuất";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.Width = 139;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Mã NV";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            this.Column8.Width = 93;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Avatar";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            this.Column9.Width = 91;
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
            this.groupBox1.Location = new System.Drawing.Point(916, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(189, 309);
            this.groupBox1.TabIndex = 70;
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
            // bt_excel
            // 
            this.bt_excel.BackColor = System.Drawing.Color.LawnGreen;
            this.bt_excel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_excel.Image = global::GUI.Properties.Resources.Microsoft_Excel_2013_icon;
            this.bt_excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_excel.Location = new System.Drawing.Point(773, 298);
            this.bt_excel.Name = "bt_excel";
            this.bt_excel.Size = new System.Drawing.Size(136, 61);
            this.bt_excel.TabIndex = 124;
            this.bt_excel.Text = "Excel";
            this.bt_excel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_excel.UseVisualStyleBackColor = false;
            this.bt_excel.Click += new System.EventHandler(this.bt_excel_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Image = global::GUI.Properties.Resources.search;
            this.pictureBox2.Location = new System.Drawing.Point(669, 316);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 123;
            this.pictureBox2.TabStop = false;
            // 
            // Sanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 717);
            this.Controls.Add(this.bt_excel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_sanpham);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Name = "Sanpham";
            this.Text = "Sanpham";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_avartar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sanpham)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_addanh;
        private System.Windows.Forms.PictureBox picture_avartar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_tensp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_giaban;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_noisx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_masp;
        private System.Windows.Forms.ComboBox cmb_mancc;
        private System.Windows.Forms.TextBox txt_gianhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmb_manv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_search;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.DataGridView dgv_sanpham;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_nhaplai;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button bt_excel;
    }
}