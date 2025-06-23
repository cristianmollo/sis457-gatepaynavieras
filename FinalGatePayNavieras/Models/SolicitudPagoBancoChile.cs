using System;
using System.Collections.Generic;

namespace FinalGatePayNavieras.Models;

public partial class SolicitudPagoBancoChile
{
    public int Id { get; set; }

    public int IdCliente { get; set; }

    public string NombreSolicitante { get; set; } = null!;

    public decimal MontoDolares { get; set; }

    public decimal TipoCambio { get; set; }

    public decimal Comision { get; set; }

    public decimal MontoEnBolivianos { get; set; }

    public string EstadoPago { get; set; } = null!;

    public DateTime FechaSolicitud { get; set; }

    public DateTime? FechaPago { get; set; }

    public string? RutaComprobantePago { get; set; }

    public string? Observaciones { get; set; }

    public virtual Cliente? IdClienteNavigation { get; set; }
}
