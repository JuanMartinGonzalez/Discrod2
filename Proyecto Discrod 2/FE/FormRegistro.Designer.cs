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
            txtNombre = new TextBox();
            pictureBoxImagen = new PictureBox();
            colorDialogColor = new ColorDialog();
            btnColor = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            btnBuscarImg = new Button();
            btnRegistrarUsuario = new Button();
            label4 = new Label();
            txtPassword = new TextBox();
            txtConfirmar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(121, 56);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.MaxLength = 25;
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "U S U A R I O";
            txtNombre.Size = new Size(237, 27);
            txtNombre.TabIndex = 7;
            txtNombre.Enter += txtNombre_Enter;
            txtNombre.Leave += txtNombre_Leave;
            // 
            // pictureBoxImagen
            // 
            pictureBoxImagen.Image = Properties.Resources.user;
            pictureBoxImagen.Location = new Point(234, 212);
            pictureBoxImagen.Margin = new Padding(3, 2, 3, 2);
            pictureBoxImagen.Name = "pictureBoxImagen";
            pictureBoxImagen.Size = new Size(191, 133);
            pictureBoxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImagen.TabIndex = 9;
            pictureBoxImagen.TabStop = false;
            // 
            // btnColor
            // 
            btnColor.Font = new Font("Bahnschrift Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnColor.Location = new Point(106, 169);
            btnColor.Margin = new Padding(0);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(264, 32);
            btnColor.TabIndex = 10;
            btnColor.Text = "S E L E C C I O N A R   C O L O R";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // btnBuscarImg
            // 
            btnBuscarImg.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscarImg.Location = new Point(27, 216);
            btnBuscarImg.Margin = new Padding(3, 2, 3, 2);
            btnBuscarImg.Name = "btnBuscarImg";
            btnBuscarImg.Size = new Size(161, 35);
            btnBuscarImg.TabIndex = 13;
            btnBuscarImg.Text = "B U S C A R   I M A G E N";
            btnBuscarImg.UseVisualStyleBackColor = true;
            btnBuscarImg.Click += btnBuscarImg_Click;
            // 
            // btnRegistrarUsuario
            // 
            btnRegistrarUsuario.AutoSize = true;
            btnRegistrarUsuario.Font = new Font("Bahnschrift SemiLight Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrarUsuario.Location = new Point(82, 364);
            btnRegistrarUsuario.Margin = new Padding(3, 2, 3, 2);
            btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            btnRegistrarUsuario.Size = new Size(329, 51);
            btnRegistrarUsuario.TabIndex = 5;
            btnRegistrarUsuario.Text = "R E G I S T R A R";
            btnRegistrarUsuario.UseVisualStyleBackColor = true;
            btnRegistrarUsuario.Click += btnRegistrarUsuario_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Bahnschrift SemiBold", 19.8000011F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.Location = new Point(94, 12);
            label4.Name = "label4";
            label4.Size = new Size(298, 28);
            label4.TabIndex = 16;
            label4.Text = "CREAR CUENTA \r\n";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(121, 94);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.MaxLength = 25;
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "C O N T R A S E Ñ A";
            txtPassword.Size = new Size(237, 27);
            txtPassword.TabIndex = 17;
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // txtConfirmar
            // 
            txtConfirmar.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmar.Location = new Point(121, 132);
            txtConfirmar.Margin = new Padding(3, 2, 3, 2);
            txtConfirmar.MaxLength = 15;
            txtConfirmar.Name = "txtConfirmar";
            txtConfirmar.PlaceholderText = "C O N F I R M A R  C O N T R A S E Ñ A";
            txtConfirmar.Size = new Size(237, 27);
            txtConfirmar.TabIndex = 18;
            txtConfirmar.Enter += txtConfirmar_Enter;
            txtConfirmar.Leave += txtConfirmar_Leave;
            // 
            // FormRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 427);
            Controls.Add(txtConfirmar);
            Controls.Add(txtPassword);
            Controls.Add(label4);
            Controls.Add(btnRegistrarUsuario);
            Controls.Add(btnBuscarImg);
            Controls.Add(btnColor);
            Controls.Add(pictureBoxImagen);
            Controls.Add(txtNombre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "FormRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de Usuarios";
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNombre;
        private PictureBox pictureBoxImagen;
        private ColorDialog colorDialogColor;
        private Button btnColor;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button btnBuscarImg;
        private Button btnRegistrarUsuario;
        private Label label4;
        private TextBox txtPassword;
        private TextBox txtConfirmar;
    }
}
