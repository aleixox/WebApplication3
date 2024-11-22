using Microsoft.EntityFrameworkCore;


namespace WebApplication3.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options): base(options) 
        {

        }

        public DbSet<Itens> Item { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=APICRUD;Username=Aleixo;Password=adminInicial");
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
            optionsBuilder.EnableSensitiveDataLogging();

            base.OnConfiguring(optionsBuilder);
        }
    }
}
