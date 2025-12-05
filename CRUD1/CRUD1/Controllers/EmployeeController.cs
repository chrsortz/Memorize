using CRUD1.DAL;
using CRUD1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUD1.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeContext _context;

        public EmployeeController(EmployeeContext context)
        {
            _context = context;
        }
       public async Task<IActionResult> Index()
        {
            return View(await _context.Employees.ToListAsync());
        }
    }
}
