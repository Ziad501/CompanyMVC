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
    }
}
