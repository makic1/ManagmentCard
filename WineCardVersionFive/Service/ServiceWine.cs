using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WineCardVersionFive.Entities;

namespace WineCardVersionFive.Service
{
    public class ServiceWine
    {
        private readonly DbContextWineCardVersionFive _context;

        public ServiceWine(DbContextWineCardVersionFive context)
        {
            _context = context;
        }

        public List<Wine> GetAllWines()
        {
            return _context.Wines.ToList();
        }
    }
}
