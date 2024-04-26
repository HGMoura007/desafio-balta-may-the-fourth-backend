


public class VeiculosService : IVeiculosService
{
    private readonly IVeiculosRepository _veiculosRepository;

    public VeiculosService(IVeiculosRepository veiculosRepository)
    {
        _veiculosRepository = veiculosRepository;
    }

    public async Task<List<Veiculo>> FindAll()
    {
        return await _veiculosRepository.FindAll();
    }

    public async Task<Veiculo> FindByID(int id)
    {
        return await _veiculosRepository.FindByID(id);
    }
}

