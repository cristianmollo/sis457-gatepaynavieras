using System;
using System.Collections.Generic;

namespace FinalGatePayNavieras.Models;

public partial class Factura
{
    public int Id { get; set; }

    public int IdGateIn { get; set; }

    public string? RutaArchivoPdf { get; set; }

    public DateTime FechaEmision { get; set; }

    public string NumeroFactura { get; set; } = null!;

    public string? UsuarioRegistro { get; set; }

    public DateTime FechaRegistro { get; set; }

    public short Estado { get; set; }

    public virtual GateIn? IdGateInNavigation { get; set; }
}
