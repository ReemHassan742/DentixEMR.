using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DentixEMR.Data.Entities;

namespace DentixEMR.Data.Configurations
{
    public class PatientConfiguration : IEntityTypeConfiguration<Patient>

    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.HasKey(p => p.PatientId);

            builder.Property(p => p.FullName)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(p => p.PhoneNumber)
                .IsRequired()
                .HasMaxLength(20);

             builder.Property(p => p.Email)
                .HasMaxLength(255);

            builder.Property(p => p.Address)
                .HasMaxLength(255);

             builder.Property(p => p.Occupation)
                .HasMaxLength(100);

             builder.Property(p => p.EmergencyContact)
                .HasMaxLength(100);

             builder.HasMany(p => p.Appointments)
                .WithOne(a => a.Patient)
                .HasForeignKey(a => a.PatientId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
