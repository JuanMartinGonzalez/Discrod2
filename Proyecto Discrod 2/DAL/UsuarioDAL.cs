using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Discrod_2.DAL
{
    public class UsuarioDAL
    {
        public string error { get; set; }
        // Metodo Agregar usuario
        public int AgregarUsuario(BE.Usuarios usuario)
        {
            // Verificar si el usuario ya existe
            int retorna = 0;
            try
            {
                // Consulta SQL para insertar un nuevo usuario y obtener su ID
                string query = "INSERT INTO Usuarios (Nombre, Password, Color, Imagen) VALUES (@Nombre, @Password, @Color, @Imagen); SELECT SCOPE_IDENTITY();";
                using (SqlCommand command = new SqlCommand(query, FormPadre.ObtenerConexion()))

                {
                    // Añadir los parámetros necesarios para la consulta
                    command.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                    command.Parameters.AddWithValue("@Password", usuario.Password);
                    command.Parameters.AddWithValue("@Color", usuario.Color);
                    command.Parameters.AddWithValue("@Imagen", usuario.Imagen);
                    // Ejecutar el comando y obtener el ID del nuevo usuario
                    retorna = Convert.ToInt32(command.ExecuteScalar());
                }
                // Si la inserción fue exitosa, retorna el ID del nuevo usuario
                return retorna;
            }
            // Si ocurre un error, captura la excepción y asigna un mensaje de error
            catch (Exception ex)
            {
                error = "Error en la base de datos.";
                throw ex;//error; 
            }



        }
        // Metodo Actualizar usuario
        public int ActualizarUsuario(BE.Usuarios usuario)
        {
            // Verificar si el usuario ya existe
            int retorna = 0;
            // Intentar ejecutar la actualización del usuario
            try
            {

                string query = "UPDATE Usuarios SET Nombre = @Nombre, Password = @Password, Color = @Color, Imagen = @Imagen WHERE UsuarioId = @UsuarioId";
                // Crear un comando SQL para actualizar el usuario
                using (SqlCommand command = new SqlCommand(query, FormPadre.ObtenerConexion()))
                {
                    // Añadir los parámetros necesarios para la consulta
                    command.Parameters.AddWithValue("@UsuarioId", usuario.UsuarioId);
                    command.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                    command.Parameters.AddWithValue("@Password", usuario.Password);
                    command.Parameters.AddWithValue("@Color", usuario.Color);
                    command.Parameters.AddWithValue("@Imagen", usuario.Imagen);
                    retorna = command.ExecuteNonQuery();
                }

                return retorna;
            }

            catch (Exception ex)
            {
                // Si ocurre un error, captura la excepción y asigna un mensaje de error
                error = "Error en la base de datos.";
                throw ex;//error; 
            }
        }
        //Metodo Eliminar usuario

        // Este método elimina un usuario de la base de datos según su ID.
        public int EliminarUsuario(int usuarioId)
        {
            // Verificar si el usuario ya existe
            int retorna = 0;
            try
            {

                string query = "DELETE FROM Usuarios WHERE UsuarioId = @UsuarioId";
                using (SqlCommand command = new SqlCommand(query, FormPadre.ObtenerConexion()))
                {
                    command.Parameters.AddWithValue("@UsuarioId", usuarioId);
                    retorna = command.ExecuteNonQuery();
                }
                return retorna;
            }
            catch (Exception ex)
            {
                error = "Error en la base de datos.";
                throw ex;//error; 
            }
        }
    }
