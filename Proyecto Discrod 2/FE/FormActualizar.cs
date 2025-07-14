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
       
        private void FormActualizar_Load(object sender, EventArgs e)
        {
            if (UsuarioLogueado.EstaLogueado)
            {
                // Crear una lista con solo el usuario actual
                List<Usuarios> listaUsuario = new List<Usuarios>();
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
    }
}
