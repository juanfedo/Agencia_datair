namespace Agencia
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.buttonrRegistrarse = new System.Windows.Forms.Button();
            this.panelIngreso = new System.Windows.Forms.Panel();
            this.panelRegistro = new System.Windows.Forms.Panel();
            this.buttonAgregarUsuario = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textNuevoPassword = new System.Windows.Forms.TextBox();
            this.textNuevoPassword2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textNuevoUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelIngreso.SuspendLayout();
            this.panelRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // textUsuario
            // 
            this.textUsuario.Location = new System.Drawing.Point(3, 20);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(174, 20);
            this.textUsuario.TabIndex = 1;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(3, 67);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(174, 20);
            this.textPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.Location = new System.Drawing.Point(3, 93);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(75, 23);
            this.buttonIngresar.TabIndex = 4;
            this.buttonIngresar.Text = "Ingresar";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // buttonrRegistrarse
            // 
            this.buttonrRegistrarse.Location = new System.Drawing.Point(84, 93);
            this.buttonrRegistrarse.Name = "buttonrRegistrarse";
            this.buttonrRegistrarse.Size = new System.Drawing.Size(93, 23);
            this.buttonrRegistrarse.TabIndex = 5;
            this.buttonrRegistrarse.Text = "Nuevo Usuario";
            this.buttonrRegistrarse.UseVisualStyleBackColor = true;
            this.buttonrRegistrarse.Click += new System.EventHandler(this.buttonrRegistrarse_Click);
            // 
            // panelIngreso
            // 
            this.panelIngreso.Controls.Add(this.buttonIngresar);
            this.panelIngreso.Controls.Add(this.buttonrRegistrarse);
            this.panelIngreso.Controls.Add(this.label1);
            this.panelIngreso.Controls.Add(this.textUsuario);
            this.panelIngreso.Controls.Add(this.textPassword);
            this.panelIngreso.Controls.Add(this.label2);
            this.panelIngreso.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelIngreso.Location = new System.Drawing.Point(0, 0);
            this.panelIngreso.Name = "panelIngreso";
            this.panelIngreso.Size = new System.Drawing.Size(182, 125);
            this.panelIngreso.TabIndex = 6;
            this.panelIngreso.Paint += new System.Windows.Forms.PaintEventHandler(this.panelIngreso_Paint);
            // 
            // panelRegistro
            // 
            this.panelRegistro.Controls.Add(this.buttonAgregarUsuario);
            this.panelRegistro.Controls.Add(this.label5);
            this.panelRegistro.Controls.Add(this.textNuevoPassword);
            this.panelRegistro.Controls.Add(this.textNuevoPassword2);
            this.panelRegistro.Controls.Add(this.label6);
            this.panelRegistro.Controls.Add(this.label3);
            this.panelRegistro.Controls.Add(this.textNombre);
            this.panelRegistro.Controls.Add(this.textNuevoUsuario);
            this.panelRegistro.Controls.Add(this.label4);
            this.panelRegistro.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRegistro.Location = new System.Drawing.Point(0, 125);
            this.panelRegistro.Name = "panelRegistro";
            this.panelRegistro.Size = new System.Drawing.Size(182, 223);
            this.panelRegistro.TabIndex = 7;
            this.panelRegistro.Visible = false;
            // 
            // buttonAgregarUsuario
            // 
            this.buttonAgregarUsuario.Location = new System.Drawing.Point(3, 190);
            this.buttonAgregarUsuario.Name = "buttonAgregarUsuario";
            this.buttonAgregarUsuario.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregarUsuario.TabIndex = 9;
            this.buttonAgregarUsuario.Text = "Registrarse";
            this.buttonAgregarUsuario.UseVisualStyleBackColor = true;
            this.buttonAgregarUsuario.Click += new System.EventHandler(this.buttonAgregarUsuario_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ingrese su contraseña";
            // 
            // textNuevoPassword
            // 
            this.textNuevoPassword.Location = new System.Drawing.Point(6, 117);
            this.textNuevoPassword.Name = "textNuevoPassword";
            this.textNuevoPassword.Size = new System.Drawing.Size(174, 20);
            this.textNuevoPassword.TabIndex = 7;
            // 
            // textNuevoPassword2
            // 
            this.textNuevoPassword2.Location = new System.Drawing.Point(6, 164);
            this.textNuevoPassword2.Name = "textNuevoPassword2";
            this.textNuevoPassword2.Size = new System.Drawing.Size(174, 20);
            this.textNuevoPassword2.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ingrese nuevamente la contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(6, 25);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(174, 20);
            this.textNombre.TabIndex = 5;
            // 
            // textNuevoUsuario
            // 
            this.textNuevoUsuario.Location = new System.Drawing.Point(6, 72);
            this.textNuevoUsuario.Name = "textNuevoUsuario";
            this.textNuevoUsuario.Size = new System.Drawing.Size(174, 20);
            this.textNuevoUsuario.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Usuario";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 353);
            this.Controls.Add(this.panelRegistro);
            this.Controls.Add(this.panelIngreso);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panelIngreso.ResumeLayout(false);
            this.panelIngreso.PerformLayout();
            this.panelRegistro.ResumeLayout(false);
            this.panelRegistro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.Button buttonrRegistrarse;
        private System.Windows.Forms.Panel panelIngreso;
        private System.Windows.Forms.Panel panelRegistro;
        private System.Windows.Forms.Button buttonAgregarUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textNuevoPassword;
        private System.Windows.Forms.TextBox textNuevoPassword2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textNuevoUsuario;
        private System.Windows.Forms.Label label4;
    }
}