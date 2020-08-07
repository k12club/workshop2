using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using workshop2.Models;
namespace workshop2.Data.Seeders {
        public class DocumentFileStatusSeeder : IEntityTypeConfiguration<DocumentFileStatus> {
                public void Configure (EntityTypeBuilder<DocumentFileStatus> builder) {
                        builder.HasData (
                                new DocumentFileStatus { Id = 1, Name = "general" },
                                new DocumentFileStatus { Id = 2, Name = "signature" }
                        );
                }
        }
}