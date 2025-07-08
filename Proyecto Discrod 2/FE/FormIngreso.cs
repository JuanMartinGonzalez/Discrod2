using Proyecto_Discrod_2.BE;
using Proyecto_Discrod_2.DAL;
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
            if (string.IsNullOrWhiteSpace(textBoxUsuarioLogin.Text.Trim()) || string.IsNullOrWhiteSpace(textBoxPasswordLogin.Text.Trim()))
            {
                MessageBox.Show("Por favor, complete ambos campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            BEUsuario beUsuario = new BEUsuario();

            // Verificar si el usuario existe con ese nombre y contraseña
            bool existe = beUsuario.ExisteUusuario(textBoxUsuarioLogin.Text.Trim(), textBoxPasswordLogin.Text.Trim());

            if (existe)
            {
                MessageBox.Show("Ingreso exitoso", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FormChat formChat = new FormChat();
                this.Close();
                formChat.ShowDialog();

            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
