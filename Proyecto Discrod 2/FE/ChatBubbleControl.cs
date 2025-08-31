using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Discrod_2.FE;

namespace Gantt
{
    public partial class ChatBubbleControl : UserControl
    {
        public ChatBubbleControl()
        {
            InitializeComponent();
        }

        public ChatBubbleControl(string texto, bool esPropio)
        {
            InitializeComponent();
            this.BackColor = Color.Transparent;
            this.AutoSize = true;

            var contenedor = new RoundedPanel
            {
                BackColor = esPropio ? Color.LightGreen : Color.LightGray,
                Padding = new Padding(6, 4, 6, 4), // Espacio interno más pequeño
                MaximumSize = new Size(300, 0),
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Margin = new Padding(0),
                BorderRadius = 8,
            };

            var lblTexto = new Label
            {
                Text = texto,
                AutoSize = true,
                Font = new Font("Segoe UI", 10),
                MaximumSize = new Size(280, 0)
            };

            contenedor.Controls.Add(lblTexto);
            this.Controls.Add(contenedor);

            // Elimina el padding lateral exagerado
            this.Padding = new Padding(0);
        }
    }
}
