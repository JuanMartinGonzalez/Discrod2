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
            label1 = new Label();
            label2 = new Label();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // textBoxUsuarioLogin
            // 
            textBoxUsuarioLogin.Location = new Point(331, 52);
            textBoxUsuarioLogin.Margin = new Padding(3, 2, 3, 2);
            textBoxUsuarioLogin.Name = "textBoxUsuarioLogin";
            textBoxUsuarioLogin.Size = new Size(285, 23);
            textBoxUsuarioLogin.TabIndex = 0;
            // 
            // textBoxPasswordLogin
            // 
            textBoxPasswordLogin.Location = new Point(331, 101);
            textBoxPasswordLogin.Margin = new Padding(3, 2, 3, 2);
            textBoxPasswordLogin.Name = "textBoxPasswordLogin";
            textBoxPasswordLogin.Size = new Size(285, 23);
            textBoxPasswordLogin.TabIndex = 1;
            textBoxPasswordLogin.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(179, 52);
            label1.Name = "label1";
            label1.Size = new Size(65, 19);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(179, 101);
            label2.Name = "label2";
            label2.Size = new Size(93, 19);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Bahnschrift SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(179, 166);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(437, 105);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Ingresar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // FormIngreso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 338);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPasswordLogin);
            Controls.Add(textBoxUsuarioLogin);
            FormBorderStyle = FormBorderStyle.FixedDialog;
<<<<<<< Updated upstream
=======
            Margin = new Padding(3, 2, 3, 2);
>>>>>>> Stashed changes
            MaximizeBox = false;
            Name = "FormIngreso";
            Text = "FormIngreso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUsuarioLogin;
        private TextBox textBoxPasswordLogin;
        private Label label1;
        private Label label2;
        private Button btnLogin;
    }
}