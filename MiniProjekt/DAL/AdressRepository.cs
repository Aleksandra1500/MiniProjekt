using EnsureThat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjekt.DAL
{
    public class AdressRepository
    {
        private readonly DbAdresses _context;

        public AdressRepository()
        {
            _context = new DbAdresses();
        }
        public IList<Adress> GetAllAdresses()
        {
            return _context.Adresy.ToList();
        }
    }
}
