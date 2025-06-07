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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblFechaPago = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.cbxMetodoPago = new System.Windows.Forms.ComboBox();
            this.lblMetodoPago = new System.Windows.Forms.Label();
            this.pnlMontoPago = new System.Windows.Forms.Panel();
            this.nudMontoPagar = new System.Windows.Forms.NumericUpDown();
            this.lblMontoPago = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlNaviera = new System.Windows.Forms.Panel();
            this.cbxNaviera = new System.Windows.Forms.ComboBox();
            this.pnlBL = new System.Windows.Forms.Panel();
            this.txtNumeroB_L = new System.Windows.Forms.TextBox();
            this.pnlCont = new System.Windows.Forms.Panel();
            this.txtContenedor = new System.Windows.Forms.TextBox();
            this.pnlCliente = new System.Windows.Forms.Panel();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.lblMetodo = new System.Windows.Forms.Label();
            this.erpCliente = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpNaviera = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpNumBL = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpContenedor = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpMontoPagar = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpMetodoPago = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGateIn)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.pnlMontoPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMontoPagar)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlNaviera.SuspendLayout();
            this.pnlBL.SuspendLayout();
            this.pnlCont.SuspendLayout();
            this.pnlCliente.SuspendLayout();
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
            this.dgvGateIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGateIn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvGateIn.Location = new System.Drawing.Point(0, 264);
            this.dgvGateIn.Name = "dgvGateIn";
            this.dgvGateIn.Size = new System.Drawing.Size(716, 135);
            this.dgvGateIn.TabIndex = 51;
            // 
            // lblRegistroGatein
            // 
            this.lblRegistroGatein.AutoSize = true;
            this.lblRegistroGatein.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroGatein.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.lblRegistroGatein.Location = new System.Drawing.Point(13, 8);
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
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(45, 12);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(45, 15);
            this.lblCliente.TabIndex = 42;
            this.lblCliente.Text = "Cliente";
            // 
            // btnRegistroGateIn
            // 
            this.btnRegistroGateIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistroGateIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(156)))), ((int)(((byte)(65)))));
            this.btnRegistroGateIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroGateIn.Location = new System.Drawing.Point(587, 1);
            this.btnRegistroGateIn.Name = "btnRegistroGateIn";
            this.btnRegistroGateIn.Size = new System.Drawing.Size(129, 44);
            this.btnRegistroGateIn.TabIndex = 40;
            this.btnRegistroGateIn.Text = "Registrar Gate In";
            this.btnRegistroGateIn.UseVisualStyleBackColor = false;
            this.btnRegistroGateIn.Click += new System.EventHandler(this.btnRegistroGateIn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(87)))), ((int)(((byte)(126)))));
            this.panel1.Controls.Add(this.lblRegistroGatein);
            this.panel1.Location = new System.Drawing.Point(59, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 31);
            this.panel1.TabIndex = 52;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(87)))), ((int)(((byte)(126)))));
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Controls.Add(this.lblMetodo);
            this.panel2.Location = new System.Drawing.Point(24, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(680, 226);
            this.panel2.TabIndex = 53;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 228F));
            this.tableLayoutPanel2.Controls.Add(this.panel9, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel8, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.pnlMontoPago, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 161);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(680, 65);
            this.tableLayoutPanel2.TabIndex = 59;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panel9.Controls.Add(this.dateTimePicker1);
            this.panel9.Controls.Add(this.lblFechaPago);
            this.panel9.Location = new System.Drawing.Point(455, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(211, 59);
            this.panel9.TabIndex = 56;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(205, 20);
            this.dateTimePicker1.TabIndex = 43;
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
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panel8.Controls.Add(this.cbxMetodoPago);
            this.panel8.Controls.Add(this.lblMetodoPago);
            this.panel8.Location = new System.Drawing.Point(229, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(153, 59);
            this.panel8.TabIndex = 56;
            // 
            // cbxMetodoPago
            // 
            this.cbxMetodoPago.FormattingEnabled = true;
            this.cbxMetodoPago.Items.AddRange(new object[] {
            "Efectivo",
            "Transferencia"});
            this.cbxMetodoPago.Location = new System.Drawing.Point(25, 29);
            this.cbxMetodoPago.Name = "cbxMetodoPago";
            this.cbxMetodoPago.Size = new System.Drawing.Size(106, 21);
            this.cbxMetodoPago.TabIndex = 44;
            // 
            // lblMetodoPago
            // 
            this.lblMetodoPago.AutoSize = true;
            this.lblMetodoPago.Location = new System.Drawing.Point(22, 12);
            this.lblMetodoPago.Name = "lblMetodoPago";
            this.lblMetodoPago.Size = new System.Drawing.Size(86, 13);
            this.lblMetodoPago.TabIndex = 42;
            this.lblMetodoPago.Text = "Metodo de Pago";
            // 
            // pnlMontoPago
            // 
            this.pnlMontoPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.pnlMontoPago.Controls.Add(this.nudMontoPagar);
            this.pnlMontoPago.Controls.Add(this.lblMontoPago);
            this.pnlMontoPago.Location = new System.Drawing.Point(3, 3);
            this.pnlMontoPago.Name = "pnlMontoPago";
            this.pnlMontoPago.Size = new System.Drawing.Size(149, 59);
            this.pnlMontoPago.TabIndex = 55;
            // 
            // nudMontoPagar
            // 
            this.nudMontoPagar.Location = new System.Drawing.Point(48, 30);
            this.nudMontoPagar.Name = "nudMontoPagar";
            this.nudMontoPagar.Size = new System.Drawing.Size(98, 20);
            this.nudMontoPagar.TabIndex = 43;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pnlNaviera, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlBL, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlCont, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlCliente, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(680, 137);
            this.tableLayoutPanel1.TabIndex = 58;
            // 
            // pnlNaviera
            // 
            this.pnlNaviera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlNaviera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.pnlNaviera.Controls.Add(this.cbxNaviera);
            this.pnlNaviera.Controls.Add(this.lblNaviera);
            this.pnlNaviera.Location = new System.Drawing.Point(343, 3);
            this.pnlNaviera.Name = "pnlNaviera";
            this.pnlNaviera.Size = new System.Drawing.Size(193, 62);
            this.pnlNaviera.TabIndex = 55;
            // 
            // cbxNaviera
            // 
            this.cbxNaviera.FormattingEnabled = true;
            this.cbxNaviera.Location = new System.Drawing.Point(47, 28);
            this.cbxNaviera.Name = "cbxNaviera";
            this.cbxNaviera.Size = new System.Drawing.Size(121, 21);
            this.cbxNaviera.TabIndex = 44;
            // 
            // pnlBL
            // 
            this.pnlBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.pnlBL.Controls.Add(this.txtNumeroB_L);
            this.pnlBL.Controls.Add(this.lblNumBL);
            this.pnlBL.Location = new System.Drawing.Point(144, 72);
            this.pnlBL.Name = "pnlBL";
            this.pnlBL.Size = new System.Drawing.Size(193, 62);
            this.pnlBL.TabIndex = 55;
            // 
            // txtNumeroB_L
            // 
            this.txtNumeroB_L.Location = new System.Drawing.Point(52, 31);
            this.txtNumeroB_L.Name = "txtNumeroB_L";
            this.txtNumeroB_L.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroB_L.TabIndex = 47;
            // 
            // pnlCont
            // 
            this.pnlCont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlCont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.pnlCont.Controls.Add(this.txtContenedor);
            this.pnlCont.Controls.Add(this.lblContenendor);
            this.pnlCont.Location = new System.Drawing.Point(343, 72);
            this.pnlCont.Name = "pnlCont";
            this.pnlCont.Size = new System.Drawing.Size(193, 62);
            this.pnlCont.TabIndex = 56;
            // 
            // txtContenedor
            // 
            this.txtContenedor.Location = new System.Drawing.Point(47, 31);
            this.txtContenedor.Name = "txtContenedor";
            this.txtContenedor.Size = new System.Drawing.Size(100, 20);
            this.txtContenedor.TabIndex = 48;
            // 
            // pnlCliente
            // 
            this.pnlCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.pnlCliente.Controls.Add(this.cbxCliente);
            this.pnlCliente.Controls.Add(this.lblCliente);
            this.pnlCliente.Location = new System.Drawing.Point(144, 3);
            this.pnlCliente.Name = "pnlCliente";
            this.pnlCliente.Size = new System.Drawing.Size(193, 62);
            this.pnlCliente.TabIndex = 54;
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
            // lblMetodo
            // 
            this.lblMetodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMetodo.AutoSize = true;
            this.lblMetodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.lblMetodo.Location = new System.Drawing.Point(3, 145);
            this.lblMetodo.Name = "lblMetodo";
            this.lblMetodo.Size = new System.Drawing.Size(118, 18);
            this.lblMetodo.TabIndex = 57;
            this.lblMetodo.Text = "Modo de Pago";
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(132)))), ((int)(((byte)(162)))));
            this.ClientSize = new System.Drawing.Size(716, 399);
            this.Controls.Add(this.btnRegistroGateIn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvGateIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmGateIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gate In";
            this.Load += new System.EventHandler(this.FrmGateIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGateIn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.pnlMontoPago.ResumeLayout(false);
            this.pnlMontoPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMontoPagar)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlNaviera.ResumeLayout(false);
            this.pnlNaviera.PerformLayout();
            this.pnlBL.ResumeLayout(false);
            this.pnlBL.PerformLayout();
            this.pnlCont.ResumeLayout(false);
            this.pnlCont.PerformLayout();
            this.pnlCliente.ResumeLayout(false);
            this.pnlCliente.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}