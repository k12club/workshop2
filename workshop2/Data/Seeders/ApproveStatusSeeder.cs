using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using workshop2.Models;

namespace workshop2.Data.Seeders
{
    public class ApproveStatusSeeder
    {
        public void Configure(EntityTypeBuilder<ApproveStatus> builder)
        {
            builder.HasData(
                    new ApproveStatus { Id = 1, Name = "อัพโหลดเอกสาร" },
                    new ApproveStatus { Id = 2, Name = "รอการอนุมัติ" },
                    new ApproveStatus { Id = 3, Name = "อนุมัติเรียบร้อย" }
            );
        }
    }
}
