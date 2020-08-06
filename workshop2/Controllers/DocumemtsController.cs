using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using workshop2.Data;
using workshop2.Models;
using workshop2.ViewModels;

namespace workshop2.Controllers {
    [Route ("api/[controller]")]
    [ApiController]
    public class DocumemtsController : ControllerBase {
        private readonly ApplicationDbContext _context;
        public static IWebHostEnvironment _environment;
        private static Random random = new Random ();
        public static string RandomString (int length) {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string (Enumerable.Repeat (chars, length)
                .Select (s => s[random.Next (s.Length)]).ToArray ());
        }
        public DocumemtsController (ApplicationDbContext context, IWebHostEnvironment environment) {
            _context = context;
            _environment = environment;
        }

        [HttpPost ("uploadfile")]
        public async Task<IActionResult> uploadFile ([FromForm] DocumemtViewModels model) {
            if (!Directory.Exists (_environment.WebRootPath + "//Uploads//")) {
                Directory.CreateDirectory (_environment.WebRootPath + "//Uploads//"); //สร้าง Folder Upload ใน wwwroot
            }
            var filePath = _environment.WebRootPath + "//Uploads//";
            //     foreach (var formFile in file.Select((value, index) => new { Value = value, Index = index }))
            //     //foreach (var formFile in data.files)
            //     {
            foreach (var formFile in model.file.Select ((value, index) => new { Value = value, Index = index }))
            //foreach (var formFile in data.files)
            {
                var random = RandomString (10);
                string filePath2 = formFile.Value.FileName;
                string filename = Path.GetFileName (filePath2);
                string ext = Path.GetExtension (filename);
                using (var stream = System.IO.File.Create (filePath + random + filename)) {
                    await formFile.Value.CopyToAsync (stream);
                }

                _context.SaveChanges ();
            }

            return Ok ("success");
            //     }

        }

    }
}