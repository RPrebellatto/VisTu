using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VisTu.Areas.Identity.Data;

namespace VisTu.Data;

public class VisTuContext : IdentityDbContext<VisTuUsuario>
{
    public VisTuContext(DbContextOptions<VisTuContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder)

        builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
    }


}

public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<VisTuUsuario>
{
    public void Configure(EntityTypeBuilder<VisTuUsuario> builder)
    {
       builder.Property(u => u.Nome).IsRequired().HasMaxLength(20);
       builder.Property(u => u.Sobrenome).IsRequired().HasMaxLength(50);
    }
}