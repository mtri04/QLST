using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TaiKhoanService
    {
        private MarketModel db = new MarketModel();

        public List<taikhoan> GetAllTaiKhoan()
        {
            return db.taikhoans.Include("nhanvien").ToList();
        }

        public bool AddTaiKhoan(taikhoan tk)
        {
            try
            {
                db.taikhoans.Add(tk);
                db.SaveChanges();
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public bool UpdateTaiKhoan(taikhoan tk)
        {
            try
            {
                var existingTK = db.taikhoans.Find(tk.manv);
                if (existingTK != null)
                {
                    db.Entry(existingTK).CurrentValues.SetValues(tk);
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

        public bool DeleteTaiKhoan(string maNV)
        {
            try
            {
                var tkToDelete = db.taikhoans.FirstOrDefault(tk => tk.manv == maNV);
                if (tkToDelete != null)
                {
                    db.taikhoans.Remove(tkToDelete);
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
        public bool CheckMaNVExist(string maNV)
        {
            return db.nhanviens.Any(tk => tk.manv == maNV);
        }
        public bool CheckUserExist(string user)
        {
            return db.taikhoans.Any(tk => tk.user == user);
        }
    }
}

