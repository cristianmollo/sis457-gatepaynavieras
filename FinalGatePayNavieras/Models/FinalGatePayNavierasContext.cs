using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FinalGatePayNavieras.Models;

public partial class FinalGatePayNavierasContext : DbContext
{
    public FinalGatePayNavierasContext()
    {
    }

    public FinalGatePayNavierasContext(DbContextOptions<FinalGatePayNavierasContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Factura> Facturas { get; set; }

    public virtual DbSet<GateIn> GateIns { get; set; }

    public virtual DbSet<Historial> Historials { get; set; }

    public virtual DbSet<Naviera> Navieras { get; set; }

    public virtual DbSet<SolicitudPago> SolicitudPagos { get; set; }

    public virtual DbSet<SolicitudPagoBancoChile> SolicitudPagoBancoChiles { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=FinalGatePayNavieras;User ID=usrthalassa;Password=123456");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cliente__3214EC07D1B70311");

            entity.ToTable("Cliente");

            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasDefaultValue((short)1)
                .HasColumnName("estado");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TipoCliente)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioRegistro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())")
                .HasColumnName("usuarioRegistro");
        });

        modelBuilder.Entity<Factura>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Factura__3214EC07FD12AA6B");

            entity.ToTable("Factura");

            entity.Property(e => e.Estado)
                .HasDefaultValue((short)1)
                .HasColumnName("estado");
            entity.Property(e => e.FechaEmision).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.NumeroFactura)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RutaArchivoPdf)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RutaArchivoPDF");
            entity.Property(e => e.UsuarioRegistro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())")
                .HasColumnName("usuarioRegistro");

            entity.HasOne(d => d.IdGateInNavigation).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.IdGateIn)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Factura_GateIn");
        });

        modelBuilder.Entity<GateIn>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__GateIn__3214EC07A0F85385");

            entity.ToTable("GateIn");

            entity.Property(e => e.Contenedor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasDefaultValue((short)1)
                .HasColumnName("estado");
            entity.Property(e => e.FechaPago)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.MetodoPago)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MontoPago).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.NumeroBl)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NumeroBL");
            entity.Property(e => e.UsuarioRegistro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())")
                .HasColumnName("usuarioRegistro");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.GateIns)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_GateIn_Cliente");

            entity.HasOne(d => d.IdNavieraNavigation).WithMany(p => p.GateIns)
                .HasForeignKey(d => d.IdNaviera)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_GateIn_Naviera");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.GateIns)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_GateIn_Usuario");
        });

        modelBuilder.Entity<Historial>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Historia__3214EC07F7D4EC31");

            entity.ToTable("Historial");

            entity.Property(e => e.Accion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasDefaultValue((short)1)
                .HasColumnName("estado");
            entity.Property(e => e.FechaHora)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.UsuarioRegistro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())")
                .HasColumnName("usuarioRegistro");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Historials)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Historial_Usuario");
        });

        modelBuilder.Entity<Naviera>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Naviera__3214EC0771B8020A");

            entity.ToTable("Naviera");

            entity.Property(e => e.Estado)
                .HasDefaultValue((short)1)
                .HasColumnName("estado");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Urlportal)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("URLPortal");
            entity.Property(e => e.UsuarioRegistro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())")
                .HasColumnName("usuarioRegistro");
        });

        modelBuilder.Entity<SolicitudPago>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Solicitu__3214EC071876E97F");

            entity.ToTable("SolicitudPago");

            entity.Property(e => e.Comision).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Contenedor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasDefaultValue((short)1)
                .HasColumnName("estado");
            entity.Property(e => e.EstadoG)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("Pendiente");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.FechaSolicitud)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.MontoEstimado).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.NumeroBl)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NumeroBL");
            entity.Property(e => e.TipoCambio).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.TotalEnBolivianos)
                .HasComputedColumnSql("([MontoEstimado]*[TipoCambio]+[Comision])", true)
                .HasColumnType("decimal(22, 4)");
            entity.Property(e => e.UsuarioRegistro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())")
                .HasColumnName("usuarioRegistro");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.SolicitudPagos)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_SolicitudPago_Cliente");

            entity.HasOne(d => d.IdNavieraNavigation).WithMany(p => p.SolicitudPagos)
                .HasForeignKey(d => d.IdNaviera)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_SolicitudPago_Naviera");
        });

        modelBuilder.Entity<SolicitudPagoBancoChile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Solicitu__3214EC07828294CA");

            entity.ToTable("SolicitudPagoBancoChile");

            entity.Property(e => e.Comision).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.EstadoPago)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("Pendiente");
            entity.Property(e => e.FechaPago).HasColumnType("datetime");
            entity.Property(e => e.FechaSolicitud)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.MontoDolares).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.MontoEnBolivianos).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.NombreSolicitante)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones).HasColumnType("text");
            entity.Property(e => e.RutaComprobantePago)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TipoCambio).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.SolicitudPagoBancoChiles)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_SolicitudPagoBancoChile_Cliente");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Usuario__3214EC07818D6DB1");

            entity.ToTable("Usuario");

            entity.Property(e => e.Contrasena)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasDefaultValue((short)1)
                .HasColumnName("estado");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Rol)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioRegistro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())")
                .HasColumnName("usuarioRegistro");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
