using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Amethyst.Domain.Classes;

namespace Amethyst.Repositories.Classes
{
    public class BirthdayConfiguration : EntityTypeConfiguration<Birthday>
    {
        public BirthdayConfiguration()
        {
            ToTable("birthdays", "dbo");

            //HasKey(e => e.Id);

            Property(e => e.Id)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
            .HasColumnName("ID");

            Property(e => e.Birthdate).HasColumnName("birthday").IsRequired();

            Property(e => e.Name).HasColumnName("Name").HasMaxLength(100).IsRequired();
        }

    }
}