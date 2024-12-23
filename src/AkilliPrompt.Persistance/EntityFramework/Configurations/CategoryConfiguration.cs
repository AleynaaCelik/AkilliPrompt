﻿using AkilliPrompt.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliPrompt.Persistance.EntityFramework.Configurations
{
    public sealed class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            // Id
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            // Name
            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(100);

            // Description
            builder.Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(500);

            // Common Properties

            // CreatedAt
            builder.Property(p => p.CreatedOn)
                .IsRequired();

            // CreatedByUserId
            builder.Property(p => p.CreatedByUserId)
                .IsRequired(false)
            .HasMaxLength(100);

            // ModifiedAt
            builder.Property(p => p.ModifiedAt)
                .IsRequired(false);

            // ModifiedByUserId
            builder.Property(p => p.ModifiedByUserId)
                .IsRequired(false)
                .HasMaxLength(100);

            // Table Name
            builder.ToTable("categories");
        }
    }
}
