using System;
using System.Collections.Generic;

namespace FinalGatePayNavieras.Models;

public partial class Historial
{
    public int Id { get; set; }

    public int IdUsuario { get; set; }

    public string Accion { get; set; } = null!;

    public DateTime FechaHora { get; set; }

    public string? UsuarioRegistro { get; set; }

    public DateTime FechaRegistro { get; set; }

    public short Estado { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
