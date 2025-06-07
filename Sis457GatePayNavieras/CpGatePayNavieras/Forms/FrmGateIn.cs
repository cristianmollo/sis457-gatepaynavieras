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
    public partial class FrmGateIn: Form
    {
        public FrmGateIn()
        {
            InitializeComponent();
        }
        private void cargarCombos()
        {
            // Llenar clientes desde la base de datos
            var clientes = ClienteCln.listar();
            cbxCliente.DataSource = clientes;
            cbxCliente.DisplayMember = "Nombre";
            cbxCliente.ValueMember = "Id";

            // Llenar navieras desde la base de datos usando Entity Framework
            using (var context = new LabGatePayNavierasEntities()) // Asegúrate de usar tu DbContext
            {
                var navieras = context.Naviera.ToList(); // Trae todas las navieras de la base de datos

                cbxNaviera.DataSource = navieras;
                cbxNaviera.DisplayMember = "Nombre"; // Asegúrate de que esta propiedad existe en la tabla
                cbxNaviera.ValueMember = "Id";      // Asegúrate de que esta propiedad existe en la tabla
            }
        }
        private async void listarGateInAsync()
        {
            var lista = await Task.Run(() => GateInCln.ListarVista()); // método que creaste
            dgvGateIn.DataSource = lista;
            dgvGateIn.Columns["Id"].Visible = false;
            dgvGateIn.Columns["NumeroBL"].HeaderText = "Número BL";
            dgvGateIn.Columns["MetodoPago"].HeaderText = "Método";
            dgvGateIn.Columns["FechaPago"].DefaultCellStyle.Format = "dd/MM/yyyy";

            // ocultar campos técnicos y renombrar columnas
        }

        private void FrmGateIn_Load(object sender, EventArgs e)
        {
            listarGateInAsync();
            cargarCombos();
            // Asignar evento *después* de llenar datos, así evitas disparos accidentales
            cbxCliente.SelectedIndexChanged += cbxCliente_SelectedIndexChanged;
        }

        private void cbxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Validamos que el ComboBox esté completamente cargado y no esté en estado inválido
            if (cbxCliente.SelectedIndex != -1 && cbxCliente.SelectedValue is int idCliente)
            {
                var solicitud = SolicitudPagoCln.listar()
                    .FirstOrDefault(s => s.IdCliente == idCliente && s.EstadoG == "Pendiente");

                if (solicitud != null)
                {
                    txtNumeroB_L.Text = solicitud.NumeroBL;
                    txtContenedor.Text = solicitud.Contenedor;
                    nudMontoPagar.Text = solicitud.MontoEstimado.ToString("0.00");
                    cbxNaviera.SelectedValue = solicitud.IdNaviera;
                }
                else
                {
                    txtNumeroB_L.Clear();
                    txtContenedor.Clear();
                    nudMontoPagar.Value=0;
                }
            }

        }

        private void limpiarFormulario()
        {
            cbxCliente.SelectedIndex = -1;
            cbxNaviera.SelectedIndex = -1;
            txtNumeroB_L.Clear();
            txtContenedor.Clear();
            nudMontoPagar.Value = 0;
            cbxMetodoPago.SelectedIndex = -1;
            // Limpiar errores
            erpCliente.SetError(cbxCliente, string.Empty);
            erpNaviera.SetError(cbxNaviera, string.Empty);
            erpNumBL.SetError(txtNumeroB_L, string.Empty);
            erpContenedor.SetError(txtContenedor, string.Empty);
            erpMontoPagar.SetError(nudMontoPagar, string.Empty);
            erpMetodoPago.SetError(cbxMetodoPago, string.Empty);
        }

        private bool validar()
        {
            bool esValido = true;
            erpCliente.SetError(cbxCliente, string.Empty);
            erpNaviera.SetError(cbxNaviera, string.Empty);
            erpNumBL.SetError(txtNumeroB_L, string.Empty);
            erpContenedor.SetError(txtContenedor, string.Empty);
            erpMontoPagar.SetError(nudMontoPagar, string.Empty);
            erpMetodoPago.SetError(cbxMetodoPago, string.Empty);

            if (cbxCliente.SelectedIndex == -1)
            {
                erpCliente.SetError(cbxCliente, "Seleccione un cliente.");
                MessageBox.Show("Seleccione un cliente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                esValido = false;
            }

            if (cbxNaviera.SelectedIndex == -1)
            {
                erpNaviera.SetError(cbxNaviera, "Seleccione una naviera.");
                MessageBox.Show("Seleccione una naviera.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtNumeroB_L.Text))
            {
                erpNumBL.SetError(txtNumeroB_L, "Ingrese el número BL.");
                MessageBox.Show("Ingrese el número BL.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                esValido = false;           }

            if (string.IsNullOrWhiteSpace(txtContenedor.Text))
            {
                erpContenedor.SetError(txtContenedor, "Ingrese el contenedor.");
                MessageBox.Show("Ingrese el contenedor.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                esValido = false;
            }

            if (!decimal.TryParse(nudMontoPagar.Text, out _))
            {
                erpMontoPagar.SetError(nudMontoPagar, "Ingrese un monto válido.");
                MessageBox.Show("Ingrese un monto válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(cbxMetodoPago.Text))
            {
                erpMetodoPago.SetError(cbxMetodoPago, "Seleccione un método de pago.");
                MessageBox.Show("Seleccione un método de pago.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                esValido = false;
            }

            return esValido;
        }

        // este metodo es para insertar un GateIn
        private void btnRegistroGateIn_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                var gateIn = new GateIn
                {
                    IdCliente = (int)cbxCliente.SelectedValue,
                    IdNaviera = (int)cbxNaviera.SelectedValue,
                    NumeroBL = txtNumeroB_L.Text.Trim(),
                    Contenedor = txtContenedor.Text.Trim(),
                    MontoPago = decimal.Parse(nudMontoPagar.Text),
                    MetodoPago = cbxMetodoPago.Text,
                    FechaPago = DateTime.Now,
                    IdUsuario = Util.usuario.Id,
                    usuarioRegistro = Util.usuario.NombreUsuario,
                    estado = 1 // activo
                };

                GateInCln.Insertar(gateIn); // Llama a tu lógica de negocio
                MessageBox.Show("Registro GateIn guardado correctamente", "::: Éxito :::", MessageBoxButtons.OK, MessageBoxIcon.Information);

                listarGateInAsync(); // vuelve a cargar el DGV
                limpiarFormulario(); // opcional: limpiar después de guardar
            }
        }




    }
}
