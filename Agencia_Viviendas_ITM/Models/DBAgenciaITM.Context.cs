﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Agencia_Viviendas_ITM.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBAgenciaITMEntities : DbContext
    {
        public DBAgenciaITMEntities()
            : base("name=DBAgenciaITMEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Agencia> Agencias { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TiposVivienda> TiposViviendas { get; set; }
        public virtual DbSet<Venta> Ventas { get; set; }
        public virtual DbSet<Vivienda> Viviendas { get; set; }
    }
}
