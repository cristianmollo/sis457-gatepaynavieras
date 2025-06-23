using System;
using System.Collections.Generic;

namespace FinalGatePayNavieras.Models;

public partial class Naviera
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Urlportal { get; set; }

    public string? UsuarioRegistro { get; set; }

    public DateTime FechaRegistro { get; set; }

    public short Estado { get; set; }

    public virtual ICollection<GateIn> GateIns { get; set; } = new List<GateIn>();

    public virtual ICollection<SolicitudPago> SolicitudPagos { get; set; } = new List<SolicitudPago>();
}
