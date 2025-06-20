using System.Drawing.Text;
using System;

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
