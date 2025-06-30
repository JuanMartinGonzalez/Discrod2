using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Discrod_2.FE;

namespace Proyecto_Discrod_2
{
    public partial class FormPadre : Form
    {
        public FormPadre()
        {
            InitializeComponent();
        }

        static string cadena = "Server=SAM\\SQLEXPRESS;Database=Discrod 2;Trusted_Connection=True;TrustServerCertificate=True";
        static SqlConnection conexion = new SqlConnection(cadena);
        private void btnRegistro_Click(object sender, EventArgs e)
        {
            FormRegistro lForm = new FormRegistro();
            lForm.MdiParent = this;
            lForm.Show();
        }
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

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistro lForm = new FormRegistro();
            lForm.MdiParent = this;
            lForm.Show();
        }
    }
}
