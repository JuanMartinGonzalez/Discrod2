using Microsoft.AspNetCore.Mvc;
using Proyecto_Discrod_2.BE;
using Proyecto_Discrod_2.DAL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Discrod_2.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuariosController : ControllerBase
    {

        // Update the method to handle IFormFile correctly
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
                    dto.Imagen.CopyTo(ms); // This now works because Imagen is of type IFormFile
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



        // Replace the property type of Imagen in UsuarioRegistroDTO
        public class UsuarioRegistroDTO
        {
            public string Nombre { get; set; }
            public string Password { get; set; }
            public int Color { get; set; }
            public IFormFile Imagen { get; set; } // Change byte[] to IFormFile
        }
    }
}