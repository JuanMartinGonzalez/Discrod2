namespace Proyecto_Discrod_2.FE
{
    partial class FormChat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            dataGridViewUsuarios = new DataGridView();
            groupBox2 = new GroupBox();
            flowLayoutPanelChat = new FlowLayoutPanel();
            buttonEnviar = new Button();
            textBoxMensaje = new TextBox();
            btnConfig = new Button();
            btnCerrarSeccion = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewUsuarios);
            groupBox1.Font = new Font("Bahnschrift SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(10, 29);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(316, 542);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Usuarios";
            // 
            // dataGridViewUsuarios
            // 
            dataGridViewUsuarios.BackgroundColor = SystemColors.ControlLight;
            dataGridViewUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsuarios.Location = new Point(23, 33);
            dataGridViewUsuarios.Margin = new Padding(3, 2, 3, 2);
            dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            dataGridViewUsuarios.ReadOnly = true;
            dataGridViewUsuarios.RowHeadersWidth = 51;
            dataGridViewUsuarios.Size = new Size(254, 464);
            dataGridViewUsuarios.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(flowLayoutPanelChat);
            groupBox2.Controls.Add(buttonEnviar);
            groupBox2.Controls.Add(textBoxMensaje);
            groupBox2.Font = new Font("Bahnschrift SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(386, 29);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(660, 542);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mensajes";
            // 
            // flowLayoutPanelChat
            // 
            flowLayoutPanelChat.BackColor = SystemColors.ControlLight;
            flowLayoutPanelChat.Location = new Point(34, 33);
            flowLayoutPanelChat.Name = "flowLayoutPanelChat";
            flowLayoutPanelChat.Size = new Size(576, 327);
            flowLayoutPanelChat.TabIndex = 1;
            // 
            // buttonEnviar
            // 
            buttonEnviar.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEnviar.Location = new Point(535, 464);
            buttonEnviar.Name = "buttonEnviar";
            buttonEnviar.Size = new Size(75, 33);
            buttonEnviar.TabIndex = 2;
            buttonEnviar.Text = "Enviar";
            buttonEnviar.UseVisualStyleBackColor = true;
            // 
            // textBoxMensaje
            // 
            textBoxMensaje.Location = new Point(34, 366);
            textBoxMensaje.Multiline = true;
            textBoxMensaje.Name = "textBoxMensaje";
            textBoxMensaje.Size = new Size(576, 131);
            textBoxMensaje.TabIndex = 2;
            // 
            // btnConfig
            // 
            btnConfig.Font = new Font("Bahnschrift SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfig.Location = new Point(10, 2);
            btnConfig.Margin = new Padding(3, 2, 3, 2);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(51, 23);
            btnConfig.TabIndex = 2;
            btnConfig.Text = "Config";
            btnConfig.UseVisualStyleBackColor = true;
            btnConfig.Click += btnConfig_Click;
            // 
            // btnCerrarSeccion
            // 
            btnCerrarSeccion.Font = new Font("Bahnschrift SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrarSeccion.Location = new Point(939, 2);
            btnCerrarSeccion.Margin = new Padding(3, 2, 3, 2);
            btnCerrarSeccion.Name = "btnCerrarSeccion";
            btnCerrarSeccion.Size = new Size(94, 23);
            btnCerrarSeccion.TabIndex = 3;
            btnCerrarSeccion.Text = "Cerrar seccion";
            btnCerrarSeccion.UseVisualStyleBackColor = true;
            btnCerrarSeccion.Click += btnCerrarSeccion_Click;
            // 
            // FormChat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 582);
            Controls.Add(btnCerrarSeccion);
            Controls.Add(btnConfig);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormChat";
            Text = "FormChat";
            Load += FormChat_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridViewUsuarios;
        private Button buttonEnviar;
        private TextBox textBoxMensaje;
        private FlowLayoutPanel flowLayoutPanelChat;
        private Button btnConfig;
        private Button btnCerrarSeccion;
    }
}