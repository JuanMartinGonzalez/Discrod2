using Proyecto_Discrod_2.BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Discrod_2.ESTADO
{
    /// Clase que guarda el usuario actualmente logueado en el sistema.
    /// Sirve para consultar desde cualquier parte del programa quién está logueado.
    public static class UsuarioLogueado
    {
        /// Usuario actual logueado. Si no hay sesión, es null.
        public static Usuarios UsuarioActual { get; private set; }

        /// Indica si hay un usuario logueado en el sistema.
        public static bool EstaLogueado => UsuarioActual != null;

        /// Inicia sesión con el usuario recibido.
        public static void IniciarSesion(Usuarios usuario)
        {
            UsuarioActual = usuario;
        }

        /// Cierra la sesión actual.
        public static void CerrarSesion()
        {
            UsuarioActual = null;
        }
    }
}
