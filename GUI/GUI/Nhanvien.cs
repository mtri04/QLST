using BUS;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Nhanvien : Form
    {
        NhanVienService nvService = new NhanVienService();
        private string avatarPath = string.Empty;
        public Nhanvien()
        {
            InitializeComponent();
            LoadNhanvien();
            setGirdViewStyle(dgv_nhanvien);
        }
        public void setGirdViewStyle(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.BackgroundColor = Color.White;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void LoadNhanvien()
        {
            var listNhanviens = nvService.GetAllNhanVien();
            BindGrid(listNhanviens);
        }
        private void BindGrid(List<nhanvien> listnhanviens)
        {
            dgv_nhanvien.Rows.Clear();
            foreach (nhanvien nv in listnhanviens)
            {
                int index = dgv_nhanvien.Rows.Add();
                dgv_nhanvien.Rows[index].Cells[0].Value = nv.manv;
                dgv_nhanvien.Rows[index].Cells[1].Value = nv.fullname;
                dgv_nhanvien.Rows[index].Cells[2].Value = nv.sdt;
                dgv_nhanvien.Rows[index].Cells[3].Value = nv.email;
                dgv_nhanvien.Rows[index].Cells[4].Value = nv.avatar;
                dgv_nhanvien.Rows[index].DefaultCellStyle.ForeColor = Color.Black;
                dgv_nhanvien.Rows[index].DefaultCellStyle.BackColor = Color.White;
            }
        }
        private void bt_quanlytaikhoan_Click(object sender, EventArgs e)
        {
            Quanlytaikhoan taikhoanForm = new Quanlytaikhoan();
            taikhoanForm.ShowDialog();
        }


        private void dgv_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgv_nhanvien.Rows[e.RowIndex];

                txt_manv.Text = selectedRow.Cells[0].Value?.ToString();
                txt_fullname.Text = selectedRow.Cells[1].Value?.ToString();
                txt_sdt.Text = selectedRow.Cells[2].Value?.ToString();
                txt_email.Text = selectedRow.Cells[3].Value?.ToString();
                ShowAvatar(selectedRow.Cells[4].Value?.ToString());
                bt_them.Enabled = false;
                bt_xoa.Enabled = true;
                bt_sua.Enabled = true;
            }
        }

        private void bt_them_Click_1(object sender, EventArgs e)
        {
            string fullName = txt_fullname.Text.Trim();
            string sdt = txt_sdt.Text.Trim();
            string email = txt_email.Text.Trim();

            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(sdt) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newNV = new nhanvien
            {
                manv = GenerateNewManv(),
                fullname = fullName,
                sdt = sdt,
                email = email,
                avatar = SaveAvatar()
            };

            if (nvService.AddNhanVien(newNV))
            {
                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNhanvien();
            }
            else
            {
                MessageBox.Show("Thêm nhân viên không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string GenerateNewManv()
        {
            var lastManv = nvService.GetAllNhanVien().OrderByDescending(nv => nv.manv).FirstOrDefault()?.manv;
            int number = string.IsNullOrEmpty(lastManv) ? 1 : int.Parse(lastManv.Substring(2)) + 1;
            return "NV" + number.ToString("D3");
        }
        private string SaveAvatar()
        {
            if (string.IsNullOrEmpty(avatarPath)) return "default.png";

            var imageDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");
            if (!Directory.Exists(imageDirectory)) Directory.CreateDirectory(imageDirectory);

            var fileName = Path.GetFileNameWithoutExtension(avatarPath);
            var extension = Path.GetExtension(avatarPath);
            var uniqueFileName = $"{fileName}_{DateTime.Now.Ticks}{extension}";
            var destinationPath = Path.Combine(imageDirectory, uniqueFileName);

            try
            {

                picture_avartar.Image?.Dispose();

                File.Copy(avatarPath, destinationPath, true);
                return uniqueFileName;
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Lỗi khi lưu avatar: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "default.png";
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
                    picture_avartar.Image = Image.FromFile(imagePath);
                }
                else
                {
                    picture_avartar.Image = null;
                }
            }
        }
        private void bt_sua_Click_1(object sender, EventArgs e)
        {
            string maNV = txt_manv.Text.Trim();
            string fullName = txt_fullname.Text.Trim();
            string sdt = txt_sdt.Text.Trim();
            string email = txt_email.Text.Trim();


            var nvToUpdate = nvService.GetNhanVienById(maNV);
            if (nvToUpdate != null)
            {
                nvToUpdate.fullname = fullName;
                nvToUpdate.sdt = sdt;
                nvToUpdate.email = email;
                if (!string.IsNullOrEmpty(avatarPath))
                {
                    nvToUpdate.avatar = SaveAvatar();
                }

                if (nvService.UpdateNhanVien(nvToUpdate))
                {
                    MessageBox.Show("Sửa thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadNhanvien();
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            txt_manv.Clear();
            txt_fullname.Clear();
            txt_sdt.Clear();
            txt_email.Clear();
            txt_manv.Focus();
            picture_avartar.Image = null;
            bt_them.Enabled = true;
            bt_xoa.Enabled = false;
            bt_sua.Enabled = false;
        }

        private void bt_xoa_Click_1(object sender, EventArgs e)
        {
            string maNV = txt_manv.Text.Trim();
            if (string.IsNullOrEmpty(maNV))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (nvService.DeleteNhanVien(maNV))
                {
                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadNhanvien();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên với mã nhân viên này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bt_addavatar_Click(object sender, EventArgs e)
        {
            using (var fileDialog = new OpenFileDialog())
            {
                fileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                fileDialog.Title = "Chọn ảnh sản phẩm";

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    avatarPath = fileDialog.FileName;
                    picture_avartar.Image = Image.FromFile(avatarPath);
                }
            }
        }

        private void bt_excel_Click(object sender, EventArgs e)
        {
            if (dgv_nhanvien.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                saveFileDialog.Title = "Lưu file Excel";
                saveFileDialog.FileName = "Danh sách nhân viên.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var data = new List<object>();
                        foreach (DataGridViewRow row in dgv_nhanvien.Rows)
                        {
                            if (row.IsNewRow) continue;
                            data.Add(new
                            {
                                MaNV = row.Cells[0].Value,
                                HoTen = row.Cells[1].Value,
                                SoDienThoai = row.Cells[2].Value,
                                Email = row.Cells[3].Value,
                                Avatar = row.Cells[4].Value
                            });
                        }

                        var columnMapping = new Dictionary<string, Func<object, object>>
                        {
                            { "Mã Nhân Viên", x => x.GetType().GetProperty("MaNV")?.GetValue(x, null) },
                            { "Họ Tên", x => x.GetType().GetProperty("HoTen")?.GetValue(x, null) },
                            { "Số Điện Thoại", x => x.GetType().GetProperty("SoDienThoai")?.GetValue(x, null) },
                            { "Email", x => x.GetType().GetProperty("Email")?.GetValue(x, null) },
                            { "Avatar", x => x.GetType().GetProperty("Avatar")?.GetValue(x, null) }
                        };

                        Excel.ExportToExcel(data, saveFileDialog.FileName, "DanhSachNhanVien", columnMapping);

                        MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Có lỗi xảy ra khi xuất file Excel: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}