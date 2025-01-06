namespace GUI
{
    partial class Donhang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Donhang));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_excel = new System.Windows.Forms.Button();
            this.bt_xuatchitiethd = new System.Windows.Forms.Button();
            this.bt_xuathoadon = new System.Windows.Forms.Button();
            this.bt_taodonhang = new System.Windows.Forms.Button();
            this.bt_huydonhang = new System.Windows.Forms.Button();
            this.bt_refesh = new System.Windows.Forms.Button();
            this.dgv_donhang = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluongmua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_xoasanpham = new System.Windows.Forms.Button();
            this.bt_themsanpham = new System.Windows.Forms.Button();
            this.cmb_masp_tensanpham_soluongton = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_soluongmua = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_manv = new System.Windows.Forms.ComboBox();
            this.datetimepacket_datecreate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_madh = new System.Windows.Forms.TextBox();
            this.txt_tenkh = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_donhang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Controls.Add(this.bt_excel);
            this.groupBox3.Controls.Add(this.bt_xuatchitiethd);
            this.groupBox3.Controls.Add(this.bt_xuathoadon);
            this.groupBox3.Controls.Add(this.bt_taodonhang);
            this.groupBox3.Controls.Add(this.bt_huydonhang);
            this.groupBox3.Controls.Add(this.bt_refesh);
            this.groupBox3.Controls.Add(this.dgv_donhang);
            this.groupBox3.Location = new System.Drawing.Point(13, 327);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1057, 337);
            this.groupBox3.TabIndex = 111;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách sản phẩm đã chọn";
            // 
            // bt_excel
            // 
            this.bt_excel.BackColor = System.Drawing.Color.LawnGreen;
            this.bt_excel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_excel.Image = global::GUI.Properties.Resources.Microsoft_Excel_2013_icon;
            this.bt_excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_excel.Location = new System.Drawing.Point(921, 272);
            this.bt_excel.Name = "bt_excel";
            this.bt_excel.Size = new System.Drawing.Size(136, 61);
            this.bt_excel.TabIndex = 126;
            this.bt_excel.Text = "Excel";
            this.bt_excel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_excel.UseVisualStyleBackColor = false;
            this.bt_excel.Click += new System.EventHandler(this.bt_excel_Click);
            // 
            // bt_xuatchitiethd
            // 
            this.bt_xuatchitiethd.BackgroundImage = global::GUI.Properties.Resources.xanhnuocbien;
            this.bt_xuatchitiethd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_xuatchitiethd.FlatAppearance.BorderSize = 0;
            this.bt_xuatchitiethd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_xuatchitiethd.Location = new System.Drawing.Point(751, 283);
            this.bt_xuatchitiethd.Name = "bt_xuatchitiethd";
            this.bt_xuatchitiethd.Size = new System.Drawing.Size(152, 38);
            this.bt_xuatchitiethd.TabIndex = 73;
            this.bt_xuatchitiethd.Text = "Xuất chi tiết ĐH";
            this.bt_xuatchitiethd.UseVisualStyleBackColor = true;
            this.bt_xuatchitiethd.Click += new System.EventHandler(this.bt_xuatchitiethd_Click);
            // 
            // bt_xuathoadon
            // 
            this.bt_xuathoadon.BackgroundImage = global::GUI.Properties.Resources.xanhnuocbien;
            this.bt_xuathoadon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_xuathoadon.FlatAppearance.BorderSize = 0;
            this.bt_xuathoadon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_xuathoadon.Location = new System.Drawing.Point(570, 283);
            this.bt_xuathoadon.Name = "bt_xuathoadon";
            this.bt_xuathoadon.Size = new System.Drawing.Size(152, 38);
            this.bt_xuathoadon.TabIndex = 72;
            this.bt_xuathoadon.Text = "Xuất hóa đơn";
            this.bt_xuathoadon.UseVisualStyleBackColor = true;
            this.bt_xuathoadon.Click += new System.EventHandler(this.bt_xuathoadon_Click);
            // 
            // bt_taodonhang
            // 
            this.bt_taodonhang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_taodonhang.BackgroundImage")));
            this.bt_taodonhang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_taodonhang.FlatAppearance.BorderSize = 0;
            this.bt_taodonhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_taodonhang.Location = new System.Drawing.Point(385, 283);
            this.bt_taodonhang.Name = "bt_taodonhang";
            this.bt_taodonhang.Size = new System.Drawing.Size(152, 38);
            this.bt_taodonhang.TabIndex = 71;
            this.bt_taodonhang.Text = "Tạo đơn hàng";
            this.bt_taodonhang.UseVisualStyleBackColor = true;
            this.bt_taodonhang.Click += new System.EventHandler(this.bt_taodonhang_Click);
            // 
            // bt_huydonhang
            // 
            this.bt_huydonhang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_huydonhang.BackgroundImage")));
            this.bt_huydonhang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_huydonhang.FlatAppearance.BorderSize = 0;
            this.bt_huydonhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_huydonhang.Location = new System.Drawing.Point(198, 283);
            this.bt_huydonhang.Name = "bt_huydonhang";
            this.bt_huydonhang.Size = new System.Drawing.Size(152, 38);
            this.bt_huydonhang.TabIndex = 70;
            this.bt_huydonhang.Text = "Hủy đơn hàng";
            this.bt_huydonhang.UseVisualStyleBackColor = true;
            this.bt_huydonhang.Click += new System.EventHandler(this.bt_huydonhang_Click);
            // 
            // bt_refesh
            // 
            this.bt_refesh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_refesh.BackgroundImage")));
            this.bt_refesh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_refesh.FlatAppearance.BorderSize = 0;
            this.bt_refesh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_refesh.Location = new System.Drawing.Point(10, 283);
            this.bt_refesh.Name = "bt_refesh";
            this.bt_refesh.Size = new System.Drawing.Size(152, 38);
            this.bt_refesh.TabIndex = 69;
            this.bt_refesh.Text = "Refesh";
            this.bt_refesh.UseVisualStyleBackColor = true;
            this.bt_refesh.Click += new System.EventHandler(this.bt_refesh_Click);
            // 
            // dgv_donhang
            // 
            this.dgv_donhang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_donhang.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_donhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_donhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.Soluongmua,
            this.Giaban,
            this.Thanhtien});
            this.dgv_donhang.Location = new System.Drawing.Point(10, 25);
            this.dgv_donhang.Name = "dgv_donhang";
            this.dgv_donhang.RowHeadersWidth = 62;
            this.dgv_donhang.RowTemplate.Height = 28;
            this.dgv_donhang.Size = new System.Drawing.Size(1027, 243);
            this.dgv_donhang.TabIndex = 68;
            // 
            // MaSP
            // 
            this.MaSP.HeaderText = "Mã SP";
            this.MaSP.MinimumWidth = 8;
            this.MaSP.Name = "MaSP";
            // 
            // TenSP
            // 
            this.TenSP.HeaderText = "Tên SP";
            this.TenSP.MinimumWidth = 8;
            this.TenSP.Name = "TenSP";
            // 
            // Soluongmua
            // 
            this.Soluongmua.HeaderText = "Số lượng";
            this.Soluongmua.MinimumWidth = 8;
            this.Soluongmua.Name = "Soluongmua";
            // 
            // Giaban
            // 
            this.Giaban.HeaderText = "Giá Bán";
            this.Giaban.MinimumWidth = 8;
            this.Giaban.Name = "Giaban";
            // 
            // Thanhtien
            // 
            this.Thanhtien.HeaderText = "Thành Tiền";
            this.Thanhtien.MinimumWidth = 8;
            this.Thanhtien.Name = "Thanhtien";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.bt_xoasanpham);
            this.groupBox1.Controls.Add(this.bt_themsanpham);
            this.groupBox1.Controls.Add(this.cmb_masp_tensanpham_soluongton);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_soluongmua);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(598, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 309);
            this.groupBox1.TabIndex = 110;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn sản phẩm";
            // 
            // bt_xoasanpham
            // 
            this.bt_xoasanpham.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_xoasanpham.BackgroundImage")));
            this.bt_xoasanpham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_xoasanpham.FlatAppearance.BorderSize = 0;
            this.bt_xoasanpham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_xoasanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoasanpham.Location = new System.Drawing.Point(267, 234);
            this.bt_xoasanpham.Name = "bt_xoasanpham";
            this.bt_xoasanpham.Size = new System.Drawing.Size(171, 38);
            this.bt_xoasanpham.TabIndex = 54;
            this.bt_xoasanpham.Text = "Xóa sản phẩm";
            this.bt_xoasanpham.UseVisualStyleBackColor = true;
            this.bt_xoasanpham.Click += new System.EventHandler(this.bt_xoasanpham_Click);
            // 
            // bt_themsanpham
            // 
            this.bt_themsanpham.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_themsanpham.BackgroundImage")));
            this.bt_themsanpham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_themsanpham.FlatAppearance.BorderSize = 0;
            this.bt_themsanpham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_themsanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_themsanpham.Location = new System.Drawing.Point(40, 234);
            this.bt_themsanpham.Name = "bt_themsanpham";
            this.bt_themsanpham.Size = new System.Drawing.Size(177, 38);
            this.bt_themsanpham.TabIndex = 53;
            this.bt_themsanpham.Text = "Thêm sản phẩm";
            this.bt_themsanpham.UseVisualStyleBackColor = true;
            this.bt_themsanpham.Click += new System.EventHandler(this.bt_themsanpham_Click);
            // 
            // cmb_masp_tensanpham_soluongton
            // 
            this.cmb_masp_tensanpham_soluongton.FormattingEnabled = true;
            this.cmb_masp_tensanpham_soluongton.Location = new System.Drawing.Point(16, 74);
            this.cmb_masp_tensanpham_soluongton.Name = "cmb_masp_tensanpham_soluongton";
            this.cmb_masp_tensanpham_soluongton.Size = new System.Drawing.Size(436, 28);
            this.cmb_masp_tensanpham_soluongton.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(12, 38);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 19);
            this.label7.TabIndex = 38;
            this.label7.Text = "Mã SP | Tên Sản Phẩm | Số lượng tồn";
            // 
            // txt_soluongmua
            // 
            this.txt_soluongmua.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soluongmua.Location = new System.Drawing.Point(11, 155);
            this.txt_soluongmua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_soluongmua.Multiline = true;
            this.txt_soluongmua.Name = "txt_soluongmua";
            this.txt_soluongmua.Size = new System.Drawing.Size(298, 31);
            this.txt_soluongmua.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Silver;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(12, 120);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 19);
            this.label10.TabIndex = 43;
            this.label10.Text = "Số lượng mua";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.cmb_manv);
            this.groupBox2.Controls.Add(this.datetimepacket_datecreate);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_diachi);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_sdt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_madh);
            this.groupBox2.Controls.Add(this.txt_tenkh);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(554, 309);
            this.groupBox2.TabIndex = 109;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khách hàng";
            // 
            // cmb_manv
            // 
            this.cmb_manv.FormattingEnabled = true;
            this.cmb_manv.Location = new System.Drawing.Point(334, 158);
            this.cmb_manv.Name = "cmb_manv";
            this.cmb_manv.Size = new System.Drawing.Size(187, 28);
            this.cmb_manv.TabIndex = 54;
            // 
            // datetimepacket_datecreate
            // 
            this.datetimepacket_datecreate.CustomFormat = "dd - MM - yyyy";
            this.datetimepacket_datecreate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimepacket_datecreate.Location = new System.Drawing.Point(11, 246);
            this.datetimepacket_datecreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.datetimepacket_datecreate.Name = "datetimepacket_datecreate";
            this.datetimepacket_datecreate.Size = new System.Drawing.Size(510, 26);
            this.datetimepacket_datecreate.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 200);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 52;
            this.label1.Text = "Ngày mua";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(12, 38);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 19);
            this.label8.TabIndex = 38;
            this.label8.Text = "Mã ĐH";
            // 
            // txt_diachi
            // 
            this.txt_diachi.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diachi.Location = new System.Drawing.Point(11, 155);
            this.txt_diachi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_diachi.Multiline = true;
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(298, 31);
            this.txt_diachi.TabIndex = 51;
            this.txt_diachi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_diachi_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(139, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 39;
            this.label2.Text = "Tên khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 43;
            this.label4.Text = "Địa chỉ";
            // 
            // txt_sdt
            // 
            this.txt_sdt.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sdt.Location = new System.Drawing.Point(334, 73);
            this.txt_sdt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_sdt.Multiline = true;
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(187, 33);
            this.txt_sdt.TabIndex = 44;
            this.txt_sdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sdt_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(335, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 45;
            this.label5.Text = "Số điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(335, 120);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 19);
            this.label6.TabIndex = 47;
            this.label6.Text = "Mã NV xử lý";
            // 
            // txt_madh
            // 
            this.txt_madh.Enabled = false;
            this.txt_madh.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_madh.Location = new System.Drawing.Point(11, 73);
            this.txt_madh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_madh.Name = "txt_madh";
            this.txt_madh.Size = new System.Drawing.Size(92, 26);
            this.txt_madh.TabIndex = 36;
            // 
            // txt_tenkh
            // 
            this.txt_tenkh.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenkh.Location = new System.Drawing.Point(143, 73);
            this.txt_tenkh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_tenkh.Multiline = true;
            this.txt_tenkh.Name = "txt_tenkh";
            this.txt_tenkh.Size = new System.Drawing.Size(166, 30);
            this.txt_tenkh.TabIndex = 37;
            this.txt_tenkh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tenkh_KeyPress);
            // 
            // Donhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 683);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Donhang";
            this.Text = "Donhang";
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_donhang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bt_xuatchitiethd;
        private System.Windows.Forms.Button bt_xuathoadon;
        private System.Windows.Forms.Button bt_taodonhang;
        private System.Windows.Forms.Button bt_huydonhang;
        private System.Windows.Forms.Button bt_refesh;
        private System.Windows.Forms.DataGridView dgv_donhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluongmua;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giaban;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thanhtien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_xoasanpham;
        private System.Windows.Forms.Button bt_themsanpham;
        private System.Windows.Forms.ComboBox cmb_masp_tensanpham_soluongton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_soluongmua;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmb_manv;
        private System.Windows.Forms.DateTimePicker datetimepacket_datecreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_madh;
        private System.Windows.Forms.TextBox txt_tenkh;
        private System.Windows.Forms.Button bt_excel;
    }
}