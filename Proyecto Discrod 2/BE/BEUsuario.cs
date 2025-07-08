using Microsoft.Data.SqlClient;
using Proyecto_Discrod_2.DAL;
using Proyecto_Discrod_2.VAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Discrod_2.BE
{
    internal class BEUsuario
    {
        public string Error { get; set; }
        public int AgregarUsuario(Usuarios usuarios)
        {
            DAL.UsuarioDAL usuarioDAL = new();
            try
            {
                return usuarioDAL.AgregarUsuario(usuarios);
            }
            catch (Exception ex)
            {
                Error = "Error al agregar el usuario." + ex;
                return -1; // Return a default value in case of an exception
            }
        }

        public bool ExisteUusuario(string nombre, string password)

        {
            // Verificar si el usuario ya existe
            try
            {
                string query = "SELECT COUNT(*) FROM Usuarios WHERE Nombre = @Nombre AND Password = @Password";
                using (SqlCommand command = new SqlCommand(query, FormPadre.ObtenerConexion()))
                {
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Password", password);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0; // Retorna true si el usuario ya está registrado
                }
            }
            catch (Exception ex)
            {
                Error = "Los datos ingresados son incorrecetos" + ex;
                return false; // Retorna false en caso de error
            }
        }

        public List<string> ValidarUsuario(Usuarios usuario)
        {
            var validator = new ValidarUsuario();
            var resultado = validator.Validate(usuario);

            var errores = resultado.Errors.Select(e => e.ErrorMessage).ToList();

            var usuarioDAL = new UsuarioDAL();
            if (usuarioDAL.ExisteUsuario(usuario.Nombre))
            {
                errores.Add("El nombre de usuario ya está registrado.");
            }

            return errores;
        }

        public List<Usuarios> ObtenerUsuarios()
        {
            try
            {
                var lista = UsuarioDAL.ObtenerUsuarios();
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar los usuarios: " + ex.Message);
            }
        }

    }
}
