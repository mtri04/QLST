namespace GUI
{
    partial class Nhaphang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nhaphang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.txt_soluongnhap = new System.Windows.Forms.TextBox();
            this.bt_nhaphang = new System.Windows.Forms.Button();
            this.dgv_nhaphang = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhaphang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.bt_thoat);
            this.groupBox1.Controls.Add(this.txt_soluongnhap);
            this.groupBox1.Controls.Add(this.bt_nhaphang);
            this.groupBox1.Controls.Add(this.dgv_nhaphang);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1006, 663);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sản phẩm";
            // 
            // bt_thoat
            // 
            this.bt_thoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_thoat.BackgroundImage")));
            this.bt_thoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_thoat.FlatAppearance.BorderSize = 0;
            this.bt_thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thoat.Image = ((System.Drawing.Image)(resources.GetObject("bt_thoat.Image")));
            this.bt_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_thoat.Location = new System.Drawing.Point(26, 575);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(115, 73);
            this.bt_thoat.TabIndex = 73;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // txt_soluongnhap
            // 
            this.txt_soluongnhap.Location = new System.Drawing.Point(650, 579);
            this.txt_soluongnhap.Multiline = true;
            this.txt_soluongnhap.Name = "txt_soluongnhap";
            this.txt_soluongnhap.Size = new System.Drawing.Size(157, 69);
            this.txt_soluongnhap.TabIndex = 72;
            // 
            // bt_nhaphang
            // 
            this.bt_nhaphang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_nhaphang.BackgroundImage")));
            this.bt_nhaphang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_nhaphang.FlatAppearance.BorderSize = 0;
            this.bt_nhaphang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_nhaphang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_nhaphang.Image = ((System.Drawing.Image)(resources.GetObject("bt_nhaphang.Image")));
            this.bt_nhaphang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_nhaphang.Location = new System.Drawing.Point(822, 575);
            this.bt_nhaphang.Name = "bt_nhaphang";
            this.bt_nhaphang.Size = new System.Drawing.Size(159, 73);
            this.bt_nhaphang.TabIndex = 71;
            this.bt_nhaphang.Text = "Nhập hàng";
            this.bt_nhaphang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_nhaphang.UseVisualStyleBackColor = true;
            this.bt_nhaphang.Click += new System.EventHandler(this.bt_nhaphang_Click);
            // 
            // dgv_nhaphang
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_nhaphang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_nhaphang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_nhaphang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_nhaphang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nhaphang.Location = new System.Drawing.Point(6, 25);
            this.dgv_nhaphang.Name = "dgv_nhaphang";
            this.dgv_nhaphang.RowHeadersWidth = 62;
            this.dgv_nhaphang.RowTemplate.Height = 28;
            this.dgv_nhaphang.Size = new System.Drawing.Size(991, 544);
            this.dgv_nhaphang.TabIndex = 69;
            this.dgv_nhaphang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_nhaphang_CellContentClick);
            // 
            // Nhaphang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 717);
            this.Controls.Add(this.groupBox1);
            this.Name = "Nhaphang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhaphang";
            this.Load += new System.EventHandler(this.Nhaphang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhaphang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.TextBox txt_soluongnhap;
        private System.Windows.Forms.Button bt_nhaphang;
        private System.Windows.Forms.DataGridView dgv_nhaphang;
    }
}