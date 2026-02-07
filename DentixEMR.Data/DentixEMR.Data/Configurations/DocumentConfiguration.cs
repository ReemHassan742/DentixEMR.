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
    public class DocumentConfiguration : IEntityTypeConfiguration<Document>
    {
        public void Configure(EntityTypeBuilder<Document> builder)
        {
           builder.HasKey(d => d.DocumentId);
    
           builder.Property(d => d.FilePath)
              .IsRequired()
              .HasMaxLength(255);

            builder.Property(d => d.FileType)
              .IsRequired()
              .HasMaxLength(50);

            builder.Property(d => d.Description)
              .HasMaxLength(500);

            builder.HasOne(d => d.Patient)
              .WithMany(p => p.Documents)
              .HasForeignKey(d => d.PatientId);

        }
    }
}
