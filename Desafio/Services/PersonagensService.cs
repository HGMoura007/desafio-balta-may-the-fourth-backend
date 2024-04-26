


public class PersonagensService : IPersonagensService
{
    private readonly IPersonagensRepository _personagensRepository;

    public PersonagensService(IPersonagensRepository personagensRepository)
    {
        _personagensRepository = personagensRepository;
    }

    public async Task<List<Personagem>> FindAll()
    {
        return await _personagensRepository.FindAll();
    }

    public async Task<Personagem> FindByID(int id)
    {
        return await _personagensRepository.FindByID(id);
    }
}

