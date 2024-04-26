

public class FilmesService : IFilmesService
{
    private readonly IFilmesRepository _filmesRepository;

    public FilmesService(IFilmesRepository filmesRepository)
    {
        _filmesRepository = filmesRepository;
    }

    public async Task<List<Filme>> FindAll()
    {
        return await _filmesRepository.FindAll();
    }

    public async Task<Filme> FindByID(int id)
    {
        return await _filmesRepository.FindByID(id);
    }
}

