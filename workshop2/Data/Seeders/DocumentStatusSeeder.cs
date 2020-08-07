using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using workshop2.Models;
namespace workshop2.Data.Seeders {
        public class DocumentStatusSeeder : IEntityTypeConfiguration<DocumentStatus> {
                public void Configure (EntityTypeBuilder<DocumentStatus> builder) {
                        builder.HasData (
                                new DocumentStatus { Id = 1, Name = "ปกติ" },
                                new DocumentStatus { Id = 2, Name = "ด่วน" },
                                new DocumentStatus { Id = 3, Name = "ด่วนมาก" },
                                new DocumentStatus { Id = 4, Name = "ด่วนที่สุด" }
                        );
                }
        }
}