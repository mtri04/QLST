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

namespace GUI
{
    public partial class Dangnhap : Form
    {
        private MarketModel dbContext;
        public Dangnhap()
        {
            InitializeComponent();
            dbContext = new MarketModel();
        }

        private void bt_dangnhap_Click(object sender, EventArgs e)
        {
            string username = txt_taikhoan.Text.Trim();
            string password = txt_matkhau.Text.Trim();
            //Kiểm tra nếu tài khoản hoặc mật khẩu để trống
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                var user = dbContext.taikhoans.Include("nhanvien").FirstOrDefault(t => t.user == username);                                                  

                if (user != null && VerifyPassword(password, user.password))
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    Main2 main2 = new Main2
                    {
                        TenNguoiDung = user.nhanvien.fullname, 
                        IsAdmin = user.isAdmin ?? false,  
                        NgayGioDangNhap = DateTime.Now 
                    };

                    main2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không ?", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Main a = new Main();
                a.Show();
                this.Hide();
            }
        }
        private bool VerifyPassword(string inputPassword, string storedPassword)
        {
            //So sánh mật khẩu người dùng với mật khẩu trong CSDl
            return inputPassword == storedPassword;
        }

        private void check_hienmatkhau_CheckedChanged(object sender, EventArgs e)
        {
            txt_matkhau.UseSystemPasswordChar = !check_hienmatkhau.Checked;
        }
    }
}
