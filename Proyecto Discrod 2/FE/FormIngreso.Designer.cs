namespace Proyecto_Discrod_2.FE
{
    partial class FormIngreso
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
            textBoxUsuarioLogin = new TextBox();
            textBoxPasswordLogin = new TextBox();
            btnLogin = new Button();
            label1 = new Label();
            linkLabelRegistrarse = new LinkLabel();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBoxUsuarioLogin
            // 
            textBoxUsuarioLogin.Location = new Point(145, 102);
            textBoxUsuarioLogin.Margin = new Padding(3, 4, 3, 4);
            textBoxUsuarioLogin.Name = "textBoxUsuarioLogin";
            textBoxUsuarioLogin.PlaceholderText = "U S U A R I O";
            textBoxUsuarioLogin.Size = new Size(270, 32);
            textBoxUsuarioLogin.TabIndex = 2;
            textBoxUsuarioLogin.Enter += textBoxUsuarioLogin_Enter;
            textBoxUsuarioLogin.Leave += textBoxUsuarioLogin_Leave;
            // 
            // textBoxPasswordLogin
            // 
            textBoxPasswordLogin.Location = new Point(145, 172);
            textBoxPasswordLogin.Margin = new Padding(3, 4, 3, 4);
            textBoxPasswordLogin.Name = "textBoxPasswordLogin";
            textBoxPasswordLogin.PlaceholderText = "C O N T R A S E Ñ A";
            textBoxPasswordLogin.Size = new Size(270, 32);
            textBoxPasswordLogin.TabIndex = 3;
            textBoxPasswordLogin.UseSystemPasswordChar = true;
            textBoxPasswordLogin.Enter += textBoxPasswordLogin_Enter;
            textBoxPasswordLogin.Leave += textBoxPasswordLogin_Leave;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Bahnschrift Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(107, 274);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(353, 54);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "I N G R E S A R ";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(151, 427);
            label1.Name = "label1";
            label1.Size = new Size(158, 24);
            label1.TabIndex = 4;
            label1.Text = "¿No tenés una cuenta?";
            // 
            // linkLabelRegistrarse
            // 
            linkLabelRegistrarse.AutoSize = true;
            linkLabelRegistrarse.Location = new Point(318, 427);
            linkLabelRegistrarse.Name = "linkLabelRegistrarse";
            linkLabelRegistrarse.Size = new Size(86, 24);
            linkLabelRegistrarse.TabIndex = 5;
            linkLabelRegistrarse.TabStop = true;
            linkLabelRegistrarse.Text = "Registrarse";
            linkLabelRegistrarse.LinkClicked += linkLabelRegistrarse_LinkClicked;
            // 
            // label2
            // 
            label2.Font = new Font("Bahnschrift SemiBold", 18F, FontStyle.Bold | FontStyle.Underline);
            label2.Location = new Point(107, 16);
            label2.Name = "label2";
            label2.Size = new Size(353, 46);
            label2.TabIndex = 1;
            label2.Text = "INICIAR SESION";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormIngreso
            // 
            AutoScaleDimensions = new SizeF(8F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 550);
            Controls.Add(label2);
            Controls.Add(linkLabelRegistrarse);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(textBoxPasswordLogin);
            Controls.Add(textBoxUsuarioLogin);
            Font = new Font("Bahnschrift Condensed", 12F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormIngreso";
            Text = "Ingreso de Usuarios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUsuarioLogin;
        private TextBox textBoxPasswordLogin;
        private Button btnLogin;
        private Label label1;
        private LinkLabel linkLabelRegistrarse;
        private Label label2;
    }
}