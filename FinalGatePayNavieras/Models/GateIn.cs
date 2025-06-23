using System;
using System.Collections.Generic;

namespace FinalGatePayNavieras.Models;

public partial class GateIn
{
    public int Id { get; set; }

    public int IdCliente { get; set; }

    public int IdNaviera { get; set; }

    public string NumeroBl { get; set; } = null!;

    public string Contenedor { get; set; } = null!;

    public decimal MontoPago { get; set; }

    public string MetodoPago { get; set; } = null!;

    public DateTime FechaPago { get; set; }

    public int IdUsuario { get; set; }

    public string? UsuarioRegistro { get; set; }

    public DateTime FechaRegistro { get; set; }

    public short Estado { get; set; }

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual Cliente? IdClienteNavigation { get; set; }

    public virtual Naviera? IdNavieraNavigation { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
