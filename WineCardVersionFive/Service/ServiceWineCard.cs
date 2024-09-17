using Microsoft.EntityFrameworkCore;
using WineCardVersionFive.Entities;

namespace WineCardVersionFive.Service
{
    public class ServiceWineCard
    {
        private readonly DbContextWineCardVersionFive _context;

        public ServiceWineCard(DbContextWineCardVersionFive context)
        {
            _context = context;
        }

        public List<Wine> GetAllWines()
        {
            return _context.Wines
                .Include(w => w.WineCard)
                .Include(w => w.Vintage)
                .Include(w => w.WineType)
                .Include(w => w.GrapeVariety)
                .Include(w => w.Winery)
                .ThenInclude(w => w.Region)
                .ThenInclude(w => w.Country).ToList();
        }

        public List<Wine> GetAllWinesFromTheWineCard(bool wineTypeAlphabetic, bool wineNamealphabetic)
        {
            // Basis-Abfrage mit Includes
            var query = _context.Wines
                .Where(w => w.WineCardId == 1)
                .Include(w => w.WineCard)
                .Include(w => w.Vintage)
                .Include(w => w.WineType)
                .Include(w => w.GrapeVariety)
                .Include(w => w.Winery)
                .ThenInclude(w => w.Region)
                .ThenInclude(w => w.Country)
                .AsQueryable(); // WICHTIG!

            // Sortierung anwenden, falls erforderlich
            if (wineTypeAlphabetic)
            {
                query = query.OrderBy(w => w.WineType.Name);  // Sortierung nach Weintyp
            }
            if (wineNamealphabetic)
            {
                query = query.OrderBy(w => w.Name);  // Sortierung nach Weinnamen
            }

            return query.ToList();  // Abfrage ausführen und Ergebnis in eine Liste konvertieren
        }

        public void UpdateWineToWineCard(Wine wineToUpdate)
        {
            var wine = FindWineById(wineToUpdate.WineId);

            if (wine is not null)
            {
                wine.WineId = wineToUpdate.WineId;
                wine.Name = wineToUpdate.Name;
                wine.GrapeVarietyId = wineToUpdate.GrapeVarietyId;
                wine.WineTypeId = wineToUpdate.WineTypeId;
                wine.VintageId = wineToUpdate.VintageId;
                wine.WineCardId = wineToUpdate.WineCardId;
                wine.WineryId = wineToUpdate.WineryId;

                _context.SaveChanges();
            }
        }

        public Wine FindWineById(int id)
        {
            return _context.Wines.Find(id);
        }

        public int CountOfCards()
        {
            var count = _context.Wines.Where(w => w.WineCardId == 1).Count();
            return count;
        }

        public List<Wine> SearchWineCards(string? wineType, string? region, string? country, string? winery, string? grapeVariety, int? vintage)
        {
            var query = _context.Wines.AsQueryable();

            if (wineType is not null)
            {
                query = query.Where(w => w.WineType.Name.Contains(wineType));
            }
            if (region is not null)
            {
                query = query.Where(w => w.Winery.Region.Name.Contains(region));
            }
            if (country is not null)
            {
                query = query.Where(w => w.Winery.Region.Country.Name.Contains(country));
            }
            if (winery is not null)
            {
                query = query.Where(w => w.Winery.Name.Contains(winery));
            }
            if (grapeVariety is not null)
            {
                query = query.Where(w => w.GrapeVariety.Name.Contains(grapeVariety));
            }
            if (vintage is not null)
            {
                query.Where(w => w.Vintage.Year == vintage);
            }

            return query.ToList();
        }
    }
}
