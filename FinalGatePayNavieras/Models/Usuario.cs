using System;
using System.Collections.Generic;

namespace FinalGatePayNavieras.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string NombreUsuario { get; set; } = null!;

    public string Contrasena { get; set; } = null!;

    public string Rol { get; set; } = null!;

    public string? UsuarioRegistro { get; set; }

    public DateTime FechaRegistro { get; set; }

    public short Estado { get; set; }

    public virtual ICollection<GateIn> GateIns { get; set; } = new List<GateIn>();

    public virtual ICollection<Historial> Historials { get; set; } = new List<Historial>();
}
