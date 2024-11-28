namespace MVCCar
{
    using Microsoft.EntityFrameworkCore;

    namespace MVCCar.Models // Ovdje prilagodite prostor imena prema svom projektu
    {
        public class ApplicationDbContext : DbContext
        {
            // DbSet za entitet Car
            public DbSet<Car> Cars { get; set; }

            // Konstruktor za konfiguraciju DbContext-a
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
            {
            }
        }
    }
}
