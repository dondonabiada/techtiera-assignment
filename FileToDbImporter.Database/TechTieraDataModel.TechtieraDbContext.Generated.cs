﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// Code is generated on: 02/09/2022 2:48:01 am
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata;
using FileToDbImporter.Database.Entites;

namespace FileToDbImporter.Database
{

    public partial class TechtieraDbContext : DbContext
    {

        public TechtieraDbContext() :
            base()
        {
            OnCreated();
        }

        public TechtieraDbContext(DbContextOptions<TechtieraDbContext> options) :
            base(options)
        {
            OnCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured ||
                (!optionsBuilder.Options.Extensions.OfType<RelationalOptionsExtension>().Any(ext => !string.IsNullOrEmpty(ext.ConnectionString) || ext.Connection != null) &&
                 !optionsBuilder.Options.Extensions.Any(ext => !(ext is RelationalOptionsExtension) && !(ext is CoreOptionsExtension))))
            {
                optionsBuilder.UseSqlServer(@"Data Source=K8PRINTING-WS\SQLEXPRESS;Initial Catalog=FileToDbImport;Integrated Security=True;Persist Security Info=True");
            }
            CustomizeConfiguration(ref optionsBuilder);
            base.OnConfiguring(optionsBuilder);
        }

        partial void CustomizeConfiguration(ref DbContextOptionsBuilder optionsBuilder);

        public virtual DbSet<Transaction> Transactions
        {
            get;
            set;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            this.TransactionMapping(modelBuilder);
            this.CustomizeTransactionMapping(modelBuilder);

            RelationshipsMapping(modelBuilder);
            CustomizeMapping(ref modelBuilder);
        }

        #region Transaction Mapping

        private void TransactionMapping(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transaction>().ToTable(@"Transactions", @"dbo");
            modelBuilder.Entity<Transaction>().Property(x => x.TransactionId).HasColumnName(@"TransactionId").HasColumnType(@"nvarchar(50)").IsRequired().ValueGeneratedNever().HasMaxLength(50);
            modelBuilder.Entity<Transaction>().Property(x => x.Amount).HasColumnName(@"Amount").HasColumnType(@"decimal(18)").IsRequired().ValueGeneratedNever().HasPrecision(18, 0).HasDefaultValueSql(@"0");
            modelBuilder.Entity<Transaction>().Property(x => x.CurrencyCode).HasColumnName(@"CurrencyCode").HasColumnType(@"nvarchar(3)").IsRequired().ValueGeneratedNever().HasMaxLength(3);
            modelBuilder.Entity<Transaction>().Property(x => x.TransactionDate).HasColumnName(@"TransactionDate").HasColumnType(@"datetime2").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<Transaction>().Property(x => x.Status).HasColumnName(@"Status").HasColumnType(@"nvarchar(10)").IsRequired().ValueGeneratedNever().HasMaxLength(10);
            modelBuilder.Entity<Transaction>().HasKey(@"TransactionId");
            modelBuilder.Entity<Transaction>().HasIndex(@"TransactionId").IsUnique(true);
        }

        partial void CustomizeTransactionMapping(ModelBuilder modelBuilder);

        #endregion

        private void RelationshipsMapping(ModelBuilder modelBuilder)
        {
        }

        partial void CustomizeMapping(ref ModelBuilder modelBuilder);

        public bool HasChanges()
        {
            return ChangeTracker.Entries().Any(e => e.State == Microsoft.EntityFrameworkCore.EntityState.Added || e.State == Microsoft.EntityFrameworkCore.EntityState.Modified || e.State == Microsoft.EntityFrameworkCore.EntityState.Deleted);
        }

        partial void OnCreated();
    }
}