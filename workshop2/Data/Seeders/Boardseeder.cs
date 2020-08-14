using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using workshop2.Models;
namespace workshop2.Data.Seeders {
        public class BoardSeeder : IEntityTypeConfiguration<Board> {
                public void Configure (EntityTypeBuilder<Board> builder) {
                        builder.HasData (
                                new Board { Id = 1, FirstName = "", CodeEmployee = "12601400" },
                                new Board { Id = 2, FirstName = "", CodeEmployee = "12601401" },

                                new Board { Id = 3, FirstName = "", CodeEmployee = "12601402" },
                                new Board { Id = 4, FirstName = "", CodeEmployee = "12601403" }
                        );
                }
        }
}