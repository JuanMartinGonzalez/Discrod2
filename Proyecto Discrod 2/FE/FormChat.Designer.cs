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
            textBoxMensaje = new TextBox();
            buttonEnviar = new Button();
            flowLayoutPanelChat = new FlowLayoutPanel();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewUsuarios);
            groupBox1.Location = new Point(99, 11);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(328, 387);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Usuarios";
            // 
            // dataGridViewUsuarios
            // 
            dataGridViewUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsuarios.Location = new Point(0, 44);
            dataGridViewUsuarios.Margin = new Padding(3, 2, 3, 2);
            dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            dataGridViewUsuarios.RowHeadersWidth = 51;
            dataGridViewUsuarios.Size = new Size(291, 358);
            dataGridViewUsuarios.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(flowLayoutPanelChat);
            groupBox2.Location = new Point(462, 11);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(547, 307);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mensajes";
            // 
            // textBoxMensaje
            // 
            textBoxMensaje.Location = new Point(462, 323);
            textBoxMensaje.Multiline = true;
            textBoxMensaje.Name = "textBoxMensaje";
            textBoxMensaje.Size = new Size(490, 89);
            textBoxMensaje.TabIndex = 2;
            // 
            // buttonEnviar
            // 
            buttonEnviar.Location = new Point(866, 365);
            buttonEnviar.Name = "buttonEnviar";
            buttonEnviar.Size = new Size(75, 33);
            buttonEnviar.TabIndex = 2;
            buttonEnviar.Text = "Enviar";
            buttonEnviar.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelChat
            // 
            flowLayoutPanelChat.BackColor = SystemColors.ActiveBorder;
            flowLayoutPanelChat.Location = new Point(0, 21);
            flowLayoutPanelChat.Name = "flowLayoutPanelChat";
            flowLayoutPanelChat.Size = new Size(490, 281);
            flowLayoutPanelChat.TabIndex = 1;
            // 
            // FormChat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 424);
            Controls.Add(buttonEnviar);
            Controls.Add(textBoxMensaje);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
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