namespace CpGatePayNavieras.Forms
{
    partial class FrmGateIn
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
            this.dgvGateIn = new System.Windows.Forms.DataGridView();
            this.lblRegistroGatein = new System.Windows.Forms.Label();
            this.lblContenendor = new System.Windows.Forms.Label();
            this.lblNumBL = new System.Windows.Forms.Label();
            this.lblNaviera = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnRegistroGateIn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlCliente = new System.Windows.Forms.Panel();
            this.pnlBL = new System.Windows.Forms.Panel();
            this.pnlNaviera = new System.Windows.Forms.Panel();
            this.pnlCont = new System.Windows.Forms.Panel();
            this.pnlMontoPago = new System.Windows.Forms.Panel();
            this.lblMontoPago = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblMetodoPago = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblFechaPago = new System.Windows.Forms.Label();
            this.lblMetodo = new System.Windows.Forms.Label();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.cbxNaviera = new System.Windows.Forms.ComboBox();
            this.txtNumeroB_L = new System.Windows.Forms.TextBox();
            this.txtContenedor = new System.Windows.Forms.TextBox();
            this.nudMontoPagar = new System.Windows.Forms.NumericUpDown();
            this.cbxMetodoPago = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.erpCliente = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpNaviera = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpNumBL = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpContenedor = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpMontoPagar = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpMetodoPago = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGateIn)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlCliente.SuspendLayout();
            this.pnlBL.SuspendLayout();
            this.pnlNaviera.SuspendLayout();
            this.pnlCont.SuspendLayout();
            this.pnlMontoPago.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMontoPagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpNaviera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpNumBL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpContenedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpMontoPagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpMetodoPago)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGateIn
            // 
            this.dgvGateIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGateIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGateIn.Location = new System.Drawing.Point(32, 314);
            this.dgvGateIn.Name = "dgvGateIn";
            this.dgvGateIn.Size = new System.Drawing.Size(651, 151);
            this.dgvGateIn.TabIndex = 51;
            // 
            // lblRegistroGatein
            // 
            this.lblRegistroGatein.AutoSize = true;
            this.lblRegistroGatein.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroGatein.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.lblRegistroGatein.Location = new System.Drawing.Point(16, 11);
            this.lblRegistroGatein.Name = "lblRegistroGatein";
            this.lblRegistroGatein.Size = new System.Drawing.Size(145, 20);
            this.lblRegistroGatein.TabIndex = 50;
            this.lblRegistroGatein.Text = "Registro de GateIn";
            // 
            // lblContenendor
            // 
            this.lblContenendor.AutoSize = true;
            this.lblContenendor.Location = new System.Drawing.Point(44, 15);
            this.lblContenendor.Name = "lblContenendor";
            this.lblContenendor.Size = new System.Drawing.Size(62, 13);
            this.lblContenendor.TabIndex = 48;
            this.lblContenendor.Text = "Contenedor";
            // 
            // lblNumBL
            // 
            this.lblNumBL.AutoSize = true;
            this.lblNumBL.Location = new System.Drawing.Point(49, 15);
            this.lblNumBL.Name = "lblNumBL";
            this.lblNumBL.Size = new System.Drawing.Size(65, 13);
            this.lblNumBL.TabIndex = 46;
            this.lblNumBL.Text = "Numero B/L";
            // 
            // lblNaviera
            // 
            this.lblNaviera.AutoSize = true;
            this.lblNaviera.Location = new System.Drawing.Point(44, 12);
            this.lblNaviera.Name = "lblNaviera";
            this.lblNaviera.Size = new System.Drawing.Size(44, 13);
            this.lblNaviera.TabIndex = 44;
            this.lblNaviera.Text = "Naviera";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(45, 12);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 42;
            this.lblCliente.Text = "Cliente";
            // 
            // btnRegistroGateIn
            // 
            this.btnRegistroGateIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistroGateIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(156)))), ((int)(((byte)(65)))));
            this.btnRegistroGateIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroGateIn.Location = new System.Drawing.Point(273, 154);
            this.btnRegistroGateIn.Name = "btnRegistroGateIn";
            this.btnRegistroGateIn.Size = new System.Drawing.Size(112, 36);
            this.btnRegistroGateIn.TabIndex = 40;
            this.btnRegistroGateIn.Text = "Registrar Gate In";
            this.btnRegistroGateIn.UseVisualStyleBackColor = false;
            this.btnRegistroGateIn.Click += new System.EventHandler(this.btnRegistroGateIn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(87)))), ((int)(((byte)(126)))));
            this.panel1.Controls.Add(this.lblRegistroGatein);
            this.panel1.Location = new System.Drawing.Point(116, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 44);
            this.panel1.TabIndex = 52;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(87)))), ((int)(((byte)(126)))));
            this.panel2.Controls.Add(this.lblMetodo);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.pnlMontoPago);
            this.panel2.Controls.Add(this.pnlCont);
            this.panel2.Controls.Add(this.pnlBL);
            this.panel2.Controls.Add(this.pnlNaviera);
            this.panel2.Controls.Add(this.pnlCliente);
            this.panel2.Controls.Add(this.btnRegistroGateIn);
            this.panel2.Location = new System.Drawing.Point(32, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(651, 272);
            this.panel2.TabIndex = 53;
            // 
            // pnlCliente
            // 
            this.pnlCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.pnlCliente.Controls.Add(this.cbxCliente);
            this.pnlCliente.Controls.Add(this.lblCliente);
            this.pnlCliente.Location = new System.Drawing.Point(104, 16);
            this.pnlCliente.Name = "pnlCliente";
            this.pnlCliente.Size = new System.Drawing.Size(193, 62);
            this.pnlCliente.TabIndex = 54;
            // 
            // pnlBL
            // 
            this.pnlBL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.pnlBL.Controls.Add(this.txtNumeroB_L);
            this.pnlBL.Controls.Add(this.lblNumBL);
            this.pnlBL.Location = new System.Drawing.Point(104, 86);
            this.pnlBL.Name = "pnlBL";
            this.pnlBL.Size = new System.Drawing.Size(193, 62);
            this.pnlBL.TabIndex = 55;
            // 
            // pnlNaviera
            // 
            this.pnlNaviera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.pnlNaviera.Controls.Add(this.cbxNaviera);
            this.pnlNaviera.Controls.Add(this.lblNaviera);
            this.pnlNaviera.Location = new System.Drawing.Point(348, 16);
            this.pnlNaviera.Name = "pnlNaviera";
            this.pnlNaviera.Size = new System.Drawing.Size(193, 62);
            this.pnlNaviera.TabIndex = 55;
            // 
            // pnlCont
            // 
            this.pnlCont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.pnlCont.Controls.Add(this.txtContenedor);
            this.pnlCont.Controls.Add(this.lblContenendor);
            this.pnlCont.Location = new System.Drawing.Point(348, 86);
            this.pnlCont.Name = "pnlCont";
            this.pnlCont.Size = new System.Drawing.Size(193, 62);
            this.pnlCont.TabIndex = 56;
            // 
            // pnlMontoPago
            // 
            this.pnlMontoPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.pnlMontoPago.Controls.Add(this.nudMontoPagar);
            this.pnlMontoPago.Controls.Add(this.lblMontoPago);
            this.pnlMontoPago.Location = new System.Drawing.Point(16, 207);
            this.pnlMontoPago.Name = "pnlMontoPago";
            this.pnlMontoPago.Size = new System.Drawing.Size(149, 62);
            this.pnlMontoPago.TabIndex = 55;
            // 
            // lblMontoPago
            // 
            this.lblMontoPago.AutoSize = true;
            this.lblMontoPago.Location = new System.Drawing.Point(46, 12);
            this.lblMontoPago.Name = "lblMontoPago";
            this.lblMontoPago.Size = new System.Drawing.Size(77, 13);
            this.lblMontoPago.TabIndex = 42;
            this.lblMontoPago.Text = "Monto a Pagar";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panel8.Controls.Add(this.cbxMetodoPago);
            this.panel8.Controls.Add(this.lblMetodoPago);
            this.panel8.Location = new System.Drawing.Point(191, 207);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(194, 62);
            this.panel8.TabIndex = 56;
            // 
            // lblMetodoPago
            // 
            this.lblMetodoPago.AutoSize = true;
            this.lblMetodoPago.Location = new System.Drawing.Point(57, 12);
            this.lblMetodoPago.Name = "lblMetodoPago";
            this.lblMetodoPago.Size = new System.Drawing.Size(86, 13);
            this.lblMetodoPago.TabIndex = 42;
            this.lblMetodoPago.Text = "Metodo de Pago";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panel9.Controls.Add(this.dateTimePicker1);
            this.panel9.Controls.Add(this.lblFechaPago);
            this.panel9.Location = new System.Drawing.Point(411, 207);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(211, 62);
            this.panel9.TabIndex = 56;
            // 
            // lblFechaPago
            // 
            this.lblFechaPago.AutoSize = true;
            this.lblFechaPago.Location = new System.Drawing.Point(3, 12);
            this.lblFechaPago.Name = "lblFechaPago";
            this.lblFechaPago.Size = new System.Drawing.Size(80, 13);
            this.lblFechaPago.TabIndex = 42;
            this.lblFechaPago.Text = "Fecha de Pago";
            // 
            // lblMetodo
            // 
            this.lblMetodo.AutoSize = true;
            this.lblMetodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.lblMetodo.Location = new System.Drawing.Point(35, 188);
            this.lblMetodo.Name = "lblMetodo";
            this.lblMetodo.Size = new System.Drawing.Size(77, 13);
            this.lblMetodo.TabIndex = 57;
            this.lblMetodo.Text = "Modo de Pago";
            // 
            // cbxCliente
            // 
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(48, 28);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(121, 21);
            this.cbxCliente.TabIndex = 43;
            this.cbxCliente.SelectedIndexChanged += new System.EventHandler(this.cbxCliente_SelectedIndexChanged);
            // 
            // cbxNaviera
            // 
            this.cbxNaviera.FormattingEnabled = true;
            this.cbxNaviera.Location = new System.Drawing.Point(47, 28);
            this.cbxNaviera.Name = "cbxNaviera";
            this.cbxNaviera.Size = new System.Drawing.Size(121, 21);
            this.cbxNaviera.TabIndex = 44;
            // 
            // txtNumeroB_L
            // 
            this.txtNumeroB_L.Location = new System.Drawing.Point(52, 31);
            this.txtNumeroB_L.Name = "txtNumeroB_L";
            this.txtNumeroB_L.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroB_L.TabIndex = 47;
            // 
            // txtContenedor
            // 
            this.txtContenedor.Location = new System.Drawing.Point(47, 31);
            this.txtContenedor.Name = "txtContenedor";
            this.txtContenedor.Size = new System.Drawing.Size(100, 20);
            this.txtContenedor.TabIndex = 48;
            // 
            // nudMontoPagar
            // 
            this.nudMontoPagar.Location = new System.Drawing.Point(48, 30);
            this.nudMontoPagar.Name = "nudMontoPagar";
            this.nudMontoPagar.Size = new System.Drawing.Size(98, 20);
            this.nudMontoPagar.TabIndex = 43;
            // 
            // cbxMetodoPago
            // 
            this.cbxMetodoPago.FormattingEnabled = true;
            this.cbxMetodoPago.Items.AddRange(new object[] {
            "Efectivo",
            "Transferencia"});
            this.cbxMetodoPago.Location = new System.Drawing.Point(60, 29);
            this.cbxMetodoPago.Name = "cbxMetodoPago";
            this.cbxMetodoPago.Size = new System.Drawing.Size(106, 21);
            this.cbxMetodoPago.TabIndex = 44;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(205, 20);
            this.dateTimePicker1.TabIndex = 43;
            // 
            // erpCliente
            // 
            this.erpCliente.ContainerControl = this;
            // 
            // erpNaviera
            // 
            this.erpNaviera.ContainerControl = this;
            // 
            // erpNumBL
            // 
            this.erpNumBL.ContainerControl = this;
            // 
            // erpContenedor
            // 
            this.erpContenedor.ContainerControl = this;
            // 
            // erpMontoPagar
            // 
            this.erpMontoPagar.ContainerControl = this;
            // 
            // erpMetodoPago
            // 
            this.erpMetodoPago.ContainerControl = this;
            // 
            // FrmGateIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 477);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvGateIn);
            this.Name = "FrmGateIn";
            this.Text = "FrmGateIn";
            this.Load += new System.EventHandler(this.FrmGateIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGateIn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlCliente.ResumeLayout(false);
            this.pnlCliente.PerformLayout();
            this.pnlBL.ResumeLayout(false);
            this.pnlBL.PerformLayout();
            this.pnlNaviera.ResumeLayout(false);
            this.pnlNaviera.PerformLayout();
            this.pnlCont.ResumeLayout(false);
            this.pnlCont.PerformLayout();
            this.pnlMontoPago.ResumeLayout(false);
            this.pnlMontoPago.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMontoPagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpNaviera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpNumBL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpContenedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpMontoPagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpMetodoPago)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGateIn;
        private System.Windows.Forms.Label lblRegistroGatein;
        private System.Windows.Forms.Label lblContenendor;
        private System.Windows.Forms.Label lblNumBL;
        private System.Windows.Forms.Label lblNaviera;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnRegistroGateIn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlCliente;
        private System.Windows.Forms.Panel pnlCont;
        private System.Windows.Forms.Panel pnlBL;
        private System.Windows.Forms.Panel pnlNaviera;
        private System.Windows.Forms.Label lblMetodo;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblFechaPago;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblMetodoPago;
        private System.Windows.Forms.Panel pnlMontoPago;
        private System.Windows.Forms.Label lblMontoPago;
        private System.Windows.Forms.ComboBox cbxNaviera;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.TextBox txtContenedor;
        private System.Windows.Forms.TextBox txtNumeroB_L;
        private System.Windows.Forms.NumericUpDown nudMontoPagar;
        private System.Windows.Forms.ComboBox cbxMetodoPago;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ErrorProvider erpCliente;
        private System.Windows.Forms.ErrorProvider erpNaviera;
        private System.Windows.Forms.ErrorProvider erpNumBL;
        private System.Windows.Forms.ErrorProvider erpContenedor;
        private System.Windows.Forms.ErrorProvider erpMontoPagar;
        private System.Windows.Forms.ErrorProvider erpMetodoPago;
    }
}