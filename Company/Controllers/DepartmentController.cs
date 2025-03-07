using Company.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Company.Controllers
{
    public class DepartmentController : Controller
    {
        DbApp db = new();
        public IActionResult Index()
        {
            List<Department> departments = db.Departments?.Include(d => d.Employees).ToList() ?? [];
            return View("viewdepartments", departments);
        }
        public IActionResult Create() => View();
        public IActionResult Save(Department department)
        {
            if (department.Name is not null) 
            {
                db.Departments?.Add(department);
                db.SaveChanges(); 
            }
            return RedirectToAction("Index");
        }
    }
}
