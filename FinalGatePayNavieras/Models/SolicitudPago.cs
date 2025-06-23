using System;
using System.Collections.Generic;

namespace FinalGatePayNavieras.Models;

public partial class SolicitudPago
{
    public int Id { get; set; }

    public int IdCliente { get; set; }

    public int IdNaviera { get; set; }

    public string NumeroBl { get; set; } = null!;

    public string? Contenedor { get; set; }

    public decimal MontoEstimado { get; set; }

    public decimal TipoCambio { get; set; }

    public decimal Comision { get; set; }

    public decimal? TotalEnBolivianos { get; set; }

    public string EstadoG { get; set; } = null!;

    public DateTime FechaSolicitud { get; set; }

    public string? UsuarioRegistro { get; set; }

    public DateTime FechaRegistro { get; set; }

    public short Estado { get; set; }

    public virtual Cliente? IdClienteNavigation { get; set; }

    public virtual Naviera? IdNavieraNavigation { get; set; }
}
