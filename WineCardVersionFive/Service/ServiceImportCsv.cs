using System.Globalization;
using WineCardVersionFive.Entities;

namespace WineCardVersionFive.Service
{
    public class ServiceImportCsv
    {
        private readonly DbContextWineCardVersionFive _context;

        public ServiceImportCsv(DbContextWineCardVersionFive context)
        {
            _context = context;
        }

        public void ImportCsv(string path)
        {
            var lines = File.ReadAllLines(path);

            for (int i = 1; i < lines.Length; i++)
            {
                var cells = lines[i].Split(';');


                Vintage vintage = _context.Vintages.FirstOrDefault(v => v.Year == Convert.ToInt32(cells[4]));
                if (vintage == null)
                {
                    vintage = new Vintage
                    {
                        Year = Convert.ToInt32(cells[4]),
                    };
                    _context.Vintages.Add(vintage);
                }

                WineType wineType = _context.WineTypes.FirstOrDefault(wt => wt.Name == cells[2]);
                if (wineType is null)
                {
                    wineType = new WineType
                    {
                        Name = cells[2],
                    };
                    _context.WineTypes.Add(wineType);
                }

                GrapeVariety grapeVariety = _context.GrapeVarieties.FirstOrDefault(gv => gv.Name == cells[7]);
                if (grapeVariety is null)
                {
                    grapeVariety = new GrapeVariety
                    {
                        Name = cells[7]
                    };
                    _context.GrapeVarieties.Add(grapeVariety);
                }

                Country country = _context.Countrys.FirstOrDefault(c => c.Name == cells[3]);
                if (country is null)
                {
                    country = new Country
                    {
                        Name = cells[3]
                    };
                    _context.Countrys.Add(country);
                }

                Entities.Region region = _context.Regions.FirstOrDefault(c => c.Name == cells[6] && c.Country == country);
                if (region is null)
                {
                    region = new Entities.Region
                    {
                        Name = cells[6],
                        Country = country
                    };
                    _context.Regions.Add(region);
                }

                Winery winery = _context.Wineries.FirstOrDefault(w => w.Name == cells[5] && w.Region == region);
                if (winery is null)
                {
                    winery = new Winery
                    {
                        Name = cells[5],
                        Region = region
                    };
                    _context.Wineries.Add(winery);
                }

                Wine wine = _context.Wines.FirstOrDefault(w => w.Name == cells[0] && w.Vintage == vintage && w.WineType == wineType && w.GrapeVariety == grapeVariety && w.Winery == winery);
                if (wine is null)
                {
                    wine = new Wine
                    {
                        Name = cells[0],
                        PriceInEuro = Decimal.Parse(cells[1].Replace("€","").Trim().Replace(",","."), CultureInfo.InvariantCulture),
                        Vintage = vintage,
                        WineType = wineType,
                        GrapeVariety = grapeVariety,
                        Winery = winery,
                    };
                    _context.Wines.Add(wine);
                }
                _context.SaveChanges();
            }
        }
    }
}
