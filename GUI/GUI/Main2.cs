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
    public partial class Main2 : Form
    {
        public string TenNguoiDung { get; set; }
        public bool IsAdmin { get; set; }
        public DateTime NgayGioDangNhap { get; set; }

        private Timer timer;
        public Main2()
        {
            InitializeComponent();
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
        private void Main2_Load_1(object sender, EventArgs e)
        {
            lb_quyen.Text = $"Xin chào: {TenNguoiDung} ({(IsAdmin ? "Admin" : "Staff")})";


            if (NgayGioDangNhap == DateTime.MinValue)
            {

                NgayGioDangNhap = DateTime.Now;
            }


            dateTimePicker1.Value = NgayGioDangNhap;


            lb_ngaythangnam.Text = NgayGioDangNhap.ToString("dddd, dd/MM/yyyy", new System.Globalization.CultureInfo("vi-VN"));

            bt_quanlynhanvien.Enabled = IsAdmin;
            bt_nhacungcap.Enabled = IsAdmin;
            bt_thongke.Enabled = IsAdmin;

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;


            lb_ngaythangnam.Text = now.ToString("dddd, dd/MM/yyyy", new System.Globalization.CultureInfo("vi-VN"));


            dateTimePicker1.Value = now;
        }
        private void ChangeButtonColor(Button selectedButton)
        {

            bt_sanpham.ForeColor = Color.White;
            bt_nhacungcap.ForeColor = Color.White;
            bt_banhang.ForeColor = Color.White;
            bt_khohang.ForeColor = Color.White;
            bt_quanlynhanvien.ForeColor = Color.White;
            bt_thongke.ForeColor = Color.White;


            selectedButton.ForeColor = Color.Green;
        }
        private void bt_sanpham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Sanpham());
            ChangeButtonColor(bt_sanpham);
        }


        private void bt_banhang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Donhang());
            ChangeButtonColor(bt_banhang);
        }

        private void bt_khohang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Khohang());
            ChangeButtonColor(bt_khohang);
        }
        private void bt_dangxuat_Click(object sender, EventArgs e)
        {
            this.Close();
            Dangnhap dnForm = new Dangnhap();
            dnForm.Show();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }

        private void bt_thongke_Click(object sender, EventArgs e)
        {
            //if (!IsAdmin)
            //{
            //    MessageBox.Show("Bạn không có quyền truy cập chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            OpenChildForm(new Thongke());
            ChangeButtonColor(bt_thongke);
        }

        private void bt_nhacungcap_Click(object sender, EventArgs e)
        {
            //if (!IsAdmin)
            //{
            //    MessageBox.Show("Bạn không có quyền truy cập chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            OpenChildForm(new Nhacungcap());
            ChangeButtonColor(bt_nhacungcap);
        }

        private void bt_quanlynhanvien_Click(object sender, EventArgs e)
        {
            //if (!IsAdmin)
            //{
            //    MessageBox.Show("Bạn không có quyền truy cập chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            OpenChildForm(new Nhanvien());
            ChangeButtonColor(bt_quanlynhanvien);
        }

    }
}
