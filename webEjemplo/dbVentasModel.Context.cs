﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace webEjemplo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbVentasContext : DbContext
    {
        public dbVentasContext()
            : base("name=dbVentasContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbCategorias> tbCategorias { get; set; }
        public virtual DbSet<tbFactura> tbFactura { get; set; }
        public virtual DbSet<tbFacturaDet> tbFacturaDet { get; set; }
        public virtual DbSet<tbLogin> tbLogin { get; set; }
        public virtual DbSet<tbProducto> tbProducto { get; set; }
    }
}
