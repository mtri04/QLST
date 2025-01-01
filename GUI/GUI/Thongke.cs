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
    public partial class Thongke : Form
    {
        public Thongke()
        {
            InitializeComponent();
            SetUpDataGridView();
        }
        private void ThongKeDoanhThu()
        {
            bool xemTatCaCacThang = checkbox_xemtacacacthang.Checked;

            DateTime ngayBatDau = dateTimePicker1_batdau.Value.Date;
            DateTime ngayKetThuc = dateTimePicker2_ketthuc.Value.Date;

            using (var context = new MarketModel())
            {
                var thongKe = xemTatCaCacThang
                    ? (from hd in context.hoadons
                       let tienLai = (from cthd in context.chitiethoadons
                                      join sp in context.sanphams on cthd.masp equals sp.masp
                                      where cthd.madh == hd.madh
                                      select (sp.giaban - sp.gianhap) * cthd.soluong).Sum()
                       let thanhTien = (from cthd in context.chitiethoadons
                                        where cthd.madh == hd.madh
                                        select cthd.dongia).Sum()
                       select new
                       {
                           MaDH = hd.madh,
                           NgayMua = hd.ngaymua,
                           ThanhTien = thanhTien,
                           TienLai = tienLai
                       })
                    : (from hd in context.hoadons
                       where hd.ngaymua >= ngayBatDau && hd.ngaymua <= ngayKetThuc
                       let tienLai = (from cthd in context.chitiethoadons
                                      join sp in context.sanphams on cthd.masp equals sp.masp
                                      where cthd.madh == hd.madh
                                      select (sp.giaban - sp.gianhap) * cthd.soluong).Sum()
                       let thanhTien = (from cthd in context.chitiethoadons
                                        where cthd.madh == hd.madh
                                        select cthd.dongia).Sum()
                       select new
                       {
                           MaDH = hd.madh,
                           NgayMua = hd.ngaymua,
                           ThanhTien = thanhTien,
                           TienLai = tienLai
                       });

                dgv_thongke.Rows.Clear();
                decimal tongTienLai = 0;

                int stt = 1; 

                foreach (var item in thongKe)
                {
                    int rowIndex = dgv_thongke.Rows.Add();
                    dgv_thongke.Rows[rowIndex].Cells[0].Value = stt++;
                    dgv_thongke.Rows[rowIndex].Cells[1].Value = item.MaDH;
                    dgv_thongke.Rows[rowIndex].Cells[2].Value = item.NgayMua?.ToString("dd/MM/yyyy");
                    dgv_thongke.Rows[rowIndex].Cells[3].Value = item.ThanhTien?.ToString("N0");
                    dgv_thongke.Rows[rowIndex].Cells[4].Value = item.TienLai?.ToString("N0");


                    tongTienLai += item.TienLai ?? 0;
                }

                txt_tienlai.Text = tongTienLai.ToString("N0");
            }
        }
        private void SetUpDataGridView()
        {
            dgv_thongke.Columns.Add("STT", "STT");

            dgv_thongke.Columns.Add("MaDH", "Mã Đơn Hàng");
            dgv_thongke.Columns.Add("NgayMua", "Ngày Mua");
            dgv_thongke.Columns.Add("ThanhTien", "Thành Tiền");
            dgv_thongke.Columns.Add("TienLai", "Tiền Lãi");

            dgv_thongke.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";
            dgv_thongke.Columns["TienLai"].DefaultCellStyle.Format = "N0";

            dgv_thongke.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void checkbox_xemtacacacthang_CheckedChanged(object sender, EventArgs e)
        {

            ThongKeDoanhThu();

            dateTimePicker1_batdau.Enabled = !checkbox_xemtacacacthang.Checked;
            dateTimePicker2_ketthuc.Enabled = !checkbox_xemtacacacthang.Checked;

            bt_excel.Visible = true;
        }


        private void txt_timkiem_Click(object sender, EventArgs e)
        {
            ThongKeDoanhThu();
            bt_excel.Enabled = dgv_thongke.Rows.Count > 0;
            bt_excel.Visible = true;
        }

        private void Thongke_Load(object sender, EventArgs e)
        {
            dateTimePicker1_batdau.Value = DateTime.Now.AddMonths(-1);
            dateTimePicker2_ketthuc.Value = DateTime.Now;
            bt_excel.Visible = false;
        }

        private void bt_excel_Click(object sender, EventArgs e)
        {
            if (dgv_thongke.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                saveFileDialog.Title = "Lưu file Excel";
                saveFileDialog.FileName = "Thống kê doanh thu.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Tạo danh sách dữ liệu từ DataGridView
                        var data = new List<object>();
                        foreach (DataGridViewRow row in dgv_thongke.Rows)
                        {
                            if (row.IsNewRow) continue;
                            data.Add(new
                            {
                                STT = row.Cells[0].Value,
                                MaDH = row.Cells[1].Value,
                                NgayMua = row.Cells[2].Value,
                                ThanhTien = row.Cells[3].Value,
                                TienLai = row.Cells[4].Value
                            });
                        }

                        var columnMapping = new Dictionary<string, Func<object, object>>
                        {
                            { "STT", x => x.GetType().GetProperty("STT")?.GetValue(x, null) },
                            { "Mã Đơn Hàng", x => x.GetType().GetProperty("MaDH")?.GetValue(x, null) },
                            { "Ngày Mua", x => x.GetType().GetProperty("NgayMua")?.GetValue(x, null) },
                            { "Thành Tiền", x => x.GetType().GetProperty("ThanhTien")?.GetValue(x, null) },
                            { "Tiền Lãi", x => x.GetType().GetProperty("TienLai")?.GetValue(x, null) }
                        };

                        Excel.ExportToExcel(data, saveFileDialog.FileName, "ThongKe", columnMapping);

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
