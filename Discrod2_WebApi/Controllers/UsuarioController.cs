using Microsoft.AspNetCore.Mvc;
using Proyecto_Discrod_2.BE;
using Proyecto_Discrod_2.DAL;
using System;
using System.IO;

namespace Discrod_2.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuariosController : ControllerBase
    {
        // POST api/usuarios/registrar
        [HttpPost("registrar")]
        public IActionResult RegistrarUsuario([FromForm] UsuarioRegistroDTO dto)
        {
            BEUsuario beUsuario = new();
            Console.WriteLine("Entró al endpoint /api/usuarios/registrar");

            try
            {
                byte[] imagenBytes = null;

                if (dto.Imagen != null && dto.Imagen.Length > 0)
                {
                    using var ms = new MemoryStream();
                    dto.Imagen.CopyTo(ms);
                    imagenBytes = ms.ToArray();
                }

                Usuarios usuario = new Usuarios(0, string.Empty, string.Empty, 0, null)
                {
                    Nombre = dto.Nombre?.Trim(),
                    Password = dto.Password,
                    Color = dto.Color,
                    Imagen = imagenBytes
                };

                var errores = beUsuario.ValidarUsuario(usuario);
                if (errores.Any())
                {
                    return BadRequest(new { mensaje = "Errores de validación", errores });
                }

                int resultadoId = beUsuario.AgregarUsuario(usuario);
                if (resultadoId == -1)
                {
                    return StatusCode(500, new { mensaje = beUsuario.Error ?? "Error al registrar el usuario en la base de datos." });
                }

                return Ok(new
                {
                    mensaje = "Usuario registrado con éxito.",
                    usuarioId = resultadoId
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    mensaje = "Ocurrió un error inesperado.",
                    error = ex.Message
                });
            }
        }

        // POST api/usuarios/login
        [HttpPost("login")]
        public IActionResult Login([FromForm] LoginDTO dto)
        {
            BEUsuario beUsuario = new();
            try
            {
                int resultado = beUsuario.VerificarLoginUsuario(dto.Nombre, dto.Password);

                if (resultado == 1)
                {
                    var usuario = beUsuario.ObtenerUsuariologueado(dto.Nombre, dto.Password);
                    return Ok(new
                    {
                        mensaje = "Login exitoso",
                        usuarioId = usuario.UsuarioId,
                        nombre = usuario.Nombre,
                        color = usuario.Color
                    });
                }
                else if (resultado == -2)
                {
                    return Unauthorized(new { mensaje = "Contraseña incorrecta" });
                }
                else
                {
                    return NotFound(new { mensaje = beUsuario.Error ?? "El usuario no existe" });
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    mensaje = "Error inesperado en login",
                    error = ex.Message
                });
            }
        }

        // GET api/usuarios/listar
        [HttpGet("listar")]
        public IActionResult ListarUsuarios()
        {
            BEUsuario beUsuario = new();
            try
            {
                var lista = beUsuario.ObtenerUsuarios();
                                                         
                var listaDTO = lista.Select(u => new
                {
                    u.UsuarioId,
                    u.Nombre,
                    u.Color,
                    Imagen = u.Imagen != null ? Convert.ToBase64String(u.Imagen) : null
                }).ToList();

                return Ok(listaDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { mensaje = "Error al obtener usuarios", error = ex.Message });
            }
        }


        // DTOs internos
        public class UsuarioRegistroDTO
        {
            public string Nombre { get; set; }
            public string Password { get; set; }
            public int Color { get; set; }
            public IFormFile Imagen { get; set; }
        }

        public class LoginDTO
        {
            public string Nombre { get; set; }
            public string Password { get; set; }
        }
    }
}
