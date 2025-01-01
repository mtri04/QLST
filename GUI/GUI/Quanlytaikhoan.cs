using DAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using BUS;

namespace GUI
{
    public partial class Quanlytaikhoan : Form
    {
        private TaiKhoanService taiKhoanService = new TaiKhoanService();

        private List<taikhoan> listTaiKhoans;
        public MarketModel contextDB { get; set; }
        public Quanlytaikhoan()
        {
            InitializeComponent();
            contextDB = new MarketModel();
            LoadTaiKhoan();
            setGirdViewStyle(dgv_taikhoan);
            datetimepacket_datecreate.Value = DateTime.Now;
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            panel_body.AutoScroll = true;
            childForm.MinimumSize = panel_body.Size;
            childForm.MaximumSize = panel_body.Size;
            childForm.Show();
        }
        public void setGirdViewStyle(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.BackgroundColor = Color.White;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void LoadTaiKhoan()
        {
            listTaiKhoans = taiKhoanService.GetAllTaiKhoan();
            BindGrid(listTaiKhoans);
            //datetimepacket_datecreate.Value = DateTime.Now;
        }

        private void BindGrid(List<taikhoan> listTaiKhoans)
        {
            dgv_taikhoan.Rows.Clear();
            foreach (var tk in listTaiKhoans)
            {
                int index = dgv_taikhoan.Rows.Add();
                dgv_taikhoan.Rows[index].Cells[0].Value = tk.manv;
                dgv_taikhoan.Rows[index].Cells[1].Value = tk.user;
                dgv_taikhoan.Rows[index].Cells[2].Value = tk.password;
                dgv_taikhoan.Rows[index].Cells[3].Value = tk.datecreate?.ToString("yyyy-MM-dd");
                dgv_taikhoan.Rows[index].Cells[4].Value = tk.isAdmin.HasValue && tk.isAdmin.Value ? "Quản trị hệ thống" : "Nhân viên bán hàng";
                dgv_taikhoan.Rows[index].DefaultCellStyle.ForeColor = Color.Black;
                dgv_taikhoan.Rows[index].DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void dgv_taikhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgv_taikhoan.Rows[e.RowIndex];

                txt_manv.Text = selectedRow.Cells[0].Value?.ToString();
                txt_user.Text = selectedRow.Cells[1].Value?.ToString();
                txt_password.Text = selectedRow.Cells[2].Value?.ToString();
                string dateStr = selectedRow.Cells[3].Value?.ToString();

                DateTime dateCreateValue;
                if (DateTime.TryParseExact(dateStr, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateCreateValue))
                {
                    datetimepacket_datecreate.Value = dateCreateValue;
                }
                else
                {
                    datetimepacket_datecreate.Value = DateTime.Now;
                }

                if (selectedRow.Cells[4].Value != null)
                {
                    bool isAdmin = selectedRow.Cells[4].Value.ToString() == "Quản trị hệ thống";
                    cmb_chucvu.SelectedItem = isAdmin ? "Quản trị hệ thống" : "Nhân viên bán hàng";
                }
                else
                {
                    cmb_chucvu.SelectedIndex = -1;
                }

                bt_them.Enabled = false;
                bt_xoa.Enabled = true;
                bt_sua.Enabled = true;
            }
        }
        private void bt_doimatkhau_Click(object sender, EventArgs e)
        {
            Doimatkhau formDoimatkhau = new Doimatkhau();
            formDoimatkhau.taikhoanForm = this;
            formDoimatkhau.ShowDialog();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            string maNV = txt_manv.Text.Trim();
            string user = txt_user.Text.Trim();
            string password = txt_password.Text.Trim();
            DateTime datecreate = datetimepacket_datecreate.Value.Date;
            bool isAdmin = cmb_chucvu.SelectedItem.ToString() == "Quản trị hệ thống";

            if (string.IsNullOrEmpty(maNV) || string.IsNullOrEmpty(user) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newTaiKhoan = new taikhoan
            {
                manv = maNV,
                user = user,
                password = password,
                datecreate = datecreate,
                isAdmin = isAdmin
            };

            if (taiKhoanService.AddTaiKhoan(newTaiKhoan))
            {
                MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTaiKhoan();
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            string maNV = txt_manv.Text.Trim();
            string user = txt_user.Text.Trim();
            string password = txt_password.Text.Trim();
            bool isAdmin = cmb_chucvu.SelectedItem.ToString() == "Quản trị hệ thống";

            if (string.IsNullOrEmpty(maNV) || string.IsNullOrEmpty(user) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var tkToUpdate = new taikhoan
            {
                manv = maNV,
                user = user,
                password = password,
                isAdmin = isAdmin
            };

            if (taiKhoanService.UpdateTaiKhoan(tkToUpdate))
            {
                MessageBox.Show("Sửa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTaiKhoan();
            }
            else
            {
                MessageBox.Show("Không tìm thấy tài khoản với mã nhân viên này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            string maNV = txt_manv.Text.Trim();

            if (string.IsNullOrEmpty(maNV))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                if (taiKhoanService.DeleteTaiKhoan(maNV))
                {
                    MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTaiKhoan();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tài khoản với mã nhân viên này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bt_nhaplai_Click(object sender, EventArgs e)
        {
            txt_manv.Clear();
            txt_user.Clear();
            txt_password.Clear();
            cmb_chucvu.SelectedIndex = -1;
            datetimepacket_datecreate.Value = DateTime.Now;
            txt_manv.Focus();
            LoadTaiKhoan();
            bt_them.Enabled = true;
            bt_xoa.Enabled = false;
            bt_sua.Enabled = false;
        }

        private void Quanlytaikhoan_Load(object sender, EventArgs e)
        {
            cmb_chucvu.Items.Add("Quản trị hệ thống");
            cmb_chucvu.Items.Add("Nhân viên bán hàng");
            cmb_chucvu.SelectedIndex = -1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Doimatkhau());
        }
    }
}