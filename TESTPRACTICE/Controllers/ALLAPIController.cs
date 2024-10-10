using CompanyTest;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TESTPRACTICE.Models;

namespace TESTPRACTICE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ALLAPIController : ControllerBase
    {

        private readonly ApplicationDbContext _context;
        public ALLAPIController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("studentsAdd")]
        public object studentsAdd(STUDENT student)
        {

            _context.Add(student);
            _context.SaveChanges();
            return Ok("DATA SAVED SUCCESSFULLY");
        }

        [HttpGet]
        [Route("studentGet")]
        public object studentGet(string studentName)
        {
            if (studentName != null)
            {
                var list = _context.STUDENT.AsQueryable().Where(s => s.NAME == studentName).OrderBy(s => s.CLASS).ToList();

                return Ok(list);
            }

            return Ok("No data Found");

        }

    }
}
