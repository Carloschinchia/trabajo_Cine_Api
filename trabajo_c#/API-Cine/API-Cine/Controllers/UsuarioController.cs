using API_Cine.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Cine.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsuarioController : ControllerBase
{
    private readonly DbCineContext _context;

    public UsuarioController(DbCineContext context)
    {
        _context = context;
    }


    // =========================
    // OBTENER USUARIOS
    // =========================

    [HttpGet]
    public async Task<IActionResult> ObtenerUsuarios()
    {
        var usuarios = await _context.Usuarios.ToListAsync();

        return Ok(usuarios);
    }


    // =========================
    // INICIAR SESIÓN
    // =========================

    [HttpPost("login")]
    public async Task<IActionResult> IniciarSesion(
        SolicitudLogin login)
    {
        var usuario = await _context.Usuarios
            .FirstOrDefaultAsync(u =>
                u.Correo == login.Correo &&
                u.Contraseña == login.Contraseña);

        if (usuario == null)
        {
            return Unauthorized("Correo o contraseña incorrectos.");
        }

        return Ok(new
        {
            usuario.Id,
            usuario.Nombre,
            usuario.Correo
        });
    }


    // =========================
    // REGISTRAR USUARIO
    // =========================

    [HttpPost("registro")]
    public async Task<IActionResult> RegistrarUsuario(
        SolicitudRegistro registro)
    {
        var existe = await _context.Usuarios
            .AnyAsync(u => u.Correo == registro.Correo);

        if (existe)
        {
            return BadRequest("El correo ya está registrado.");
        }

        var usuario = new Usuario
        {
            Nombre = registro.Nombre,
            Correo = registro.Correo,
            Contraseña = registro.Contraseña    
        };

        _context.Usuarios.Add(usuario);

        await _context.SaveChangesAsync();

        return Ok(usuario);
    }
}