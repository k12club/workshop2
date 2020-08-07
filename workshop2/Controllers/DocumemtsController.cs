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

        //ฟังชั่นสำหรับ random ชื่อไฟล์
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
        public async Task<IActionResult> uploadFile ([FromForm] DocumentViewModels model) {
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

                // _context.SaveChanges ();
            }

            return Ok ("success");
            //     }

        }

        [HttpPost ("adddoc")]
        public async Task<IActionResult> AddDocument ([FromForm] DocumentViewModels model) {
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

                // _context.SaveChanges ();
            }

            return Ok ("success");
            //     }

        }

        [HttpPost]
        public async Task<IActionResult> PostTest ([FromForm] DocumentViewModels model) {
            var Data = new Document {
                Name = model.Name,
                Create_At = DateTime.Now
            };
            //แอดเข้าฐานข้อมูล
            _context.Document.Add (Data);
            _context.SaveChanges ();
            //end แอดเข้าฐานข้อมูล
            //เช็คโฟลเดอร์ Uploadsถ้ายังไม่ได้สร้างให้มันทำการสร้างให้
            if (!Directory.Exists (_environment.WebRootPath + "//Uploads//")) {
                Directory.CreateDirectory (_environment.WebRootPath + "//Uploads//"); //สร้าง Folder Upload ใน wwwroot
            }

            //path ไฟล์ที่ทำการอัพโหลดมาจะอยู่ในโฟลเดอร์ wwwroot/Uploads
            var filePath = _environment.WebRootPath + "//Uploads//";

            //for สำหรับรับไฟล์ที่เป็น array
            foreach (var formFile in model.file)
            //foreach (var formFile in data.files)
            {
                //random ชื่อไฟล์
                var random = RandomString (10);
                //ชื่อไฟล์เก่าที่เราอัพโหลดเข้ามา
                string filePath2 = formFile.FileName;
                string filename = Path.GetFileName (filePath2);
                //end ชื่อไฟล์เก่าที่เราอัพโหลดเข้ามา

                //เรียกนามสกุลของไฟล์ออกมา
                string ext = Path.GetExtension (filename);
                using (var stream = System.IO.File.Create (filePath + random + filename)) {
                    await formFile.CopyToAsync (stream);
                }

                var DataFile = new DocumentFile {
                    FileName = random + filename,
                    DocumentId = Data.Id,
                    DocumentFileStatusId = 1
                };
                //แอดเข้าฐานข้อมูล
                _context.DocumentFile.Add (DataFile);
                _context.SaveChanges ();
                //end แอดเข้าฐานข้อมูล
            }
            return Ok (Data); 
            //     }

        }

        [HttpPut]
        public IActionResult PutTest ([FromForm] DocumentViewModels model) {

            return Ok ("HttpPut");

        }

    }
}