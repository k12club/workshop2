using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using workshop2.Models;
namespace workshop2.Data.Seeders {
        public class EmployeeSeeder : IEntityTypeConfiguration<Employee> {
                public void Configure (EntityTypeBuilder<Employee> builder) {
                        builder.HasData (
                                new Employee { Id = 1, FirstName = "Jeerawut", CodeEmployee = "555555555", BoardId = 1 }

                        );
                }
        }
}