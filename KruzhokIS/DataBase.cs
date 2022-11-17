using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KruzhokIS
{
    internal class DataBase
    {
        private static Entities12 _context;
        public static Entities12 GetContext()
        {
            if (_context == null)
                _context = new Entities12();
            return _context;
        }
    }
}
