using System.Drawing.Text;
using System;
using Proyecto_Discrod_2.BE;
using Proyecto_Discrod_2.Properties;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto_Discrod_2.FE
{
    public partial class FormRegistro : Form
    {
        public FormRegistro()
        {
            InitializeComponent();
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            BEUsuario beusuario = new BEUsuario();
            try
            {
                Usuarios usuario = new Usuarios(0, string.Empty, string.Empty, 0, null);
                usuario.Nombre = txtNombre.Text.Trim();
                usuario.Password = maskedTextBoxPassword.Text;
                usuario.Color = btnColor.BackColor.ToArgb();
                usuario.Imagen = Image.FromFile("C:\\Imagenes\\imagen1.jpg");

                beusuario.VerificarUsuario(usuario);
                beusuario.AgregarUsuario(usuario);
            }
            catch (Exception ex)
            {
                MessageBox.Show(beusuario.error + ", " + ex);
            }
        }
     
        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialogColor.ShowDialog() == DialogResult.OK)
            {
                btnColor.BackColor = colorDialogColor.Color;
            }
        }
    }
}
