using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AcmeSacBlazor.Web.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Categoria> categorias { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Categoria>().HasData(
                new Categoria { Id = 1, nom_categoria = "Categoria 01" },
                new Categoria { Id = 2, nom_categoria = "Categoria 02" },
                new Categoria { Id = 3, nom_categoria = "Categoria 03" }
                );
        }
    }
}
