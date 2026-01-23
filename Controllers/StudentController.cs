using Microsoft.AspNetCore.Mvc;

namespace RoutingDemo.Controllers
{
    public class StudentController : Controller
    {
        [Route("Details/{id}")]
        public IActionResult Details(int id)
        {
            return Content("Student ID is:" + id);
        }

        [Route("Marks/{id}/{subject}")]
        //multiple route parameters
        public IActionResult Marks(int id, string subject)
        {
            return Content("Student ID: " + id + ",subject:" + subject);
        }
    }
}
