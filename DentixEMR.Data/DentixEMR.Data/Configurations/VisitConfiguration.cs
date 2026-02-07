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
    public class VisitConfiguration : IEntityTypeConfiguration<Visit>
    {
        public void Configure(EntityTypeBuilder<Visit> builder)
        {
            builder.HasKey(v => v.VisitId);

            builder.Property(v => v.Diagnosis)
                .HasMaxLength(500);

            builder.Property(v => v.TreatmentProvided)
                .HasMaxLength(1000);

            builder.Property(v => v.Notes)
                .HasMaxLength(2000);

            // One visit contains many medical documents
            builder.HasMany(v => v.Documents)
                .WithOne(d => d.Visit)
                .HasForeignKey(d => d.VisitId);
        }

    }
}
