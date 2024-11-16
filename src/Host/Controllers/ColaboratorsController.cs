using ApplicationCore.DTOs.Colaborators;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Host.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ColaboratorsController : ControllerBase
{
    private readonly IColaboratorsService _service;

    public ColaboratorsController(IColaboratorsService service)
    {
        _service = service;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var colaborators = await _service.ListColaborators();
        return Ok(colaborators);
    }
    
    [HttpPost]
    public async Task<IActionResult> Create(ColaboratorCreateDto request)
    {
        var colaborator = await _service.Create(request);
        return Ok(colaborator);
    }
}