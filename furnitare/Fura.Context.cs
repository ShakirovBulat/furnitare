﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace furnitare
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FurnitureShopEntities : DbContext
    {
        public FurnitureShopEntities()
            : base("name=FurnitureShopEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Doljnost> Doljnost { get; set; }
        public virtual DbSet<Furniture> Furniture { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<Material> Material { get; set; }
        public virtual DbSet<Postavshik> Postavshik { get; set; }
        public virtual DbSet<Proizvoditel> Proizvoditel { get; set; }
        public virtual DbSet<Shop> Shop { get; set; }
        public virtual DbSet<Sklad> Sklad { get; set; }
        public virtual DbSet<Sotrudniki> Sotrudniki { get; set; }
        public virtual DbSet<TypeFurniture> TypeFurniture { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}
