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
    public partial class FrmSolicitudPago: Form
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
                    dgvSolicitudPago.Columns["Id"].Visible = true;
                    dgvSolicitudPago.Columns["IdCliente"].Visible = true;
                    dgvSolicitudPago.Columns["IdNaviera"].Visible = true;
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
                            dgvSolicitudPago.CurrentCell = dgvSolicitudPago.Rows[0].Cells[1];
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

            // Llenar navieras desde la base de datos usando Entity Framework
            using (var context = new LabGatePayNavierasEntities()) // Asegúrate de usar tu DbContext
            {
                var navieras = context.Naviera.ToList(); // Trae todas las navieras de la base de datos

                cboNaviera.DataSource = navieras;
                cboNaviera.DisplayMember = "Nombre"; // Asegúrate de que esta propiedad existe en la tabla
                cboNaviera.ValueMember = "Id";      // Asegúrate de que esta propiedad existe en la tabla
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
            if (string.IsNullOrWhiteSpace(txtNumeroBL.Text))
            {
                MessageBox.Show("Ingrese el número BL.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtContenedor.Text))
            {
                MessageBox.Show("Ingrese el número de contenedor.");
                return false;
            }

            if (!decimal.TryParse(txtMontoEstimado.Text, out _))
            {
                MessageBox.Show("Ingrese un monto estimado válido.");
                return false;
            }

            if (!decimal.TryParse(txtTipoCambio.Text, out _))
            {
                MessageBox.Show("Ingrese un tipo de cambio válido.");
                return false;
            }

            if (!decimal.TryParse(txtComision.Text, out _))
            {
                MessageBox.Show("Ingrese una comisión válida.");
                return false;
            }

            if (cboEstadoG.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un estado.");
                return false;
            }

            if (cboCliente.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un cliente.");
                return false;
            }

            if (cboNaviera.SelectedIndex < 0)
            {
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
                    solicitudExistente.NumeroBL = solicitud.NumeroBL;
                    solicitudExistente.Contenedor = solicitud.Contenedor;
                    solicitudExistente.MontoEstimado = solicitud.MontoEstimado;
                    solicitudExistente.TipoCambio = solicitud.TipoCambio;
                    solicitudExistente.Comision = solicitud.Comision;
                    solicitudExistente.EstadoG = solicitud.EstadoG;
                    solicitudExistente.FechaSolicitud = DateTime.Now; // Aseguramos que la fecha se actualice
                    SolicitudPagoCln.actualizar(solicitudExistente);
                    MessageBox.Show("Solicitud de pago actualizada correctamente", "::: Mensaje :::", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                listarAsync();
                tabControl1.SelectedTab = SolicitudLista;
            }
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
    }
}
