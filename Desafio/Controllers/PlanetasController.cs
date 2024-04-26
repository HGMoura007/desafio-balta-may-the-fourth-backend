using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[ApiVersion("1")]
[Route("api/[controller]/v{version:apiVersion}")]
public class PlanetasController : ControllerBase
{

    private readonly IPlanetasService _planetasService;

    public PlanetasController(IPlanetasService planetasService)
    {
        _planetasService = planetasService;
    }

    [HttpGet]
    public async Task<IActionResult> GetPlanetas()
    {
        return Ok(await _planetasService.FindAll());
    }


    [HttpGet("{id}")]
    public async Task<IActionResult> GetPlanetaById(int id)
    {
        var planeta = await _planetasService.FindByID(id);
        return planeta == null ? NotFound("planeta não encontrado.") : Ok(planeta);
    }
}

