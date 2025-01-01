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
    public partial class xuatdonhang : Form
    {
        // Các property để lưu thông tin
        public string MaHD { get; set; }
        public string TenKH { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string MaNV { get; set; }
        public DateTime NgayMua { get; set; }
        public DataTable HoaDonData { get; set; }  // Dữ liệu cho DataGridView
        public xuatdonhang(string mahd, string tenkh, string sdt, string diachi, string manv, DateTime ngaymua, DataTable hoadonData)
        {
            InitializeComponent();

            // Khởi tạo giá trị cho các property
            MaHD = mahd;
            TenKH = tenkh;
            SDT = sdt;
            DiaChi = diachi;
            MaNV = manv;
            NgayMua = ngaymua;
            HoaDonData = hoadonData;
        }
        // Hàm để cập nhật thông tin từ form tạo đơn hàng
        private void XuatThongTin()
        {
            // Cập nhật các label với thông tin từ đơn hàng
            lb_mahd.Text = MaHD;
            lb_tenkh.Text = TenKH;
            lb_sdt.Text = SDT;
            lb_diachi.Text = DiaChi;
            lb_manv.Text = MaNV;
            lb_ngaymua.Text = NgayMua.ToString("dd/MM/yyyy");

            // Thêm cột STT vào DataTable nếu chưa có
            if (!HoaDonData.Columns.Contains("STT"))
            {
                HoaDonData.Columns.Add("STT", typeof(int)); // Thêm cột STT vào DataTable
            }

            // Cập nhật số thứ tự cho từng dòng trong DataTable
            int stt = 1;
            foreach (DataRow row in HoaDonData.Rows)
            {
                row["STT"] = stt++; // Gán số thứ tự cho mỗi dòng
            }

            // Thiết lập DataGridView với dữ liệu từ HoaDonData
            dgv_hoadon.DataSource = HoaDonData;
            // Di chuyển cột STT lên đầu
            dgv_hoadon.Columns["STT"].DisplayIndex = 0;
            // Tính tổng tiền và hiển thị vào label
            double tongTien = 0;
            foreach (DataRow row in HoaDonData.Rows)
            {
                tongTien += Convert.ToDouble(row["Thanhtien"]);
            }
            lb_tongtien.Text = tongTien.ToString("N2");
            lb_phaitra.Text = lb_tongtien.Text;

            // Cập nhật tiêu đề các cột của DataGridView
            dgv_hoadon.Columns["STT"].HeaderText = "STT";
            dgv_hoadon.Columns["STT"].Width = 50; // Đặt chiều rộng cho cột STT
            dgv_hoadon.Columns["MaSP"].HeaderText = "Mã SP";
            dgv_hoadon.Columns["TenSP"].HeaderText = "Tên SP";
            dgv_hoadon.Columns["Soluongmua"].HeaderText = "Số lượng mua";
            dgv_hoadon.Columns["Giaban"].HeaderText = "Giá Bán";
            dgv_hoadon.Columns["Thanhtien"].HeaderText = "Thành tiền";
        }

        private void xuatdonhang_Load(object sender, EventArgs e)
        {
            XuatThongTin();
        }

    }
}
