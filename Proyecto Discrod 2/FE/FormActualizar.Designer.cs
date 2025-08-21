namespace Proyecto_Discrod_2.FE
{
    partial class FormActualizar
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
            dataGridViewActualizar = new DataGridView();
            btnActualizar = new Button();
            btnEliminar = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewActualizar).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewActualizar
            // 
            dataGridViewActualizar.BackgroundColor = SystemColors.ControlLight;
            dataGridViewActualizar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewActualizar.Location = new Point(28, 58);
            dataGridViewActualizar.Margin = new Padding(3, 2, 3, 2);
            dataGridViewActualizar.Name = "dataGridViewActualizar";
            dataGridViewActualizar.RowHeadersWidth = 51;
            dataGridViewActualizar.Size = new Size(543, 68);
            dataGridViewActualizar.TabIndex = 0;
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(162, 172);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(135, 49);
            btnActualizar.TabIndex = 2;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(425, 172);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(135, 49);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 21);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 4;
            label1.Text = "Usuario";
            // 
            // FormActualizar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 248);
            Controls.Add(dataGridViewActualizar);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Name = "FormActualizar";
            Text = "FormActualizar";
            Load += FormActualizar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewActualizar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridViewActualizar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Label label1;
    }
}