using Proyecto_Discrod_2.BE;
using Proyecto_Discrod_2.ESTADO;


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
                    MessageBox.Show(beUsuario.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabelRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegistro registro = new FormRegistro();
            registro.ShowDialog();  // La ventana bloquea hasta cerrarse.
        }


        #region Estilo txt

        private void textBoxUsuarioLogin_Enter(object sender, EventArgs e)
        {
            OcultarTexto(textBoxUsuarioLogin);
        }

        private void textBoxUsuarioLogin_Leave(object sender, EventArgs e)
        {
            OcultarTexto(textBoxUsuarioLogin);
        }

        private void textBoxPasswordLogin_Enter(object sender, EventArgs e)
        {
            OcultarTexto(textBoxPasswordLogin);
        }

        private void textBoxPasswordLogin_Leave(object sender, EventArgs e)
        {
            OcultarTexto(textBoxPasswordLogin);
        }

        private void OcultarTexto (TextBox txt)
        {
            if (txt.Name == "textBoxUsuarioLogin")
            {
                if (txt.PlaceholderText == "U S U A R I O")
                {
                    txt.PlaceholderText = string.Empty;
                }
                else if (txt.Text == string.Empty)
                {
                    txt.PlaceholderText = "U S U A R I O";
                }
            }
            if (txt.Name == "textBoxPasswordLogin")
            {
                if (txt.Focused && txt.PlaceholderText == "C O N T R A S E Ñ A")
                {
                    txt.PlaceholderText = string.Empty;
                    txt.UseSystemPasswordChar = true;
                }
                if (!txt.Focused && txt.PlaceholderText == string.Empty)
                {
                    txt.UseSystemPasswordChar = false;
                    txt.PlaceholderText = "C O N T R A S E Ñ A";
                }
                if ((!string.IsNullOrEmpty(txt.Text) && (txt.Text != "C O N T R A S E Ñ A")) && (!txt.Focused))
                {
                    txt.UseSystemPasswordChar = true; // Mantener el uso de caracteres de contraseña si ya se ingresó texto
                }

            }

        }
        #endregion

    }
}
