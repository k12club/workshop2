using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace workshop2.Models {
        public class DocumentFile {
                [Key]
                [DatabaseGenerated (DatabaseGeneratedOption.Identity)]

                public long Id { get; set; }
                public string FileName { get; set; }

                public string PageNumber { get; set; }
                public long? DocumentFilePositionSignatureId { get; set; }
                public virtual DocumentFilePositionSignature DocumentFilePositionSignature { get; set; }

                public long DocumentFileStatusId { get; set; }
                public virtual DocumentFileStatus DocumentFileStatus { get; set; }

                public long DocumentId { get; set; }

                public virtual Document Document { get; set; }
        }
}