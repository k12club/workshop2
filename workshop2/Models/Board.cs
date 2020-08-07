using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace workshop2.Models {
    public class Board {
        [Key]
        [DatabaseGenerated (DatabaseGeneratedOption.Identity)]

        public long Id { get; set; }
        public string FirstNamessss { get; set; }
        public string LastName { get; set; }
        public string CodeEmployee { get; set; }

        public DateTime Create_At { get; set; } = DateTime.Now;

         public ICollection<Employee> Employees { get; set; }

    }
}