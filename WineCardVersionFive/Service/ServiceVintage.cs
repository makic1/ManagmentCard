using WineCardVersionFive.Entities;

namespace WineCardVersionFive.Service
{
    public class ServiceVintage
    {
        private readonly DbContextWineCardVersionFive _context;

        public ServiceVintage(DbContextWineCardVersionFive context)
        {
            _context = context;
        }

        public List<Vintage> GetAllVintages()
        {
            return _context.Vintages.ToList();
        }

        public void AddVintage(Vintage vintage)
        {
            _context.Vintages.Add(vintage);
            _context.SaveChanges();
        }

        public void UpdateVintage(Vintage vintageToUpdate)
        {
            var vintage = FindVintageById(vintageToUpdate.VintageId);

            if (vintage is not null)
            {
                vintage.VintageId = vintageToUpdate.VintageId;
                vintage.Year = vintageToUpdate.Year;

                _context.SaveChanges();
            }
        }

        public void RemoveVintageById(int id)
        {
            _context.Vintages.Remove(FindVintageById(id));
            _context.SaveChanges();
        }

        public Vintage FindVintageById(int id)
        {
            return _context.Vintages.Find(id);
        }

        public bool CheckOfDuplicateVintage(Vintage vintage)
        {
            return _context.Vintages.Any(v => v.Year == vintage.Year);
        }
    }
}
