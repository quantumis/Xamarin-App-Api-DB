﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web_API_COMP.Entitnes
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class COMP_FIRMEntities : DbContext
    {
        public COMP_FIRMEntities()
            : base("name=COMP_FIRMEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Components> Components { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Manufacturer> Manufacturer { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Posts> Posts { get; set; }
        public virtual DbSet<Supply> Supply { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Workers> Workers { get; set; }
        public virtual DbSet<ComponentsImage> ComponentsImage { get; set; }
    }
}