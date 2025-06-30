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
        public int AgregarUsuario(Usuarios usuarios)
        {
            DAL.UsuarioDAL usuarioDAL = new DAL.UsuarioDAL();
            try
            { 
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
                if (usuarios.Password.Contains('\'') || usuarios.Password.Contains('\"'))
                {
                    throw new ArgumentException("La contraseña no puede contener comillas");
                }
                if (usuarios.Color == null)
                {
                    throw new ArgumentOutOfRangeException(nameof(usuarios.Color), "El usuario debe elegir un color.");
                }
                if (usuarios.Imagen == null)
                {
                    throw new ArgumentNullException(nameof(usuarios.Imagen), "La imagen del usuario no puede ser nula.");
                }
                if (usuarios.Nombre == "U S U A R I O")
                {
                    throw new ArgumentException(nameof(usuarios.Nombre), "El usuario debe elegir otro nombre.");
                }
                if (usuarios.Password == "C O N T R A S E Ñ A")
                {
                    throw new ArgumentException(nameof(usuarios.Password), "El usuario debe elegir otra contraseña");
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
