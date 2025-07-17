using Microsoft.AspNetCore.Mvc;
using Proyecto_Discrod_2.BE;
using Proyecto_Discrod_2.DAL;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

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

            try
            {
                /*byte[] imagenBytes = null;

                if (dto.Imagen != null && dto.Imagen.Length > 0)
                {
                    using var ms = new MemoryStream();
                    dto.Imagen.CopyTo(ms);
                    imagenBytes = ms.ToArray();
                }*/
                // Crear instancia del usuario
                Usuarios usuario = new Usuarios(0, string.Empty, string.Empty, 0, null)
                {
                    Nombre = dto.Nombre?.Trim(),
                    Password = dto.Password,
                    Color = dto.Color,
                    Imagen = dto.Imagen
                };

                // Validar
                var errores = beUsuario.ValidarUsuario(usuario);
                if (errores.Any())
                {
                    return BadRequest(new { mensaje = "Errores de validación", errores });
                }

                // Agregar a BD
                int resultadoId = beUsuario.AgregarUsuario(usuario);
                if (resultadoId == -1)
                {
                    return StatusCode(500, new { mensaje = beUsuario.Error ?? "Error al registrar el usuario en la base de datos." });
                }

                // Éxito
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


        // DTO: lo que llega desde el form web (incluye imagen como archivo) ¡mudarlo a su propia clase!
        public class UsuarioRegistroDTO
        {
            public string Nombre { get; set; }
            public string Password { get; set; }
            //public string ConfirmarPassword { get; set; }
            public int Color { get; set; }
            //public IFormFile Imagen {get; set;}
            public byte[] Imagen { get; set; }
        }
    }
}