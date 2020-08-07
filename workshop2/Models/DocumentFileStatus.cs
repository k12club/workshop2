using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace workshop2.Models {
        public class DocumentFileStatus {
                [Key]
                [DatabaseGenerated (DatabaseGeneratedOption.Identity)]

                public long Id { get; set; }
                public string Name { get; set; }

        }
}