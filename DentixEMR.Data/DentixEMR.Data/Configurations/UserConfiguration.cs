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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            // Sets Primary Key 
            builder.HasKey(u => u.FullName);

            // Makes FullName required and sets max length
            builder.Property(u => u.FullName)
                .IsRequired()
                .HasMaxLength(150);

            // Email is required and be unique
            builder.Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(255);
            builder.HasIndex(u => u.Email)
                .IsUnique();   // Prevent duplicate emails

            // Password is required 
            builder.Property(u => u.Password)
                .IsRequired()
                .HasMaxLength(20);

            // Phone number is required and has max length
            builder.Property(u => u.PhoneNumber)
                .IsRequired()
                .HasMaxLength(20);

            // Role is required and stored as string
            builder.Property(u => u.Role)
                .IsRequired()
                .HasConversion<string>(); // Store enum as string
        }

    }
}
