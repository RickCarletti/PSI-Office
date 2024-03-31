using Microsoft.EntityFrameworkCore;

namespace PsiOffice.TypeAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() { }
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

        public DbSet<SessionType> SessionTypes { get; set; }
        public DbSet<TreatmentType> TreatmentTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
