using CompanyTest;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TESTPRACTICE.Models;
using static System.Net.Mime.MediaTypeNames;

namespace TESTPRACTICE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TESTController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public TESTController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpPost]
        [Route("logPostData")]
        public object logPostData(LOGREG model)
        {
            if (model != null)
            {
                Random random = new Random();
                int otp = random.Next(100000, 999999);
                _context.LOGREG.Add(model);
                _context.SaveChanges();
                return new
                {
                    Status = 1,
                    otp = otp
                };
            }

            return new
            {
                Status = 0,
                Message = "Invalid Number"
            };

        }


    }
}
