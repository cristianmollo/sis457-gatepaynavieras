using CadGatePayNavieras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnGatePayNavieras
{
    public class GateInCln
    {
        public static int Insertar(GateIn gatein) // el Gatein es el objeto que se va insertar a la base de datos
        {
            using (var context = new LabGatePayNavierasEntities())
            {
                context.GateIn.Add(gatein); // Agrega el objeto GateIn al contexto
                context.SaveChanges(); // Guarda los cambios en la base de datos
                return gatein.Id; // Devuelve el Id del GateIn insertado
            }
        }

        public static List<object> ListarVista()
        {
            using (var context = new LabGatePayNavierasEntities())
            {
                return context.GateIn
                    .Include("Cliente")
                    .Include("Naviera")
                    .Include("Usuario")
                    .Where(g => g.estado != -1)
                    .OrderByDescending(g => g.FechaPago)
                    .Select(g => new
                    {
                        g.Id,
                        Cliente = g.Cliente.Nombre,
                        Naviera = g.Naviera.Nombre,
                        g.NumeroBL,
                        g.Contenedor,
                        g.MontoPago,
                        g.MetodoPago,
                        g.FechaPago,
                        Usuario = g.Usuario.NombreUsuario
                    })
                    .ToList<object>();
            }
        }

    }
}
