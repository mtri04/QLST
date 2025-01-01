namespace GUI
{
    partial class Khohang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_xoasanpham = new System.Windows.Forms.Button();
            this.bt_nhaphang = new System.Windows.Forms.Button();
            this.bt_refesh = new System.Windows.Forms.Button();
            this.dgv_khohang = new System.Windows.Forms.DataGridView();
            this.bt_excel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khohang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.bt_excel);
            this.groupBox1.Controls.Add(this.bt_xoasanpham);
            this.groupBox1.Controls.Add(this.bt_nhaphang);
            this.groupBox1.Controls.Add(this.bt_refesh);
            this.groupBox1.Controls.Add(this.dgv_khohang);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1052, 632);
            this.groupBox1.TabIndex = 110;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin kho hàng";
            // 
            // bt_xoasanpham
            // 
            this.bt_xoasanpham.BackgroundImage = global::GUI.Properties.Resources.xanhla;
            this.bt_xoasanpham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_xoasanpham.FlatAppearance.BorderSize = 0;
            this.bt_xoasanpham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_xoasanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoasanpham.Location = new System.Drawing.Point(559, 571);
            this.bt_xoasanpham.Name = "bt_xoasanpham";
            this.bt_xoasanpham.Size = new System.Drawing.Size(223, 48);
            this.bt_xoasanpham.TabIndex = 73;
            this.bt_xoasanpham.Text = "Xóa sản phẩm trong kho";
            this.bt_xoasanpham.UseVisualStyleBackColor = true;
            this.bt_xoasanpham.Click += new System.EventHandler(this.bt_xoasanpham_Click);
            // 
            // bt_nhaphang
            // 
            this.bt_nhaphang.BackgroundImage = global::GUI.Properties.Resources.xanhla;
            this.bt_nhaphang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_nhaphang.FlatAppearance.BorderSize = 0;
            this.bt_nhaphang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_nhaphang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_nhaphang.Location = new System.Drawing.Point(276, 571);
            this.bt_nhaphang.Name = "bt_nhaphang";
            this.bt_nhaphang.Size = new System.Drawing.Size(134, 48);
            this.bt_nhaphang.TabIndex = 71;
            this.bt_nhaphang.Text = "Nhập hàng";
            this.bt_nhaphang.UseVisualStyleBackColor = true;
            this.bt_nhaphang.Click += new System.EventHandler(this.bt_nhaphang_Click);
            // 
            // bt_refesh
            // 
            this.bt_refesh.BackgroundImage = global::GUI.Properties.Resources.xanhla;
            this.bt_refesh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_refesh.FlatAppearance.BorderSize = 0;
            this.bt_refesh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_refesh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_refesh.Location = new System.Drawing.Point(41, 571);
            this.bt_refesh.Name = "bt_refesh";
            this.bt_refesh.Size = new System.Drawing.Size(114, 48);
            this.bt_refesh.TabIndex = 70;
            this.bt_refesh.Text = "Refesh";
            this.bt_refesh.UseVisualStyleBackColor = true;
            this.bt_refesh.Click += new System.EventHandler(this.bt_refesh_Click);
            // 
            // dgv_khohang
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_khohang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_khohang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_khohang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_khohang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_khohang.Location = new System.Drawing.Point(6, 25);
            this.dgv_khohang.Name = "dgv_khohang";
            this.dgv_khohang.RowHeadersWidth = 62;
            this.dgv_khohang.RowTemplate.Height = 28;
            this.dgv_khohang.Size = new System.Drawing.Size(1040, 534);
            this.dgv_khohang.TabIndex = 69;
            // 
            // bt_excel
            // 
            this.bt_excel.BackColor = System.Drawing.Color.LawnGreen;
            this.bt_excel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_excel.Image = global::GUI.Properties.Resources.Microsoft_Excel_2013_icon;
            this.bt_excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_excel.Location = new System.Drawing.Point(910, 565);
            this.bt_excel.Name = "bt_excel";
            this.bt_excel.Size = new System.Drawing.Size(136, 61);
            this.bt_excel.TabIndex = 127;
            this.bt_excel.Text = "Excel";
            this.bt_excel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_excel.UseVisualStyleBackColor = false;
            this.bt_excel.Click += new System.EventHandler(this.bt_excel_Click);
            // 
            // Khohang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 681);
            this.Controls.Add(this.groupBox1);
            this.Name = "Khohang";
            this.Text = "Khohang";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khohang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_xoasanpham;
        private System.Windows.Forms.Button bt_nhaphang;
        private System.Windows.Forms.Button bt_refesh;
        private System.Windows.Forms.DataGridView dgv_khohang;
        private System.Windows.Forms.Button bt_excel;
    }
}