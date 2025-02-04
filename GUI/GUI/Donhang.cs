﻿using DAL.Model;
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
    public partial class Donhang : Form
    {
        private MarketModel db = new MarketModel();
        public Donhang()
        {
            InitializeComponent();
            LoadData();
            bt_xuatchitiethd.Visible = false;
            bt_xuathoadon.Visible = false;
            cmb_masp_tensanpham_soluongton.SelectedIndex = -1;
            cmb_manv.SelectedIndex = -1;
            setGirdViewStyle(dgv_donhang);
        }
        public void setGirdViewStyle(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.BackgroundColor = Color.White;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadData()
        {

            var products = db.sanphams.Select(p => new ProductInfo
            {
                MaSP = p.masp,
                TenSP = p.tensp,
                SoLuongTon = p.solg ?? 0
            }).ToList();


            cmb_masp_tensanpham_soluongton.DataSource = products;

            cmb_masp_tensanpham_soluongton.DisplayMember = "DisplayText";
            cmb_masp_tensanpham_soluongton.ValueMember = "MaSP";


            var employees = db.nhanviens.Select(nv => new
            {
                MaNV = nv.manv,
                TenNV = nv.fullname
            }).ToList();
            cmb_manv.DataSource = employees;
            cmb_manv.DisplayMember = "MaNV"; 
            cmb_manv.ValueMember = "MaNV"; 


            datetimepacket_datecreate.Value = DateTime.Now;
        }
        private void bt_refesh_Click(object sender, EventArgs e)
        {
            txt_madh.Text = string.Empty;
            txt_tenkh.Text = string.Empty;
            txt_sdt.Text = string.Empty;
            txt_diachi.Text = string.Empty;
            txt_soluongmua.Text = string.Empty;
            dgv_donhang.Rows.Clear();
            cmb_masp_tensanpham_soluongton.Refresh();
            datetimepacket_datecreate.Value = DateTime.Now;
            LoadData();
            cmb_masp_tensanpham_soluongton.SelectedIndex = -1;
            cmb_manv.SelectedIndex = -1;
            bt_xuatchitiethd.Visible = false;
            bt_xuathoadon.Visible = false;
        }
        private void txt_tenkh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;  
            }
        }
        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;  
            }
        }
        private void txt_diachi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '-')
            {
                e.Handled = true;  
            }
        }

        private void bt_taodonhang_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_tenkh.Text) ||
                    string.IsNullOrWhiteSpace(txt_sdt.Text) ||
                    string.IsNullOrWhiteSpace(txt_diachi.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmb_manv.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string selectedManv = cmb_manv.SelectedValue.ToString();

                if (dgv_donhang.Rows.Count == 0)
                {
                    MessageBox.Show("Đơn hàng chưa có sản phẩm nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                int orderCount = db.hoadons.Count(); 
                string madh = "HD0" + (orderCount + 1).ToString("D2"); 

                txt_madh.Text = madh;


                var newOrder = new hoadon
                {
                    madh = madh,
                    tenkh = txt_tenkh.Text,
                    sdt = txt_sdt.Text,
                    diachi = txt_diachi.Text,
                    manv = cmb_manv.SelectedValue.ToString(),
                    ngaymua = datetimepacket_datecreate.Value
                };

                db.hoadons.Add(newOrder); 


                foreach (DataGridViewRow row in dgv_donhang.Rows)
                {
                    if (row.Cells["MaSP"].Value == null || row.Cells["SoLuongMua"].Value == null || row.Cells["Thanhtien"].Value == null)
                        continue; 

                    var detail = new chitiethoadon
                    {
                        madh = madh,
                        masp = row.Cells["MaSP"].Value.ToString(),
                        soluong = Convert.ToInt32(row.Cells["SoLuongMua"].Value),
                        dongia = Convert.ToDecimal(row.Cells["Thanhtien"].Value)
                    };

                    db.chitiethoadons.Add(detail); 
                }

                db.SaveChanges();

                MessageBox.Show("Tạo đơn hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                bt_xuatchitiethd.Visible = true;
                bt_xuathoadon.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_themsanpham_Click(object sender, EventArgs e)
        {

            var selectedProduct = (ProductInfo)cmb_masp_tensanpham_soluongton.SelectedItem;

            if (selectedProduct == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            var product = db.sanphams.FirstOrDefault(p => p.masp == selectedProduct.MaSP);
            if (product == null)
            {
                MessageBox.Show("Sản phẩm không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal giaBan = product.giaban ?? 0;


            if (!int.TryParse(txt_soluongmua.Text, out int soLuongMua) || soLuongMua <= 0)
            {
                MessageBox.Show("Số lượng mua không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (soLuongMua > selectedProduct.SoLuongTon)
            {
                MessageBox.Show("Số lượng mua vượt quá số lượng tồn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            decimal thanhTien = soLuongMua * giaBan;

 
            dgv_donhang.Rows.Add(selectedProduct.MaSP, selectedProduct.TenSP, soLuongMua, giaBan, thanhTien);

 
            selectedProduct.SoLuongTon -= soLuongMua;
            product.solg -= soLuongMua;
            cmb_masp_tensanpham_soluongton.Refresh();


            MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bt_xoasanpham_Click(object sender, EventArgs e)
        {

            if (dgv_donhang.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            foreach (DataGridViewRow selectedRow in dgv_donhang.SelectedRows)
            {
                if (selectedRow.Cells["MaSP"].Value == null || selectedRow.Cells["Soluongmua"].Value == null)
                {
                    continue;
                }


                string maSP = selectedRow.Cells["MaSP"].Value.ToString();
                int soLuongMua = Convert.ToInt32(selectedRow.Cells["Soluongmua"].Value);

  
                dgv_donhang.Rows.Remove(selectedRow);

  
                var product = (ProductInfo)cmb_masp_tensanpham_soluongton.Items.Cast<ProductInfo>().FirstOrDefault(p => p.MaSP == maSP);
                if (product != null)
                {
                    product.SoLuongTon += soLuongMua; 
                    LoadData();
                }
       
                var productInDb = db.sanphams.FirstOrDefault(p => p.masp == maSP);
                if (productInDb != null)
                {
                    productInDb.solg += soLuongMua; 
                    db.SaveChanges(); 
                }
            }

   
            cmb_masp_tensanpham_soluongton.Refresh();

         
            MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

 
        public class ProductInfo
        {
            public string MaSP { get; set; }
            public string TenSP { get; set; }
            public int SoLuongTon { get; set; }
     
            public string DisplayText
            {
                get
                {
                    return $"{MaSP} | {TenSP} | {SoLuongTon}";
                }
            }
        }

        private void bt_huydonhang_Click(object sender, EventArgs e)
        {
            try
            {

                string madh = txt_madh.Text;

                if (string.IsNullOrWhiteSpace(madh))
                {
                    MessageBox.Show("Vui lòng chọn đơn hàng cần hủy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

  
                var orderToDelete = db.hoadons.FirstOrDefault(o => o.madh == madh);
                if (orderToDelete == null)
                {
                    MessageBox.Show("Đơn hàng không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

      
                var orderDetailsToDelete = db.chitiethoadons.Where(c => c.madh == madh).ToList();


                foreach (var detail in orderDetailsToDelete)
                {
                    var product = db.sanphams.FirstOrDefault(p => p.masp == detail.masp);
                    if (product != null)
                    {
                        product.solg += detail.soluong;
                    }
                }


                db.chitiethoadons.RemoveRange(orderDetailsToDelete);

       
                db.hoadons.Remove(orderToDelete);

         
                db.SaveChanges();

       
                MessageBox.Show("Đơn hàng đã được hủy thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

          
                ResetForm();
            }
            catch (Exception ex)
            {
               
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ResetForm()
        {
            txt_madh.Text = string.Empty;
            txt_tenkh.Text = string.Empty;
            txt_sdt.Text = string.Empty;
            txt_diachi.Text = string.Empty;
            dgv_donhang.Rows.Clear();
            cmb_masp_tensanpham_soluongton.SelectedIndex = -1;
            cmb_manv.SelectedIndex = -1;
            datetimepacket_datecreate.Value = DateTime.Now;
        }

        private void bt_xuathoadon_Click(object sender, EventArgs e)
        {
            try
            {
                string mahd = txt_madh.Text;  
                string manv = cmb_manv.SelectedValue.ToString();  
                string tenkh = txt_tenkh.Text;  
                string sdt = txt_sdt.Text;  
                string diachi = txt_diachi.Text;  
                DateTime ngaymua = datetimepacket_datecreate.Value;  


                DataTable hoadonData = new DataTable();
                hoadonData.Columns.Add("MaSP");
                hoadonData.Columns.Add("TenSP");
                hoadonData.Columns.Add("SoLuongMua");
                hoadonData.Columns.Add("Giaban");
                hoadonData.Columns.Add("Thanhtien");

                foreach (DataGridViewRow row in dgv_donhang.Rows)
                {
                    if (row.Cells["MaSP"].Value != null && row.Cells["SoLuongMua"].Value != null && row.Cells["Thanhtien"].Value != null)
                    {
                        DataRow newRow = hoadonData.NewRow();
                        newRow["MaSP"] = row.Cells["MaSP"].Value.ToString();
                        newRow["TenSP"] = row.Cells["TenSP"].Value.ToString();
                        newRow["SoLuongMua"] = row.Cells["Soluongmua"].Value.ToString();
                        newRow["Giaban"] = row.Cells["Giaban"].Value.ToString();
                        newRow["Thanhtien"] = row.Cells["Thanhtien"].Value.ToString();
                        hoadonData.Rows.Add(newRow);
                    }
                }

                if (hoadonData.Rows.Count == 0)
                {
                    MessageBox.Show("Đơn hàng chưa có sản phẩm để xuất hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                xuatdonhang phieuxuatForm = new xuatdonhang(
                    mahd,        
                    tenkh,        
                    sdt,          
                    diachi,      
                    manv,         
                    ngaymua,  
                    null,         
                    null,         
                    null,         
                    null,         
                    null          
                );

                phieuxuatForm.LoadData(hoadonData);  
                phieuxuatForm.ShowDialog();         
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_xuatchitiethd_Click(object sender, EventArgs e)
        {
            try
            {
                string mahd = txt_madh.Text; 
                string manv = cmb_manv.SelectedValue.ToString(); 
                string tenkh = txt_tenkh.Text; 
                string sdt = txt_sdt.Text; 
                string diachi = txt_diachi.Text; 
                DateTime ngaymua = datetimepacket_datecreate.Value; 


                DataTable chitiethoadonData = new DataTable();
                chitiethoadonData.Columns.Add("MaSP");
                chitiethoadonData.Columns.Add("TenSP");
                chitiethoadonData.Columns.Add("TenNCC");
                chitiethoadonData.Columns.Add("GiaNhap");
                chitiethoadonData.Columns.Add("GiaBan");
                chitiethoadonData.Columns.Add("HSD");
                chitiethoadonData.Columns.Add("NoiSX");
                chitiethoadonData.Columns.Add("SoLuongMua");
                chitiethoadonData.Columns.Add("Thanhtien");

                foreach (DataGridViewRow row in dgv_donhang.Rows)
                {
                    if (row.Cells["MaSP"].Value != null && row.Cells["SoLuongMua"].Value != null && row.Cells["Thanhtien"].Value != null)
                    {
                        string masp = row.Cells["MaSP"].Value.ToString().Trim();

                        var sanpham = db.sanphams.FirstOrDefault(sp => sp.masp == masp);

                        if (sanpham != null)
                        {
                            DataRow newRow = chitiethoadonData.NewRow();
                            newRow["MaSP"] = masp;
                            newRow["TenSP"] = sanpham.tensp;
                            newRow["TenNCC"] = sanpham.nhacungcap?.tenncc ?? "N/A";
                            newRow["GiaNhap"] = sanpham.gianhap ?? 0;
                            newRow["GiaBan"] = sanpham.giaban ?? 0;
                            newRow["HSD"] = sanpham.hsd.HasValue? sanpham.hsd.Value.ToString("dd-MM-yyyy"): "N/A";
                            newRow["NoiSX"] = sanpham.noisx ?? "N/A";
                            newRow["SoLuongMua"] = row.Cells["Soluongmua"].Value.ToString();
                            newRow["Thanhtien"] = row.Cells["Thanhtien"].Value ?? 0;

                            chitiethoadonData.Rows.Add(newRow);
                        }
                    }
                }

                if (chitiethoadonData.Rows.Count == 0)
                {
                    MessageBox.Show("Không có chi tiết hóa đơn để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Chitietdonhang chitiethdForm = new Chitietdonhang(
                    mahd,
                    tenkh,
                    sdt,
                    diachi,
                    manv,
                    ngaymua,
                    0,
                    null,
                    null,
                    0,
                    0,
                    DateTime.MinValue,
                    "N/A"
                );

                chitiethdForm.LoadData(chitiethoadonData);
                chitiethdForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_excel_Click(object sender, EventArgs e)
        {
            try
            {
                using (var saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files|*.xlsx";
                    saveFileDialog.Title = "Lưu file Excel";
                    saveFileDialog.FileName = "Thông tin hóa đơn.xlsx";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var data = new List<dynamic>();

                        foreach (var hd in db.hoadons.ToList())
                        {
                            foreach (var ct in hd.chitiethoadons)
                            {
                                data.Add(new
                                {
                                    MãHóaĐơn = hd.madh,
                                    TênKháchHàng = hd.tenkh ?? "N/A",
                                    SốĐiệnThoại = hd.sdt ?? "N/A",
                                    ĐịaChỉ = hd.diachi ?? "N/A",
                                    TênSảnPhẩm = ct.sanpham.tensp ?? "N/A",
                                    TênNhacungCap = ct.sanpham.nhacungcap.tenncc ?? "N/A",
                                    GiáNhập = ct.sanpham.gianhap?.ToString("N0") ?? "0",
                                    GiáBán = ct.sanpham.giaban?.ToString("N0") ?? "0",
                                    SốLượng = ct.soluong ?? 0,
                                    ThànhTiền = (ct.dongia ?? 0),
                                    MãNhânViên = hd.manv,
                                    NgàyMua = hd.ngaymua?.ToString("dd-MM-yyyy") ?? "N/A"
                                });
                            }
                        }

                        var columnMapping = new Dictionary<string, Func<dynamic, object>>
                        {
                            { "Mã Hóa Đơn", row => row.MãHóaĐơn },
                            { "Tên Khách Hàng", row => row.TênKháchHàng },
                            { "Số Điện Thoại", row => row.SốĐiệnThoại },
                            { "Địa Chỉ", row => row.ĐịaChỉ },
                            { "Tên Sản Phẩm", row => row.TênSảnPhẩm },
                            { "Tên Nhà Cung Cấp", row => row.TênNhacungCap },
                            { "Giá Nhập", row => row.GiáNhập },
                            { "Giá Bán", row => row.GiáBán },
                            { "Số Lượng", row => row.SốLượng },
                            { "Thành Tiền", row => row.ThànhTiền.ToString("N0") },
                            { "Mã Nhân Viên", row => row.MãNhânViên },
                            { "Ngày Mua", row => row.NgàyMua }
                        };

                        Excel.ExportToExcel(data, saveFileDialog.FileName, "Thông tin hóa đơn", columnMapping);

                        MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xuất file Excel: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

