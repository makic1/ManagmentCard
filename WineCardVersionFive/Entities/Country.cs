using System.ComponentModel.DataAnnotations;

namespace WineCardVersionFive.Entities
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }

        [Required, MinLength(2), MaxLength(50)]
        public string Name { get; set; }

        public ICollection<Region> Regions { get; set; } = new List<Region>();

        public override string ToString()
        {
            return Name;
        }
    }
}
