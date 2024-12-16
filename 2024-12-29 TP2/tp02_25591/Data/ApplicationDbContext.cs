using GestaoReceitasExercicios.Models;
using Microsoft.EntityFrameworkCore;


namespace GestaoReceitasExercicios.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Receita> Receitas { get; set; }
        public DbSet<Exercicio> Exercicio { get; set; }
    }
}
