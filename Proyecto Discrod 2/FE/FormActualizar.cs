using Proyecto_Discrod_2.BE;

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
    public partial class FormActualizar : Form
    {
        private Usuarios UsuarioActual;
        public FormActualizar(Usuarios usuario)
        {
            InitializeComponent();
            UsuarioActual = usuario;
            // Aquí puedes usar usuarioActual para cargar datos o personalizar el formulario
        }
        private BindingList<Usuarios> listaUsuario; // Declarar como campo del formulario

        private void FormActualizar_Load(object sender, EventArgs e)
        {
            if (UsuarioLogueado.EstaLogueado)
            {
                // Crear una lista con solo el usuario actual
                listaUsuario = new BindingList<Usuarios>();
                listaUsuario.Add(UsuarioLogueado.UsuarioActual);

                // Mostrar en el DataGridView
                dataGridViewActualizar.DataSource = listaUsuario;
                if (dataGridViewActualizar.Columns["Imagen"] is DataGridViewImageColumn colImagen)
                {
                    colImagen.ImageLayout = DataGridViewImageCellLayout.Zoom; // Ajusta la imagen al tamaño de celda
                }
            }
            else
            {
                MessageBox.Show("No hay usuario logueado.");
                this.Close(); // o redireccionar a login
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dataGridViewActualizar.CurrentRow == null) return;

            var row = dataGridViewActualizar.CurrentRow;

            // ID 
            int usuarioId = Convert.ToInt32(row.Cells["UsuarioId"].Value);

            // Traigo el usuario original de la BD
            BEUsuario beUsuario = new BEUsuario();
            Usuarios usuarioOriginal = beUsuario.ObtenerUsuarioPorId(usuarioId);

            // Si hay un valor nuevo en la grilla lo uso, si no, dejo el original
            string nombre = string.IsNullOrEmpty(row.Cells["Nombre"].Value?.ToString())
                ? usuarioOriginal.Nombre
                : row.Cells["Nombre"].Value.ToString();

            string password = string.IsNullOrEmpty(row.Cells["Password"].Value?.ToString())
                ? usuarioOriginal.Password
                : row.Cells["Password"].Value.ToString();

            int color;
            if (row.Cells["Color"].Value == null ||
                !int.TryParse(row.Cells["Color"].Value.ToString(), out color))
            {
                color = usuarioOriginal.Color;
            }

            byte[] imagenBytes = usuarioOriginal.Imagen;
            if (row.Cells["Imagen"].Value is Image img)
            {
                using (var ms = new MemoryStream())
                {
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    imagenBytes = ms.ToArray();
                }
            }

            // Construyo el objeto solo con lo editado, el resto queda igual
            Usuarios usuarioEditado = new Usuarios(usuarioId, nombre, password, color, imagenBytes);

            int resultado = beUsuario.ActualizarUsuario(usuarioEditado);

            if (resultado > 0)
                MessageBox.Show("Usuario actualizado correctamente.");
            else
                MessageBox.Show("No se pudo actualizar el usuario.");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verifica si hay una fila seleccionada en el DataGridView
            if (dataGridViewActualizar.CurrentRow == null)
            {

                // Si no hay ninguna fila seleccionada, muestra un mensaje y corta la ejecución
                MessageBox.Show("Seleccione un usuario para eliminar.");
                return;
            }

            // 1. CurrentRow → obtiene la fila actual (la que el usuario seleccionó).
            // 2. DataBoundItem → devuelve el objeto real que está vinculado a esa fila (en este caso, un objeto de tipo Usuarios).
            // 3. (Usuarios) → convierte ese objeto al tipo Usuarios mediante un "cast".
            // 4. usuarioSeleccionado → almacena ese objeto para poder trabajar con todos sus datos.
            Usuarios usuarioSeleccionado = (Usuarios)dataGridViewActualizar.CurrentRow.DataBoundItem;


            // Pide confirmación al usuario antes de eliminar
            // Muestra un MessageBox con botones "Sí" y "No" y un icono de advertencia
            var confirm = MessageBox.Show(
                "¿Seguro que desea eliminar este usuario?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            // Si el usuario confirma la eliminación
            if (confirm == DialogResult.Yes)
            {
                // Crea un objeto de la capa de negocio (BEUsuario)
                BEUsuario beUsuario = new BEUsuario();

                // Llama al método EliminarUsuario pasando el ID seleccionado
                // El método devuelve cuántas filas fueron afectadas en la base de datos
                int resultado = beUsuario.EliminarUsuario(usuarioSeleccionado.UsuarioId);
                // Si el resultado es mayor a 0 significa que se eliminó bien
                if (resultado > 0)
                {
                    // Eliminar de la BindingList actualiza automáticamente la grilla
                    listaUsuario.Remove(usuarioSeleccionado);
                    MessageBox.Show("Usuario eliminado correctamente.");
                }
                else
                {
                    // Si no se eliminó en la base de datos, muestra mensaje de error
                    MessageBox.Show("No se pudo eliminar el usuario.");
                }
            }
        }
    }
}
