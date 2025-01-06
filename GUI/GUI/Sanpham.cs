using BUS;
using DAL.Model;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Sanpham : Form
    {
        private SanPhamService sanPhamService;
        private List<sanpham> listsanphams;
        private string avatarPath = string.Empty;

        public Sanpham()
        {
            InitializeComponent();
            sanPhamService = new SanPhamService();
            LoadSanPham();
            LoadNCCs();
            LoadNhanvien();
            cmb_mancc.SelectedValue = 0;
            cmb_manv.SelectedValue = 0;
            setGirdViewStyle(dgv_sanpham);
        }
        public void setGirdViewStyle(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.BackgroundColor = Color.White;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadSanPham()
        {
            try
            {
                listsanphams = sanPhamService.GetAllSanPham();
                BindGrid(listsanphams);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu sản phẩm: {ex.Message}");
            }
        }

        private void LoadNCCs()
        {
            var nccList = sanPhamService.GetNCCs(); 
            cmb_mancc.DataSource = nccList;
            cmb_mancc.DisplayMember = "tenncc";
            cmb_mancc.ValueMember = "mancc";
        }


        private void LoadNhanvien()
        {
            var nhanvienList = sanPhamService.GetNhanViens(); 
            cmb_manv.DataSource = nhanvienList;
            cmb_manv.DisplayMember = "tennv";
            cmb_manv.ValueMember = "manv";
        }


        private void BindGrid(List<sanpham> sanphams)
        {
            dgv_sanpham.Rows.Clear();
            foreach (var sp in sanphams)
            {
                int index = dgv_sanpham.Rows.Add();
                dgv_sanpham.Rows[index].Cells[0].Value = sp.masp;
                dgv_sanpham.Rows[index].Cells[1].Value = sp.tensp;
                dgv_sanpham.Rows[index].Cells[2].Value = sp.mancc;
                dgv_sanpham.Rows[index].Cells[3].Value = sp.gianhap;
                dgv_sanpham.Rows[index].Cells[4].Value = sp.giaban;
                dgv_sanpham.Rows[index].Cells[5].Value = sp.hsd?.ToString("yyyy-MM-dd") ?? "N/A";
                dgv_sanpham.Rows[index].Cells[6].Value = sp.noisx;
                dgv_sanpham.Rows[index].Cells[7].Value = sp.manv;
                dgv_sanpham.Rows[index].Cells[8].Value = sp.avatar;
            }
        }

        private void txt_tensp_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void txt_noisx_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
        private void txt_gianhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void txt_giaban_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_tensp.Text) || string.IsNullOrEmpty(txt_gianhap.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                    return;
                }

                var product = new sanpham
                {
                    masp = sanPhamService.GenerateNewMasp(),
                    tensp = txt_tensp.Text.Trim(),
                    mancc = (int)cmb_mancc.SelectedValue,
                    gianhap = int.Parse(txt_gianhap.Text),
                    giaban = int.Parse(txt_giaban.Text),
                    hsd = dateTimePicker1.Value,
                    noisx = txt_noisx.Text.Trim(),
                    manv = (string)cmb_manv.SelectedValue,
                    avatar = SaveAvatar(),
                    ngaynhap = DateTime.Now,
                    solg = 0
                };

                bool result = sanPhamService.AddSanPham(product);
                if (result)
                {
                    LoadSanPham();
                    MessageBox.Show("Thêm sản phẩm thành công!");
                }
                else
                {
                    MessageBox.Show("Lỗi khi thêm sản phẩm!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm sản phẩm: {ex.Message}");
            }
        }


        private string SaveAvatar()
        {
            if (string.IsNullOrEmpty(avatarPath)) return "default.png";

            var imageDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");
            if (!Directory.Exists(imageDirectory)) Directory.CreateDirectory(imageDirectory);

            var fileName = Path.GetFileName(avatarPath);
            var destinationPath = Path.Combine(imageDirectory, fileName);

            try
            {
                // Đảm bảo file không bị khóa trước khi copy
                if (File.Exists(destinationPath))
                {
                    File.SetAttributes(destinationPath, FileAttributes.Normal);
                }

                File.Copy(avatarPath, destinationPath, true);
                return fileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu avatar: {ex.Message}");
                return "default.png";
            }
        }

        private void bt_addanh_Click(object sender, EventArgs e)
        {
            using (var fileDialog = new OpenFileDialog())
            {
                fileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                fileDialog.Title = "Chọn ảnh sản phẩm";

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    avatarPath = fileDialog.FileName;

                    // Đọc ảnh từ file vào luồng bộ nhớ
                    using (var stream = new MemoryStream(File.ReadAllBytes(avatarPath)))
                    {
                        picture_avartar.Image = Image.FromStream(stream);
                    }
                }
            }
        }


        private void bt_sua_Click(object sender, EventArgs e)
        {
            try
            {
                var masp = txt_masp.Text.Trim();
                var product = sanPhamService.GetSanPhamByMasp(masp);

                if (product == null)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm để sửa!");
                    return;
                }

                // Lưu tên ảnh cũ
                string oldAvatar = product.avatar;

                // Cập nhật các thông tin sản phẩm
                product.tensp = txt_tensp.Text.Trim();
                product.mancc = (int)cmb_mancc.SelectedValue;
                product.gianhap = int.Parse(txt_gianhap.Text);
                product.giaban = int.Parse(txt_giaban.Text);
                product.hsd = dateTimePicker1.Value;
                product.noisx = txt_noisx.Text.Trim();
                product.manv = cmb_manv.SelectedValue.ToString();

                // Kiểm tra và xử lý ảnh sản phẩm
                if (!string.IsNullOrWhiteSpace(avatarPath))
                {
                    // Nếu tên sản phẩm thay đổi, xóa ảnh cũ và lưu ảnh mới
                    if (product.tensp != txt_tensp.Text.Trim())
                    {
                        // Xóa ảnh cũ nếu tồn tại
                        if (!string.IsNullOrEmpty(oldAvatar) && File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", oldAvatar)))
                        {
                            try
                            {
                                if (picture_avartar.Image != null)
                                {
                                    picture_avartar.Image.Dispose();
                                    picture_avartar.Image = null;
                                }
                                File.Delete(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", oldAvatar));
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Lỗi khi xóa ảnh cũ: {ex.Message}");
                            }
                        }
                    }

                    product.avatar = SaveAvatar();
                }

                if (sanPhamService.UpdateSanPham(product))
                {
                    LoadSanPham();
                    MessageBox.Show("Sửa sản phẩm thành công!");
                }
                else
                {
                    MessageBox.Show("Lỗi khi sửa sản phẩm!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi sửa sản phẩm: {ex.Message}");
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                var masp = txt_masp.Text.Trim();
                var product = sanPhamService.GetSanPhamByMasp(masp);

                if (product == null)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm để xóa!");
                    return;
                }

                bool result = sanPhamService.DeleteSanPham(product);
                if (result)
                {
                    LoadSanPham();
                    MessageBox.Show("Xóa sản phẩm thành công!");
                }
                else
                {
                    MessageBox.Show("Lỗi khi xóa sản phẩm!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa sản phẩm: {ex.Message}");
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string keyword = txt_search.Text.Trim().ToLower();
            var filteredProducts = listsanphams.Where(sp => sp.tensp.ToLower().Contains(keyword)).ToList();
            BindGrid(filteredProducts);
        }

        private void bt_nhaplai_Click(object sender, EventArgs e)
        {
            txt_masp.Clear();
            txt_tensp.Clear();
            cmb_mancc.SelectedValue = 0;
            cmb_manv.SelectedValue = 0;
            txt_gianhap.Clear();
            txt_giaban.Clear();
            txt_noisx.Clear();
            dateTimePicker1.Value = DateTime.Now;
            picture_avartar.Image = null;
            avatarPath = string.Empty;

            bt_them.Enabled = true;
            bt_sua.Enabled = false;
            bt_xoa.Enabled = false;
        }
        private void dgv_sanphamp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgv_sanpham.Rows[e.RowIndex];
                txt_masp.Text = selectedRow.Cells[0].Value?.ToString();
                txt_tensp.Text = selectedRow.Cells[1].Value?.ToString();
                cmb_mancc.SelectedValue = selectedRow.Cells[2].Value;
                txt_gianhap.Text = selectedRow.Cells[3].Value?.ToString();
                txt_giaban.Text = selectedRow.Cells[4].Value?.ToString();
                dateTimePicker1.Value = selectedRow.Cells[5].Value != null ? DateTime.Parse(selectedRow.Cells[5].Value.ToString()) : DateTime.Now;
                txt_noisx.Text = selectedRow.Cells[6].Value?.ToString();
                cmb_manv.SelectedValue = selectedRow.Cells[7].Value;
                ShowAvatar(selectedRow.Cells[8].Value?.ToString());

                bt_them.Enabled = false;
                bt_sua.Enabled = true;
                bt_xoa.Enabled = true;
            }
        }

        private void ShowAvatar(string imageName)
        {
            if (string.IsNullOrEmpty(imageName))
            {
                picture_avartar.Image = null;
            }
            else
            {
                string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", imageName);
                if (File.Exists(imagePath))
                {
                    using (var stream = new MemoryStream(File.ReadAllBytes(imagePath)))
                    {
                        picture_avartar.Image = Image.FromStream(stream);
                    }
                }
                else
                {
                    picture_avartar.Image = null;
                }
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
                    saveFileDialog.FileName = "Thông tin sản phẩm.xlsx";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var columnMapping = new Dictionary<string, Func<sanpham, object>>
                {
                    { "Mã SP", sp => sp.masp },
                    { "Tên SP", sp => sp.tensp },
                    { "Mã NCC", sp => sp.mancc },
                    { "Giá nhập", sp => sp.gianhap },
                    { "Giá bán", sp => sp.giaban },
                    { "Số lượng", sp => sp.solg },
                    { "HSD", sp => sp.hsd?.ToString("dd-MM-yyyy") ?? "N/A" },
                    { "Nơi SX", sp => sp.noisx },
                    { "Mã NV", sp => sp.manv },
                    { "Avatar", sp => sp.avatar },
                    { "Ngày nhập", sp => sp.ngaynhap.ToString("dd-MM-yyyy") }
                };

                        Excel.ExportToExcel<sanpham>(listsanphams,saveFileDialog.FileName, "Thông tin sản phẩm",columnMapping);

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