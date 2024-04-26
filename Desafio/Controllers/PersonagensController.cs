using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


[ApiController]
[ApiVersion("1")]
[Route("api/[controller]/v{version:apiVersion}")]
public class PersonagensController : ControllerBase
{

    private IPersonagensService _personagensService;

    public PersonagensController(IPersonagensService personagensService)
    {
        _personagensService = personagensService;
    }

    [HttpGet]
    public async Task<IActionResult> GetPersonagens()
    {
        
        return Ok(await _personagensService.FindAll());
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetPersonagemById(int id)
    {
        var personagem = await _personagensService.FindByID(id);

        return personagem == null ? NotFound("Personagem não encontrado.") : Ok(personagem);

    }
}

