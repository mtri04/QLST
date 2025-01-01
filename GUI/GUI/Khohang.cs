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
    public partial class Khohang : Form
    {
        MarketModel contextDB;
        public Khohang()
        {
            InitializeComponent();
            contextDB = new MarketModel();
            LoadKhoHangData();
            setGirdViewStyle(dgv_khohang);
        }
        public void setGirdViewStyle(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.BackgroundColor = Color.White;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public void LoadKhoHangData()
        {
            try
            {
                using (var context = new MarketModel())
                {
                    var data = context.sanphams
                        .Select(sp => new
                        {
                            MaSP = sp.masp,
                            TenSP = sp.tensp,
                            SoLuongTon = sp.solg,
                            NgayNhap = sp.ngaynhap
                        })
                        .ToList();

                    dgv_khohang.DataSource = data;
                }
                dgv_khohang.Columns["MaSP"].HeaderText = "Mã SP";
                dgv_khohang.Columns["TenSP"].HeaderText = "Tên SP";
                dgv_khohang.Columns["SoLuongTon"].HeaderText = "Số lượng tồn";
                dgv_khohang.Columns["NgayNhap"].HeaderText = "Ngày nhập";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_refesh_Click(object sender, EventArgs e)
        {
            LoadKhoHangData();
        }

        private void bt_nhaphang_Click(object sender, EventArgs e)
        {
            Nhaphang nhaphangForm = new Nhaphang();
            nhaphangForm.khohangForm = this;
            nhaphangForm.ShowDialog();
        }

        private void bt_xoasanpham_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_khohang.SelectedRows.Count > 0) 
                {

                    List<string> selectedMaSPs = dgv_khohang.SelectedRows
                        .Cast<DataGridViewRow>()
                        .Select(row => row.Cells["MaSP"].Value.ToString())
                        .ToList();

                    string maSPList = string.Join(", ", selectedMaSPs);

                    DialogResult confirmResult = MessageBox.Show(
                        $"Bạn có chắc chắn muốn xóa các sản phẩm với Mã SP: {maSPList}?",
                        "Xác nhận xóa",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (confirmResult == DialogResult.Yes)
                    {
                        foreach (string maSP in selectedMaSPs)
                        {
                            var productToDelete = contextDB.sanphams.FirstOrDefault(sp => sp.masp == maSP);
                            if (productToDelete != null)
                            {
                                contextDB.sanphams.Remove(productToDelete);
                            }
                        }

                        contextDB.SaveChanges();

                        MessageBox.Show("Xóa các sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadKhoHangData();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn ít nhất một sản phẩm cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa sản phẩm: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_excel_Click(object sender, EventArgs e)
        {
            try
            {
                using (var saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files|*.xlsx";
                    saveFileDialog.Title = "Lưu file Excel";
                    saveFileDialog.FileName = "Thông tin kho hàng.xlsx";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var data = new List<dynamic>();

                        foreach (var kho in contextDB.sanphams.ToList()) 
                        {
                            data.Add(new
                            {
                                MaSP = kho.masp ?? "N/A",  
                                TenSP = kho.tensp ?? "N/A",       
                                SoLuongTon = kho.solg ?? 0,    
                                GiaNhap = kho.gianhap?.ToString("N0") ?? "0",
                                TênNhacungCap = kho.nhacungcap?.tenncc ?? "N/A", 
                                NgayNhap = kho.ngaynhap == DateTime.MinValue ? "N/A" : kho.ngaynhap.ToString("dd-MM-yyyy")
                            });
                        }

                        var columnMapping = new Dictionary<string, Func<dynamic, object>>
                {
                    { "Mã SP", row => row.MaSP },
                    { "Tên Sản Phẩm", row => row.TenSP },
                    { "Tên Nhà Cung Cấp", row => row.TênNhacungCap },
                    { "Số Lượng Tồn", row => row.SoLuongTon },
                    { "Giá Nhập", row => row.GiaNhap },
                    { "Ngày Nhập", row => row.NgayNhap }
                };

                        Excel.ExportToExcel(data, saveFileDialog.FileName, "Thông tin kho hàng", columnMapping);

                        MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xuất file Excel: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}