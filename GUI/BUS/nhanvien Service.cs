using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhanVienService
    {
        private MarketModel db = new MarketModel();

        public List<nhanvien> GetAllNhanVien()
        {
            return db.nhanviens.ToList();
        }

        public nhanvien GetNhanVienById(string manv)
        {
            return db.nhanviens.FirstOrDefault(nv => nv.manv == manv);
        }

        public bool AddNhanVien(nhanvien nv)
        {
            try
            {
                db.nhanviens.Add(nv);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateNhanVien(nhanvien nv)
        {
            try
            {
                var existingNV = GetNhanVienById(nv.manv);
                if (existingNV != null)
                {
                    db.Entry(existingNV).CurrentValues.SetValues(nv);
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

        public bool DeleteNhanVien(string manv)
        {
            try
            {
                var nv = GetNhanVienById(manv);
                if (nv != null)
                {
                    db.nhanviens.Remove(nv);
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
    }
}
