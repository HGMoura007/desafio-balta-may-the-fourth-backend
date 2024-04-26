


using Microsoft.EntityFrameworkCore;

public class VeiculosRepository : IVeiculosRepository
{
    private readonly AppDbContext _context;

    public VeiculosRepository(AppDbContext context)
    {
        _context = context;
    }

    public Task<Veiculo> Create(Veiculo item)
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

    public async Task<List<Veiculo>> FindAll()
    {
        return await _context.Veiculos.ToListAsync();
    }

    public async Task<Veiculo> FindByID(int id)
    {
        return await _context.Veiculos.FindAsync(id);
    }

    public Task<Veiculo> Update(Veiculo item)
    {
        throw new NotImplementedException();
    }
}

