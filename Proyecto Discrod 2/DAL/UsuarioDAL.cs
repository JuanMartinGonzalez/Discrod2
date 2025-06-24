using Microsoft.Data.SqlClient;
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
        public int AgregarUsuario(BE.Usuarios usuario)
        {
            int retorna = 0;
            try
            {
                string query = "INSERT INTO Usuarios (Nombre, Password, Color, Imagen) VALUES (@Nombre, @Password, @Color, @Imagen); SELECT SCOPE_IDENTITY();";
                using (SqlCommand command = new SqlCommand(query, FormPadre.ObtenerConexion()))
                {
                    command.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                    command.Parameters.AddWithValue("@Password", usuario.Password);
                    command.Parameters.AddWithValue("@Color", usuario.Color);
                    command.Parameters.AddWithValue("@Imagen", usuario.Imagen);
                    // Ejecutar el comando y obtener el ID del nuevo usuario
                    retorna = Convert.ToInt32(command.ExecuteScalar());
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
}
