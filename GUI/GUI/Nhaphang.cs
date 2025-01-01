using DAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Nhaphang : Form
    {
        MarketModel contextDB;

        public Khohang khohangForm;
        public Nhaphang()
        {
            InitializeComponent();
            contextDB = new MarketModel();
            setGirdViewStyle(dgv_nhaphang);

        }
        public void setGirdViewStyle(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.BackgroundColor = Color.White;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void bt_nhaphang_Click(object sender, EventArgs e)
        {

            if (dgv_nhaphang.SelectedRows.Count > 0)
            {

                var selectedRow = dgv_nhaphang.SelectedRows[0];


                string maSP = selectedRow.Cells["MaSP"].Value.ToString();


                if (int.TryParse(txt_soluongnhap.Text, out int soLuongNhap) && soLuongNhap > 0)
                {

                    var product = contextDB.sanphams.FirstOrDefault(sp => sp.masp == maSP);

                    if (product != null)
                    {

                        product.solg += soLuongNhap;

                        contextDB.SaveChanges();

                        MessageBox.Show("Nhập hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Sản phẩm không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Số lượng nhập không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {

            if (khohangForm != null)
            {
                khohangForm.LoadKhoHangData();
            }
            this.Close();
        }

        private void dgv_nhaphang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Nhaphang_Load(object sender, EventArgs e)
        {

            var data = contextDB.sanphams
                .Select(sp => new
                {
                    MaSP = sp.masp,
                    TenSP = sp.tensp,
                    Mancc = sp.mancc,
                    Gianhap = sp.gianhap,
                    NoiSX = sp.noisx
                })
                .ToList();


            dgv_nhaphang.DataSource = data;

            dgv_nhaphang.Columns["MaSP"].HeaderText = "Mã SP";
            dgv_nhaphang.Columns["TenSP"].HeaderText = "Tên SP";
            dgv_nhaphang.Columns["Mancc"].HeaderText = "Mã NCC";
            dgv_nhaphang.Columns["Gianhap"].HeaderText = "Giá nhập";
            dgv_nhaphang.Columns["NoiSX"].HeaderText = "Nơi sản xuất";
        }
    }
}