using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineCardVersionFive.Service
{
    public class ServiceRegion
    {
        private readonly DbContextWineCardVersionFive _context;

        public ServiceRegion(DbContextWineCardVersionFive context)
        {
            _context = context;
        }

        public List<Entities.Region> GetAllRegions()
        {
            return _context.Regions.ToList();
        }
    }
}
