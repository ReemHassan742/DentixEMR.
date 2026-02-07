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
    public class MedicalRecordConfiguration : IEntityTypeConfiguration<MedicalRecord>
    {
        public void Configure(EntityTypeBuilder<MedicalRecord> builder)
        {
            builder.HasKey(m => m.MedicalRecordId);
    
            builder.Property(m => m.Allergies)
                .HasMaxLength(500);

            builder.Property(m => m.Medications)
                .HasMaxLength(500);
            builder.Property(m => m.PreviousSurgeries)
                .HasMaxLength(255);
    
             builder.HasOne(m => m.Patient)
                .WithOne(p => p.MedicalRecord)
                .HasForeignKey<MedicalRecord>(m => m.PatientId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    
    }
}
