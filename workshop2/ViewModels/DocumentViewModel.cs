using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace workshop2.ViewModels {
        public class DocumemtViewModels {

                public string Name { get; set; }
                public IFormFile[] file { get; set; }

        }
}