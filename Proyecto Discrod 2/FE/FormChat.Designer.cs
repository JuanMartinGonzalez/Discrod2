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
            textBoxMensaje = new TextBox();
            buttonEnviar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewUsuarios);
            groupBox1.Font = new Font("Bahnschrift SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(113, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(336, 568);
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
            dataGridViewUsuarios.Size = new Size(333, 501);
            dataGridViewUsuarios.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(flowLayoutPanelChat);
            groupBox2.Font = new Font("Bahnschrift SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(497, 15);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(640, 437);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mensajes";
            // 
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
            buttonEnviar.Name = "buttonEnviar";
            buttonEnviar.Size = new Size(86, 44);
            buttonEnviar.TabIndex = 2;
            buttonEnviar.Text = "Enviar";
            buttonEnviar.UseVisualStyleBackColor = true;
            // 
            // FormChat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 619);
            Controls.Add(buttonEnviar);
            Controls.Add(textBoxMensaje);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormChat";
            Text = "FormChat";
            Load += FormChat_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridViewUsuarios;
        private Button buttonEnviar;
        private TextBox textBoxMensaje;
        private FlowLayoutPanel flowLayoutPanelChat;
    }
}