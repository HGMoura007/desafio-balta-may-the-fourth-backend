using Microsoft.EntityFrameworkCore;

public class FilmesRepository : IFilmesRepository
{
    private readonly AppDbContext _context;

    public FilmesRepository(AppDbContext context)
    {
        _context = context;
    }

    public Task<Filme> Create(Filme item)
    {
        throw new NotImplementedException();
    }

    public Task Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Exists(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Filme>> FindAll()
    {
        return await _context.Filmes.ToListAsync();
    }

    public async Task<Filme> FindByID(int id)
    {
        return await _context.Filmes.FindAsync(id);

    }

    public Task<Filme> Update(Filme item)
    {
        throw new NotImplementedException();
    }
}

