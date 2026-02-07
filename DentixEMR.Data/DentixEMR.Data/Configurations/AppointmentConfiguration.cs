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
    public class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            builder.HasKey(a => a.AppointmentId);

            builder.Property(a => a.AppointmentDate)
                .IsRequired();

            builder.Property(a => a.Status)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasOne(a => a.Visit)
                .WithOne(v => v.Appointment)
                .HasForeignKey<Visit>(v => v.AppointmentId);

        }
    }
}
