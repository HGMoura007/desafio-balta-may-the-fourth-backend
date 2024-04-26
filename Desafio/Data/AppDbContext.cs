using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext 
{
    public DbSet<Filme> Filmes { get; set; }
    public DbSet<NaveEstelar> NavesEstelares { get; set; }
    public DbSet<Personagem> Personagens { get; set; }
    public DbSet<Planeta> Planetas { get; set; }
    public DbSet<Veiculo> Veiculos { get; set; }

    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("DataSource=desafio.db; Cache=Shared");
}

