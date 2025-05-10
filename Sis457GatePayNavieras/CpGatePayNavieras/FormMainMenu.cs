using CpGatePayNavieras.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpGatePayNavieras
{
    public partial class FormMainMenu: Form
    {
        private Forms.FrmLoginAnimated frmLoginAnimed;
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        //Constructor
        public FormMainMenu( FrmLoginAnimated frmLoginAnimed)
        {
            InitializeComponent();
            this.frmLoginAnimed = frmLoginAnimed;
        }

        //este metodo es cuando le damos play a la aplicacion
        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            random = new Random(); // Inizializa el generador de números aleatorios
            foreach (Control ctrl in panelMenu.Controls)
            {
                if (ctrl is C1.Win.C1Input.C1Button btn)
                {
                    btn.MouseEnter += Button_MouseEnter;
                    btn.MouseLeave += Button_MouseLeave;
                }
            }
        }

        //Methods

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            if (sender is C1.Win.C1Input.C1Button btn && btn != currentButton)
            {
                btn.BackColor = Color.FromArgb(70, 70, 100); // Un tono un poco más claro
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            if (sender is C1.Win.C1Input.C1Button btn && btn != currentButton)
            {
                btn.BackColor = Color.FromArgb(51, 51, 76); // Color original
            }
        }

        private Color SelectThemeColor()
        { 
            int index = random.Next(ThemeColor.ColorList.Count); // Randomly select a color from the list

            // si el color tiene  sera seleccionado. nosotros seleccionamos otra ves para elegir un diferente color
            while (tempIndex == index) // Ensure the same color is not selected consecutively
            {
               index = random.Next(ThemeColor.ColorList.Count); // genera un nuevo número aleatorio
            }
            tempIndex = index; // Store the selected index
            string color = ThemeColor.ColorList[index]; // Obtiene el color de la lista
            return ColorTranslator.FromHtml(color); //Convierte el color string a un color
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                Button clickedButton = (Button)btnSender;

                if (currentButton != clickedButton)
                {
                    DisablerButton();
                    Color color = SelectThemeColor();
                    currentButton = clickedButton;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                    //esto es para que el color de la barra de arriba cambie
                    panelTitle.BackColor = color; // Cambia el color de fondo del panel superior
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3); // Cambia el color de fondo del panel de logo
                    //panelLogo.BackColor = color; // Cambia el color de fondo del panel de logo 
                }
            }
        }

        private void DisablerButton()
        {
            //MessageBox.Show("DisablerButton fue llamado"); // Debug temporal
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn is C1.Win.C1Input.C1Button btn)
                { 
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76); // Cambia el color de fondo del botón
                    previousBtn.ForeColor = Color.Gainsboro; // Cambia el color de texto del botón
                    previousBtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))); // Cambia la fuente del botón

                    previousBtn.Invalidate();  // Forzar redibujado
                    previousBtn.Refresh();
                }
            }
        }

        // Método para abrir formularios hijos en el panel
        private void OpenChildForm(Form childForm, object btnSender)
        {
            // Verifica si hay un formulario activo y lo cierra si es necesario
            if (activeForm != null && activeForm != childForm)
            {
                activeForm.Close(); // Cierra el formulario activo
            }

            // Activa el botón correspondiente
            ActivateButton(btnSender);

            // Asigna el nuevo formulario activo
            activeForm = childForm;

            // Establece las propiedades del formulario hijo
            childForm.TopLevel = false; // El formulario es un hijo
            childForm.FormBorderStyle = FormBorderStyle.None; // Elimina el borde del formulario
            childForm.Dock = DockStyle.Fill; // Ajusta el formulario al panel
            this.panelDesktop.Controls.Add(childForm); // Agrega el formulario al panel desktop
            this.panelDesktop.Tag = childForm; // Asigna el formulario al panel

            // Lleva el formulario al frente
            childForm.BringToFront();

            // Muestra el formulario
            childForm.Show();

            // Cambia el texto del título superior por el título del formulario hijo
            lblTitle.Text = childForm.Text;
        }

        // Evento para el botón Clientes
        private void btnClientes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FrmCliente(), sender);
        }


        private void btnNavieras_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            OpenChildForm(new Forms.FrmNaviera(), sender);
        }

        private void btnSolictudPago_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            OpenChildForm(new Forms.FrmSolicitudPago(), sender);
        }

        private void btnGateIn_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            OpenChildForm(new Forms.FrmGateIn(), sender);
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            OpenChildForm(new Forms.FrmFactura(), sender);
        }

        private void btnSolicitudPagoBanco_Click(object sender, EventArgs e)
        {            
            //ActivateButton(sender);
            OpenChildForm(new Forms.FrmSolictudPagoBancoChile(), sender);
        }

        private void FormMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmLoginAnimed.Show(); // Muestra el formulario de inicio de sesión al cerrar el menú principal
        }
    }
}
