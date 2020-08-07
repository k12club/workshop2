using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using workshop2.Models;
namespace workshop2.Data.Seeders {
        public class SecretSeeder : IEntityTypeConfiguration<Secret> {
                public void Configure (EntityTypeBuilder<Secret> builder) {
                        builder.HasData (
                                new Secret { Id = 1, Name = "ปกติ" },
                                new Secret { Id = 2, Name = "ลับ" },
                                new Secret { Id = 3, Name = "ลับมาก" },
                                new Secret { Id = 4, Name = "ลับที่สุด" }
                        );
                }
        }
}