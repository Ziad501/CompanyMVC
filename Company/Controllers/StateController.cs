using Microsoft.AspNetCore.Mvc;

namespace Company.Controllers
{
    public class StateController : Controller
    {
        private const string TempDataKey = "Message";
        public IActionResult Tempdata1()
        {
            TempData[TempDataKey] = "This is the StateController";
            return Content("data saved");
        }
        public IActionResult Tempdata2()
        {
            if (TempData.TryGetValue(TempDataKey, out object? value))
            {
                TempData.Keep(TempDataKey);
                string message = value as string ?? "No TempData";
                return Content(message);
            }
            return Content("NA");
        }
        public IActionResult Session1()
        {
            HttpContext.Session.SetString("Name", "Ziad");
            HttpContext.Session.SetInt32("Age", 25);
            return Content("Session data saved");
        }
        public IActionResult Session2()
        {
            if(HttpContext.Session.IsAvailable)
            {
            string Name = HttpContext.Session.GetString("Name") ?? "NA";
            int Age = HttpContext.Session.GetInt32("Age") ?? 0;
            return Content($"Name: {Name}, Age: {Age}");
            }
            return Content("Session data not available");
        }
        public IActionResult SetCookies()
        {
            CookieOptions options = new();
            options.Expires = DateTimeOffset.Now.AddDays(15);
            Response.Cookies.Append("Name", "Ziad",options); //presists for 15 days
            Response.Cookies.Append("Age", "25"); //persists for the session(default) "20min"
            return Content("Cookies saved");
        }
        public IActionResult GetCookies()
        {
            string Name = Request.Cookies["Name"] ?? "NA";
            string Age = Request.Cookies["Age"] ?? "0";
            return Content($"Name: {Name}, Age: {Age}");
        }
    }
}
