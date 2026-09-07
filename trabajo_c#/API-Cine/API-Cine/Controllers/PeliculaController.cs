using API_Cine.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Cine.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PeliculaController : ControllerBase
{
    private readonly DbCineContext _context;

    public PeliculaController(DbCineContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> ObtenerPeliculas()
    {
        var peliculas = await _context.Peliculas.ToListAsync();

        return Ok(peliculas);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> ObtenerPeliculaPorId(int id)
    {
        var pelicula = await _context.Peliculas.FindAsync(id);

        if (pelicula == null)
        {
            return NotFound();
        }

        return Ok(pelicula);
    }
}