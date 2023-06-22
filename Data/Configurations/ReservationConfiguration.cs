﻿using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.Property(p => p.Name).IsRequired().HasMaxLength(255);
            builder.Property(p => p.LastName).IsRequired().HasMaxLength(255);
            builder.Property(p => p.Email).IsRequired().HasMaxLength(255);
            builder.Property(p => p.Additionals).IsRequired().HasColumnType("TEXT");
            builder.Property(p => p.IsActive).IsRequired().HasDefaultValue(false);
            builder.Property(p => p.PhoneNumber).IsRequired().HasMaxLength(255);
            builder.Property(p => p.ReservDate).IsRequired();
            builder.Property(p => p.ReservEndDate).IsRequired();
            builder.Property(p => p.IsDeleted).IsRequired().HasDefaultValue(false);

        }
    }
}
