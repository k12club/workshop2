using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace workshop2.Models {
        public class DocumentFilePositionSignature {
                [Key]
                [DatabaseGenerated (DatabaseGeneratedOption.Identity)]

                public long Id { get; set; }

                public double X1 { get; set; }
                public double Y1 { get; set; }
                public long SignatureToId { get; set; }

        }
}