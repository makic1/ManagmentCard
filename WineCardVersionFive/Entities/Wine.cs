using System.ComponentModel.DataAnnotations;

namespace WineCardVersionFive.Entities
{
    public class Wine
    {
        [Key]
        public int WineId { get; set; }

        [Required, MinLength(2), MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public decimal PriceInEuro { get; set; }

        public int? WineCardId { get; set; }
        public WineCard? WineCard { get; set; }

        public int VintageId { get; set; }
        public Vintage Vintage { get; set; }

        public int WineTypeId { get; set; }
        public WineType WineType { get; set; }

        public int GrapeVarietyId { get; set; }
        public GrapeVariety GrapeVariety { get; set; }

        public int WineryId { get; set; }
        public Winery Winery { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
