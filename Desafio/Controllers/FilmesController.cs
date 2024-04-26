using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;



[ApiController]
[ApiVersion("1")]
[Route("api/[controller]/v{version:apiVersion}")]
public class FilmesController : ControllerBase
{
    private IFilmesService _filmesService;

    public FilmesController(IFilmesService filmesService)
    {
        
        _filmesService = filmesService;
    }

    [HttpGet]
    public async Task<IActionResult> GetFilmes()
    {       
        return Ok(await _filmesService.FindAll());
    }


    [HttpGet("{id}")]
    public async Task<IActionResult> GetFilmeById(int id)
    {
        var filme = await _filmesService.FindByID(id);
        return filme == null ? NotFound("Filme não encontrado.") : Ok(filme);
    }
}

