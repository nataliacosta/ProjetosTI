﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CPWebApp.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CPDatabaseEntities : DbContext
    {
        public CPDatabaseEntities()
            : base("name=CPDatabaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<PARTICIPANTES> PARTICIPANTES { get; set; }
        public virtual DbSet<PESSOAS> PESSOAS { get; set; }
        public virtual DbSet<PROJETOS> PROJETOS { get; set; }
        public virtual DbSet<RECURSOS> RECURSOS { get; set; }
        public virtual DbSet<SISTEMAS> SISTEMAS { get; set; }
        public virtual DbSet<SOLICITACOES> SOLICITACOES { get; set; }
        public virtual DbSet<TIPO_PARTICIPANTE> TIPO_PARTICIPANTE { get; set; }
        public virtual DbSet<TIPO_RECURSO> TIPO_RECURSO { get; set; }
    }
}
