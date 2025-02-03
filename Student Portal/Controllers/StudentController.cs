using Microsoft.AspNetCore.Mvc;

namespace Student_Portal.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
