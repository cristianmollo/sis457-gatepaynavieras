namespace CpGatePayNavieras.Forms
{
    partial class FrmNaviera
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
            this.erpTipoCliente = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNaviera = new System.Windows.Forms.Label();
            this.erpTelefono = new System.Windows.Forms.ErrorProvider(this.components);
            this.clienteDetalle = new System.Windows.Forms.TabPage();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cbxTipoCliente = new System.Windows.Forms.ComboBox();
            this.lblTipoCliente = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ClienteLista = new System.Windows.Forms.TabPage();
            this.lblBuscarCliente = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.crTextBox1 = new CpGatePayNavieras.CRControls.CRTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.erpTipoCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpNombre)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpTelefono)).BeginInit();
            this.clienteDetalle.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.ClienteLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // erpTipoCliente
            // 
            this.erpTipoCliente.ContainerControl = this;
            // 
            // erpNombre
            // 
            this.erpNombre.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblNaviera);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 67);
            this.panel1.TabIndex = 17;
            // 
            // lblNaviera
            // 
            this.lblNaviera.AutoSize = true;
            this.lblNaviera.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaviera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblNaviera.Location = new System.Drawing.Point(12, 9);
            this.lblNaviera.Name = "lblNaviera";
            this.lblNaviera.Size = new System.Drawing.Size(149, 45);
            this.lblNaviera.TabIndex = 0;
            this.lblNaviera.Text = "Navieras";
            this.lblNaviera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // erpTelefono
            // 
            this.erpTelefono.ContainerControl = this;
            // 
            // clienteDetalle
            // 
            this.clienteDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(35)))), ((int)(((byte)(66)))));
            this.clienteDetalle.Controls.Add(this.crTextBox1);
            this.clienteDetalle.Controls.Add(this.txtEmail);
            this.clienteDetalle.Controls.Add(this.lblEmail);
            this.clienteDetalle.Controls.Add(this.btnCancelar);
            this.clienteDetalle.Controls.Add(this.btnGuardar);
            this.clienteDetalle.Controls.Add(this.cbxTipoCliente);
            this.clienteDetalle.Controls.Add(this.lblTipoCliente);
            this.clienteDetalle.Controls.Add(this.txtTelefono);
            this.clienteDetalle.Controls.Add(this.lblTelefono);
            this.clienteDetalle.Controls.Add(this.lblNombre);
            this.clienteDetalle.Location = new System.Drawing.Point(4, 22);
            this.clienteDetalle.Name = "clienteDetalle";
            this.clienteDetalle.Padding = new System.Windows.Forms.Padding(3);
            this.clienteDetalle.Size = new System.Drawing.Size(724, 345);
            this.clienteDetalle.TabIndex = 1;
            this.clienteDetalle.Text = "tabPage2";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(303, 121);
            this.txtEmail.MaxLength = 250;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(194, 20);
            this.txtEmail.TabIndex = 25;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(300, 89);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 24;
            this.lblEmail.Text = "Email:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(316, 175);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnCancelar.Size = new System.Drawing.Size(111, 40);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(126, 175);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnGuardar.Size = new System.Drawing.Size(105, 40);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // cbxTipoCliente
            // 
            this.cbxTipoCliente.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cbxTipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoCliente.FormattingEnabled = true;
            this.cbxTipoCliente.Items.AddRange(new object[] {
            "Administrador",
            "Chofer",
            "Gerente",
            "Importadora",
            "Representante",
            ""});
            this.cbxTipoCliente.Location = new System.Drawing.Point(303, 49);
            this.cbxTipoCliente.Name = "cbxTipoCliente";
            this.cbxTipoCliente.Size = new System.Drawing.Size(194, 21);
            this.cbxTipoCliente.TabIndex = 17;
            // 
            // lblTipoCliente
            // 
            this.lblTipoCliente.AutoSize = true;
            this.lblTipoCliente.Location = new System.Drawing.Point(300, 33);
            this.lblTipoCliente.Name = "lblTipoCliente";
            this.lblTipoCliente.Size = new System.Drawing.Size(81, 13);
            this.lblTipoCliente.TabIndex = 16;
            this.lblTipoCliente.Text = "Tipo de Cliente:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(37, 121);
            this.txtTelefono.MaxLength = 250;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(194, 20);
            this.txtTelefono.TabIndex = 15;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(34, 89);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 14;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(34, 33);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Nombre:";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(114)))), ((int)(((byte)(161)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.ForeColor = System.Drawing.Color.Black;
            this.btnNuevo.Location = new System.Drawing.Point(619, 19);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(0);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 40);
            this.btnNuevo.TabIndex = 11;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.ClienteLista);
            this.tabControl1.Controls.Add(this.clienteDetalle);
            this.tabControl1.Location = new System.Drawing.Point(0, 67);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(732, 371);
            this.tabControl1.TabIndex = 16;
            // 
            // ClienteLista
            // 
            this.ClienteLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(35)))), ((int)(((byte)(66)))));
            this.ClienteLista.Controls.Add(this.lblBuscarCliente);
            this.ClienteLista.Controls.Add(this.btnCerrar);
            this.ClienteLista.Controls.Add(this.btnEliminar);
            this.ClienteLista.Controls.Add(this.btnEditar);
            this.ClienteLista.Controls.Add(this.btnNuevo);
            this.ClienteLista.Controls.Add(this.btnBuscar);
            this.ClienteLista.Controls.Add(this.txtBuscar);
            this.ClienteLista.Controls.Add(this.dgvCliente);
            this.ClienteLista.Location = new System.Drawing.Point(4, 22);
            this.ClienteLista.Name = "ClienteLista";
            this.ClienteLista.Padding = new System.Windows.Forms.Padding(3);
            this.ClienteLista.Size = new System.Drawing.Size(724, 345);
            this.ClienteLista.TabIndex = 0;
            this.ClienteLista.Text = "tabPage1";
            // 
            // lblBuscarCliente
            // 
            this.lblBuscarCliente.AutoSize = true;
            this.lblBuscarCliente.Location = new System.Drawing.Point(7, 7);
            this.lblBuscarCliente.Name = "lblBuscarCliente";
            this.lblBuscarCliente.Size = new System.Drawing.Size(85, 13);
            this.lblBuscarCliente.TabIndex = 15;
            this.lblBuscarCliente.Text = "Buscar Navieras";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.DarkGray;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.Black;
            this.btnCerrar.Location = new System.Drawing.Point(619, 187);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(20, 3, 0, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 40);
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(114)))), ((int)(((byte)(161)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(619, 133);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(20, 3, 20, 0);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 40);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(114)))), ((int)(((byte)(161)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Location = new System.Drawing.Point(619, 74);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(20, 3, 20, 0);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 40);
            this.btnEditar.TabIndex = 14;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.LightBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnBuscar.Location = new System.Drawing.Point(508, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 30);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
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
            // 
            // dgvCliente
            // 
            this.dgvCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.dgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.GridColor = System.Drawing.Color.LightGray;
            this.dgvCliente.Location = new System.Drawing.Point(8, 55);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.RowHeadersVisible = false;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(602, 275);
            this.dgvCliente.TabIndex = 3;
            // 
            // crTextBox1
            // 
            this.crTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.crTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(204)))), ((int)(((byte)(220)))));
            this.crTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.crTextBox1.BorderRadius = 0;
            this.crTextBox1.BorderSize = 2;
            this.crTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crTextBox1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.crTextBox1.Location = new System.Drawing.Point(37, 49);
            this.crTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.crTextBox1.Multiline = false;
            this.crTextBox1.Name = "crTextBox1";
            this.crTextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.crTextBox1.PasswordChar = false;
            this.crTextBox1.Size = new System.Drawing.Size(194, 31);
            this.crTextBox1.TabIndex = 26;
            this.crTextBox1.Texts = "";
            this.crTextBox1.UnderlinedStyle = false;
            // 
            // FrmNaviera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 438);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNaviera";
            this.Text = "FrmNaviera";
            ((System.ComponentModel.ISupportInitialize)(this.erpTipoCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpNombre)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpTelefono)).EndInit();
            this.clienteDetalle.ResumeLayout(false);
            this.clienteDetalle.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ClienteLista.ResumeLayout(false);
            this.ClienteLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider erpTipoCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNaviera;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ClienteLista;
        private System.Windows.Forms.Label lblBuscarCliente;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.TabPage clienteDetalle;
        private CRControls.CRTextBox crTextBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cbxTipoCliente;
        private System.Windows.Forms.Label lblTipoCliente;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ErrorProvider erpNombre;
        private System.Windows.Forms.ErrorProvider erpTelefono;
    }
}