using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Discrod_2.BE
{
    public class Usuarios
    {
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Password { get; set; }
        public int Color { get; set; }
        public byte[] Imagen { get; set; }
        public Usuarios(int usuarioId, string nombre, string password, int color, byte[] imagen)
        {
            UsuarioId = usuarioId;
            Nombre = nombre;
            Password = password;
            Color = color;
            Imagen = imagen;
        }
    }
}
