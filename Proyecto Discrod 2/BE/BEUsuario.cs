using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Discrod_2.BE
{
    internal class BEUsuario
    {
        public string error{ get; set; }
        //public BEUsuario() { }
        public int AgregarUsuario(Usuarios usuarios)
        {
            DAL.UsuarioDAL usuarioDAL = new DAL.UsuarioDAL();
            try
            {
                usuarioDAL.AgregarUsuario(usuarios);
                return usuarioDAL.AgregarUsuario(usuarios);
            }
            catch (Exception ex)
            {
                error = "Error al agregar el usuario.";
                throw ex;
            }
        }
        public int VerificarUsuario(Usuarios usuarios)
        {
            try
            {
                #region validaciones
                if (usuarios == null)
                {
                    throw new ArgumentNullException(nameof(usuarios), "El usuario no puede ser nulo.");
                }
                if (string.IsNullOrWhiteSpace(usuarios.Nombre))
                {
                    throw new ArgumentException("El nombre del usuario no puede estar vacío.", nameof(usuarios.Nombre));
                }
                if (string.IsNullOrWhiteSpace(usuarios.Password))
                {
                    throw new ArgumentException("La contraseña del usuario no puede estar vacía.", nameof(usuarios.Password));
                }
                if (usuarios.Color == null)
                {
                    throw new ArgumentOutOfRangeException(nameof(usuarios.Color), "El usuario debe elegir un color.");
                }
                if (usuarios.Imagen == null)
                {
                    throw new ArgumentNullException(nameof(usuarios.Imagen), "La imagen del usuario no puede ser nula.");
                }
                #endregion validaciones
                return 0; // Si todo está bien, retorna 0 o algún valor que indique éxito
            }
            catch (Exception ex)
            {
                error = "Error crítico.";
                throw ex;
            }
        }
    }
}
