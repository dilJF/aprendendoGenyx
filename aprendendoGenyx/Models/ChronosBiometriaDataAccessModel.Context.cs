﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace aprendendoGenyx.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class db_chronos_biometria_homologEntities : DbContext
    {
        public db_chronos_biometria_homologEntities()
            : base("name=db_chronos_biometria_homologEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<funcionalidade> funcionalidade { get; set; }
        public virtual DbSet<funcionalidade_permissao> funcionalidade_permissao { get; set; }
        public virtual DbSet<grupo> grupo { get; set; }
        public virtual DbSet<permissao> permissao { get; set; }
        public virtual DbSet<usuario> usuario { get; set; }
        public virtual DbSet<modulo> modulo { get; set; }
    }
}
