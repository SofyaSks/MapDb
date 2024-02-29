using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeographyDb
{
    [Table("Cities")]
    public class City
    {
        [Column("cityId")]
        [Key] public int Id { get;set; }

        [Column("cityName")]
        [Required] public string Name { get; set; }

        [Column("cityCountryId")]
        public int CountryId { get; set; }

        [ForeignKey (nameof(CountryId))]
        public Country Country { get; set; }

        
    }
}
