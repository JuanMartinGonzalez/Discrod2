using Microsoft.Data.SqlClient;
using Proyecto_Discrod_2.FE;
using System.Data;

namespace Proyecto_Discrod_2
{
    public partial class FormPadre : Form
    {
        public FormPadre()
        {
            InitializeComponent();
        }
        static string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "cadena.txt"); 
        static SqlConnection conexion = new SqlConnection(ObtenerCadena(rutaArchivo));   //hacer conexion a la base de datos

        public static SqlConnection? ObtenerConexion()
        {
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                return conexion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        private void FormPadre_Load(object sender, EventArgs e)
        {
            ObtenerConexion(); 
        }
        #region Botones de la barra de herramientas
        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistro lForm = new FormRegistro();
            lForm.MdiParent = this;
            lForm.Show();
        }

        private void ingresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIngreso lForm1 = new FormIngreso();
            lForm1.MdiParent = this;
            lForm1.Show();
        }

        #endregion

        public static string ObtenerCadena(string rutaArchivo)
        {
            // Método para leer la cadena de conexión desde un archivo
            try
            {
                if (System.IO.File.Exists(rutaArchivo)) // Verifica si el archivo existe
                {
                    return System.IO.File.ReadAllText(rutaArchivo);  // Lee el contenido del archivo
                }
                else
                {
                    MessageBox.Show("El archivo no existe: " + rutaArchivo, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }

    }
}
