namespace CpGatePayNavieras.Forms
{
    partial class FrmSolicitudPago
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSolicitudPago));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.txtMontoEstimado = new System.Windows.Forms.TextBox();
            this.lblTipoCambio = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblMontoEstimado = new System.Windows.Forms.Label();
            this.lblBuscarCliente = new System.Windows.Forms.Label();
            this.SolicitudLista = new System.Windows.Forms.TabPage();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvSolicitudPago = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SolicitudDetalle = new System.Windows.Forms.TabPage();
            this.txtTotalBolivianos = new System.Windows.Forms.TextBox();
            this.labelTotalBol = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.cboEstadoG = new System.Windows.Forms.ComboBox();
            this.txtComision = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTipoCambio = new System.Windows.Forms.TextBox();
            this.txtNumeroBL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboNaviera = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.txtContenedor = new System.Windows.Forms.TextBox();
            this.Contenedor = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.erpMontoEstimado = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpTipoCambio = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlSolicitudPago = new System.Windows.Forms.Panel();
            this.erpNumeroBL = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SolicitudLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudPago)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SolicitudDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpMontoEstimado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTipoCambio)).BeginInit();
            this.pnlSolicitudPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpNumeroBL)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.DarkGray;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCerrar.ForeColor = System.Drawing.Color.Black;
            this.btnCerrar.Image = global::CpGatePayNavieras.Properties.Resources.cerrar;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(619, 187);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(20, 3, 0, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnCerrar.Size = new System.Drawing.Size(100, 40);
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(114)))), ((int)(((byte)(161)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Image = global::CpGatePayNavieras.Properties.Resources.eliminar;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(619, 133);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(20, 3, 20, 0);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnEliminar.Size = new System.Drawing.Size(100, 40);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(114)))), ((int)(((byte)(161)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Image = global::CpGatePayNavieras.Properties.Resources.editar;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(619, 74);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(20, 3, 20, 0);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnEditar.Size = new System.Drawing.Size(100, 40);
            this.btnEditar.TabIndex = 14;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.LightBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBuscar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnBuscar.Image = global::CpGatePayNavieras.Properties.Resources.buscar;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(508, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 30);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.ForeColor = System.Drawing.Color.Gray;
            this.txtBuscar.Location = new System.Drawing.Point(0, 26);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(499, 20);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // txtMontoEstimado
            // 
            this.txtMontoEstimado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMontoEstimado.Location = new System.Drawing.Point(16, 21);
            this.txtMontoEstimado.MaxLength = 250;
            this.txtMontoEstimado.Name = "txtMontoEstimado";
            this.txtMontoEstimado.Size = new System.Drawing.Size(144, 20);
            this.txtMontoEstimado.TabIndex = 25;
            // 
            // lblTipoCambio
            // 
            this.lblTipoCambio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTipoCambio.AutoSize = true;
            this.lblTipoCambio.Location = new System.Drawing.Point(13, 0);
            this.lblTipoCambio.Name = "lblTipoCambio";
            this.lblTipoCambio.Size = new System.Drawing.Size(84, 13);
            this.lblTipoCambio.TabIndex = 24;
            this.lblTipoCambio.Text = "Tipo de Cambio:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnCancelar.Image = global::CpGatePayNavieras.Properties.Resources.cancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(182, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnCancelar.Size = new System.Drawing.Size(111, 40);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnGuardar.Image = global::CpGatePayNavieras.Properties.Resources.guardar;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(3, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnGuardar.Size = new System.Drawing.Size(105, 40);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblMontoEstimado
            // 
            this.lblMontoEstimado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMontoEstimado.AutoSize = true;
            this.lblMontoEstimado.Location = new System.Drawing.Point(13, 4);
            this.lblMontoEstimado.Name = "lblMontoEstimado";
            this.lblMontoEstimado.Size = new System.Drawing.Size(86, 13);
            this.lblMontoEstimado.TabIndex = 16;
            this.lblMontoEstimado.Text = "Monto Estimado:";
            // 
            // lblBuscarCliente
            // 
            this.lblBuscarCliente.AutoSize = true;
            this.lblBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarCliente.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBuscarCliente.Location = new System.Drawing.Point(7, 7);
            this.lblBuscarCliente.Name = "lblBuscarCliente";
            this.lblBuscarCliente.Size = new System.Drawing.Size(115, 18);
            this.lblBuscarCliente.TabIndex = 15;
            this.lblBuscarCliente.Text = "Buscar Solicitud";
            // 
            // SolicitudLista
            // 
            this.SolicitudLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(35)))), ((int)(((byte)(66)))));
            this.SolicitudLista.Controls.Add(this.lblBuscarCliente);
            this.SolicitudLista.Controls.Add(this.btnCerrar);
            this.SolicitudLista.Controls.Add(this.btnEliminar);
            this.SolicitudLista.Controls.Add(this.btnEditar);
            this.SolicitudLista.Controls.Add(this.btnNuevo);
            this.SolicitudLista.Controls.Add(this.btnBuscar);
            this.SolicitudLista.Controls.Add(this.txtBuscar);
            this.SolicitudLista.Controls.Add(this.dgvSolicitudPago);
            this.SolicitudLista.Location = new System.Drawing.Point(4, 22);
            this.SolicitudLista.Name = "SolicitudLista";
            this.SolicitudLista.Padding = new System.Windows.Forms.Padding(3);
            this.SolicitudLista.Size = new System.Drawing.Size(724, 345);
            this.SolicitudLista.TabIndex = 0;
            this.SolicitudLista.Text = "SolicitudLista";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(114)))), ((int)(((byte)(161)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnNuevo.ForeColor = System.Drawing.Color.Black;
            this.btnNuevo.Image = global::CpGatePayNavieras.Properties.Resources.nuevo;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(619, 19);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(0);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnNuevo.Size = new System.Drawing.Size(100, 40);
            this.btnNuevo.TabIndex = 11;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvSolicitudPago
            // 
            this.dgvSolicitudPago.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSolicitudPago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSolicitudPago.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.dgvSolicitudPago.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSolicitudPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitudPago.GridColor = System.Drawing.Color.LightGray;
            this.dgvSolicitudPago.Location = new System.Drawing.Point(8, 55);
            this.dgvSolicitudPago.Name = "dgvSolicitudPago";
            this.dgvSolicitudPago.RowHeadersVisible = false;
            this.dgvSolicitudPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSolicitudPago.Size = new System.Drawing.Size(602, 275);
            this.dgvSolicitudPago.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.SolicitudLista);
            this.tabControl1.Controls.Add(this.SolicitudDetalle);
            this.tabControl1.Location = new System.Drawing.Point(-1, 59);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(732, 371);
            this.tabControl1.TabIndex = 18;
            // 
            // SolicitudDetalle
            // 
            this.SolicitudDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(132)))), ((int)(((byte)(162)))));
            this.SolicitudDetalle.Controls.Add(this.tableLayoutPanel2);
            this.SolicitudDetalle.Controls.Add(this.tableLayoutPanel1);
            this.SolicitudDetalle.Location = new System.Drawing.Point(4, 22);
            this.SolicitudDetalle.Name = "SolicitudDetalle";
            this.SolicitudDetalle.Padding = new System.Windows.Forms.Padding(3);
            this.SolicitudDetalle.Size = new System.Drawing.Size(724, 345);
            this.SolicitudDetalle.TabIndex = 1;
            this.SolicitudDetalle.Text = "SolicitudDetalle";
            // 
            // txtTotalBolivianos
            // 
            this.txtTotalBolivianos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalBolivianos.Location = new System.Drawing.Point(16, 17);
            this.txtTotalBolivianos.MaxLength = 250;
            this.txtTotalBolivianos.Name = "txtTotalBolivianos";
            this.txtTotalBolivianos.Size = new System.Drawing.Size(144, 20);
            this.txtTotalBolivianos.TabIndex = 40;
            // 
            // labelTotalBol
            // 
            this.labelTotalBol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalBol.AutoSize = true;
            this.labelTotalBol.Location = new System.Drawing.Point(13, 0);
            this.labelTotalBol.Name = "labelTotalBol";
            this.labelTotalBol.Size = new System.Drawing.Size(77, 13);
            this.labelTotalBol.TabIndex = 39;
            this.labelTotalBol.Text = "Total Boliviano";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(20, 0);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(43, 13);
            this.labelEstado.TabIndex = 36;
            this.labelEstado.Text = "Estado:";
            // 
            // cboEstadoG
            // 
            this.cboEstadoG.FormattingEnabled = true;
            this.cboEstadoG.Items.AddRange(new object[] {
            "ESPERA",
            "PAGADO",
            "NO PAGADO"});
            this.cboEstadoG.Location = new System.Drawing.Point(23, 21);
            this.cboEstadoG.Name = "cboEstadoG";
            this.cboEstadoG.Size = new System.Drawing.Size(121, 21);
            this.cboEstadoG.TabIndex = 35;
            // 
            // txtComision
            // 
            this.txtComision.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComision.Location = new System.Drawing.Point(14, 17);
            this.txtComision.MaxLength = 250;
            this.txtComision.Name = "txtComision";
            this.txtComision.Size = new System.Drawing.Size(121, 20);
            this.txtComision.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Comision:";
            // 
            // txtTipoCambio
            // 
            this.txtTipoCambio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTipoCambio.Location = new System.Drawing.Point(16, 16);
            this.txtTipoCambio.MaxLength = 250;
            this.txtTipoCambio.Name = "txtTipoCambio";
            this.txtTipoCambio.Size = new System.Drawing.Size(144, 20);
            this.txtTipoCambio.TabIndex = 32;
            // 
            // txtNumeroBL
            // 
            this.txtNumeroBL.Location = new System.Drawing.Point(23, 17);
            this.txtNumeroBL.MaxLength = 250;
            this.txtNumeroBL.Name = "txtNumeroBL";
            this.txtNumeroBL.Size = new System.Drawing.Size(144, 20);
            this.txtNumeroBL.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Naviera:";
            // 
            // cboNaviera
            // 
            this.cboNaviera.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboNaviera.FormattingEnabled = true;
            this.cboNaviera.Location = new System.Drawing.Point(14, 23);
            this.cboNaviera.Name = "cboNaviera";
            this.cboNaviera.Size = new System.Drawing.Size(121, 21);
            this.cboNaviera.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Cliente:";
            // 
            // cboCliente
            // 
            this.cboCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(14, 20);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(121, 21);
            this.cboCliente.TabIndex = 27;
            // 
            // txtContenedor
            // 
            this.txtContenedor.Location = new System.Drawing.Point(23, 16);
            this.txtContenedor.MaxLength = 250;
            this.txtContenedor.Name = "txtContenedor";
            this.txtContenedor.Size = new System.Drawing.Size(131, 20);
            this.txtContenedor.TabIndex = 15;
            // 
            // Contenedor
            // 
            this.Contenedor.AutoSize = true;
            this.Contenedor.Location = new System.Drawing.Point(20, 0);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(65, 13);
            this.Contenedor.TabIndex = 14;
            this.Contenedor.Text = "Contenedor:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(15, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(63, 13);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Numero BL:";
            // 
            // erpMontoEstimado
            // 
            this.erpMontoEstimado.ContainerControl = this;
            // 
            // erpTipoCambio
            // 
            this.erpTipoCambio.ContainerControl = this;
            // 
            // pnlSolicitudPago
            // 
            this.pnlSolicitudPago.Controls.Add(this.pictureBox3);
            this.pnlSolicitudPago.Controls.Add(this.pictureBox2);
            this.pnlSolicitudPago.Controls.Add(this.pictureBox1);
            this.pnlSolicitudPago.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSolicitudPago.Location = new System.Drawing.Point(0, 0);
            this.pnlSolicitudPago.Name = "pnlSolicitudPago";
            this.pnlSolicitudPago.Size = new System.Drawing.Size(731, 67);
            this.pnlSolicitudPago.TabIndex = 19;
            // 
            // erpNumeroBL
            // 
            this.erpNumeroBL.ContainerControl = this;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 251F));
            this.tableLayoutPanel1.Controls.Add(this.panel9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(33, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.92558F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.72781F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.36095F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(683, 241);
            this.tableLayoutPanel1.TabIndex = 41;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.txtNumeroBL);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 51);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtMontoEstimado);
            this.panel2.Controls.Add(this.lblMontoEstimado);
            this.panel2.Location = new System.Drawing.Point(198, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(189, 51);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cboCliente);
            this.panel3.Location = new System.Drawing.Point(435, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(189, 51);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Contenedor);
            this.panel4.Controls.Add(this.txtContenedor);
            this.panel4.Location = new System.Drawing.Point(3, 87);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(189, 44);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblTipoCambio);
            this.panel5.Controls.Add(this.txtTipoCambio);
            this.panel5.Location = new System.Drawing.Point(198, 87);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(189, 44);
            this.panel5.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cboNaviera);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(435, 87);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(189, 44);
            this.panel6.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.labelEstado);
            this.panel7.Controls.Add(this.cboEstadoG);
            this.panel7.Location = new System.Drawing.Point(3, 168);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(164, 46);
            this.panel7.TabIndex = 42;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.labelTotalBol);
            this.panel8.Controls.Add(this.txtTotalBolivianos);
            this.panel8.Location = new System.Drawing.Point(198, 168);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(189, 51);
            this.panel8.TabIndex = 43;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label3);
            this.panel9.Controls.Add(this.txtComision);
            this.panel9.Location = new System.Drawing.Point(435, 168);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(189, 43);
            this.panel9.TabIndex = 43;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnGuardar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCancelar, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(163, 272);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(358, 46);
            this.tableLayoutPanel2.TabIndex = 42;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(224, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(119, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(118, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FrmSolicitudPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 423);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pnlSolicitudPago);
            this.Name = "FrmSolicitudPago";
            this.Text = "Solicitud de Pagos";
            this.Load += new System.EventHandler(this.FrmSolicitudPago_Load);
            this.SolicitudLista.ResumeLayout(false);
            this.SolicitudLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudPago)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.SolicitudDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erpMontoEstimado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTipoCambio)).EndInit();
            this.pnlSolicitudPago.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erpNumeroBL)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox txtMontoEstimado;
        private System.Windows.Forms.Label lblTipoCambio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblMontoEstimado;
        private System.Windows.Forms.Label lblBuscarCliente;
        private System.Windows.Forms.TabPage SolicitudLista;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvSolicitudPago;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SolicitudDetalle;
        private System.Windows.Forms.TextBox txtContenedor;
        private System.Windows.Forms.Label Contenedor;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ErrorProvider erpMontoEstimado;
        private System.Windows.Forms.Panel pnlSolicitudPago;
        private System.Windows.Forms.ErrorProvider erpTipoCambio;
        private System.Windows.Forms.TextBox txtNumeroBL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboNaviera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.TextBox txtTipoCambio;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.ComboBox cboEstadoG;
        private System.Windows.Forms.TextBox txtComision;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalBolivianos;
        private System.Windows.Forms.Label labelTotalBol;
        private System.Windows.Forms.ErrorProvider erpNumeroBL;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}