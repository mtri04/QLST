using DAL.Model;
using Microsoft.Reporting.WinForms;
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
        public string MaHD { get; set; }
        public string TenKH { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string MaNV { get; set; }
        public DateTime NgayMua { get; set; }
        public int? soluong { get; set; }
        public string masp { get; set; }
        public string tensp { get; set; }
        public string tenncc { get; set; }
        public int? gianhap { get; set; }
        public int? giaban { get; set; }
        public DateTime? hsd { get; set; }
        public string noisx { get; set; }
        public decimal? dongia { get; set; }
        public Chitietdonhang(string maHD, string tenKH, string sdt, string diaChi, string maNV, DateTime ngayMua, decimal? donGia, string maSP, string tenSP, int giaNhap, int giaBan, DateTime HSD, string noiSX)
        {
            InitializeComponent();
            MaHD = maHD;
            TenKH = tenKH;
            SDT = sdt;
            DiaChi = diaChi;
            MaNV = maNV;
            NgayMua = ngayMua;
            dongia = donGia;
            masp = maSP;
            tensp = tenSP;
            gianhap = giaNhap;
            giaban = giaBan;
            hsd = HSD;
            noisx = noiSX;
        }
        public void LoadData(DataTable chiTietData)
        {
            // Tạo DataTable cho ReportViewer
            DataTable reportData = new DataTable();
            reportData.Columns.Add("MaHD", typeof(string));
            reportData.Columns.Add("TenKH", typeof(string));
            reportData.Columns.Add("SDT", typeof(string));
            reportData.Columns.Add("DiaChi", typeof(string));
            reportData.Columns.Add("MaNV", typeof(string));
            reportData.Columns.Add("NgayMua", typeof(DateTime));
            reportData.Columns.Add("MaSP", typeof(string));
            reportData.Columns.Add("TenSP", typeof(string));
            reportData.Columns.Add("TenNCC", typeof(string));
            reportData.Columns.Add("GiaNhap", typeof(decimal));
            reportData.Columns.Add("GiaBan", typeof(decimal));
            reportData.Columns.Add("HSD", typeof(string));
            reportData.Columns.Add("NoiSX", typeof(string));
            reportData.Columns.Add("SoLuong", typeof(int));
            reportData.Columns.Add("DonGia", typeof(decimal));

            foreach (DataRow row in chiTietData.Rows)
            {
                string maSP = row["MaSP"]?.ToString() ?? "N/A";
                string tenSP = row["TenSP"]?.ToString() ?? "N/A";
                string tenNCC = row["TenNCC"]?.ToString() ?? "N/A";
                int giaNhap = 0;
                int giaBan = 0;
                string noiSX = row["NoiSX"]?.ToString() ?? "N/A";

                if (decimal.TryParse(row["GiaNhap"]?.ToString(), out decimal tempGiaNhap))
                    giaNhap = (int)tempGiaNhap;

                if (decimal.TryParse(row["GiaBan"]?.ToString(), out decimal tempGiaBan))
                    giaBan = (int)tempGiaBan;

                string hsdValue = row["HSD"]?.ToString() ?? "N/A";


                decimal thanhTien = row["Thanhtien"] != DBNull.Value ? Convert.ToDecimal(row["Thanhtien"]) : 0;

                reportData.Rows.Add(
                    MaHD ?? "N/A",
                    TenKH ?? "N/A",
                    SDT ?? "N/A",
                    DiaChi ?? "N/A",
                    MaNV ?? "N/A",
                    NgayMua != DateTime.MinValue ? NgayMua : (DateTime?)null,
                    maSP,
                    tenSP,
                    tenNCC,
                    giaNhap,                       
                    giaBan,
                    hsdValue,
                    noiSX,
                    Convert.ToInt32(row["SoLuongMua"]),
                    thanhTien
                );
            }

            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2", reportData));
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
