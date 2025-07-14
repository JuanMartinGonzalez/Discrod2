using Proyecto_Discrod_2.BE;
<<<<<<< Updated upstream
=======
using Proyecto_Discrod_2.DAL;
using Proyecto_Discrod_2.ESTADO;
using Proyecto_Discrod_2.VAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
>>>>>>> Stashed changes

namespace Proyecto_Discrod_2.FE
{
    public partial class FormIngreso : Form
    {
        public FormIngreso()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtiene los valores de los textBox y limpiarlos de espacios
                string usuario = textBoxUsuarioLogin.Text.Trim();
                string pasword = textBoxPasswordLogin.Text.Trim();

                // Validar que los campos no estén vacíos
                if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(pasword))
                {
                    MessageBox.Show("Por favor, complete ambos campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                BEUsuario beUsuario = new BEUsuario();

                // Verificar si el usuario existe con ese nombre y contraseña
                int resultado = beUsuario.VerificarLoginUsuario(usuario, pasword);
                if (resultado == 1)
                {
                    MessageBox.Show("Ingreso exitoso", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FormChat formChat = new FormChat();
                    this.Close();
                    formChat.ShowDialog();
                }
                else
                {
                    MessageBox.Show(beUsuario.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
<<<<<<< Updated upstream
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
=======
                MessageBox.Show("Ingreso exitoso", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // obtenemos el usuario completo para guardarlo en la sesión
                Usuarios usuarioCompleto = beUsuario.ObtenerUsuariologueado(textBoxUsuarioLogin.Text.Trim(), textBoxPasswordLogin.Text.Trim());

                // Guardamos el usuario completo en la clase estática para sesión
                UsuarioLogueado.IniciarSesion(usuarioCompleto);

                FormChat formChat = new FormChat();
                this.Close();
                formChat.ShowDialog();

            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

>>>>>>> Stashed changes
        }
    }
}
