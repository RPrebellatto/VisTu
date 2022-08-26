

namespace VisTu.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options):
            base(options)
        {

        }
        public DbSet<Setor>?Setores{get; set;}
    }
}
