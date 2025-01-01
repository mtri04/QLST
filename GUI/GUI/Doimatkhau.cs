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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace GUI
{
    public partial class Doimatkhau : Form
    {
        MarketModel contextDB;

        public Quanlytaikhoan taikhoanForm;
        public Doimatkhau()
        {
            InitializeComponent();
            contextDB = new MarketModel();
            Loadtaikhoan();
        }
        private void Loadtaikhoan()
        {
            var taikhoanList = contextDB.taikhoans.ToList();
            cmb_manv.DataSource = taikhoanList;
            cmb_manv.DisplayMember = "fullname";
            cmb_manv.ValueMember = "manv";
        }
        private void bt_doimatkhau_Click(object sender, EventArgs e)
        {
            string selectedManv = cmb_manv.SelectedValue.ToString();
            string username = txt_user.Text.Trim();
            string newPassword = txt_matkhaumoi.Text.Trim();
            string reenteredPassword = txt_reenterpassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(reenteredPassword))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != reenteredPassword)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp. Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_matkhaumoi.Clear();
                txt_reenterpassword.Clear();
                txt_matkhaumoi.Focus();
                return;
            }

            var account = contextDB.taikhoans.FirstOrDefault(t => t.manv == selectedManv && t.user == username);

            if (account == null)
            {
                MessageBox.Show("Tài khoản không tồn tại hoặc không khớp với mã nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            account.password = newPassword;
            try
            {
                contextDB.SaveChanges();


                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi cập nhật mật khẩu: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void checkbox_hienmatkhau_CheckedChanged(object sender, EventArgs e)
        {
            txt_matkhaumoi.UseSystemPasswordChar = !checkbox_hienmatkhau.Checked;
            txt_reenterpassword.UseSystemPasswordChar = !checkbox_hienmatkhau.Checked;
        }

        private void cmb_manv_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedManv = cmb_manv.SelectedValue.ToString();

            var account = contextDB.taikhoans.FirstOrDefault(t => t.manv == selectedManv);

            if (account != null)
            {
                txt_user.Text = account.user;
            }
            else
            {
                txt_user.Clear();
            }
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            if (taikhoanForm != null)
            {
                taikhoanForm.LoadTaiKhoan();
            }
            this.Close();
        }
    }
}