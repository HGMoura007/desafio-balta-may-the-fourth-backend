
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[ApiVersion("1")]
[Route("api/[controller]/v{version:apiVersion}")]
public class NavesEstelaresController : ControllerBase
{
    private INavesEstelaresService _navesEstelaresService;

    public NavesEstelaresController(INavesEstelaresService navesEstelaresService)
    {
        _navesEstelaresService = navesEstelaresService;
    }

    [HttpGet]
    public async Task<IActionResult> GetNaves()
    {
        return Ok(await _navesEstelaresService.FindAll());
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetNaveById(int id)
    {
        var nave = await _navesEstelaresService.FindByID(id);
        return nave == null ? NotFound("Nave não encontrada.") : Ok(nave);    
    }
}


