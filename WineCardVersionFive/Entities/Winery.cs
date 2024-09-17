using System.ComponentModel.DataAnnotations;

namespace WineCardVersionFive.Entities
{
    public class Winery
    {
        [Key]
        public int WineryId { get; set; }

        [Required, MinLength(3), MaxLength(60)]
        public string Name { get; set; }

        public ICollection<Wine> Wines { get; set; } = new List<Wine>();

        public int RegionId { get; set; }
        public Region Region { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
