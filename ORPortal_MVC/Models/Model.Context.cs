﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ORPortal_MVC.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class IOR_V1Model : DbContext
    {
        public IOR_V1Model()
            : base("name=IOR_V1Model")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Actual> Actuals { get; set; }
        public virtual DbSet<Break> Breaks { get; set; }
        public virtual DbSet<CommonProblem> CommonProblems { get; set; }
        public virtual DbSet<MachineGroup> MachineGroups { get; set; }
        public virtual DbSet<MachineInput> MachineInputs { get; set; }
        public virtual DbSet<Machine> Machines { get; set; }
        public virtual DbSet<OFF> OFFs { get; set; }
        public virtual DbSet<Plan> Plans { get; set; }
        public virtual DbSet<ProjectMachine> ProjectMachines { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Session> Sessions { get; set; }
        public virtual DbSet<ShiftMachine> ShiftMachines { get; set; }
        public virtual DbSet<Shift> Shifts { get; set; }
        public virtual DbSet<SpecificProblem> SpecificProblems { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Command> Commands { get; set; }
        public virtual DbSet<ManPower> ManPowers { get; set; }
        public virtual DbSet<ProjectTracker> ProjectTrackers { get; set; }
        public virtual DbSet<Scrap> Scraps { get; set; }
        public virtual DbSet<Stop> Stops { get; set; }
    }
}