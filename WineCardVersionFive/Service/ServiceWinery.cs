using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WineCardVersionFive.Entities;

namespace WineCardVersionFive.Service
{
    public class ServiceWinery
    {
        private readonly DbContextWineCardVersionFive _context;

        public ServiceWinery(DbContextWineCardVersionFive context)
        {
            _context = context;
        }

        public List<Winery> GetAllWineries()
        {
            return _context.Wineries.ToList();
        }

        public void AddWinery (Winery winery)
        {
            _context.Wineries.Add(winery);
            _context.SaveChanges();
        }

        public void UpdateWinery(Winery wineryToUpdate)
        {
            var winery = FindWineryById(wineryToUpdate.WineryId);

            if (winery is not null)
            {
                winery.WineryId = wineryToUpdate.WineryId;
                winery.Name = wineryToUpdate.Name;
                winery.RegionId = wineryToUpdate.RegionId;

                _context.SaveChanges();
            }
        }

        public void RemoveWineryById(int id)
        {
            _context.Wineries.Remove(FindWineryById(id));
            _context.SaveChanges();
        }

        public Winery FindWineryById(int id)
        {
            return _context.Wineries.Find(id);
        }

        public bool CheckOfDuplicateWineries(Winery winery)
        {
            return _context.Wineries.Any(w => w.Name == winery.Name && w.RegionId == winery.RegionId);
        }
    }
}
