using LoginApp.Models;
using LoginApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LoginApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }
      

        // GET: /Account/Register
        public IActionResult Register()
        {
            return View();
        }

        // POST: /Account/Register
        [HttpPost]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                _userService.AddUser(user); // Use the service to add the user
                return RedirectToAction("Index", "Home"); // Redirect to Home after successful registration
            }

            return View(user); // Return to the same view if there are validation errors
        }

        public IActionResult Users()
        {
            List<User> users = _userService.GetUsers(); // Fetch users from DB
            return View(users);
        }

        public IActionResult Edit(int id)
        {
            var user = _userService.GetUserById(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        [HttpPost]
        public IActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {
                _userService.UpdateUser(user);
                return RedirectToAction("Users");
            }
            return View(user);
        }
    }
}
