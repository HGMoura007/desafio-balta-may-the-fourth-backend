


public class PlanetasService : IPlanetasService
{
    private readonly IPlanetasRepository _planetasRepository;

    public PlanetasService(IPlanetasRepository planetasRepository)
    {
        _planetasRepository = planetasRepository;
    }

    public async Task<List<Planeta>> FindAll()
    {
        return await _planetasRepository.FindAll();
    }

    public async Task<Planeta> FindByID(int id)
    {
        return await _planetasRepository.FindByID(id);
    }
}
