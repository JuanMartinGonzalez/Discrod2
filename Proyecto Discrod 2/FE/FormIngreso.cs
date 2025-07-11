using Proyecto_Discrod_2.BE;

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
                // Validar que los campos de usuario y contraseña no estén vacíos
                if (string.IsNullOrWhiteSpace(textBoxUsuarioLogin.Text.Trim()) || string.IsNullOrWhiteSpace(textBoxPasswordLogin.Text.Trim()))
                {
                    MessageBox.Show("Por favor, complete ambos campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                BEUsuario beUsuario = new BEUsuario();

                // Verificar si el usuario existe con ese nombre y contraseña
                int resultado = beUsuario.VerificarLoginUsuario(textBoxUsuarioLogin.Text.Trim(), textBoxPasswordLogin.Text.Trim());
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
                // Manejo de excepciones generales
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
