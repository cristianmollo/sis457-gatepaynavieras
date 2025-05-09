//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CadGatePayNavieras
{
    using System;
    using System.Collections.Generic;
    
    public partial class GateIn
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GateIn()
        {
            this.Factura = new HashSet<Factura>();
        }
    
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public int IdNaviera { get; set; }
        public string NumeroBL { get; set; }
        public string Contenedor { get; set; }
        public decimal MontoPago { get; set; }
        public string MetodoPago { get; set; }
        public System.DateTime FechaPago { get; set; }
        public int IdUsuario { get; set; }
        public string usuarioRegistro { get; set; }
        public System.DateTime fechaRegistro { get; set; }
        public short estado { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Factura> Factura { get; set; }
        public virtual Naviera Naviera { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
