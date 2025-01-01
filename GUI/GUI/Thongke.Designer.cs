namespace GUI
{
    partial class Thongke
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Thongke));
            this.dgv_thongke = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_timkiem = new System.Windows.Forms.Button();
            this.dateTimePicker2_ketthuc = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1_batdau = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkbox_xemtacacacthang = new System.Windows.Forms.CheckBox();
            this.txt_tienlai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_excel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongke)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_thongke
            // 
            this.dgv_thongke.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_thongke.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_thongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thongke.Location = new System.Drawing.Point(11, 197);
            this.dgv_thongke.Name = "dgv_thongke";
            this.dgv_thongke.RowHeadersWidth = 62;
            this.dgv_thongke.RowTemplate.Height = 28;
            this.dgv_thongke.Size = new System.Drawing.Size(1057, 369);
            this.dgv_thongke.TabIndex = 112;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.txt_timkiem);
            this.groupBox1.Controls.Add(this.dateTimePicker2_ketthuc);
            this.groupBox1.Controls.Add(this.dateTimePicker1_batdau);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkbox_xemtacacacthang);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1058, 153);
            this.groupBox1.TabIndex = 111;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn hàng";
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_timkiem.BackgroundImage")));
            this.txt_timkiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt_timkiem.FlatAppearance.BorderSize = 0;
            this.txt_timkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timkiem.Location = new System.Drawing.Point(603, 95);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(229, 35);
            this.txt_timkiem.TabIndex = 24;
            this.txt_timkiem.Text = "Tìm kiếm đơn hàng";
            this.txt_timkiem.UseVisualStyleBackColor = true;
            this.txt_timkiem.Click += new System.EventHandler(this.txt_timkiem_Click);
            // 
            // dateTimePicker2_ketthuc
            // 
            this.dateTimePicker2_ketthuc.CustomFormat = "";
            this.dateTimePicker2_ketthuc.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2_ketthuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2_ketthuc.Location = new System.Drawing.Point(393, 98);
            this.dateTimePicker2_ketthuc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker2_ketthuc.Name = "dateTimePicker2_ketthuc";
            this.dateTimePicker2_ketthuc.Size = new System.Drawing.Size(158, 28);
            this.dateTimePicker2_ketthuc.TabIndex = 23;
            this.dateTimePicker2_ketthuc.Value = new System.DateTime(2024, 12, 29, 0, 0, 0, 0);
            // 
            // dateTimePicker1_batdau
            // 
            this.dateTimePicker1_batdau.CustomFormat = "";
            this.dateTimePicker1_batdau.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1_batdau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1_batdau.Location = new System.Drawing.Point(184, 98);
            this.dateTimePicker1_batdau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1_batdau.Name = "dateTimePicker1_batdau";
            this.dateTimePicker1_batdau.Size = new System.Drawing.Size(158, 28);
            this.dateTimePicker1_batdau.TabIndex = 22;
            this.dateTimePicker1_batdau.Value = new System.DateTime(2024, 12, 29, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(358, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "~";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thời gian mua hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkbox_xemtacacacthang
            // 
            this.checkbox_xemtacacacthang.AutoSize = true;
            this.checkbox_xemtacacacthang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_xemtacacacthang.Location = new System.Drawing.Point(16, 38);
            this.checkbox_xemtacacacthang.Name = "checkbox_xemtacacacthang";
            this.checkbox_xemtacacacthang.Size = new System.Drawing.Size(186, 24);
            this.checkbox_xemtacacacthang.TabIndex = 0;
            this.checkbox_xemtacacacthang.Text = "Xem tất cả các tháng";
            this.checkbox_xemtacacacthang.UseVisualStyleBackColor = true;
            this.checkbox_xemtacacacthang.CheckedChanged += new System.EventHandler(this.checkbox_xemtacacacthang_CheckedChanged);
            // 
            // txt_tienlai
            // 
            this.txt_tienlai.Location = new System.Drawing.Point(822, 596);
            this.txt_tienlai.Name = "txt_tienlai";
            this.txt_tienlai.Size = new System.Drawing.Size(215, 26);
            this.txt_tienlai.TabIndex = 114;
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(717, 597);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 113;
            this.label3.Text = "Tiền lãi: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_excel
            // 
            this.bt_excel.BackColor = System.Drawing.Color.LawnGreen;
            this.bt_excel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_excel.Image = global::GUI.Properties.Resources.Microsoft_Excel_2013_icon;
            this.bt_excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_excel.Location = new System.Drawing.Point(12, 573);
            this.bt_excel.Name = "bt_excel";
            this.bt_excel.Size = new System.Drawing.Size(136, 61);
            this.bt_excel.TabIndex = 126;
            this.bt_excel.Text = "Excel";
            this.bt_excel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_excel.UseVisualStyleBackColor = false;
            this.bt_excel.Click += new System.EventHandler(this.bt_excel_Click);
            // 
            // Thongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 646);
            this.Controls.Add(this.bt_excel);
            this.Controls.Add(this.txt_tienlai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_thongke);
            this.Controls.Add(this.groupBox1);
            this.Name = "Thongke";
            this.Text = "Thongke";
            this.Load += new System.EventHandler(this.Thongke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongke)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_thongke;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button txt_timkiem;
        private System.Windows.Forms.DateTimePicker dateTimePicker2_ketthuc;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_batdau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkbox_xemtacacacthang;
        private System.Windows.Forms.TextBox txt_tienlai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_excel;
    }
}