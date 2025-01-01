using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class SanPhamService
    {
        private MarketModel db = new MarketModel();
        public List<sanpham> GetAllSanPham()
        {
            return db.sanphams.ToList();
        }

        public sanpham GetSanPhamByMasp(string masp)
        {
            return db.sanphams.FirstOrDefault(sp => sp.masp == masp);
        }

        public List<nhacungcap> GetNCCs()
        {
            return db.nhacungcaps.ToList();
        }

        public List<nhanvien> GetNhanViens()
        {
            return db.nhanviens.ToList();
        }

        public string GenerateNewMasp()
        {
            var latestProduct = db.sanphams.OrderByDescending(sp => sp.masp).FirstOrDefault();
            if (latestProduct != null)
            {
                int newMasp = int.Parse(latestProduct.masp.Substring(2)) + 1;
                return "SP" + newMasp.ToString("D3");
            }
            return "SP001";
        }

        public bool AddSanPham(sanpham sp)
        {
            try
            {
                db.sanphams.Add(sp);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateSanPham(sanpham sp)
        {
            try
            {
                var existingSP = db.sanphams.Find(sp.masp);
                if (existingSP != null)
                {
                    db.Entry(existingSP).CurrentValues.SetValues(sp);
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteSanPham(sanpham sp)
        {
            try
            {
                db.sanphams.Remove(sp);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool IsManccInSanPham(int mancc)
        {
            var sanPhams = db.sanphams.Where(sp => sp.mancc == mancc).ToList();
            return sanPhams.Any();
        }
        public bool NhapHang(string masp, int soLuongNhap)
        {
            var product = db.sanphams.FirstOrDefault(sp => sp.masp == masp);
            if (product != null)
            {
                product.solg += soLuongNhap;
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
