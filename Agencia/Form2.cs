using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Agencia
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();            
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            BaseDatos db = new BaseDatos();
            DataTable datos = db.RetornarTabla("select nombre from usuario where usuario = '" + textUsuario.Text.Trim() + "' and password = '" + textPassword.Text.Trim() + "'");
            bool es_usuario = false;
            if (datos != null)
            {
                if (datos.Rows.Count > 0)
                {
                    es_usuario = true;
                    MessageBox.Show("Bienvenido " + datos.Rows[0]["nombre"].ToString());
                    bool esAdmin = datos.Rows[0]["nombre"].ToString() == "admin";
                    Form1 f1 = new Form1(esAdmin);
                    f1.Show();
                    this.Hide();
                }
            }
            if (!es_usuario)
            {
                MessageBox.Show("el usuario o la contraseña no son correctos");
                buttonrRegistrarse.Visible = true;
                changeSize();
            }
        }

        private void buttonrRegistrarse_Click(object sender, EventArgs e)
        {
            panelRegistro.Visible = true;
            panelIngreso.Visible = false;
            changeSize();
        }

        private void changeSize()
        {
            this.Size = new Size(198, 0);
            int largo = 39;
            foreach (Control c in this.Controls)
            {
                if (c is Panel && c.Visible)
                    largo += c.Size.Height;
            }
            this.Size = new Size(198, largo);
        }

        private void buttonAgregarUsuario_Click(object sender, EventArgs e)
        {
            BaseDatos db = new BaseDatos();
            if (textNuevoPassword.Text.Trim() == textNuevoPassword2.Text.Trim())
            {
                if (textNuevoUsuario.Text.Trim().Length > 0)
                {
                    db.EjecutarComando("insert into usuario(nombre, usuario, password) values ('" + textNombre.Text.Trim() + "','" + textNuevoUsuario.Text.Trim() + "','" + textNuevoPassword.Text.Trim() + "')");                    
                    panelRegistro.Visible = false;
                    panelIngreso.Visible = true;
                    textUsuario.Text = "";
                    textPassword.Text = "";
                    changeSize();
                    MessageBox.Show("Usuario registrado con exito");
                }
                else
                    MessageBox.Show("Debe de ingresar un usuario");
            }
            else
            {
                textNuevoPassword.Text = "";
                textNuevoPassword2.Text = "";
                MessageBox.Show("Las contraseñas no coinciden");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            changeSize();
        }

        private void panelIngreso_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
