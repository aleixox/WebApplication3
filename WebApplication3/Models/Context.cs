using Microsoft.EntityFrameworkCore;


namespace WebApplication3.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options): base(options) 
        {

        }

        public DbSet<Itens> Item { get; set; }

    }
}
