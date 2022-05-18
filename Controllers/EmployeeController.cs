using FinalMockAssessment6.Data;
using Microsoft.AspNetCore.Mvc;

namespace FinalMockAssessment6.Controllers
{
    public class EmployeeController : Controller
    {
        public readonly AppDbContext _context;

        public EmployeeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
