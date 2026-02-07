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
    public class AuditLogConfiguration : IEntityTypeConfiguration<AuditLog>
    {
        public void Configure(EntityTypeBuilder<AuditLog> builder)
        {
            builder.HasKey(a => a.AuditLogId);

            builder.Property(builder => builder.UserId)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(builder => builder.Action)
                .IsRequired()
                .HasMaxLength(255);


            builder.Property(builder => builder.EntityName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(builder => builder.Timestamp)
                .IsRequired();

            builder.HasOne(a => a.User)
                .WithMany()
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.SetNull);



        }
    
    }
}
