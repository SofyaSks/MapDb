using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographyDb
{
    public class GeographyDbContext :DbContext
    {

        public DbSet <Country> Countries {  get; set; }
        public DbSet <City> Cities { get; set; }
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\.;Initial Catalog=Geography;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=False");
        }
    }
}
