using System.Drawing.Text;
using System;
using Proyecto_Discrod_2.BE;
using Proyecto_Discrod_2.Properties;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing.Imaging;
using System.CodeDom;

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
            this.Close();
            /*BEUsuario beUsuario = new BEUsuario();

            try
            {
                // Crear instancia del usuario con los datos del formulario
                Usuarios usuario = new Usuarios(0, string.Empty, string.Empty, 0, null)
                {
                    Nombre = txtNombre.Text.Trim(),
                    Password = ObtenerPassword(),
                    Color = btnColor.BackColor.ToArgb(),
                    Imagen = ConvertirImagen()
                };

                // Validar el usuario
                var errores = beUsuario.ValidarUsuario(usuario); // Cambiado para usar la instancia 'beUsuario'

                if (errores.Any())
                {
                    MessageBox.Show(string.Join("\n", errores), "Errores de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Parar el proceso si hay errores
                }

                // Intentar agregar el usuario a la base de datos
                int resultadoId = beUsuario.AgregarUsuario(usuario);

                if (resultadoId == -1)
                {
                    MessageBox.Show(beUsuario.Error ?? "Error al registrar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Parar el proceso si hubo error en BD
                }

                // Asignar el ID generado al usuario
                usuario.UsuarioId = resultadoId;

                // Confirmar éxito
                DialogResult resultado = MessageBox.Show("Usuario registrado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (resultado == DialogResult.OK)
                {
                    this.Close(); // Cerrar el formulario si el usuario acepta
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado:\n" + ex.Message, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
        }




        #region Obtener prop
        private byte[] ConvertirImagen()
        {
            using (MemoryStream ms = new MemoryStream())  //recervar espacio de memoria
            using (Bitmap bmp = new Bitmap(pictureBoxImagen.Image))   //variable que guarda la imagen seleccionada
            {
                bmp.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private string ObtenerPassword()
        {
            if (txtPassword.Text != txtConfirmar.Text)
            {
                throw new ArgumentException("La contraseña no coincide");
            }
             return txtConfirmar.Text.Trim();
        }
        #endregion

        private void btnBuscarImg_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog file = new OpenFileDialog();
                file.Filter = "archivos de imagen (*jpg; *png;) | *jpg; *png;";   //filtra por solo formatos png y jpg
                if (file.ShowDialog() == DialogResult.OK)       //abre explorador de archivos
                {
                    pictureBoxImagen.Image = Image.FromFile(file.FileName);      //mostramos la imagen seleccionada
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error al buscar archivo");
            }
        }
        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialogColor.ShowDialog() == DialogResult.OK)
            {
                btnColor.BackColor = colorDialogColor.Color;
            }
        }

        #region Estilizar campos
        private void txtNombre_Enter(object sender, EventArgs e)
        {
            OcultarTexto(txtNombre);
        }
        private void txtNombre_Leave(object sender, EventArgs e)
        {
            OcultarTexto(txtNombre);
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            OcultarTexto(txtPassword);
        }
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            OcultarTexto(txtPassword);
        }
        private void txtConfirmar_Enter(object sender, EventArgs e)
        {
            OcultarTexto(txtConfirmar);
        }

        private void txtConfirmar_Leave(object sender, EventArgs e)
        {
            OcultarTexto(txtConfirmar);
        }


        private void OcultarTexto(TextBox txt)
        {
            if (txt.Name == "txtNombre")
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

            if (txt.Name == "txtPassword")
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

            if (txt.Name == "txtConfirmar")
            {
                if (txt.Focused && txt.PlaceholderText == "C O N F I R M A R  C O N T R A S E Ñ A")
                {
                    txt.PlaceholderText = string.Empty;
                    txt.UseSystemPasswordChar = true;
                }
                if (!txt.Focused && txt.PlaceholderText == string.Empty)
                {
                    txt.UseSystemPasswordChar = false;
                    txt.PlaceholderText = "C O N F I R M A R  C O N T R A S E Ñ A";
                }
                if ((!string.IsNullOrEmpty(txt.Text) && (txt.Text != "C O N F I R M A R  C O N T R A S E Ñ A")) && (!txt.Focused))
                {
                    txt.UseSystemPasswordChar = true; // Mantener el uso de caracteres de contraseña si ya se ingresó texto
                }
            }

        }
        #endregion Estilizar campos

    }
}
