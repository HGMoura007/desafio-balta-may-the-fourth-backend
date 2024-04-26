



using Microsoft.EntityFrameworkCore;

public class PlanetasRepository : IPlanetasRepository
{
    private readonly AppDbContext _context;

    public PlanetasRepository(AppDbContext context)
    {
        _context = context;
    }

    public Task<Planeta> Create(Planeta item)
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

    public async Task<List<Planeta>> FindAll()
    {
        return await _context.Planetas.ToListAsync();
    }

    public async Task<Planeta> FindByID(int id)
    {
        return await _context.Planetas.FindAsync(id);
    }

    public Task<Planeta> Update(Planeta item)
    {
        throw new NotImplementedException();
    }
}

