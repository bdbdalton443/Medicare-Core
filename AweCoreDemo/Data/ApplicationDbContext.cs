using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DemoHms;
using DemoHms.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Concurrent;
using AweCoreDemo.Data;

namespace DemoHms.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<EntityType>().HasIndex(E => E.Name).IsUnique();
            builder.Entity<ArmyDivision>().HasIndex(E => E.Name).IsUnique();
            builder.Entity<ArmyService>().HasIndex(E => E.Name).IsUnique();
            builder.Entity<ArmyStatus>().HasIndex(E => E.Name).IsUnique();
            builder.Entity<ArmyUnit>().HasIndex(E => E.Name).IsUnique();
            builder.Entity<BranchType>().HasIndex(E => E.Name).IsUnique();
            builder.Entity<EmployeeGroup>().HasIndex(E => E.Name).IsUnique();
            builder.Entity<Item>().HasIndex(E => E.Name).IsUnique();
            builder.Entity<ItemSubGroup>().HasIndex(E => E.Name).IsUnique();
            builder.Entity<ItemSuperType>().HasIndex(E => E.Name).IsUnique();
            builder.Entity<ItemType>().HasIndex(E => E.Name).IsUnique();
            builder.Entity<ItemUnit>().HasIndex(E => E.Name).IsUnique();
            builder.Entity<Module>().HasIndex(E => E.Name).IsUnique();
            builder.Entity<PatientType>().HasIndex(E => E.Name).IsUnique();
            builder.Entity<Rank>().HasIndex(E => E.Name).IsUnique();
            builder.Entity<Receipt>().HasIndex(E => E.ReceiptNumber).IsUnique();
            builder.Entity<Status>().HasIndex(E => E.Name).IsUnique();
            builder.Entity<ReferralStatus>().HasIndex(E => E.Name).IsUnique();
            builder.Entity<Test>().HasIndex(E => E.Name).IsUnique();
            builder.Entity<HService>().HasIndex(E => E.Name).IsUnique();
            builder.Entity<BillItemType>().HasIndex(E => E.Name).IsUnique();
            builder.Entity<BillItem>().HasIndex(E => E.Name).IsUnique();
            builder.Entity<RoutineType>().HasIndex(E => E.Name).IsUnique();
            builder.Entity<DispenseStatus>().HasIndex(E => E.Name).IsUnique();
            builder.Entity<Permission>().HasIndex(E => E.Name).IsUnique();
            builder.Entity<Supplier>().HasIndex(E => E.Name).IsUnique();

            base.OnModelCreating(builder);
        }
        public DbSet<ApplicationUser> AppUsers { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Bill> Bills { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Item> Items { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Receipt> Receipts { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<ReceiptRoutine> ReceiptRoutines { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<ItemType> ItemTypes { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<ItemUnit> ItemUnits { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<ItemSubGroup> ItemSubGroups { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<ItemSuperType> ItemSuperTypes { get; set; }
        public DbSet<DemoHms.Request> Request { get; set; }
        //public Microsoft.EntityFrameworkCore.DbSet<Stock> Stoks { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Stok> Stoks { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Permission> Permissions { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<EmployeeGroup> EmployeeGroups { get; set; }
        public DbSet<DemoHms.Data.Activity> Activity { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Patient> Patients { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<NOKRelationship> NOKRelationships { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<ArmyUnit> ArmyUnits { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<NextOfKin> NextOfKins { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Family> Families { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Branch> Branches { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<BranchType> BranchTypes { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<EntityType> EntityTypes { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<ArmyService> ArmyServices { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Status> Statuses { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<ArmyStatus> ArmyStatuses { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Hospital> Hospitals { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Module> Modules { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Mapping> Mappings { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Department> Departments { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<PatientType> PatientTypes { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Rank> Ranks { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Organisation> Organizations { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Assignment> Assignments { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<ReferralStatus> ReferralStatuses { get; set; }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entries = ChangeTracker
        .Entries()
        .Where(e => e.Entity is BaseEntity && (
                e.State == EntityState.Added
                || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                ((BaseEntity)entityEntry.Entity).UpdatedOn = DateTime.Now;

                if (entityEntry.State == EntityState.Added)
                {
                    ((BaseEntity)entityEntry.Entity).CreatedOn = DateTime.Now;
                }
            }
            return base.SaveChangesAsync();
        }
        
        public override int SaveChanges()
        {
            var entries = ChangeTracker
        .Entries()
        .Where(e => e.Entity is BaseEntity && (
                e.State == EntityState.Added
                || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                ((BaseEntity)entityEntry.Entity).UpdatedOn = DateTime.Now;

                if (entityEntry.State == EntityState.Added)
                {
                    ((BaseEntity)entityEntry.Entity).CreatedOn = DateTime.Now;
                }
            }
            return base.SaveChanges();
        }      
        public DbSet<DemoHms.Data.BillStatus> BillStatus { get; set; }
        public DbSet<DemoHms.Data.Treatment> Treatments { get; set; }
        public DbSet<DemoHms.Data.Examination> Examinations { get; set; }
        public DbSet<DemoHms.Data.Test> Tests { get; set; }
        public DbSet<DemoHms.Data.Procedure> Procedures { get; set; }
        public DbSet<DemoHms.Data.ExaminationStatus> ExaminationStatuses { get; set; }
        public DbSet<DemoHms.Data.BillItem> BillItems { get; set; }
        public DbSet<BillItemType> BillItemTypes { get; set; }
        public DbSet<HService> HServices { get; set; }
        public DbSet<TestConsumable> TestConsumables { get; set; }
        public void DetachAllEntities()
        {
            var changedEntriesCopy = this.ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Added ||
                            e.State == EntityState.Modified ||
                            e.State == EntityState.Deleted)
                .ToList();

            foreach (var entry in changedEntriesCopy)
                entry.State = EntityState.Detached;
        }
        public DbSet<AweCoreDemo.Data.RoutineType> RoutineType { get; set; }
        public DbSet<AweCoreDemo.Data.StockRoutine> StockRoutines { get; set; }
        public DbSet<AweCoreDemo.Data.DispenseStatus> DispenseStatuses { get; set; }
        public DbSet<AweCoreDemo.Data.DispenseRoutine> DispenseRoutines { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
    }
}
