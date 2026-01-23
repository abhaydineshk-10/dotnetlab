using Microsoft.AspNetCore.Mvc;

namespace RoutingDemo.Controllers
{

    public class StudentController : Controller
    {
        [Route("Input/{id}")]

        public IActionResult Input(int id, string name)
        {
            string message = $"Studwnt ID: {id}, Student Name:{name}";
            return Content(message);
        }
    }
}