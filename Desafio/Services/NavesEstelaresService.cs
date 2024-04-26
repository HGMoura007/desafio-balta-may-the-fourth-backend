


public class NavesEstelaresService : INavesEstelaresService
{
    private readonly INavesEstelaresRepository _navesEstelaresRepository;

    public NavesEstelaresService(INavesEstelaresRepository navesEstelaresRepository)
    {
        _navesEstelaresRepository = navesEstelaresRepository;
    }

    public async Task<List<NaveEstelar>> FindAll()
    {
        return await _navesEstelaresRepository.FindAll();
    }

    public async Task<NaveEstelar> FindByID(int id)
    {
        return await _navesEstelaresRepository.FindByID(id);
    }
}

