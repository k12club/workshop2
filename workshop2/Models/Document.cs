using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace workshop2.Models {
    public class Document {
        [Key]
        [DatabaseGenerated (DatabaseGeneratedOption.Identity)]

        public long Id { get; set; }
        public string Name { get; set; }
        public long DocumentStatusId { get; set; } = 1;
        public virtual DocumentStatus DocumentStatus { get; set; }
        public long EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public long SecretId { get; set; } = 1;
        public virtual Secret Secret { get; set; }
        public DateTime Create_At { get; set; } = DateTime.Now;

        public ICollection<DocumentFile> DocumentFiles { get; set; }
    }
}