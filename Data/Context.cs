

namespace VisTu.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options):
            base(options)
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
        public DbSet<Setor>? Setores{get; set;}
        public DbSet<Usuario>? Usuarios { get; set; }
        public DbSet<Tubulacao> Tubulacoes { get; set; }
        public DbSet<Avaria> Avarias { get; set; }
    }
}
