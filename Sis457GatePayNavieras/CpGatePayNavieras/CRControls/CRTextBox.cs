using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace CpGatePayNavieras.CRControls
{
    [DefaultEvent("TextChanged")]
    public partial class CRTextBox: UserControl
    {
        //Fields
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underlinedStyle = false;
        private Color borderFocusColor = Color.DodgerBlue; // Azul claro, elegante
        private bool isFocused = false;

        //redondeados
        private int borderRadius = 0;

        //Constructor
        public CRTextBox()
        {
            InitializeComponent();
            // Estas líneas nuevas:
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        //Eventos predeterminados al cuadro de texto
        public event EventHandler _TextChanged;

        //sirve para el color del borde
        [Category("CR Personalizada")]
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }

            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        //sirve para el tamano del borde
        [Category("CR Personalizada")]
        public int BorderSize 
        { 
            get
            {
                return borderSize;
            }

            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        //sirve para el estilo de la caja
        [Category("CR Personalizada")]
        public bool UnderlinedStyle 
        { 
            get
            {
                return underlinedStyle;
            }

            set
            {
                underlinedStyle = value;
                this.Invalidate();
            }
        }

        //vamos a ser para password
        [Category("CR Personalizada")]
        public bool PasswordChar
        {
            get
            {
                return textBox1.UseSystemPasswordChar;
            }
            set
            {
                textBox1.UseSystemPasswordChar = value;
            }
        }
        //sirve para multilineas
        [Category("CR Personalizada")]
        public bool Multiline
        {
            get
            {
                return textBox1.Multiline;
            }
            set
            {
                textBox1.Multiline = value;
            }
        }

        [Category("CR Personalizada")]
        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                base.BackColor = value;
                textBox1.BackColor = value; // 🔥 También cambiamos el fondo del textbox
                this.Invalidate(); // 🔥 Forzar redibujar
            }
        }
        //color de texto
        [Category("CR Personalizada")]
        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }

        //sirve para el tamano de la fuente
        [Category("CR Personalizada")]
        public override Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (this.DesignMode) // Update the height of the control when the font changes in design mode
                    UpdateControlHeight();
            }
        }

        //sirve para el texto
        [Category("CR Personalizada")]
        public  string Texts
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }

        //sirve para que el textbox tenga el foco
        [Category("CR Personalizada")]
        public Color BorderFocusColor 
        {
            get => borderFocusColor;
            set
            {
                borderFocusColor = value;
                this.Invalidate(); // <-- Forzar repintado
            }
        }

        [Category("CR Personalizada")]
        public int BorderRadius
        {
            get
            {
                return borderRadius;
            }
            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }



        //PODEMO SEGUIR AUMENTANDO MAS PROPIEDADES 
        //***************


        //Overridden methods
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            //redondeados
            if (borderRadius > 1)
            {
                //field 
                var rectBorderSmooth = this.ClientRectangle;
                var recBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
                int smoothSize = borderSize > 0 ? borderSize : 1;

                using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius))

                using (GraphicsPath pathBorder = GetFigurePath(recBorder, borderRadius - borderSize))

                using (Pen penBorderSmooth = new Pen(this.Parent.BackColor,smoothSize))

                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(pathBorderSmooth);
                    if (borderRadius > 15) SetTextBoxRoundedRegion(); // 🔥 Redondear el textbox
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
                    if (isFocused) penBorder.Color = borderFocusColor;

                    if (underlinedStyle) // Line style
                    {
                        //Draw border smoothing
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        //Draw border
                        graph.SmoothingMode = SmoothingMode.None;
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else // Normal style
                    {
                        //Draw border smoothing
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        //Draw border
                        graph.DrawPath(penBorder, pathBorder);
                    }
                }


            }
            else //square/normal
            {
                // Primero pintamos el fondo
                using (SolidBrush brush = new SolidBrush(this.BackColor))
                {
                    graph.FillRectangle(brush, this.ClientRectangle);
                }

                // Luego dibujamos el borde
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(this.ClientRectangle);
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                    if (!isFocused)
                    {
                        if (underlinedStyle) // Line style
                        {
                            graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                        }
                        else // Normal style
                        {
                            graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                        }
                    }
                    else
                    {
                        penBorder.Color = borderFocusColor;
                        if (underlinedStyle) // Line style
                        {
                            graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                        }
                        else // Normal style
                        {
                            graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                        }
                    }

                }
            }
        }

        private void SetTextBoxRoundedRegion()
        {
            GraphicsPath pathTxt;
            if (Multiline)
            {
                pathTxt = GetFigurePath(textBox1.ClientRectangle, borderRadius - borderSize);
                textBox1.Region = new Region(pathTxt);
            }
            else
            {
                pathTxt = GetFigurePath(textBox1.ClientRectangle, borderRadius*2);
                textBox1.Region = new Region(pathTxt);
            }
        }

        //crear una ruta de graficos para crear el control con esquinas redondeadas
        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }


        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode) 
                UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        //private methods
        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            { 
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        //desde aqui son los eventos del textbox
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
            {
                _TextChanged.Invoke(sender, e);
            }
        }


        //evento click sive para cuando el mouse da click en el textbox
        private void textBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        //evento MouseEnter sive para cuando el mouse entra al textbox
        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        //evento MouseLeave sive para cuando el mouse sale del textbox
        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        //evento KeyDown sive para cuando el teclado da click en el textbox
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        //este evento sirve para cuando el textbox tiene el foco
        private void textBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
        }

        // este evento sirve para cuando el textbox pierde el foco
        private void textBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
        }

        // este evento sirve cuando hayque limpiar el textbox
        public void Clear()
        {
            this.Texts = string.Empty;
        }


        // 🔽 NUEVO MÉTODO AQUÍ
        public void SelectAll()
        {
            textBox1.SelectAll();
        }
        //PODEMOS VINCULAR MAS EVENTOS PORQUE CON LOS EVENTOS CLASICO NO FUNCIONARIA EN NUESTRA PEERSONALZIACION
    }
}
