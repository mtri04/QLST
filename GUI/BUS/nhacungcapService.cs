using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhaCungCapService
    {
        private MarketModel db = new MarketModel();


        public List<nhacungcap> GetAllNhaCungCap()
        {
            return db.nhacungcaps.ToList();
        }
        public nhacungcap GetNhacungcapByMancc(int mancc)
        {
            return db.nhacungcaps.FirstOrDefault(ncc => ncc.mancc == mancc);
        }

        public bool AddNhaCungCap(nhacungcap ncc)
        {
            try
            {
                db.nhacungcaps.Add(ncc);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }


        public bool UpdateNhaCungCap(nhacungcap updatedNCC)
        {
            try
            {
                var ncc = db.nhacungcaps.Find(updatedNCC.mancc);
                if (ncc != null)
                {
                    ncc.tenncc = updatedNCC.tenncc;
                    ncc.diachi = updatedNCC.diachi;
                    ncc.sdt = updatedNCC.sdt;
                    ncc.email = updatedNCC.email;
                    ncc.avatar = updatedNCC.avatar;
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

        public bool DeleteNhaCungCap(int mancc)
        {
            try
            {
                var ncc = db.nhacungcaps.Find(mancc);
                if (ncc != null)
                {
                    db.nhacungcaps.Remove(ncc);
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
