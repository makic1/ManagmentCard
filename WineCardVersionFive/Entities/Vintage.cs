using System.ComponentModel.DataAnnotations;

namespace WineCardVersionFive.Entities
{
    public class Vintage
    {
        [Key]
        public int VintageId { get; set; }

        [Required]
        public int Year { get; set; }

        public ICollection<Wine> Wines { get; set; } = new List<Wine>();

        public override string ToString()
        {
            return Convert.ToString(Year);
        }
    }
}
