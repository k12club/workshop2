using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace workshop2.Models {
    public class Employee {
        [Key]
        [DatabaseGenerated (DatabaseGeneratedOption.Identity)]

        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CodeEmployee { get; set; }
        public long BoardId { get; set; }
        public virtual Board Board { get; set; }

        public DateTime Create_At { get; set; } = DateTime.Now;

    }
}