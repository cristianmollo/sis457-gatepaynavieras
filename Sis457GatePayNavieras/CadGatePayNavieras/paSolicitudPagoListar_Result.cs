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
    
    public partial class paSolicitudPagoListar_Result
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public int IdNaviera { get; set; }
        public string NombreNaviera { get; set; }
        public string NumeroBL { get; set; }
        public string Contenedor { get; set; }
        public decimal MontoEstimado { get; set; }
        public decimal TipoCambio { get; set; }
        public decimal Comision { get; set; }
        public Nullable<decimal> TotalEnBolivianos { get; set; }
        public string EstadoG { get; set; }
        public System.DateTime FechaSolicitud { get; set; }
    }
}
