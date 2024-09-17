using System.ComponentModel.DataAnnotations;

namespace WineCardVersionFive.Entities
{
    public class GrapeVariety
    {
        [Key]
        public int GrapeVarietyId { get; set; }

        [Required, MinLength(1), MaxLength(50)]
        public string Name { get; set; }

        public ICollection<Wine> Wines { get; set; } = new List<Wine>();

        public override string ToString()
        {
            return Name;
        }
    }
}
