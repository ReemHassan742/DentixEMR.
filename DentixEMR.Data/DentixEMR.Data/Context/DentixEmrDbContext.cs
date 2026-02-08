using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DentixEMR.Data.Entities;

namespace DentixEMR.Data.Context
{
    public class DentixEmrDbContext : DbContext
    {
        // Constructor receives configuration options (Connection string, etc.)
        public DentixEmrDbContext(DbContextOptions<DentixEmrDbContext> options)
            : base(options)
        {
        }

        // Each DbSet represents a table in the database
        public DbSet<User> Users { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Visit> Visits { get; set; }
        public DbSet<MedicalRecord> MedicalRecords { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Alert> Alerts { get; set; }
        public DbSet<AuditLog> AuditLogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DentixEmrDbContext).Assembly);
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
