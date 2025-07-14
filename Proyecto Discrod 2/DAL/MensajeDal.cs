using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Discrod_2.BE;
using Microsoft.Data.SqlClient;

namespace Proyecto_Discrod_2.DAL
{
    public class MensajeDal
    {
        public string Error { get; set; }

        public int AgregarMensaje(Mensajes mensaje)
        {
            try
            {
                string query = @"INSERT INTO Mensajes (Texto, FechaEnvio, FechaLectura, UsuarioOrigenId, UsuarioDestinoId)
                                 VALUES (@Texto, @FechaEnvio, @FechaLectura, @OrigenId, @DestinoId);
                                 SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, FormPadre.ObtenerConexion()))
                {
                    //añado los parámetros necesarios para la consulta 
                    command.Parameters.AddWithValue("@Texto", mensaje.Texto);
                    command.Parameters.AddWithValue("@FechaEnvio", mensaje.FechaEnvio);
                    command.Parameters.AddWithValue("@FechaLectura", mensaje.FechaLectura);
                    command.Parameters.AddWithValue("@OrigenId", mensaje.UsuarioOrigen.UsuarioId);
                    command.Parameters.AddWithValue("@DestinoId", mensaje.UsuarioDestino.UsuarioId);

                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                Error = "Error al agregar mensaje: " + ex.Message;
                return -1;
            }
        }
        public bool ExisteMensaje(int mensajeId)
        {
            // Verifica si el mensaje existe en la base de datos por su ID
            try
            {
                string query = "SELECT COUNT(*) FROM Mensajes WHERE MensajeId = @MensajeId";
                using (SqlCommand command = new SqlCommand(query, FormPadre.ObtenerConexion()))
                {
                    command.Parameters.AddWithValue("@MensajeId", mensajeId);
                    int cantidad = Convert.ToInt32(command.ExecuteScalar());
                    return cantidad > 0; // Retorna true si el mensaje existe
                }
            }
            catch (Exception ex)
            {
                Error = "Error al verificar existencia del mensaje: " + ex.Message;
                return false;
            }
        }
        public bool ModificarMensaje(int mensajeId, Mensajes mensaje)
        {
            try
            {
                string query = @"UPDATE Mensajes 
                         SET Texto = @Texto, 
                             FechaEnvio = @FechaEnvio, 
                             FechaLectura = @FechaLectura, 
                             UsuarioOrigenId = @OrigenId, 
                             UsuarioDestinoId = @DestinoId 
                         WHERE MensajeId = @MensajeId";

                using (SqlCommand command = new SqlCommand(query, FormPadre.ObtenerConexion()))
                {
                    command.Parameters.AddWithValue("@Texto", mensaje.Texto);
                    command.Parameters.AddWithValue("@FechaEnvio", mensaje.FechaEnvio);
                    command.Parameters.AddWithValue("@FechaLectura", mensaje.FechaLectura);
                    command.Parameters.AddWithValue("@OrigenId", mensaje.UsuarioOrigen.UsuarioId);
                    command.Parameters.AddWithValue("@DestinoId", mensaje.UsuarioDestino.UsuarioId);
                    command.Parameters.AddWithValue("@MensajeId", mensajeId);

                    int filasAfectadas = command.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
            catch (Exception ex)
            {
                Error = "Error al modificar el mensaje: " + ex.Message;
                return false;
            }
        }
        public int EliminarMnesaje(int mensajeId)
        {
            // Método para eliminar un mensaje por su ID
            int retorna = 0;
            try
            {
                string query = "DELETE FROM Mensajes WHERE MensajeId = @MensajeId";
                using (SqlCommand command = new SqlCommand(query, FormPadre.ObtenerConexion()))
                {
                    command.Parameters.AddWithValue("@MensajeId", mensajeId);
                    retorna = command.ExecuteNonQuery();
                }
                return retorna;
            }
            catch (Exception ex)
            {
                Error = "Error en la base de datos: " + ex.Message;
                throw ex;
            }
        }
        public bool MarcarMensajeComoRecibido(int mensajeId)
        {
            try
            {
                // simulo que el mensaje fue "recibido", por ejemplo, al obtenerlo desde base de datos
                string query = "SELECT * FROM Mensajes WHERE MensajeId = @MensajeId";

                using (SqlCommand command = new SqlCommand(query, FormPadre.ObtenerConexion()))
                {
                    command.Parameters.AddWithValue("@MensajeId", mensajeId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // lo marca como recibido en la base de datos 
                            string updateQuery = "UPDATE Mensajes SET Recibido = 1 WHERE MensajeId = @MensajeId";
                            using (SqlCommand updateCommand = new SqlCommand(updateQuery, FormPadre.ObtenerConexion()))
                            {
                                updateCommand.Parameters.AddWithValue("@MensajeId", mensajeId);
                                updateCommand.ExecuteNonQuery();
                                // Actualiza la fecha de lectura al momento de marcarlo como recibido
                            }

                            return true;
                        }
                        else
                        {
                            return false; // No se encontró el mensaje
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Error = "Error al marcar como recibido: " + ex.Message;
                return false;
            }
        }


    }
}
