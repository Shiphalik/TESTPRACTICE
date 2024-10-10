using CompanyTest;
using Microsoft.AspNetCore.Mvc;
using TESTPRACTICE.Models;

namespace TESTPRACTICE.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public StudentController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        [HttpGet]
        public IActionResult studentInfoAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult studentInfoAdd(STUDENT student,IFormFile image)
        {
            string uniqueFileName = "";
            if(image != null&& image.Length>0)
            {
                string uploadFolder = Path.Combine(_webHostEnvironment.WebRootPath, "Images");
                uniqueFileName = Guid.NewGuid().ToString()+"_"+image.FileName;
                string filePath=Path.Combine(uploadFolder,uniqueFileName);
                using(var fileStream = new FileStream(filePath,FileMode.Create))
                {
                    image.CopyTo(fileStream);
                }

                student.IMAGE = uniqueFileName;
            }

            _context.Add(student);
            _context.SaveChanges();
            return RedirectToAction("studentInfoAdd", "Student");
        }


        [HttpGet]
        public IActionResult getStudentList(string search)
        {
            var list = _context.STUDENT.AsQueryable();

            if (!string.IsNullOrEmpty(search))
            {
                list = list.Where(s => s.NAME.Contains(search)).OrderBy(s => s.CLASS);
            }

            return View(list);
        }

    }
}
