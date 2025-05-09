﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class LabGatePayNavierasEntities : DbContext
    {
        public LabGatePayNavierasEntities()
            : base("name=LabGatePayNavierasEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Factura> Factura { get; set; }
        public virtual DbSet<GateIn> GateIn { get; set; }
        public virtual DbSet<Naviera> Naviera { get; set; }
        public virtual DbSet<SolicitudPago> SolicitudPago { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
    
        public virtual ObjectResult<paClienteListar_Result> paClienteListar(string parametro)
        {
            var parametroParameter = parametro != null ?
                new ObjectParameter("parametro", parametro) :
                new ObjectParameter("parametro", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<paClienteListar_Result>("paClienteListar", parametroParameter);
        }
    
        public virtual ObjectResult<paGateInListar_Result> paGateInListar(string parametro)
        {
            var parametroParameter = parametro != null ?
                new ObjectParameter("parametro", parametro) :
                new ObjectParameter("parametro", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<paGateInListar_Result>("paGateInListar", parametroParameter);
        }
    
        public virtual ObjectResult<paNavieraListar_Result> paNavieraListar(string parametro)
        {
            var parametroParameter = parametro != null ?
                new ObjectParameter("parametro", parametro) :
                new ObjectParameter("parametro", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<paNavieraListar_Result>("paNavieraListar", parametroParameter);
        }
    
        public virtual ObjectResult<paSolicitudPagoListar_Result> paSolicitudPagoListar(string parametro)
        {
            var parametroParameter = parametro != null ?
                new ObjectParameter("parametro", parametro) :
                new ObjectParameter("parametro", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<paSolicitudPagoListar_Result>("paSolicitudPagoListar", parametroParameter);
        }
    }
}
