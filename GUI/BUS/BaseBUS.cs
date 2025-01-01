using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace BUS
{
    public class BaseBUS<T> where T : class
    {
        private readonly DbContext _context;

        public BaseBUS(DbContext context)
        {
            _context = context;
        }
    }
}
