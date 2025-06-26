namespace Proyecto_Discrod_2.FE
{
    partial class FormRegistro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnRegistrarUsuario = new Button();
            maskedTextBoxUsuario = new MaskedTextBox();
            txtNombre = new TextBox();
            pictureBox1 = new PictureBox();
            colorDialogColor = new ColorDialog();
            btnColor = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            maskedTextBoxPassword = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 29);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "Usuario ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 79);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 124);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 2;
            label3.Text = "Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 177);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 3;
            label4.Text = "Color";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 237);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 4;
            label5.Text = "Imagen";
            // 
            // btnRegistrarUsuario
            // 
            btnRegistrarUsuario.Location = new Point(443, 31);
            btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            btnRegistrarUsuario.Size = new Size(150, 75);
            btnRegistrarUsuario.TabIndex = 5;
            btnRegistrarUsuario.Text = "Registrar";
            btnRegistrarUsuario.UseVisualStyleBackColor = true;
            btnRegistrarUsuario.Click += btnRegistrarUsuario_Click;
            // 
            // maskedTextBoxUsuario
            // 
            maskedTextBoxUsuario.Location = new Point(175, 33);
            maskedTextBoxUsuario.Mask = "99999";
            maskedTextBoxUsuario.Name = "maskedTextBoxUsuario";
            maskedTextBoxUsuario.Size = new Size(125, 27);
            maskedTextBoxUsuario.TabIndex = 6;
            maskedTextBoxUsuario.ValidatingType = typeof(int);
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(175, 79);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Grafico_matriz_foda_sencillo_formal_neutro_azul_gris;
            pictureBox1.Location = new Point(114, 237);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(338, 119);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // btnColor
            // 
            btnColor.Location = new Point(406, 168);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(178, 29);
            btnColor.TabIndex = 10;
            btnColor.Text = "Seleccionar Color";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // maskedTextBoxPassword
            // 
            maskedTextBoxPassword.Location = new Point(175, 124);
            maskedTextBoxPassword.Mask = "99999";
            maskedTextBoxPassword.Name = "maskedTextBoxPassword";
            maskedTextBoxPassword.Size = new Size(125, 27);
            maskedTextBoxPassword.TabIndex = 11;
            // 
            // FormRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 462);
            Controls.Add(maskedTextBoxPassword);
            Controls.Add(btnColor);
            Controls.Add(pictureBox1);
            Controls.Add(txtNombre);
            Controls.Add(maskedTextBoxUsuario);
            Controls.Add(btnRegistrarUsuario);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormRegistro";
            Text = "Registro de Usuarios";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnRegistrarUsuario;
        private MaskedTextBox maskedTextBoxUsuario;
        private TextBox txtNombre;
        private PictureBox pictureBox1;
        private ColorDialog colorDialogColor;
        private Button btnColor;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private MaskedTextBox maskedTextBoxPassword;
    }
}
