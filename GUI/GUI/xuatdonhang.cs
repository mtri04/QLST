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
    public partial class xuatdonhang : Form
    {
        public string MaHD { get; set; }
        public string TenKH { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string MaNV { get; set; }
        public DateTime NgayMua { get; set; }
        public int? giaban { get; set; }
        public int? soluong { get; set; }
        public string masp { get; set; }
        public string tensp { get; set; }
        public decimal? dongia { get; set; }

        public xuatdonhang(string maHD, string tenKH, string sdt, string diaChi, string maNV, DateTime ngayMua, int? giaBan, int? soLuong, string maSP, string tenSP, decimal? donGia)
        {
            InitializeComponent();
            MaHD = maHD;
            TenKH = tenKH;
            SDT = sdt;
            DiaChi = diaChi;
            MaNV = maNV;
            NgayMua = ngayMua;
            giaban = giaBan;
            soluong = soLuong;
            masp = maSP;
            tensp = tenSP;
            dongia = donGia;

        }
        public void LoadData(DataTable hoadonData)
        {
            DataTable donHangReportData = new DataTable();
            donHangReportData.Columns.Add("MaHD", typeof(string));
            donHangReportData.Columns.Add("TenKH", typeof(string));
            donHangReportData.Columns.Add("SDT", typeof(string));
            donHangReportData.Columns.Add("DiaChi", typeof(string));
            donHangReportData.Columns.Add("MaNV", typeof(string));
            donHangReportData.Columns.Add("NgayMua", typeof(DateTime));
            donHangReportData.Columns.Add("MaSP", typeof(string));
            donHangReportData.Columns.Add("TenSP", typeof(string));
            donHangReportData.Columns.Add("SoLuong", typeof(int));
            donHangReportData.Columns.Add("Giaban", typeof(decimal));
            donHangReportData.Columns.Add("DonGia", typeof(decimal));
            donHangReportData.Columns.Add("Thanhtien", typeof(decimal));

            foreach (DataRow row in hoadonData.Rows)
            {
                decimal thanhTien = row["Thanhtien"] != DBNull.Value ? Convert.ToDecimal(row["Thanhtien"]) : 0;
                donHangReportData.Rows.Add(
                    MaHD ?? "N/A",
                    TenKH ?? "N/A",
                    SDT ?? "N/A",
                    DiaChi ?? "N/A",
                    MaNV ?? "N/A",
                    NgayMua != DateTime.MinValue ? NgayMua : (DateTime?)null,
                    row["MaSP"].ToString(),
                    row["TenSP"].ToString(),
                    Convert.ToInt32(row["SoLuongMua"]),
                    row["Giaban"] != DBNull.Value ? Convert.ToDecimal(row["Giaban"]) : 0,
                    thanhTien
                );
            }

            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", donHangReportData));
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();
        }

    }
}
