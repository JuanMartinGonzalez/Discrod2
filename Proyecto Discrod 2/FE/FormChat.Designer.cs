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
            buttonEnviar = new Button();
            flowLayoutPanelChat = new FlowLayoutPanel();
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
<<<<<<< Updated upstream
            groupBox1.Location = new Point(113, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(336, 568);
=======
            groupBox1.Location = new Point(31, 39);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(290, 426);
>>>>>>> Stashed changes
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Usuarios";
            // 
            // dataGridViewUsuarios
            // 
            dataGridViewUsuarios.BackgroundColor = SystemColors.ControlLight;
            dataGridViewUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsuarios.Location = new Point(0, 59);
            dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            dataGridViewUsuarios.ReadOnly = true;
            dataGridViewUsuarios.RowHeadersWidth = 51;
<<<<<<< Updated upstream
            dataGridViewUsuarios.Size = new Size(333, 501);
=======
            dataGridViewUsuarios.Size = new Size(290, 376);
>>>>>>> Stashed changes
            dataGridViewUsuarios.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonEnviar);
            groupBox2.Controls.Add(flowLayoutPanelChat);
            groupBox2.Controls.Add(textBoxMensaje);
            groupBox2.Font = new Font("Bahnschrift SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
<<<<<<< Updated upstream
            groupBox2.Location = new Point(497, 15);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(640, 437);
=======
            groupBox2.Location = new Point(338, 39);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(460, 414);
>>>>>>> Stashed changes
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mensajes";
            // 
<<<<<<< Updated upstream
            // flowLayoutPanelChat
            // 
            flowLayoutPanelChat.BackColor = SystemColors.ControlLight;
            flowLayoutPanelChat.Location = new Point(45, 63);
            flowLayoutPanelChat.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanelChat.Name = "flowLayoutPanelChat";
            flowLayoutPanelChat.Size = new Size(560, 375);
            flowLayoutPanelChat.TabIndex = 1;
            // 
            // textBoxMensaje
            // 
            textBoxMensaje.Location = new Point(504, 456);
            textBoxMensaje.Margin = new Padding(3, 4, 3, 4);
            textBoxMensaje.Multiline = true;
            textBoxMensaje.Name = "textBoxMensaje";
            textBoxMensaje.Size = new Size(559, 117);
            textBoxMensaje.TabIndex = 2;
            // 
            // buttonEnviar
            // 
            buttonEnviar.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEnviar.Location = new Point(959, 515);
            buttonEnviar.Margin = new Padding(3, 4, 3, 4);
=======
            // buttonEnviar
            // 
            buttonEnviar.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEnviar.Location = new Point(358, 382);
>>>>>>> Stashed changes
            buttonEnviar.Name = "buttonEnviar";
            buttonEnviar.Size = new Size(86, 44);
            buttonEnviar.TabIndex = 2;
            buttonEnviar.Text = "Enviar";
            buttonEnviar.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelChat
            // 
            flowLayoutPanelChat.BackColor = SystemColors.ControlLight;
            flowLayoutPanelChat.Location = new Point(39, 44);
            flowLayoutPanelChat.Name = "flowLayoutPanelChat";
            flowLayoutPanelChat.Size = new Size(394, 281);
            flowLayoutPanelChat.TabIndex = 1;
            // 
            // textBoxMensaje
            // 
            textBoxMensaje.Location = new Point(39, 331);
            textBoxMensaje.Multiline = true;
            textBoxMensaje.Name = "textBoxMensaje";
            textBoxMensaje.Size = new Size(396, 89);
            textBoxMensaje.TabIndex = 2;
            // 
            // btnConfig
            // 
            btnConfig.Font = new Font("Bahnschrift SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfig.Location = new Point(12, 3);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(58, 31);
            btnConfig.TabIndex = 2;
            btnConfig.Text = "Config";
            btnConfig.UseVisualStyleBackColor = true;
            btnConfig.Click += btnConfig_Click;
            // 
            // btnCerrarSeccion
            // 
            btnCerrarSeccion.Font = new Font("Bahnschrift SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrarSeccion.Location = new Point(714, 3);
            btnCerrarSeccion.Name = "btnCerrarSeccion";
            btnCerrarSeccion.Size = new Size(107, 31);
            btnCerrarSeccion.TabIndex = 3;
            btnCerrarSeccion.Text = "Cerrar seccion";
            btnCerrarSeccion.UseVisualStyleBackColor = true;
            btnCerrarSeccion.Click += btnCerrarSeccion_Click;
            // 
            // FormChat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
<<<<<<< Updated upstream
            ClientSize = new Size(1370, 619);
            Controls.Add(buttonEnviar);
            Controls.Add(textBoxMensaje);
=======
            ClientSize = new Size(833, 466);
            Controls.Add(btnCerrarSeccion);
            Controls.Add(btnConfig);
>>>>>>> Stashed changes
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
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