using Gantt;
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
            // Obtener el color del usuario logueado y aplicarlo a todos los GroupBox del formulario
            if (UsuarioLogueado.EstaLogueado)
            {
                // Convertir el int a Color
                Color colorUsuario = Color.FromArgb(UsuarioLogueado.UsuarioActual.Color);
                // Aplicar ese color a todos los GroupBox
                AplicarColorGroupBox(this, colorUsuario);
            }

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

            dataGridViewUsuarios.Columns.Add("UsuarioId", "UsuarioId");
            dataGridViewUsuarios.Columns["UsuarioId"].Visible = false;  
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
                dataGridViewUsuarios.Rows.Add(usuario.UsuarioId, usuario.Nombre, img);
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

        // Meodo que aplica un color a todos los GroupBox que haya dentro de un contenedor (formulario, panel, etc.)
        private void AplicarColorGroupBox(Control parent, Color color)
        {
            // Recorremos todos los controles que estan dentro del contenedor "parent"
            foreach (Control ctrl in parent.Controls)
            {
                // Si el control actual es un GroupBox...
                if (ctrl is GroupBox)
                {
                    //  entonces cambiamos su color de fondo al que recibimos por parametro
                    ctrl.BackColor = color;
                }

                // Si este control tiene a su vez controles "hijos" (otros controles dentro)
                if (ctrl.HasChildren)
                {
                    // Llamamos recursivamente al mismo metodo para revisar los hijos
                    // Así nos aseguramos de que tambien cambien los GroupBox dentro de otros contenedores
                    AplicarColorGroupBox(ctrl, color);
                }
            }
        }
        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxMensaje.Text) && dataGridViewUsuarios.CurrentRow != null)
            {   
                BEUsuario beUsuario = new BEUsuario();
                int fila = dataGridViewUsuarios.CurrentRow.Index;
                int usuarioDestinoId = Convert.ToInt32(dataGridViewUsuarios["UsuarioId", fila].Value);
                DateTime fechaLectura = new DateTime (1900, 1, 1);
                Mensajes nuevoMensaje = new Mensajes(
                    textBoxMensaje.Text,
                    DateTime.Now,
                    fechaLectura,
                    UsuarioLogueado.UsuarioActual.UsuarioId,
                    usuarioDestinoId
                );

                BEMensaje beMensaje = new BEMensaje();
                beMensaje.AgregarMensaje(nuevoMensaje);

                MostrarMensajesChat(usuarioDestinoId);
                textBoxMensaje.Clear();

            }
        }
        private void MostrarMensajesChat(int usuarioDestinoId)
        {
            flowLayoutPanelMensajes.Controls.Clear();

            int usuarioOrigenId = UsuarioLogueado.UsuarioActual.UsuarioId;
            BEMensaje beMensaje = new BEMensaje();
            List<Mensajes> mensajes = beMensaje.ObtenerMensajesEntreUsuarios(usuarioOrigenId, usuarioDestinoId);

            foreach (var mensaje in mensajes)
            {
                bool esMio = mensaje.UsuarioOrigen == usuarioOrigenId;
                var chatBubble = new ChatBubbleControl(mensaje.Texto, esMio);

                var panel = new RoundedPanel();
                panel.Width = flowLayoutPanelMensajes.Width - 30;
                panel.Height = chatBubble.Height + 10;
                panel.Controls.Add(chatBubble);

                flowLayoutPanelMensajes.Controls.Add(panel);
                if (flowLayoutPanelMensajes.Controls.Count > 0)
                {
                    var ultimo = flowLayoutPanelMensajes.Controls[flowLayoutPanelMensajes.Controls.Count - 1];
                    flowLayoutPanelMensajes.ScrollControlIntoView(ultimo);
                }
            }
        }

        private void dataGridViewUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewUsuarios.SelectedRows.Count > 0)
            {
                int fila = dataGridViewUsuarios.CurrentRow.Index;
                int usuarioDestinoId = Convert.ToInt32(dataGridViewUsuarios["UsuarioId", fila].Value);
                MostrarMensajesChat(usuarioDestinoId);
            }
        }
    }
}
