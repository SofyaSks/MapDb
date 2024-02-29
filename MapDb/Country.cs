using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GeographyDb
{
    [Table("Countries") ]
    public class Country
    {
        [Column("countryId")]
        [Key] public int Id { get; set; }
        [Column("countryName")]
        [Required] public string Name { get; set;}       
        public IList<City> Cities {  get; set; } = new List<City>();

        [NotMapped]
        public int CitiesCount { get; }
    }
}
