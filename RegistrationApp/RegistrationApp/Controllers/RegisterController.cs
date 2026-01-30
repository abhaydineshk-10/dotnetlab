using Microsoft.AspNetCore.Mvc;

namespace RegistrationApp.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Models.Register User)
        {
            if (ModelState.IsValid)
            {
                return Content(
                $"Registration Sucessful\nName: {User.Name}\nEmail: {User.Email}\nPassword: {User.Password}\nAge: {User.Age}");
            }
            return View(User);

        }
    }
}
