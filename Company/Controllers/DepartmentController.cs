using Company.Models;
using Microsoft.AspNetCore.Mvc;

namespace Company.Controllers
{
    public class DepartmentController : Controller
    {
        DbApp db = new();
        public IActionResult Index()
        {
            List<Department> departments = [.. db.Departments];
            return View("viewdepartments", departments);
        }
    }
}
