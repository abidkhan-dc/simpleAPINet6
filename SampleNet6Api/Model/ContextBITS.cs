using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SampleNet6Api.Model
{
    public partial class ContextBITS : DbContext
    {
        public ContextBITS()
        {
        }

        public ContextBITS(DbContextOptions<ContextBITS> options)
            : base(options)
        {
        }

        public virtual DbSet<Bp006> Bp006s { get; set; } = null!;
        public virtual DbSet<Election> Elections { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
