using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChiTietHoaDonService
    {
        private MarketModel db = new MarketModel();

        public List<chitiethoadon> GetAllChiTietHoaDon()
        {
            return db.chitiethoadons.ToList();
        }

        public bool AddChiTietHoaDon(chitiethoadon cthd)
        {
            try
            {
                db.chitiethoadons.Add(cthd);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
