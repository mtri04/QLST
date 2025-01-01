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
    public partial class Chitietdonhang : Form
    {
        private MarketModel db = new MarketModel();
        // Các property để lưu thông tin
        public string MaHD { get; set; }
        public string TenKH { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string MaNV { get; set; }
        public DateTime NgayMua { get; set; }
        public DataTable HoaDonData { get; set; }  // Dữ liệu cho DataGridView
        public Chitietdonhang(string mahd, string tenkh, string sdt, string diachi, string manv, DateTime ngaymua, DataTable hoadonData)
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
        private void XuatThongTin()
        {
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

            // Thêm cột mancc và Giá nhập vào DataGridView nếu chưa có
            if (!HoaDonData.Columns.Contains("ManCC"))
            {
                HoaDonData.Columns.Add("ManCC", typeof(string));
                HoaDonData.Columns.Add("GiaNhap", typeof(decimal));
            }

            // Điền giá trị cho cột mới nếu cần
            foreach (DataRow row in HoaDonData.Rows)
            {
                string maSP = row["MaSP"].ToString();
                var product = db.sanphams.FirstOrDefault(p => p.masp == maSP);

                if (product != null)
                {
                    row["ManCC"] = product.mancc;  // Lấy mancc từ sản phẩm
                    row["GiaNhap"] = product.gianhap ?? 0;  // Lấy giá nhập từ sản phẩm
                }
                else
                {
                    row["ManCC"] = "N/A";  // Nếu không tìm thấy sản phẩm
                    row["GiaNhap"] = 0;
                }
            }

            // Cập nhật tiêu đề các cột của DataGridView
            dgv_hoadon.Columns["STT"].HeaderText = "STT";
            dgv_hoadon.Columns["STT"].Width = 50; // Đặt chiều rộng cho cột STT
            dgv_hoadon.Columns["MaSP"].HeaderText = "Mã SP";
            dgv_hoadon.Columns["TenSP"].HeaderText = "Tên SP";
            dgv_hoadon.Columns["ManCC"].HeaderText = "Mã NCC";
            dgv_hoadon.Columns["Soluongmua"].HeaderText = "Số lượng mua";
            dgv_hoadon.Columns["GiaNhap"].HeaderText = "Giá Nhập";
            dgv_hoadon.Columns["Giaban"].HeaderText = "Giá Bán";
            dgv_hoadon.Columns["Thanhtien"].HeaderText = "Thành tiền";
        }


        private void Chitietdonhang_Load(object sender, EventArgs e)
        {
            XuatThongTin();
            // Cập nhật DataGridView để hiển thị cột mancc và Giá nhập
            dgv_hoadon.Columns["ManCC"].HeaderText = "Mã NCC";
            dgv_hoadon.Columns["GiaNhap"].HeaderText = "Giá Nhập";
        }
    }
}
