using ClnGatePayNavieras;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CadGatePayNavieras;
using CpGatePayNavieras;

namespace CpGatePayNavieras.Forms
{
    public partial class FrmLoginAnimated: Form
    {
        public FrmLoginAnimated()
        {
            InitializeComponent();

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);


        private bool validar()
        {
            bool esValido = true;

            erpUsuario.SetError(crtxtUsuario, "");
            erpClave.SetError(crtxtClave, "");

            if (string.IsNullOrWhiteSpace(crtxtUsuario.Texts) || crtxtUsuario.Texts == "USUARIO")
            {
                erpUsuario.SetError(crtxtUsuario, "El usuario es obligatorio");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(crtxtClave.Texts) || crtxtClave.Texts == "CONTRASEÑA")
            {
                erpClave.SetError(crtxtClave, "La contraseña es obligatoria");
                esValido = false;
            }

            return esValido;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                var usuario = UsuarioCln.Validar(crtxtUsuario.Texts, Util.Encrypt(crtxtClave.Texts));
                if (usuario != null)
                {
                    Util.usuario = usuario;
                    crtxtClave.Clear();
                    crtxtUsuario.Focus();
                    crtxtUsuario.SelectAll();
                    Hide();
                    new FormMainMenu(this).ShowDialog(); // Abre el menú principal
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos", "::: GatePayNavieras :::",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //new FormMainMenu(this).ShowDialog();
        }

        private void crtxtUsuario_Enter(object sender, EventArgs e)
        {
            if (crtxtUsuario.Texts == "USUARIO")
            {
                crtxtUsuario.Texts = "";
                crtxtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void crtxtUsuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(crtxtUsuario.Texts))
            {
                crtxtUsuario.Texts = "USUARIO";
                crtxtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void crtxtClave_Enter(object sender, EventArgs e)
        {
            if (crtxtClave.Texts == "CONTRASEÑA")
            {
                crtxtClave.Texts = "";
                crtxtClave.ForeColor = Color.LightGray;
                //crtxtClave.PasswordChar = false;
            }
        }

        private void crtxtClave_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(crtxtClave.Texts))
            {
                //crtxtClave.PasswordChar = false;
                crtxtClave.Texts = "CONTRASEÑA";
                crtxtClave.ForeColor = Color.DimGray;
            }
        }

        private void FrmLoginAnimated_Load(object sender, EventArgs e)
        {
            crtxtUsuario.Texts = "USUARIO";
            crtxtUsuario.ForeColor = Color.DimGray;

            crtxtClave.Texts = "CONTRASEÑA";
            crtxtClave.ForeColor = Color.DimGray;
            crtxtClave.PasswordChar = false;
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmLoginAnimated_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void crtxtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( e.KeyChar == (char)Keys.Enter)
            {
                button2_Click(sender, e);
            }
        }
    }
}
