using Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.DbConfig
{
    public class ApplicationUserConfig : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.ToTable("Users",SchemaNames.Security);
            builder.Property(p => p.CreatedOnDate).HasDefaultValue(DateTime.UtcNow);
            builder.Property(p => p.UpdatedOnDate).HasDefaultValue(DateTime.UtcNow);
            builder.Property(p => p.DeletedOnDate).HasDefaultValue(DateTime.UtcNow);
            builder.Property(p => p.IsDeleted).HasDefaultValue(false);
            builder.Property(p => p.IsActive).HasDefaultValue(true);
        }
    }
}
