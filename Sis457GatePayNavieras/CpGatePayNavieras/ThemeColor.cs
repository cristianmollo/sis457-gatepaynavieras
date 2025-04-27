using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpGatePayNavieras
{
    public static class ThemeColor
    {
        public static List<string> ColorList = new List<string>() 
        {
            "#3F51B5",
            "#009688",
            "#FF5722",
            "#607D8B",
            "#FF9800",
            "#9C27B0",
            "#2196F3",
            "#EA676C",
            "#E41A4A",
            "#5978BB",
            "#018790",
            "#0E3441",
            "#00B0AD",
            "#721D47",
            "#EA4833",
            "#EF937E",
            "#F37521",
            "#A12059",
            "#126881",
            "#8BC240",
            "#364D5B",
            "#C7DC5B",
            "#0094BC",
            "#E4126B",
            "#43B76E",
            "#7BCFE9",
            "#871C46"
        };

        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;

            double green = color.G;

            double blue = color.B;

            //If correction factor is less than 0, darken color.

            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor; // sirve para que el valor sea negativo
                red *= correctionFactor; // multiplica el valor de rojo por el factor de corrección
                green *= correctionFactor; // multiplica el valor de verde por el factor de corrección
                blue *= correctionFactor;  // multiplica el valor de azul por el factor de corrección
            }
            //If correction factor is greater than zero, lighten color.

            else
            {
                red = (255 - red) * correctionFactor + red; // diferencia entre 255 y el valor de rojo por el factor de corrección
                green = (255 - green) * correctionFactor + green; // diferencia entre 255 y el valor de verde por el factor de corrección
                blue = (255 - blue) * correctionFactor + blue; // diferencia entre 255 y el valor de azul por el factor de corrección
            }

            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);

        }   
    }
}
