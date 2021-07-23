namespace AMSinSC.DataAccess
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Design;

    public class AbsenceCaseStorageContextFactory : IDesignTimeDbContextFactory<AbsenceCaseStorageContext>
    {
        public AbsenceCaseStorageContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AbsenceCaseStorageContext>();
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=AbsenceCaseStorage;Integrated Security=True");
            return new AbsenceCaseStorageContext(optionsBuilder.Options);
        }
    }
}
