using BUS;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Nhacungcap : Form
    {
        private NhaCungCapService nhaCungCapService;
        List<nhacungcap> listnhacungcaps;
        private string avatarPath = string.Empty;
        private SanPhamService sanPhamService;
        public Nhacungcap()
        {
            InitializeComponent();
            nhaCungCapService = new NhaCungCapService();
            sanPhamService = new SanPhamService();
            LoadNhacungcap();
            setGirdViewStyle(dgv_nhacungcap);
        }
        public void setGirdViewStyle(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.BackgroundColor = Color.White;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void LoadNhacungcap()
        {
            listnhacungcaps = nhaCungCapService.GetAllNhaCungCap();
            BindGrid(listnhacungcaps);
        }
        private void BindGrid(List<nhacungcap> nhacungcaps)
        {
            dgv_nhacungcap.Rows.Clear();
            foreach (nhacungcap ncc in nhacungcaps)
            {
                int index = dgv_nhacungcap.Rows.Add();
                dgv_nhacungcap.Rows[index].Cells[0].Value = ncc.mancc;
                dgv_nhacungcap.Rows[index].Cells[1].Value = ncc.tenncc;
                dgv_nhacungcap.Rows[index].Cells[2].Value = ncc.diachi;
                dgv_nhacungcap.Rows[index].Cells[3].Value = ncc.sdt;
                dgv_nhacungcap.Rows[index].Cells[4].Value = ncc.email;
                dgv_nhacungcap.Rows[index].Cells[5].Value = ncc.avatar;
            }
        }
        private void txt_tennhacungcap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txt_diachi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void txt_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '@' && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            string tenNCC = txt_tennhacungcap.Text.Trim();
            string diaChi = txt_diachi.Text.Trim();
            string sdt = txt_sdt.Text.Trim();
            string email = txt_email.Text.Trim();

            if (string.IsNullOrEmpty(tenNCC) || string.IsNullOrEmpty(diaChi) || string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhà cung cấp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newNCC = new nhacungcap
            {
                tenncc = tenNCC,
                diachi = diaChi,
                sdt = sdt,
                email = email,
                avatar = SaveAvatar()
            };

            if (nhaCungCapService.AddNhaCungCap(newNCC))
            {
                MessageBox.Show("Thêm nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNhacungcap();
            }
            else
            {
                MessageBox.Show("Thêm nhà cung cấp thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void bt_sua_Click(object sender, EventArgs e)
        {

            if (int.TryParse(txt_manhacungcap.Text.Trim(), out int mancc))
            {
                var updatedNCC = new nhacungcap
                {
                    mancc = mancc,
                    tenncc = txt_tennhacungcap.Text.Trim(),
                    diachi = txt_diachi.Text.Trim(),
                    sdt = txt_sdt.Text.Trim(),
                    email = txt_email.Text.Trim(),
                };
                if (!string.IsNullOrEmpty(avatarPath))
                {
                    updatedNCC.avatar = SaveAvatar();
                }
                else
                {
                    updatedNCC.avatar = listnhacungcaps.FirstOrDefault(ncc => ncc.mancc == mancc)?.avatar;
                }
                if (nhaCungCapService.UpdateNhaCungCap(updatedNCC))
                {
                    MessageBox.Show("Cập nhật nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadNhacungcap();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhà cung cấp hoặc cập nhật thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_manhacungcap.Text.Trim(), out int mancc))
            {
                bool isUsedInSanPham = sanPhamService.IsManccInSanPham(mancc);
                if (isUsedInSanPham)
                {
                    MessageBox.Show("Không thể xóa nhà cung cấp vì đang có sản phẩm liên quan!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (nhaCungCapService.DeleteNhaCungCap(mancc))
                {
                    MessageBox.Show("Xóa nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadNhacungcap();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhà cung cấp hoặc xóa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bt_nhaplai_Click(object sender, EventArgs e)
        {
            txt_manhacungcap.Clear();
            txt_tennhacungcap.Clear();
            txt_diachi.Clear();
            txt_sdt.Clear();
            txt_email.Clear();
            txt_tennhacungcap.Focus();
            picture_avartar.Image = null;
            bt_them.Enabled = true;
            bt_xoa.Enabled = false;
            bt_sua.Enabled = false;
        }
        private void dgv_nhacungcap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgv_nhacungcap.Rows[e.RowIndex];

                txt_manhacungcap.Text = selectedRow.Cells[0].Value?.ToString();
                txt_tennhacungcap.Text = selectedRow.Cells[1].Value?.ToString();
                txt_diachi.Text = selectedRow.Cells[2].Value?.ToString();
                txt_sdt.Text = selectedRow.Cells[3].Value?.ToString();
                txt_email.Text = selectedRow.Cells[4].Value?.ToString();
                ShowAvatar(selectedRow.Cells[5].Value?.ToString());
                bt_them.Enabled = false;
                bt_xoa.Enabled = true;
                bt_sua.Enabled = true;
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
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string keyword = txt_search.Text.Trim().ToLower();


            var filteredNCCs = listnhacungcaps.Where(ncc => ncc.tenncc.ToLower().Contains(keyword)).ToList();

            BindGrid(filteredNCCs);
        }

        private void bt_addanh_Click(object sender, EventArgs e)
        {
            using (var fileDialog = new OpenFileDialog())
            {
                fileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

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

        private void bt_excel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
            saveFileDialog.FileName = "DanhSachNhaCungCap.xlsx"; // Tên mặc định cho file

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Ánh xạ dữ liệu từ NhaCungCap sang các cột Excel
                    var columnMapping = new Dictionary<string, Func<nhacungcap, object>>
            {
                { "Mã NCC", ncc => ncc.mancc },
                { "Tên NCC", ncc => ncc.tenncc },
                { "Địa Chỉ", ncc => ncc.diachi },
                { "Số Điện Thoại", ncc => ncc.sdt },
                { "Email", ncc => ncc.email },
                { "Avatar", ncc => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", ncc.avatar) }
            };

                    // Sử dụng lại phương thức ExportToExcel
                    Excel.ExportToExcel(listnhacungcaps, saveFileDialog.FileName, "Nhà Cung Cấp", columnMapping);

                    // Thông báo xuất file thành công
                    MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi khi xuất Excel
                    MessageBox.Show($"Lỗi khi xuất file Excel: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
