using CompanyTest;
using Microsoft.AspNetCore.Mvc;
using TESTPRACTICE.Models;
using static System.Net.WebRequestMethods;

namespace TESTPRACTICE.Controllers
{
    public class PracticeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public PracticeController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Route("logPostData")]
        public object logPostData(LOGREG model)
        {
            if(model != null) 
            { 
                Random random = new Random();
                int otp = random.Next(100000, 999999);
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
