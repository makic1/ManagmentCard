using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineCardVersionFive.Entities
{
    public class Region
    {
        [Key]
        public int RegionId { get; set; }
        [Required, MinLength(2), MaxLength(50)]
        public string Name { get; set; }

        public ICollection<Winery> Wineries { get; set; } = new List<Winery>();

        public int CountryId { get; set; }
        public Country Country { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
