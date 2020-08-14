using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace workshop2.ViewModels {
        public class DocumentViewModels {

                public string Name { get; set; }
                public List<IFormFile> file { get; set; }
                public long EmployeeId { get; set; }
                public long DocumentStatusId { get; set; }
                public long SecretId { get; set; }

                
                ///ddddd
        }
}