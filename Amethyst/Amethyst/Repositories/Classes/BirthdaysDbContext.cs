using System.Data.Entity;
using Amethyst.Domain.Classes;

namespace Amethyst.Repositories.Classes
{
    public class BirthdaysDbContext : DbContext
    {
        public BirthdaysDbContext()
            : base("BirthdaysConnectionString")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<BirthdaysDbContext>());
        }

        public DbSet<Birthday> Birthdays { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new BirthdayConfiguration());
        }
    }
}