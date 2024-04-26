


using Microsoft.EntityFrameworkCore;

public class NavesEstelaresRepository : INavesEstelaresRepository
{
    private readonly AppDbContext _context;

    public NavesEstelaresRepository(AppDbContext context)
    {
        _context = context;
    }

    public Task<NaveEstelar> Create(NaveEstelar item)
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

    public async Task<List<NaveEstelar>> FindAll()
    {
        return await _context.NavesEstelares.ToListAsync();
    }

    public async Task<NaveEstelar> FindByID(int id)
    {
        return await _context.NavesEstelares.FindAsync(id);
    }

    public Task<NaveEstelar> Update(NaveEstelar item)
    {
        throw new NotImplementedException();
    }
}
