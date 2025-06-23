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
<<<<<<< HEAD
    public partial class FrmSolicitudPago: Form
=======
<<<<<<< HEAD
    public partial class FrmSolicitudPago: Form
=======
    public partial class FrmSolicitudPago : Form
>>>>>>> 19c75cd (Avance del proyecto: agregados archivos y mejoras)
>>>>>>> 0eb0043 (Actualización: avance del proyecto)
    {
        private bool esNuevo; // Variable para determinar si es nuevo o editar
        public FrmSolicitudPago()
        {
            InitializeComponent();
            this.Shown += FrmSolicitudPago_Shown;
        }

        // Esto sirve para que las pestañas no se vean
        private void FrmSolicitudPago_Shown(object sender, EventArgs e)
        {
            tabControl1.Appearance = TabAppearance.FlatButtons; // Cambia la apariencia de las pestañas
            tabControl1.ItemSize = new Size(0, 1); // Establece el tamaño de las pestañas
            tabControl1.SizeMode = TabSizeMode.Fixed; // Establece el modo de tamaño de las pestañas
        }

        // Método para listar las solicitudes de pago en el DataGridView
        private async void listarAsync()
        {
            var parametro = txtBuscar.Text.Trim();
            var lista = await Task.Run(() => SolicitudPagoCln.listarPa(parametro));

            if (this.IsHandleCreated)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    dgvSolicitudPago.DataSource = lista;
<<<<<<< HEAD
                    dgvSolicitudPago.Columns["Id"].Visible = true;
                    dgvSolicitudPago.Columns["IdCliente"].Visible = true;
                    dgvSolicitudPago.Columns["IdNaviera"].Visible = true;
=======
<<<<<<< HEAD
                    dgvSolicitudPago.Columns["Id"].Visible = true;
                    dgvSolicitudPago.Columns["IdCliente"].Visible = true;
                    dgvSolicitudPago.Columns["IdNaviera"].Visible = true;
=======
                    dgvSolicitudPago.Columns["Id"].Visible = false;
                    dgvSolicitudPago.Columns["IdCliente"].Visible = false;
                    dgvSolicitudPago.Columns["IdNaviera"].Visible = false;
>>>>>>> 19c75cd (Avance del proyecto: agregados archivos y mejoras)
>>>>>>> 0eb0043 (Actualización: avance del proyecto)
                    dgvSolicitudPago.Columns["EstadoG"].HeaderText = "Estado";
                    dgvSolicitudPago.Columns["MontoEstimado"].HeaderText = "Monto Estimado";
                    dgvSolicitudPago.Columns["TotalEnBolivianos"].HeaderText = "Total (Bs)";

                    // Selecciona la primera fila si existe
                    if (dgvSolicitudPago.Rows.Count > 0)
                    {
                        // Verifica si hay filas antes de intentar seleccionar la primera
                        if (dgvSolicitudPago.Rows.Count > 0)
                        {
                            dgvSolicitudPago.Rows[0].Selected = true;
<<<<<<< HEAD
                            dgvSolicitudPago.CurrentCell = dgvSolicitudPago.Rows[0].Cells[1];
=======
<<<<<<< HEAD
                            dgvSolicitudPago.CurrentCell = dgvSolicitudPago.Rows[0].Cells[1];
=======
                            dgvSolicitudPago.CurrentCell = dgvSolicitudPago.Rows[0].Cells[2];
>>>>>>> 19c75cd (Avance del proyecto: agregados archivos y mejoras)
>>>>>>> 0eb0043 (Actualización: avance del proyecto)
                        }
                        else
                        {
                            dgvSolicitudPago.ClearSelection(); // Limpia cualquier selección si no hay filas
                        }
                    }
                });
            }

            btnEditar.Enabled = lista.Count > 0;
            btnEliminar.Enabled = lista.Count > 0;
        }

        private void cargarCombos()
        {
            // Llenar clientes desde la base de datos
            var clientes = ClienteCln.listar();
            cboCliente.DataSource = clientes;
            cboCliente.DisplayMember = "Nombre";
            cboCliente.ValueMember = "Id";
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
            cboCliente.SelectedIndex = -1; // Esto es muy importante para evitar selección automática
>>>>>>> 19c75cd (Avance del proyecto: agregados archivos y mejoras)
>>>>>>> 0eb0043 (Actualización: avance del proyecto)

            // Llenar navieras desde la base de datos usando Entity Framework
            using (var context = new LabGatePayNavierasEntities()) // Asegúrate de usar tu DbContext
            {
                var navieras = context.Naviera.ToList(); // Trae todas las navieras de la base de datos

                cboNaviera.DataSource = navieras;
                cboNaviera.DisplayMember = "Nombre"; // Asegúrate de que esta propiedad existe en la tabla
                cboNaviera.ValueMember = "Id";      // Asegúrate de que esta propiedad existe en la tabla
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
                cboCliente.SelectedIndex = -1; // Esto es muy importante para evitar selección automática
>>>>>>> 19c75cd (Avance del proyecto: agregados archivos y mejoras)
>>>>>>> 0eb0043 (Actualización: avance del proyecto)
            }
        }

        private void FrmSolicitudPago_Load(object sender, EventArgs e)
        {
            cargarCombos();
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

        //crearemos un metodo limpiar
        private void limpiar()
        {
            txtBuscar.Clear();
            txtMontoEstimado.Clear();
            txtTotalBolivianos.Clear();
            txtComision.Clear();
            txtTipoCambio.Clear();
            txtContenedor.Clear();
            txtNumeroBL.Clear();
            esNuevo = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listarAsync();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            tabControl1.SelectedTab = SolicitudDetalle;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            int index = dgvSolicitudPago.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvSolicitudPago.Rows[index].Cells[0].Value);
            var solicitud = SolicitudPagoCln.obtenerUno(id);

            txtNumeroBL.Text = solicitud.NumeroBL;
            txtContenedor.Text = solicitud.Contenedor;
            txtMontoEstimado.Text = solicitud.MontoEstimado.ToString();
            txtTipoCambio.Text = solicitud.TipoCambio.ToString();
            txtComision.Text = solicitud.Comision.ToString();
            cboEstadoG.Text = solicitud.EstadoG;

            tabControl1.SelectedTab = SolicitudDetalle;
        }

        private bool validar()
        {
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 0eb0043 (Actualización: avance del proyecto)
            if (string.IsNullOrWhiteSpace(txtNumeroBL.Text))
            {
                MessageBox.Show("Ingrese el número BL.");
                return false;
<<<<<<< HEAD
=======
=======
            bool esValido = true;

            // Limpiar errores anteriores
            lblErrorNumeroBL.Text = "";
            lblErrorContenedor.Text = "";
            lblErrorMontoEstimado.Text = "";
            lblErrorTipoCambio.Text = "";
            lblErrorTipoCambio.Text = "";
            lblErrorEstado.Text = "";
            lblErrorCliente.Text = "";
            lblErrorNaviera.Text = "";

            if (string.IsNullOrWhiteSpace(txtNumeroBL.Text))
            {
                lblErrorNumeroBL.Text = "⚠️ Ingrese el número BL.";
                lblErrorNumeroBL.Visible = true;
                esValido = false;
>>>>>>> 19c75cd (Avance del proyecto: agregados archivos y mejoras)
>>>>>>> 0eb0043 (Actualización: avance del proyecto)
            }

            if (string.IsNullOrWhiteSpace(txtContenedor.Text))
            {
<<<<<<< HEAD
                MessageBox.Show("Ingrese el número de contenedor.");
                return false;
=======
<<<<<<< HEAD
                MessageBox.Show("Ingrese el número de contenedor.");
                return false;
=======
                lblErrorContenedor.Text = "⚠️ Ingrese el contenedor.";
                lblErrorContenedor.Visible = true;
                esValido = false;
>>>>>>> 19c75cd (Avance del proyecto: agregados archivos y mejoras)
>>>>>>> 0eb0043 (Actualización: avance del proyecto)
            }

            if (!decimal.TryParse(txtMontoEstimado.Text, out _))
            {
<<<<<<< HEAD
                MessageBox.Show("Ingrese un monto estimado válido.");
                return false;
=======
<<<<<<< HEAD
                MessageBox.Show("Ingrese un monto estimado válido.");
                return false;
=======
                lblErrorMontoEstimado.Text = "⚠️ Ingrese un monto válido.";
                lblErrorMontoEstimado.Visible = true;
                esValido = false;
>>>>>>> 19c75cd (Avance del proyecto: agregados archivos y mejoras)
>>>>>>> 0eb0043 (Actualización: avance del proyecto)
            }

            if (!decimal.TryParse(txtTipoCambio.Text, out _))
            {
<<<<<<< HEAD
                MessageBox.Show("Ingrese un tipo de cambio válido.");
                return false;
=======
<<<<<<< HEAD
                MessageBox.Show("Ingrese un tipo de cambio válido.");
                return false;
=======
                lblErrorTipoCambio.Text = "⚠️ Ingrese el tipo de cambio válido.";
                lblErrorTipoCambio.Visible = true;
                esValido = false;
>>>>>>> 19c75cd (Avance del proyecto: agregados archivos y mejoras)
>>>>>>> 0eb0043 (Actualización: avance del proyecto)
            }

            if (!decimal.TryParse(txtComision.Text, out _))
            {
<<<<<<< HEAD
                MessageBox.Show("Ingrese una comisión válida.");
                return false;
=======
<<<<<<< HEAD
                MessageBox.Show("Ingrese una comisión válida.");
                return false;
=======
                lblErrorTipoCambio.Text = "⚠️ Ingrese la comisión válida.";
                lblErrorTipoCambio.Visible = true;
                esValido = false;
>>>>>>> 19c75cd (Avance del proyecto: agregados archivos y mejoras)
>>>>>>> 0eb0043 (Actualización: avance del proyecto)
            }

            if (cboEstadoG.SelectedIndex < 0)
            {
<<<<<<< HEAD
                MessageBox.Show("Seleccione un estado.");
                return false;
=======
<<<<<<< HEAD
                MessageBox.Show("Seleccione un estado.");
                return false;
=======
                lblErrorEstado.Text = "⚠️ Seleccione un estado.";
                lblErrorEstado.Visible = true;
                esValido = false;
>>>>>>> 19c75cd (Avance del proyecto: agregados archivos y mejoras)
>>>>>>> 0eb0043 (Actualización: avance del proyecto)
            }

            if (cboCliente.SelectedIndex < 0)
            {
<<<<<<< HEAD
                MessageBox.Show("Seleccione un cliente.");
                return false;
=======
<<<<<<< HEAD
                MessageBox.Show("Seleccione un cliente.");
                return false;
=======
                lblErrorCliente.Text = "⚠️ Seleccione un cliente.";
                lblErrorCliente.Visible = true;
                esValido = false;
>>>>>>> 19c75cd (Avance del proyecto: agregados archivos y mejoras)
>>>>>>> 0eb0043 (Actualización: avance del proyecto)
            }

            if (cboNaviera.SelectedIndex < 0)
            {
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 0eb0043 (Actualización: avance del proyecto)
                MessageBox.Show("Seleccione una naviera.");
                return false;
            }

            return true;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar()) // Aquí llamamos al método validar para asegurarnos que los campos son correctos
            {
                var solicitud = new SolicitudPago
                {
                    IdCliente = (int)cboCliente.SelectedValue,
                    IdNaviera = (int)cboNaviera.SelectedValue,
                    NumeroBL = txtNumeroBL.Text.Trim(),
                    Contenedor = txtContenedor.Text.Trim(),
                    MontoEstimado = decimal.Parse(txtMontoEstimado.Text),
                    TipoCambio = decimal.Parse(txtTipoCambio.Text),
                    Comision = decimal.Parse(txtComision.Text),
                    EstadoG = cboEstadoG.Text,
                    usuarioRegistro = "Jhamil" // Asignamos el usuario que realiza el registro
                };

                // Si es un nuevo registro, agregamos la fecha de solicitud
                if (esNuevo)
                {
                    try
                    {
                        solicitud.FechaSolicitud = DateTime.Now; // Agregar la fecha de solicitud para nuevos registros
                        solicitud.fechaRegistro = DateTime.Now;
                        SolicitudPagoCln.insertar(solicitud);
                        MessageBox.Show("Solicitud de pago guardada correctamente", "::: Mensaje :::", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al guardar la solicitud: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else // Si no es un nuevo registro, actualizamos la solicitud existente
                {
                    int index = dgvSolicitudPago.CurrentCell.RowIndex;
                    int id = Convert.ToInt32(dgvSolicitudPago.Rows[index].Cells[0].Value);
                    var solicitudExistente = SolicitudPagoCln.obtenerUno(id);
<<<<<<< HEAD
=======
=======
                lblErrorNaviera.Text = "⚠️ Seleccione una naviera.";
                lblErrorNaviera.Visible = true;
                esValido = false;
            }

            return esValido;
        }


        private void calcularTotal()
        {
            bool montoValido = decimal.TryParse(txtMontoEstimado.Text, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal monto);
            bool tipoCambioValido = decimal.TryParse(txtTipoCambio.Text, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal tipoCambio);
            bool comisionValida = decimal.TryParse(txtComision.Text, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal comision);

            if (montoValido && tipoCambioValido && comisionValida && tipoCambio > 0)
            {
                decimal baseBs = monto / tipoCambio;
                decimal comisionBs = baseBs * (comision / 100);
                decimal totalBs = baseBs + comisionBs;

                txtTotalBolivianos.Text = totalBs.ToString("N2");
            }
            else
            {
                txtTotalBolivianos.Text = "";
            }
        }




        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validar()) return;

            var cultura = System.Globalization.CultureInfo.CurrentCulture;

            // Parsear los valores individuales
            bool montoValido = decimal.TryParse(txtMontoEstimado.Text, System.Globalization.NumberStyles.Any, cultura, out decimal monto);
            bool tipoCambioValido = decimal.TryParse(txtTipoCambio.Text, System.Globalization.NumberStyles.Any, cultura, out decimal tipoCambio);
            bool comisionValida = decimal.TryParse(txtComision.Text, System.Globalization.NumberStyles.Any, cultura, out decimal comision);
            bool totalValido = decimal.TryParse(txtTotalBolivianos.Text, System.Globalization.NumberStyles.Any, cultura, out decimal totalBs);

            if (!montoValido || !tipoCambioValido || !comisionValida || !totalValido || tipoCambio == 0)
            {
                MessageBox.Show("Verifique que los datos numéricos sean válidos y que el tipo de cambio sea distinto de cero.");
                return;
            }

            // Validar combos
            if (!(cboCliente.SelectedValue is int idCliente) || idCliente <= 0)
            {
                MessageBox.Show("Seleccione un cliente válido.");
                return;
            }

            if (!(cboNaviera.SelectedValue is int idNaviera) || idNaviera <= 0)
            {
                MessageBox.Show("Seleccione una naviera válida.");
                return;
            }

            var solicitud = new SolicitudPago
            {
                IdCliente = idCliente,
                IdNaviera = idNaviera,
                NumeroBL = txtNumeroBL.Text.Trim(),
                Contenedor = txtContenedor.Text.Trim(),
                MontoEstimado = monto,
                TipoCambio = tipoCambio,
                TotalEnBolivianos = totalBs,
                Comision = comision,
                EstadoG = cboEstadoG.Text,
                usuarioRegistro = Util.usuario?.NombreUsuario ?? "admin"
            };

            if (esNuevo)
            {
                try
                {
                    solicitud.FechaSolicitud = DateTime.Now;
                    solicitud.fechaRegistro = DateTime.Now;
                    SolicitudPagoCln.insertar(solicitud);
                    MessageBox.Show("Solicitud de pago guardada correctamente.", "::: Mensaje :::", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar la solicitud: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                int index = dgvSolicitudPago.CurrentCell.RowIndex;
                int id = Convert.ToInt32(dgvSolicitudPago.Rows[index].Cells[0].Value);
                var solicitudExistente = SolicitudPagoCln.obtenerUno(id);

                if (solicitudExistente != null)
                {
                    solicitudExistente.IdCliente = idCliente;
                    solicitudExistente.IdNaviera = idNaviera;
>>>>>>> 19c75cd (Avance del proyecto: agregados archivos y mejoras)
>>>>>>> 0eb0043 (Actualización: avance del proyecto)
                    solicitudExistente.NumeroBL = solicitud.NumeroBL;
                    solicitudExistente.Contenedor = solicitud.Contenedor;
                    solicitudExistente.MontoEstimado = solicitud.MontoEstimado;
                    solicitudExistente.TipoCambio = solicitud.TipoCambio;
                    solicitudExistente.Comision = solicitud.Comision;
                    solicitudExistente.EstadoG = solicitud.EstadoG;
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 0eb0043 (Actualización: avance del proyecto)
                    solicitudExistente.FechaSolicitud = DateTime.Now; // Aseguramos que la fecha se actualice
                    SolicitudPagoCln.actualizar(solicitudExistente);
                    MessageBox.Show("Solicitud de pago actualizada correctamente", "::: Mensaje :::", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                listarAsync();
                tabControl1.SelectedTab = SolicitudLista;
            }
<<<<<<< HEAD
=======
=======
                    solicitudExistente.FechaSolicitud = DateTime.Now;
                    solicitudExistente.TotalEnBolivianos = totalBs;

                    SolicitudPagoCln.actualizar(solicitudExistente);
                    MessageBox.Show("Solicitud de pago actualizada correctamente.", "::: Mensaje :::", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            listarAsync();
            tabControl1.SelectedTab = SolicitudLista;
>>>>>>> 19c75cd (Avance del proyecto: agregados archivos y mejoras)
>>>>>>> 0eb0043 (Actualización: avance del proyecto)
        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = dgvSolicitudPago.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvSolicitudPago.Rows[index].Cells[0].Value);
            string numeroBL = dgvSolicitudPago.Rows[index].Cells[3].Value.ToString();

            DialogResult dialog = MessageBox.Show($"¿Está seguro de eliminar la solicitud de pago {numeroBL}?", "::: Mensaje :::", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                SolicitudPagoCln.eliminar(id, "Jhamil");
                listarAsync();
                MessageBox.Show("Solicitud de pago eliminada correctamente", "::: Mensaje :::", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close(); // Cierra el formulario actual
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = SolicitudLista; // Cambia a la pestaña de lista
            limpiar(); // Limpia los campos del formulario
        }
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======

        private void txtNumeroBL_TextChanged(object sender, EventArgs e)
        {
            lblErrorNumeroBL.Text = ""; // Limpia el mensaje de error al cambiar el texto
        }

        private void txtContenedor_TextChanged(object sender, EventArgs e)
        {
            lblErrorContenedor.Text = ""; // Limpia el mensaje de error al cambiar el texto
        }

        private void txtMontoEstimado_TextChanged(object sender, EventArgs e)
        {
            lblErrorMontoEstimado.Text = ""; // Limpia el mensaje de error al cambiar el texto
            calcularTotal(); // Calcula el total en bolivianos al cambiar el monto estimado
        }

        private void txtTipoCambio_TextChanged(object sender, EventArgs e)
        {
            lblErrorTipoCambio.Text = ""; // Limpia el mensaje de error al cambiar el texto
            calcularTotal(); // Calcula el total en bolivianos al cambiar el tipo de cambio
        }

        private void txtComision_TextChanged(object sender, EventArgs e)
        {
            lblErrorComision.Text = ""; // Limpia el mensaje de error al cambiar el texto
            calcularTotal(); // Calcula el total en bolivianos al cambiar la comisión
        }

        private void cboEstadoG_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblErrorEstado.Text = ""; // Limpia el mensaje de error al cambiar el estado
        }

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblErrorCliente.Text = ""; // Limpia el mensaje de error al cambiar el cliente
        }

        private void cboNaviera_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblErrorNaviera.Text = ""; // Limpia el mensaje de error al cambiar la naviera
        }

>>>>>>> 19c75cd (Avance del proyecto: agregados archivos y mejoras)
>>>>>>> 0eb0043 (Actualización: avance del proyecto)
    }
}
