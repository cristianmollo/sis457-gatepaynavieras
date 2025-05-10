using CadGatePayNavieras;
using ClnGatePayNavieras;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpGatePayNavieras.Forms
{
    public partial class FrmCliente: Form
    {
        private bool esNuevo; // Variable para determinar si es nuevo o editar
        public FrmCliente()
        {
            InitializeComponent();
            this.Shown += FrmCliente_Shown;
        }


        // esto sirve para que las pestañas no se vean
        private void FrmCliente_Shown(object sender, EventArgs e)
        {
            tabControl1.Appearance = TabAppearance.FlatButtons; // Cambia la apariencia de las pestañas
            tabControl1.ItemSize = new Size(0, 1); // Establece el tamaño de las pestañas
            tabControl1.SizeMode = TabSizeMode.Fixed; // Establece el modo de tamaño de las pestañas
        }

        private async void listarAsync()
        {
            var parametro = txtBuscar.Text.Trim();

            // Aquí carga los datos en segundo plano
            var lista = await Task.Run(() => ClienteCln.listarPa(parametro));

            // Cuando termine, lo muestra en tu DataGridView
            //dvgLista.DataSource = lista;
            //var lista = ClienteCln.listarPa(txtBuscar.Text.Trim());

            // Verifica si la lista tiene datos
            //if (lista.Count == 0)
            //{
            //    MessageBox.Show("No se encontraron clientes.");
            //}


            // Ahora actualizamos el DataGridView en el hilo de la interfaz
            if (this.IsHandleCreated)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    dgvCliente.DataSource = lista; // Cambié dvgLista por dvgCliente
                    //vamos a cambiar los nombres de las columnas que son por defecto la base de datos
                    dgvCliente.Columns["Id"].Visible = false; // Oculta la columna "Id"
                    dgvCliente.Columns["estado"].Visible = false; // Oculta la columna "estado"
                    dgvCliente.Columns["usuarioRegistro"].Visible = false; // Oculta la columna "usuarioRegistro"
                    dgvCliente.Columns["fechaRegistro"].Visible = false; // Oculta la columna "fechaRegistro"
                    dgvCliente.Columns["TipoCliente"].HeaderText = "Tipo Cliente"; // Cambia el encabezado de la columna "TipoCliente"
                    dgvCliente.Columns["Nombre"].HeaderText = "Nombre"; // Cambia el encabezado de la columna "Nombre"
                    dgvCliente.Columns["Telefono"].HeaderText = "Teléfono"; // Cambia el encabezado de la columna "Telefono"
                    dgvCliente.Columns["Email"].HeaderText = "Email"; // Cambia el encabezado de la columna "Email"
                    //quieo que me seleccione la primera fila
                    if (dgvCliente.Rows.Count > 0)
                    {
                        dgvCliente.Rows[0].Selected = true; // Selecciona la primera fila
                        dgvCliente.CurrentCell = dgvCliente.Rows[0].Cells[1]; // Establece el foco en la primera celda
                    }
                    //------------------------------------
                    //vamos a ajusta los tamaños de las celdas con propiedades nomas con autosizeColumns -> allcells
                    //para seleccionar toda la fila en propiedad selectionmode -> fullrowselect
                    //para buscar y hacer enter en el buscador con enter que se busque
                });
            }
            //Esto me sirve para deshabilitar botones si en caso no hay lista de clientes
            btnEditar.Enabled = lista.Count > 0; // Desactiva el botón de editar si es 0 o menor  o  0
            btnEliminar.Enabled = lista.Count > 0; // Desactiva el botón de eliminar si es 0 o menor o 0
            //--------------------------------------

        } //TODO ESTO ES LA LISTA QUE VA APARECER EN MI DGV

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            listarAsync();

        }

        //crearemos un metodo limpiar
        private void limpiar()
        {
            crTextBox1.Clear(); // Limpia el TextBox de nombre
            txtTelefono.Clear(); // Limpia el TextBox de teléfono
            txtEmail.Clear(); // Limpia el TextBox de email
            cbxTipoCliente.SelectedIndex = -1; // Limpia el ComboBox de tipo cliente
        }

        // crearemos un evento cancelar 

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = ClienteLista; // Cambia a la pestaña de lista de clientes
            limpiar(); // Llama al método limpiar para limpiar los campos
        }

        //Este es el evento para buscar el cliente esta relacionado con el txtBuscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listarAsync();
        }

        //Este evento sirve para qeu busqeu cuadno presione la tecla enter
        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) // verifica si la tecla presioanda es enter
            {
                // Verifica si el texto del TextBox no está vacío
                if (!string.IsNullOrWhiteSpace(txtBuscar.Text))
                {
                    // Llama al método listar() para realizar la búsqueda
                    listarAsync();
                }
            }
        }

        //este metodo es para agregar un nuevo cliente
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true; // Cambia el estado a nuevo
            //tabControl1.TabPages.Remove(ClienteLista); // Cambia a la pestaña de agregar cliente
            //tabControl1.TabPages.Add(clienteDetalle); // Agrega la pestaña de nuevo cliente

            // Cambia a la pestaña clienteDetalle
            tabControl1.SelectedTab = clienteDetalle;

            // Opcionalmente puedes cambiar el título de la pestaña si quieres
            //clienteDetalle.Text = "Agregar Nuevo Cliente"; // Cambia el texto de la pestaña
        }

        //esto es el boton editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            esNuevo = false; // Cambia el estado a editar
            //Size = new Size(800, 600); // Cambia el tamaño del formulario

            int idex = dgvCliente.CurrentCell.RowIndex; // Obtiene el índice de la fila seleccionada
            int id = Convert.ToInt32(dgvCliente.Rows[idex].Cells[0].Value); // Obtiene el ID del cliente seleccionado
            var cliente = ClienteCln.obtenerUno(id); // Busca el cliente por ID en la base de datos
            crTextBox1.Texts = cliente.Nombre; // Asigna el nombre del cliente al TextBox
            txtTelefono.Text = cliente.Telefono; // Asigna el teléfono del cliente al TextBox
            txtEmail.Text = cliente.Email; // Asigna el email del cliente al TextBox
            cbxTipoCliente.Text = cliente.TipoCliente; // Asigna el tipo de cliente al ComboBox
            crTextBox1.Focus(); // Establece el foco en el TextBox de nombre

            // Cambia a la pestaña clienteDetalle
            tabControl1.SelectedTab = clienteDetalle;
        }

        // metodo para guardar
        //antes crearemos un metodo extra
        private bool validar()
        {
            bool esValido = true; // si se queda en V entonces quiere decir que no entro a ningun if para qeu se cambie a false entonces quiere decir que esta llenado correctamente
            //limpian errores anteriores en cada control
            erpNombre.SetError(crTextBox1, ""); // Limpia el error del TextBox de nombre
            erpTelefono.SetError(txtTelefono, ""); // Limpia el error del TextBox de teléfono
            erpTipoCliente.SetError(cbxTipoCliente, ""); // Limpia el error del ComboBox de tipo de cliente

            // en los if vota v o f porque si no se llena el campo de texto entonces entra al if y cambia el valor a false
            if (string.IsNullOrEmpty(crTextBox1.Texts)) // Verifica si el TextBox de nombre está vacío
            {
                erpNombre.SetError(crTextBox1, "Ingrese el nombre del cliente."); // Establece el error en el TextBox de nombre
                esValido = false; // esto cambia el valor a false si no se llena el campo
            }

            if (string.IsNullOrEmpty(txtTelefono.Text)) // Verifica si el TextBox de teléfono está vacío
            {
                erpTelefono.SetError(txtTelefono, "Ingrese el teléfono del cliente."); // Establece el error en el TextBox de teléfono
                esValido = false; // esto cambia el valor a false si no se llena el campo
            }

            if (string.IsNullOrEmpty(cbxTipoCliente.Text)) // Verifica si el ComboBox de tipo de cliente está vacío
            {
                erpTipoCliente.SetError(cbxTipoCliente, "Seleccione el tipo de cliente."); // Establece el error en el ComboBox de tipo de cliente
                esValido = false; // esto cambia el valor a false si no se llena el campo
            }

            return esValido; // retornamos el valor de la variable esValido
        }

        //este metodo es para guardar el cliente
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar()) // aqui se llama al metodo validar para saber si esta lleno los datos o no
            {
                var cliente = new Cliente(); // se crea un objeto cliente
                //se empieza a llenar los datos propiedades
                cliente.Nombre = crTextBox1.Texts.Trim(); // trim es quitar los espacios blancos
                cliente.Telefono = txtTelefono.Text.Trim(); // se llena la propiedad Telefomo
                cliente.TipoCliente = cbxTipoCliente.Text; // se llena la propiedad tipo cliente
                cliente.Email = txtEmail.Text.Trim(); // se llena la propiedad email
                cliente.usuarioRegistro = Util.usuario.NombreUsuario; //"jhamil"; // se llena la propiedad usuario registro
                //cliente.usuarioRegistro = Util.usuario.usuario1; //"Jhamil" ahora logueamos bien  19_04_25;

                // aqui vamos a vaidar si es nuevo entonces insertamos o si no actualizamos
                if (esNuevo) // esNuevo en btnNuevo esta esNuevo como true
                {
                    cliente.fechaRegistro = DateTime.Now; // esto asigna la fecha y hora actual
                    cliente.estado = 1; // estado activo
                    ClienteCln.insertar(cliente); // y llama al metodo insertar del CRUD ClnGatePayNavieras
                }
                else // si no es nuevo entonces actualizamos
                {
                    int index = dgvCliente.CurrentCell.RowIndex;
                    int id = Convert.ToInt32(dgvCliente.Rows[index].Cells[0].Value);

                    // 1. Obtener el cliente original desde la BD
                    var clienteExistente = ClienteCln.obtenerUno(id);

                    if (clienteExistente != null)
                    {
                        // 2. Actualizar solo los campos que sí deben cambiar
                        clienteExistente.Nombre = crTextBox1.Texts.Trim();
                        clienteExistente.Telefono = txtTelefono.Text.Trim();
                        clienteExistente.TipoCliente = cbxTipoCliente.Text;
                        clienteExistente.Email = txtEmail.Text.Trim();

                        // 3. Guardar cambios
                        ClienteCln.actualizar(clienteExistente);
                    }
                }
                //else // si no es nuevo entonces actualizamos esNuevo es False
                //{

                //    //cliente.fechaRegistro = DateTime.Now; // esto asigna la fecha y hora actual
                //    //cliente.estado = 1; // estado activo 

                //    //// aqui se obtiene el id del cliente que se va a actualizar
                //    //int index = dgvCliente.CurrentCell.RowIndex;
                //    //cliente.Id = Convert.ToInt32(dgvCliente.Rows[index].Cells[0].Value); // obtiene el id del cliente seleccionado
                //    ////cliente.Id = Convert.ToInt32(dgvCliente.Rows[index].Cells["Id"].Value);
                //    //ClienteCln.actualizar(cliente);
                //    //// osea que el id es el que esta en la fila seleccionada
                //    //// y lo convertimos a entero porque es un entero
                //}

                listarAsync(); // llama al metodo listarAsync para que se actualice la lista

                //Ahora esto es como hacer un cclick en guardar y me lo limpie el cuadro de llenados llamando al metodo btnancelar
                //btnCancelar.PerformClick(); // esto hace click en el boton cancelar

                MessageBox.Show("Cliente guardado correctamente", "::: Thalassa - Mensaje :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Cambia a la pestaña clienteLista
            tabControl1.SelectedTab = ClienteLista;
        }

        //Este evento es para eliminar el cliente
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = dgvCliente.CurrentCell.RowIndex; // Obtiene el índice de la fila seleccionada
            int id = Convert.ToInt32(dgvCliente.Rows[index].Cells[0].Value); // Obtiene el ID del cliente seleccionado
            string nombre = dgvCliente.Rows[index].Cells[1].Value.ToString(); // Obtiene el nombre del cliente seleccionado

            DialogResult dialog = MessageBox.Show(
                $"¿Está seguro de eliminar el cliente {nombre}?",
                "::: Thalassa - Mensaje :::",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dialog == DialogResult.Yes) // Si el usuario selecciona "Sí"
            {
                string usuario = Util.usuario.NombreUsuario; // Asigna el usuario que elimina el cliente
                ClienteCln.eliminar(id, Util.usuario.NombreUsuario); // Llama al método eliminar del CRUD ClnGatePayNavieras
                listarAsync(); // Llama al método listarAsync para actualizar la lista
                MessageBox.Show("Cliente eliminado correctamente", "::: Thalassa - Mensaje :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
