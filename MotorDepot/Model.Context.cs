﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MotorDepot
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class lllEntities : DbContext
    {
        public lllEntities()
            : base("name=lllEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Car> Car { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<FeedbackDriver> FeedbackDriver { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<HistoryClientDriver> HistoryClientDriver { get; set; }
        public virtual DbSet<PlaceArrival> PlaceArrival { get; set; }
        public virtual DbSet<PlaceDeparture> PlaceDeparture { get; set; }
        public virtual DbSet<RequestDriver> RequestDriver { get; set; }
        public virtual DbSet<Stamp> Stamp { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}
