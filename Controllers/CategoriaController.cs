using Microsoft.AspNetCore.Mvc;
using ProCatalog.API.Models;

namespace ProCatalog.API.Controllers;

[ApiController]
[Route("api/[controller]")]

public class CategoriaController : ControllerBase
{

    [HttpGet]
    public IActionResult Get()
    {
        var categorias = new List<Categoria>
        {
            new Categoria { Id = 1, Nome = "Eletrônicos" },
            new Categoria { Id = 2, Nome = "Games" }
        };

        return Ok(categorias);
    }
}
