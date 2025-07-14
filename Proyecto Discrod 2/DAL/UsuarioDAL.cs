using Microsoft.Data.SqlClient;
using Proyecto_Discrod_2.BE;
using System.Data;

namespace Proyecto_Discrod_2.DAL
{
    public class UsuarioDAL
    {
        public string Error { get; set; } // Propiedad para almacenar mensajes de error

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
                Error = "Error en la base de datos." + ex;
                return -1; // Retorna -1 en caso de error
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
                return retorna;  // Retorna el número de filas afectadas por la actualización
            }
            catch (Exception ex)
            {
                // Si ocurre un error, captura la excepción y asigna un mensaje de error
                Error = "Error en la base de datos.";
                throw ex;//error; 
            }
        }
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
                return retorna; // Retorna el número de filas afectadas por la eliminación
            }
            catch (Exception ex)
            {
                Error = "Error en la base de datos.";
                throw ex;//error; 
            }
        }

        //metodo para traer los usuarios guardados en BD
        public static List<Usuarios> ObtenerUsuarios() 
        {
            // Lista donde vamos a guardar los usuarios de BD
            List<Usuarios> LisUsu = new List<Usuarios>();

            // Consulta para traer nombre e imagen
            string query = "SELECT UsuarioId, Nombre, Password, Color, Imagen FROM Usuarios";
            try 
            {
                // Creamos un comando para ejecutar la consulta
                SqlCommand cmd = new SqlCommand(query, FormPadre.ObtenerConexion());

                // Creamos un DataAdapter para llenar un DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                // DataTable para guardar temporalmente los datos
                DataTable tabla = new DataTable();

                // Llenamos la tabla con los datos de la consulta
                adapter.Fill(tabla);

                // Recorremos las filas del DataTable 
                foreach (DataRow fila in tabla.Rows)
                {
                    // Obtenemos los datos de cada fila
                    int UsuarioId = Convert.ToInt32(fila["UsuarioId"]);
                    string nombre = fila["Nombre"].ToString();
                    string password = fila["Password"].ToString();
                    int color = Convert.ToInt32(fila["Color"]);
                    byte[] imagen = fila["Imagen"] as byte[];
                        // Creamos un objeto Usuario con los datos
                    Usuarios usuario = new Usuarios(UsuarioId, nombre, password, color, imagen);
                    // Lo agregamos a la lista
                    LisUsu.Add(usuario);
                }
            }
            catch (Exception ex)
            {
                // lanzamos una excepcion con el mensaje
                throw new Exception("Error al obtener usuarios: " + ex.Message);
            }
            // Devolvemos la lista de usuarios
            return LisUsu;
        }

        public Usuarios ObtenerUsuarioLogueado(string nombre, string password)
        {
            string query = "SELECT UsuarioId, Nombre, Password, Color, Imagen FROM Usuarios WHERE Nombre = @Nombre AND Password = @Password";

            using (SqlCommand cmd = new SqlCommand(query, FormPadre.ObtenerConexion()))
            {
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Password", password);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Usuarios(
                            Convert.ToInt32(reader["UsuarioId"]),
                            reader["Nombre"].ToString(),
                            reader["Password"].ToString(),
                            Convert.ToInt32(reader["Color"]),
                            reader["Imagen"] as byte[]
                        );
                    }
                }
            }

            return null;
        }
        public bool ExisteUsuario(string nombre)
        {
            // Verificar si el usuario ya existe
            try
            {
                string query = "SELECT COUNT(*) FROM Usuarios WHERE Nombre = @Nombre";
                using (SqlCommand command = new SqlCommand(query, FormPadre.ObtenerConexion()))
                {
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0; // Retorna true si el usuario ya está registrado
                }
            }
            catch (Exception ex)
            {
                Error = "Error en la base de datos." + ex;
                return false; // Retorna false en caso de error
            }
        }
        public bool PasswordCorrecta(string nombre, string password)
        {
            //verifica si la contraseña es correcta para el usuario dado
            try
            {
                string query = "SELECT Password FROM Usuarios WHERE Nombre = @Nombre";
                using (SqlCommand command = new SqlCommand(query, FormPadre.ObtenerConexion()))
                {
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    var result = command.ExecuteScalar();
                    if (result == null)
                        return false;

<<<<<<< Updated upstream
                    string? passwordEnBD = result as string; // Casteo seguro para evitar posibles nulls
                    //Compara la contraseña ingresada con la almacenada en la base de datos
                    return passwordEnBD == password;     // true si son iguales, false si no lo son
                }
            }
            catch (Exception ex)
            {
                Error = "Error al verificar la contraseña: " + ex.Message;
                return false;
            }
        }
=======
       

>>>>>>> Stashed changes
    }
}

