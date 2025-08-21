using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.IO;

namespace Discrod2_WebApi.Data
{
    public static class ConexionApi
    {
        private static SqlConnection? conexion;
        private static readonly string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "cadena.txt");

        public static SqlConnection? ObtenerConexion()
        {
            try
            {
                if (conexion == null)
                    conexion = new SqlConnection(ObtenerCadena());

                if (conexion.State != ConnectionState.Open)
                    conexion.Open();

                return conexion;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
                return null;
            }
        }

        private static string ObtenerCadena()
        {
            try
            {
                if (File.Exists(rutaArchivo))
                    return File.ReadAllText(rutaArchivo);
                else
                {
                    Console.WriteLine("El archivo de cadena de conexión no existe.");
                    return string.Empty;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al leer la cadena de conexión: " + ex.Message);
                return string.Empty;
            }
        }
    }
}
