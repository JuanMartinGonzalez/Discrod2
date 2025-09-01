using Microsoft.AspNetCore.Mvc;
using Proyecto_Discrod_2.BE;
using System;
using System.Linq;

namespace Proyecto_Discrod_2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MensajesController : ControllerBase
    {
        private readonly BEMensaje beMensaje = new();

        // DTO para enviar mensajes
        public class MensajeDTO
        {
            public string Texto { get; set; }
            public int UsuarioOrigen { get; set; }
            public int UsuarioDestino { get; set; }
        }

        // GET api/mensajes/entre-usuarios?origenId=1&destinoId=2
        [HttpGet("entre-usuarios")]
        public IActionResult ObtenerMensajesEntreUsuarios(int origenId, int destinoId)
        {
            try
            {
                var mensajes = beMensaje.ObtenerMensajesEntreUsuarios(origenId, destinoId);
                var dto = mensajes.Select(m => new
                {
                    m.Texto,
                    m.UsuarioOrigen,
                    m.UsuarioDestino,
                    m.FechaEnvio,
                    m.FechaLectura
                }).ToList();
                return Ok(dto);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { mensaje = "Error al obtener mensajes", error = ex.Message });
            }
        }

        // POST api/mensajes/enviar
        [HttpPost("enviar")]
        public IActionResult EnviarMensaje([FromBody] MensajeDTO dto)
        {
            try
            {
                var mensaje = new Mensajes(
                    dto.Texto,
                    DateTime.Now,
                    new DateTime(1900, 1, 1),
                    dto.UsuarioOrigen,
                    dto.UsuarioDestino
                );

                int id = beMensaje.AgregarMensaje(mensaje);

                if (id > 0)
                    return Ok(new { mensaje = "Mensaje enviado", id });
                else
                    return StatusCode(500, new { mensaje = beMensaje.Error ?? "No se pudo enviar el mensaje" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { mensaje = "Error al enviar mensaje", error = ex.Message });
            }
        }
    }
}
