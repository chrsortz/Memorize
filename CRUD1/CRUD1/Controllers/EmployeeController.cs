using CRUD1.DAL;
using CRUD1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUD1.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeContext _employeeContext;

        public EmployeeController(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }

        //List 

        public async Task<IActionResult> Index()
        {
            return View(await _employeeContext.Employees.ToListAsync());
        }

        //Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _employeeContext.Employees.Add(employee);
                await _employeeContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }


        //Edit
        public async Task<IActionResult> Edit(int id)
        {
            var employee = await _employeeContext.Employees.FindAsync(id);
            return View(employee);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _employeeContext.Employees.Update(employee);
                await _employeeContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        //View 
        public async Task<IActionResult> View(int id)
        {
            var employee = await _employeeContext.Employees.FindAsync(id);
            return View(employee);
        }

    }
}
