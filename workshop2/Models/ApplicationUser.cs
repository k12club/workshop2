using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace workshop2.Models {
    public class ApplicationUser : IdentityUser {
        public long EmployeeId { get; set; }
        public virtual Employee Employeeeeee { get; set; }
        //sdfsdf
    }
}