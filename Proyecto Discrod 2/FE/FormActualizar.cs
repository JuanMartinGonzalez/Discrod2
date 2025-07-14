using Proyecto_Discrod_2.BE;

namespace Proyecto_Discrod_2.FE
{
    public partial class FormActualizar : Form
    {
        public FormActualizar()
        {
            InitializeComponent();
        }

        private void FormActualizar_Load(object sender, EventArgs e)
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
            dataGridViewActualizar.Rows.Clear();

            // Limpiamos las columnas para definirlas nuevamente
            dataGridViewActualizar.Columns.Clear();

            dataGridViewActualizar.Columns.Add("UsuarioId", "ID");
            dataGridViewActualizar.Columns.Add("Nombre", "Nombre");
            dataGridViewActualizar.Columns.Add("Password", "Password");
            dataGridViewActualizar.Columns.Add("Color", "Color");

            // Creamos una columna especial para mostrar imágenes en la grilla
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol.HeaderText = "Imagen";
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;

            // Añadimos la columna de imágenes al DataGridView
            dataGridViewActualizar.Columns.Add(imgCol);

            // Recorremos la lista de usuarios obtenida para agregar cada uno al DataGridView
            foreach (var usuario in lista)
            {
                Image img = null;

                if (usuario.Imagen != null && usuario.Imagen.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(usuario.Imagen))
                    {
                        img = Image.FromStream(ms);
                    }
                }

                // Añadimos una nueva fila a la grilla con el nombre y la imagen del usuario
                dataGridViewActualizar.Rows.Add(usuario.UsuarioId,
                    usuario.Nombre ?? string.Empty,
                    usuario.Password ?? string.Empty,
                    usuario.Color,
                    img);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Obtiene el usuario seleccionado en el DataGridView
            var usuario = ObtenerUsuarioSeleccionado();
            if (usuario == null)
            {
                // Si no hay usuario seleccionado, muestra un mensaje y sale del método
                MessageBox.Show("Seleccione un usuario para eliminar.");
                return;
            }
            // Pide confirmación antes de eliminar
            if (MessageBox.Show("¿Está seguro que desea eliminar este usuario?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
               /* BEUsuario beUsuario = new BEUsuario();
                // Llama al método para eliminar el usuario (debes implementarlo en BEUsuario)
                beUsuario.EliminarUsuario(usuario.UsuarioId);
                // Recarga la grilla para reflejar los cambios
                FormActualizar_Load(null, null);*/
            }
        }

        // MÉTODO PARA OBTENER EL USUARIO SELECCIONADO
        private Usuarios ObtenerUsuarioSeleccionado()
        {
            if (dataGridViewActualizar.CurrentRow == null) return null;

            // Obtener la imagen de la celda
            var imgCell = dataGridViewActualizar.CurrentRow.Cells["Imagen"].Value as Image;
            byte[] imagenBytes = null;
            if (imgCell != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    imgCell.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    imagenBytes = ms.ToArray();
                }
            }

            return new Usuarios(
                Convert.ToInt32(dataGridViewActualizar.CurrentRow.Cells["UsuarioId"].Value),
                dataGridViewActualizar.CurrentRow.Cells["Nombre"].Value.ToString(),
                dataGridViewActualizar.CurrentRow.Cells["Password"].Value.ToString(),
                Convert.ToInt32(dataGridViewActualizar.CurrentRow.Cells["Color"].Value),
                imagenBytes
            );
        }
    }
}
