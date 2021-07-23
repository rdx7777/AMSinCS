namespace AMSinSC.DataAccess
{
    using AMSinSC.DataAccess.Entities;
    using Microsoft.EntityFrameworkCore;

    public class AbsenceCaseStorageContext : DbContext
    {
        public AbsenceCaseStorageContext(DbContextOptions<AbsenceCaseStorageContext> options) : base(options)
        {
        }

        public DbSet<AbsenceCase> AbsenceCases { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
