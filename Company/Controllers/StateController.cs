using Microsoft.AspNetCore.Mvc;

namespace Company.Controllers
{
    public class StateController : Controller
    {
        private const string TempDataKey = "Message";
        public IActionResult Index()
        {
            TempData[TempDataKey] = "This is the StateController";
            return Content("data saved");
        }
        public IActionResult Index1()
        {
            if (TempData.TryGetValue(TempDataKey, out object? value))
            {
                TempData.Keep(TempDataKey);
                string message = value as string ?? "No TempData";
                return Content(message);
            }
            return Content("NA");
        }
    }
}
