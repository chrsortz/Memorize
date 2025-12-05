using CRUD1.DAL;
using CRUD1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUD1.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeContext _employeeContext;

        public EmployeeController(Employee _context)
        {
            _employeeContext = _context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _employeeContext.Employees.ToListAsync());
        }
    }
}
