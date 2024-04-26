


using Microsoft.EntityFrameworkCore;

public class PersonagensRepository : IPersonagensRepository
{
    private readonly AppDbContext _context;

    public PersonagensRepository(AppDbContext context)
    {
        _context = context;
    }

    public Task<Personagem> Create(Personagem item)
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

    public async Task<List<Personagem>> FindAll()
    {
        return await _context.Personagens.ToListAsync();
    }

    public async Task<Personagem> FindByID(int id)
    {
        return await _context.Personagens.FindAsync(id);
    }

    public Task<Personagem> Update(Personagem item)
    {
        throw new NotImplementedException();
    }
}

