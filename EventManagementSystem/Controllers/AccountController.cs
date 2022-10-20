using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace EventManagementSystem.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(UserForLoginDto userForLoginDto)
        {
            if (ModelState.IsValid)
            {

            }

            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Register(UserForRegisterDto userForRegisterDto)
        {
            if (ModelState.IsValid)
            {

            }

            return View();
        }

    }
}
