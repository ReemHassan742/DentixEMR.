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
    public class NotificationConfiguration : IEntityTypeConfiguration<Alert>
    {
        public void Configure(EntityTypeBuilder<Alert> builder)
        {
            builder.HasKey(a => a.AlertId);

            builder.Property(a => a.Message)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(a => a.IsRead)
                .IsRequired();

            builder.HasOne(a => a.Patient)
                .WithMany(p => p.Alerts)
                .HasForeignKey(a => a.PatientId);
        }

    }
}
