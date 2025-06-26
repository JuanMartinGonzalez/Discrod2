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
            textBoxUsuarioLogin.Location = new Point(549, 76);
            textBoxUsuarioLogin.Name = "textBoxUsuarioLogin";
            textBoxUsuarioLogin.Size = new Size(325, 27);
            textBoxUsuarioLogin.TabIndex = 0;
            // 
            // textBoxPasswordLogin
            // 
            textBoxPasswordLogin.Location = new Point(549, 142);
            textBoxPasswordLogin.Name = "textBoxPasswordLogin";
            textBoxPasswordLogin.Size = new Size(325, 27);
            textBoxPasswordLogin.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(375, 76);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(375, 142);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(375, 228);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(499, 140);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Ingresar";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // FormIngreso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1392, 450);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPasswordLogin);
            Controls.Add(textBoxUsuarioLogin);
            Name = "FormIngreso";
            Text = "FormIngreso";
            Load += FormIngreso_Load;
            Controls.SetChildIndex(textBoxUsuarioLogin, 0);
            Controls.SetChildIndex(textBoxPasswordLogin, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(btnLogin, 0);
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