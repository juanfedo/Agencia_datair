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
    public partial class Form1 : Form
    {
        public Form1(bool esAdmin)
        {
            InitializeComponent();
            groupAdministrador.Visible = esAdmin;            
            groupReserva.Visible = !esAdmin;
        }

        public void llenarCombos()
        {
            BaseDatos bd = new BaseDatos();
            combociudadorigen.ValueMember = "id";
            combociudadorigen.DisplayMember = "nombre";
            combociudadorigen.DataSource = bd.RetornarTabla("SELECT * from ciudad");
            combociudaddestino.ValueMember = "id";
            combociudaddestino.DisplayMember = "nombre";
            combociudaddestino.DataSource = bd.RetornarTabla("SELECT * from ciudad");
            comboAerolinea.ValueMember = "id";
            comboAerolinea.DisplayMember = "nombre";
            comboAerolinea.DataSource = bd.RetornarTabla("SELECT * from aerolinea");
            combociudadorigenAdmin.ValueMember = "id";
            combociudadorigenAdmin.DisplayMember = "nombre";
            combociudadorigenAdmin.DataSource = bd.RetornarTabla("SELECT * from ciudad");
            combociudaddestinoAdmin.ValueMember = "id";
            combociudaddestinoAdmin.DisplayMember = "nombre";
            combociudaddestinoAdmin.DataSource = bd.RetornarTabla("SELECT * from ciudad");
            comboAerolineaAdmin.ValueMember = "id";
            comboAerolineaAdmin.DisplayMember = "nombre";
            comboAerolineaAdmin.DataSource = bd.RetornarTabla("SELECT * from aerolinea");
            comboAvionAdmin.ValueMember = "id";
            comboAvionAdmin.DisplayMember = "tipo";
            comboAvionAdmin.DataSource = bd.RetornarTabla("SELECT * from avion");
            comboAerolineaReporte.ValueMember = "id";
            comboAerolineaReporte.DisplayMember = "nombre";
            comboAerolineaReporte.DataSource = bd.RetornarTabla("SELECT * from aerolinea");
            comboAdminAerolinea.ValueMember = "id";
            comboAdminAerolinea.DisplayMember = "nombre";
            comboAdminAerolinea.DataSource = bd.RetornarTabla("SELECT * from aerolinea");
            comboAdminDestino.ValueMember = "id";
            comboAdminDestino.DisplayMember = "nombre";
            comboAdminDestino.DataSource = bd.RetornarTabla("SELECT * from ciudad");
            comboAdminOrigen.ValueMember = "id";
            comboAdminOrigen.DisplayMember = "nombre";
            comboAdminOrigen.DataSource = bd.RetornarTabla("SELECT * from ciudad");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateFechaIda.CustomFormat = "MM-dd-yyyy";
            dateFechaRegreso.CustomFormat = "MM-dd-yyyy";
            llenarCombos();
            groupReserva.ResumeLayout(false);
            groupReserva.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
            ChangeSize();
        }

        private void ChangeSize()
        {
            //this.Size = new Size(467, 0);
            //int largo = 39;
            //int ancho = 0;
            //foreach (Control c in this.Controls)
            //{
            //    if (c is GroupBox && c.Visible)
            //    {
            //        largo += c.Size.Height;
            //        ancho = c.Size.Width;
            //    }
            //}
            //this.Size = new Size(ancho + 40, largo);
        }

        private bool ValidarDatos()
        {
            if (radioIdaVuelta.Checked)
            {
                if (dateFechaRegreso.Value.Date < dateFechaIda.Value.Date)
                {                    
                    MessageBox.Show("La fecha de salida no puede ser superior a la fecha de regreso");
                    return false;
                }
            }
            if (combociudaddestino.SelectedIndex == combociudadorigen.SelectedIndex)
            {
                MessageBox.Show("La ciudad destino no puede ser igual a la ciudad origen");
                return false;
            }
            return true;
        }

        private void DataVuelos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row_index = e.RowIndex;
            for (int i = 0; i < dataVuelos.Rows.Count; i++)
            {
                if (row_index != i)
                {
                    dataVuelos.Rows[i].Cells["Selecciona"].Value = false;
                }
            }
            buttonReservar.Visible = true;
        }

        private void dataVuelosRegreso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row_index = e.RowIndex;
            for (int i = 0; i < dataVuelosRegreso.Rows.Count; i++)
            {
                if (row_index != i)
                {
                    dataVuelosRegreso.Rows[i].Cells["Seleccionar"].Value = false;
                }
            }
            buttonReservar.Visible = true;
        }

        private void buttonBuscarVuelos_Click(object sender, EventArgs e)
        {
            buttonReservar.Visible = false;
            if (ValidarDatos())
            {
                groupBoxIda.Text = "Vuelos de ida " + combociudadorigen.Text + " - " + combociudaddestino.Text;
                groupBoxRegreso.Text = "Vuelos de regreso " + combociudaddestino.Text + " - " + combociudadorigen.Text;

                BaseDatos db = new BaseDatos();
                dataVuelos.DataSource = db.RetornarTabla("select tipo,fecha_salida,hora_salida,vuelo.id, aerolinea.nombre as aerolinea, capacidad from vuelo " +
                    "inner join avion on vuelo.avion_id = avion.id inner join ciudad on vuelo.origen = ciudad.id inner join aerolinea on vuelo.aerolinea = aerolinea.id where fecha_salida = '" + dateFechaIda.Value.Date.ToString("MM/dd/yyyy") + "' " +
                    " and origen = " + combociudadorigen.SelectedValue + " and destino = " + combociudaddestino.SelectedValue + " and aerolinea = " + comboAerolinea.SelectedValue);

                dataVuelosRegreso.DataSource = db.RetornarTabla("select tipo,fecha_salida,hora_salida,vuelo.id, aerolinea.nombre as aerolinea, capacidad from vuelo " +
                    "inner join avion on vuelo.avion_id = avion.id inner join ciudad on vuelo.origen = ciudad.id inner join aerolinea on vuelo.aerolinea = aerolinea.id where fecha_salida = '" + dateFechaRegreso.Value.Date.ToString("MM/dd/yyyy") + "' " +
                    " and origen = " + combociudaddestino.SelectedValue + " and destino = " + combociudadorigen.SelectedValue + " and aerolinea= " + comboAerolinea.SelectedValue);

                dataVuelos.Columns["id"].Visible = false;
                dataVuelosRegreso.Columns["id"].Visible = false;
                dataVuelos.Columns["capacidad"].Visible = false;
                dataVuelosRegreso.Columns["capacidad"].Visible = false;
                groupBoxRegreso.Visible = radioIdaVuelta.Checked;                
                groupBoxIda.Visible = true;
            }
            ChangeSize();
        }

        private void radioIda_CheckedChanged(object sender, EventArgs e)
        {
            if (radioIda.Checked)
            {
                dateFechaRegreso.Visible = false;
                label4.Visible = false;
            }
        }

        private void radioIdaVuelta_CheckedChanged(object sender, EventArgs e)
        {
            if (radioIdaVuelta.Checked)
            {
                dateFechaRegreso.Visible = true;
                label4.Visible = true;                
            }
        }

        private bool validarSeleccionVuelo()
        {
            bool seleccion = false;

            if (groupBoxIda.Visible)
                for (int i = 0; i < dataVuelos.Rows.Count; i++)
                    if (dataVuelos.Rows[i].Cells["Selecciona"].Value != null)
                        if ((bool)dataVuelos.Rows[i].Cells["Selecciona"].Value)
                            seleccion = true;

            if (groupBoxRegreso.Visible)
                {
                    for (int i = 0; i < dataVuelosRegreso.Rows.Count; i++)
                        if (dataVuelosRegreso.Rows[i].Cells["Seleccionar"].Value != null)
                            if ((bool)dataVuelosRegreso.Rows[i].Cells["Seleccionar"].Value)
                                return seleccion && true;
                    seleccion = false;
                }
            return seleccion;
        }

        private void buttonReservar_Click(object sender, EventArgs e)
        {
            bool seleccion = validarSeleccionVuelo();
            if (seleccion)
            {
                groupCliente.Visible = seleccion;
                buttonReservar.Visible = false;
            }
            else
                MessageBox.Show("Debe seleccionar un vuelo");
        }

        private void limpiarControles()
        {
            textIdentificacion.Text = "";
            textNombre.Text = "";
            txtApellidos.Text = "";
            txtMail.Text = "";
            txtTelefono.Text = "";
            textNumero.Text = "";
            comboTipoIdentificacion.SelectedItem = "";
            comboGenero.SelectedItem = "";
        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            bool error = false;
            if (groupBoxIda.Visible)
            {
                for (int i = 0; i < dataVuelos.Rows.Count; i++)
                {
                    if ((bool)dataVuelos.Rows[i].Cells["Selecciona"].Value)
                    {
                        BaseDatos db = new BaseDatos();
                        DataTable temp = db.RetornarTabla("select * from cliente where documento = " + textIdentificacion.Text);
                        if (temp == null || temp.Rows.Count == 0)
                        {
                            string tipo_tarjeta = string.Empty;
                            if (radioMaster.Checked)
                                tipo_tarjeta = "Master";
                            else
                                tipo_tarjeta = "Visa";
                            db.EjecutarComando("INSERT INTO cliente (nombre,apellidos,genero,email,telefono,documento,tipo_documento,tipo_tarjeta,numero_tarjeta) VALUES ('" + textNombre.Text +
                                "','" + txtApellidos.Text + "'," +
                                "'" + comboGenero.SelectedItem + "'," +
                                "'" + txtMail.Text + "'," +
                                "" + txtTelefono.Text + "," +
                                "'" + textIdentificacion.Text + "'," +
                                "'" + comboTipoIdentificacion.SelectedItem + "'," +
                                "'" + tipo_tarjeta + "'," +
                                "" + textNumero.Text + ")");
                        }

                        int reservas_vuelo = Convert.ToInt16(db.EjecutarEscalar("select count(vuelo_ida_id) from reservas where vuelo_ida_id = " + dataVuelos.Rows[i].Cells["id"].Value.ToString()));

                        if (reservas_vuelo >= Convert.ToInt16(dataVuelos.Rows[i].Cells["capacidad"].Value))
                        {
                            MessageBox.Show("El vuelo de ida no cuenta con asientos disponibles, lo invitamos a realizar nuevamente otra busqueda en nuestro sistema");
                            buttonBuscarVuelos.Visible = true;
                            error = true;
                        }
                        else
                            db.EjecutarComando("INSERT INTO reservas (vuelo_ida_id,cliente) " + "VALUES (" + dataVuelos.Rows[i].Cells["id"].Value.ToString() + "," + textIdentificacion.Text + ")");                        
                        break;
                    }
                }
            }
            if (groupBoxRegreso.Visible)
            {
                for (int i = 0; i < dataVuelosRegreso.Rows.Count; i++)
                {
                    if ((bool)dataVuelosRegreso.Rows[i].Cells["Seleccionar"].Value)
                    {
                        BaseDatos db = new BaseDatos();
                        DataTable temp = db.RetornarTabla("select * from cliente where documento = " + textIdentificacion.Text);
                        if (temp == null || temp.Rows.Count == 0)
                        {
                            string tipo_tarjeta = string.Empty;
                            if (radioMaster.Checked)
                                tipo_tarjeta = "Master";
                            else
                                tipo_tarjeta = "Visa";
                            db.EjecutarComando("INSERT INTO cliente (nombre,apellidos,genero,email,telefono,documento,tipo_documento,tipo_tarjeta,numero_tarjeta) VALUES ('" + textNombre.Text +
                                "','" + txtApellidos.Text + "'," +
                                "'" + comboGenero.SelectedItem + "'," +
                                "'" + txtMail.Text + "'," +
                                "" + txtTelefono.Text + "," +
                                "'" + textIdentificacion.Text + "'," +
                                "'" + comboTipoIdentificacion.SelectedItem + "'," +
                                "'" + tipo_tarjeta + "'," +
                                "" + textNumero.Text + ")");
                        }

                        int reservas_vuelo = Convert.ToInt16(db.EjecutarEscalar("select count(vuelo_regreso_id) from reservas where vuelo_ida_id = " + dataVuelosRegreso.Rows[i].Cells["id"].Value.ToString()));

                        if (reservas_vuelo >= Convert.ToInt16(dataVuelosRegreso.Rows[i].Cells["capacidad"].Value))
                        {
                            MessageBox.Show("El vuelo de regreso no cuenta con asientos disponibles, lo invitamos a realizar nuevamente otra busqueda en nuestro sistema");
                            buttonBuscarVuelos.Visible = true;
                            error = true;
                        }
                        else
                            db.EjecutarComando("INSERT INTO reservas (vuelo_regreso_id,cliente) " +
                            "VALUES (" + dataVuelosRegreso.Rows[i].Cells["id"].Value.ToString() + "," + textIdentificacion.Text + ")");
                        break;
                    }
                }
            }
                groupBoxIda.Visible = false;
                groupBoxRegreso.Visible = false;
                groupCliente.Visible = false;
                buttonReservar.Visible = false;
                dataVuelos.DataSource = null;
                dataVuelos.DataSource = null;
                groupReserva.Visible = true;
                limpiarControles();
            if (!error)
            {
                limpiarControles();
                MessageBox.Show("Reserva realizada con exito!!!");
            }
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            BaseDatos db = new BaseDatos();
            dataConsulta.DataSource = db.RetornarTabla(
                "select tipo as Avion,fecha_salida,hora_salida, aerolinea.nombre as aerolinea ,ciudad.nombre as origen ,(select nombre from vuelo inner join ciudad on vuelo.destino = ciudad.id where vuelo.id = V.id) as destino " +
                " from vuelo as V " +
                " inner join avion on V.avion_id = avion.id " +
                " inner join ciudad on V.origen = ciudad.id " +
                " inner join aerolinea on V.aerolinea = aerolinea.id " +
                " inner join reservas on reservas.vuelo_ida_id = V.id " +
                " inner join cliente on reservas.cliente = cliente.documento " +
                " where documento = '" + textConsultaIdentificacion.Text + "' " +
                " union all" +
                " select tipo as Avion, fecha_salida, hora_salida,aerolinea.nombre as aerolinea ,ciudad.nombre as origen, (select nombre from vuelo inner join ciudad on vuelo.destino = ciudad.id where vuelo.id = V.id) as destino " +
                " from vuelo as V " +
                " inner join avion on V.avion_id = avion.id " +
                " inner join ciudad on V.origen = ciudad.id " +
                " inner join aerolinea on V.aerolinea = aerolinea.id " +
                " inner join reservas on reservas.vuelo_regreso_id = V.id " +
                " inner join cliente on reservas.cliente = cliente.documento " +
                " where documento = '" + textConsultaIdentificacion.Text +"'"
                );

            DataTable datos = db.RetornarTabla("select nombre from cliente where documento = '" + textConsultaIdentificacion.Text +"'");

            if (datos.Rows.Count > 0)
            {
                textNombreReserva.Text = datos.Rows[0]["nombre"].ToString();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonCrearVuelo_Click(object sender, EventArgs e)
        {
            ChangeSize();
            BaseDatos db = new BaseDatos();
            if (db.EjecutarComando("INSERT INTO vuelo (avion_id,fecha_salida,hora_salida,origen,destino,aerolinea) " +
                            "VALUES (" + comboAvionAdmin.SelectedValue + ",'" + dateFechaIdaAdmin.Value.Date.ToString("MM/dd/yyyy") + "','" + dateHoraAdmin.Value.ToShortTimeString().Split(new char[] {' '})[0] + "'," + combociudadorigenAdmin.SelectedValue + "," + combociudaddestinoAdmin.SelectedValue + "," + comboAerolineaAdmin.SelectedValue + ")"))
            {
                MessageBox.Show("Registro creado con exito");
            }
            else
            {
                MessageBox.Show("Se presento un error al crear el registro");

            }
        }

        private void buttonReporte_Click(object sender, EventArgs e)
        {
            BaseDatos db = new BaseDatos();
            dataGridView1.DataSource = db.RetornarTabla("select tipo as Avion,cliente,fecha_salida,hora_salida, aerolinea.nombre as aerolinea ,ciudad.nombre as origen ,(select nombre from vuelo inner join ciudad on vuelo.destino = ciudad.id where vuelo.id = V.id) as destino " +
                " from vuelo as V " +
                " inner join avion on V.avion_id = avion.id " +
                " inner join ciudad on V.origen = ciudad.id " +
                " inner join aerolinea on V.aerolinea = aerolinea.id " +
                " inner join reservas on reservas.vuelo_ida_id = V.id " +
                " where V.aerolinea = " + comboAerolineaReporte.SelectedValue +
                " union " +
                " select tipo as Avion,cliente, fecha_salida, hora_salida,aerolinea.nombre as aerolinea ,ciudad.nombre as origen, (select nombre from vuelo inner join ciudad on vuelo.destino = ciudad.id where vuelo.id = V.id) as destino " +
                " from vuelo as V " +
                " inner join avion on V.avion_id = avion.id " +
                " inner join ciudad on V.origen = ciudad.id " +
                " inner join aerolinea on V.aerolinea = aerolinea.id " +
                " inner join reservas on reservas.vuelo_regreso_id = V.id " +
                " where V.aerolinea = " + comboAerolineaReporte.SelectedValue);
        }

        private void btnConsultarClientes_Click(object sender, EventArgs e)
        {
            BaseDatos db = new BaseDatos();
            dataClientesRegistrados.DataSource = db.RetornarTabla("select nombre, apellidos, tipo_documento, documento, genero, email, telefono from cliente ");
        }

        private void dataAdminVuelos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row_index = e.RowIndex;
            for (int i = 0; i < dataAdminVuelos.Rows.Count; i++)
            {
                if (row_index != i)
                {
                    dataAdminVuelos.Rows[i].Cells["escoger"].Value = false;
                }
            }           
        }

        private bool validarSeleccionVueloAdmin()
        {
            bool seleccion = false;

            for (int i = 0; i < dataAdminVuelos.Rows.Count; i++)
                if (dataAdminVuelos.Rows[i].Cells["escoger"].Value != null)
                    if ((bool)dataAdminVuelos.Rows[i].Cells["escoger"].Value)
                        seleccion = true;

            return seleccion;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BaseDatos db = new BaseDatos();

            dataAdminVuelos.DataSource = db.RetornarTabla("select tipo,fecha_salida,hora_salida,vuelo.id, aerolinea.nombre as aerolinea from vuelo " +
                "inner join avion on vuelo.avion_id = avion.id inner join ciudad on vuelo.origen = ciudad.id inner join aerolinea on vuelo.aerolinea = aerolinea.id where fecha_salida = '" + dateAdminFecha.Value.Date.ToString("MM/dd/yyyy") + "' " +
                " and destino = " + comboAdminDestino.SelectedValue + " and origen = " + comboAdminOrigen.SelectedValue + " and aerolinea = " + comboAdminAerolinea.SelectedValue + " and hora_salida = '" + dateAdminHora.Value.ToString("hh:mm:ss") + "'");
            dataAdminVuelos.Columns["id"].Visible = false;
        }

        private void btnConsultarPasajeros_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataAdminVuelos.Rows.Count; i++)
                if (dataAdminVuelos.Rows[i].Cells["escoger"].Value != null)
                    if ((bool)dataAdminVuelos.Rows[i].Cells["escoger"].Value)
                    {
                        BaseDatos db = new BaseDatos();
                        dataAdminPasajeros.DataSource = db.RetornarTabla("select nombre, apellidos,tipo_documento,documento, email, telefono from cliente inner join reservas on cliente.documento = reservas.cliente where (vuelo_ida_id = " + (int)dataAdminVuelos.Rows[i].Cells["id"].Value + " or vuelo_regreso_id = " + (int)dataAdminVuelos.Rows[i].Cells["id"].Value + ")" );
                    }
        }

        private void textIdentificacion_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textIdentificacion_Leave(object sender, EventArgs e)
        {
            BaseDatos db = new BaseDatos();
            if (textIdentificacion.Text.Trim().Length > 0)
            {
                DataTable datos = db.RetornarTabla("select * from cliente where documento = " + textIdentificacion.Text);
                if (datos != null && datos.Rows.Count > 0)
                {
                    textNombre.Text = datos.Rows[0]["nombre"].ToString();
                    txtApellidos.Text = datos.Rows[0]["apellidos"].ToString();
                    comboTipoIdentificacion.SelectedItem = datos.Rows[0]["tipo_documento"].ToString();
                    comboGenero.SelectedItem = datos.Rows[0]["genero"].ToString();
                    txtMail.Text = datos.Rows[0]["email"].ToString();
                    txtTelefono.Text = datos.Rows[0]["telefono"].ToString();
                    textNumero.Text = datos.Rows[0]["numero_tarjeta"].ToString();
                    if (datos.Rows[0]["tipo_tarjeta"].ToString() == "Visa")
                        radioVisa.Checked = true;
                    else
                        radioMaster.Checked = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f1 = new Form2();
            f1.Show();
        }

        private void comboAvionAdmin_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboAvionAdmin.SelectedValue != null)
            {
                BaseDatos db = new BaseDatos();
                lblCapacidad.Text = db.EjecutarEscalar("select capacidad from avion where id = " + comboAvionAdmin.SelectedValue).ToString();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f1 = new Form2();
            f1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BaseDatos db = new BaseDatos();
            if (textAdminAvion.Text.Trim() != "" && textAdminCapacidad.Text != "")
            {
                db.EjecutarComando("insert into avion(tipo,capacidad) values ('" + textAdminAvion.Text + "'," + textAdminCapacidad.Text + ")");
                dataAdminAvion.DataSource = db.RetornarTabla("select tipo,capacidad from avion");
                textAdminAvion.Text = "";
                textAdminCapacidad.Text = "";
                llenarCombos();
            }
            else
                MessageBox.Show("Se presento un error al crear el avión");
        }

        private void buttonAdminCiudad_Click(object sender, EventArgs e)
        {
            BaseDatos db = new BaseDatos();
            if (textAdminCiudad.Text.Trim() != "")
            {
                db.EjecutarComando("insert into ciudad(nombre) values ('" + textAdminCiudad.Text + "')");
                dataAdminCiudad.DataSource = db.RetornarTabla("select nombre from ciudad");
                textAdminCiudad.Text = "";
                llenarCombos();
            }
            else
                MessageBox.Show("Se presento un error al crear la ciudad");
        }

        private void groupReserva_Enter(object sender, EventArgs e)
        {

        }
    }
}

      


