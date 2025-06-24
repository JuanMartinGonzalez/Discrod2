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
            groupBox2 = new GroupBox();
            dataGridViewUsuarios = new DataGridView();
            dataGridViewMensajes = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMensajes).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewUsuarios);
            groupBox1.Location = new Point(104, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(477, 379);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Usuarios";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewMensajes);
            groupBox2.Location = new Point(646, 34);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(625, 379);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mensajes";
            // 
            // dataGridViewUsuarios
            // 
            dataGridViewUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsuarios.Location = new Point(15, 39);
            dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            dataGridViewUsuarios.RowHeadersWidth = 51;
            dataGridViewUsuarios.Size = new Size(456, 323);
            dataGridViewUsuarios.TabIndex = 0;
            // 
            // dataGridViewMensajes
            // 
            dataGridViewMensajes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMensajes.Location = new Point(27, 39);
            dataGridViewMensajes.Name = "dataGridViewMensajes";
            dataGridViewMensajes.RowHeadersWidth = 51;
            dataGridViewMensajes.Size = new Size(560, 323);
            dataGridViewMensajes.TabIndex = 1;
            // 
            // FormChat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1393, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormChat";
            Text = "FormChat";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMensajes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridViewUsuarios;
        private DataGridView dataGridViewMensajes;
    }
}