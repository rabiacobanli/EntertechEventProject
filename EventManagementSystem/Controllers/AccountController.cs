using DataAccess.Concrete;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace EventManagementSystem.Controllers
{
    public class AccountController : Controller
    {
        private readonly EventContext _eventContext;
        public AccountController(EventContext eventContext)
        {
            _eventContext = eventContext;
        }

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
                User user = new()
                {
                    Email = userForRegisterDto.Email,
                    Password = userForRegisterDto.Password,
                    FirstName = userForRegisterDto.FirstName,
                    LastName = userForRegisterDto.LastName,

                };
            }

            return View();
        }

    }
}
