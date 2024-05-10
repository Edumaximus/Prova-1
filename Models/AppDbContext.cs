using Microsoft.EntityFrameworkCore;

namespace patrickJesusSuprano.Models;

public class AppDbContext : DbContext
{
    public DbSet<Funcionario>Funcionarios  { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=eduardozaduski_patrickjesus.db");
    }
}