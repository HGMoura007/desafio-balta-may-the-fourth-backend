using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[ApiVersion("1")]
[Route("api/[controller]/v{version:apiVersion}")]
public class VeiculosController : ControllerBase
{
    private IVeiculosService _veiculosService;

    public VeiculosController(IVeiculosService veiculosService)
    {
        _veiculosService = veiculosService;
    }

    [HttpGet]
    public async Task<IActionResult> GetVeiculos()
    {
        return Ok(await _veiculosService.FindAll());
    }


    [HttpGet("{id}")]
    public async Task<IActionResult> GetVeiculoById(int id)
    {
        var veiculo = await _veiculosService.FindByID(id);
        return veiculo == null ? NotFound("veiculo não encontrado.") : Ok(veiculo);
    }
}

