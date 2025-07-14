using Proyecto_Discrod_2.BE;
using Proyecto_Discrod_2.DAL;
using Proyecto_Discrod_2.ESTADO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proyecto_Discrod_2.FE
{
    public partial class FormChat : Form
    {
        public FormChat()
        {
            InitializeComponent();
        }
        private void FormChat_Load(object sender, EventArgs e)
        {
            // Creamos una instancia de la clase de lógica de negocio para usuarios
            BEUsuario beUsuario = new BEUsuario();

            // Declaramos la lista donde se guardarán los usuarios obtenidos
            List<Usuarios> lista;

            try
            {
                // Intentamos obtener la lista de usuarios desde la lógica de negocio (puede lanzar una excepción)
                lista = beUsuario.ObtenerUsuarios();
            }
            catch (Exception ex)
            {
                // Si ocurre un error al obtener los usuarios, mostramos un mensaje de error al usuario y salimos del método
                MessageBox.Show("Error al cargar los usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Limpiamos las filas existentes del DataGridView para evitar duplicados
            dataGridViewUsuarios.Rows.Clear();

            // Limpiamos las columnas para definirlas nuevamente
            dataGridViewUsuarios.Columns.Clear();

            // Agregamos una columna para mostrar el nombre de los usuarios
            dataGridViewUsuarios.Columns.Add("Nombre", "Nombre");

            // Creamos una columna especial para mostrar imágenes en la grilla
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();

            // Definimos el encabezado de la columna de imágenes
            imgCol.HeaderText = "Imagen";

            // Configuramos la visualizacion de la imagen para que se ajuste al tamaño de la celda
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;

            // Añadimos la columna de imágenes al DataGridView
            dataGridViewUsuarios.Columns.Add(imgCol);

            // Recorremos la lista de usuarios obtenida para agregar cada uno al DataGridView
            foreach (var usuario in lista)
            {
                Image img = null;

                // Si el usuario tiene una imagen guardada, la convertimos de bytes a un objeto Image
                if (usuario.Imagen != null && usuario.Imagen.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(usuario.Imagen))
                    {
                        img = Image.FromStream(ms);
                    }
                }

                // Añadimos una nueva fila a la grilla con el nombre y la imagen del usuario
                dataGridViewUsuarios.Rows.Add(usuario.Nombre, img);
            }
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            if (!UsuarioLogueado.EstaLogueado)
            {
                MessageBox.Show("Debe iniciar sesión primero.");
                return;
            }

            FormActualizar editar = new FormActualizar(UsuarioLogueado.UsuarioActual);
            editar.ShowDialog();
        }

        private void btnCerrarSeccion_Click(object sender, EventArgs e)
        {
            // 1. Cierra la sesión
            UsuarioLogueado.CerrarSesion();

            // 2. Abre nuevamente el formulario de login
            FormIngreso login = new FormIngreso();
            login.Show();

            // 3. Cierra el FormChat (este formulario)
            this.Close();
        }
    }
}
