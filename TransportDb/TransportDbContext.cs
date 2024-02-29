using Microsoft.EntityFrameworkCore;

namespace TransportDb
{
    public class TransportDbContext : DbContext 
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Company> Companies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\.;Initial Catalog=Transport;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                 .Entity<Car>()
                 .HasOne(car => car.Company)
                 .WithMany(company => company.Cars)
                 .HasForeignKey(nameof(Car.CompanyId))
                 .OnDelete(DeleteBehavior.NoAction)
                 .IsRequired();

            modelBuilder.Entity<Car>().Navigation(nameof(Car.Company));


        }
    }
}
