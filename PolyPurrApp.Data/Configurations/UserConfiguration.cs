using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PolyPurrApp.Core.Models;

namespace PolyPurrApp.Data.Configurations;

public class UserAppConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.Property(x => x.ProfilImageUrl).HasMaxLength(50);
    }
}
