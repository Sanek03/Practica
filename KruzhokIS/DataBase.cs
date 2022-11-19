using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KruzhokIS
{
    internal class DataBase
    {
        private static Entities14 _context;
        public static Entities14 GetContext()
        {
            if (_context == null)
                _context = new Entities14();
            return _context;
        }
    }
}
