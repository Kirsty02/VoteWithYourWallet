using CW.Data;
using CW.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;


namespace CW.Controllers
{
    // Define the AccountController class, which inherits from the Controller class
    public class AccountController : Controller
    {
        // Declare a private read-only variable for the database context
        private readonly MyDbContext _db;

        // Define the constructor for the AccountController that takes a MyDbContext object as a parameter
        public AccountController(MyDbContext db)
        {
            // Assign the passed MyDbContext object to the private _db variable
            _db = db;
        }

        // Define the Register action with HttpGet attribute
        [HttpGet]
        public IActionResult Register()
        {
            // Redirect the user to the Register action in the Home controller
            return RedirectToAction("Register", "Home");
        }

        // Define the Register action with HttpPost attribute, which takes email, password, and name as parameters
        [HttpPost]
        public IActionResult Register(string email, string password, string name)
        {
            // Create a new Member object
            Member new_member = new CW.Data.Member();
            new_member.Email = email;
            new_member.Name = name;
            new_member.Password = password;
            new_member.Role = "Member";

            // Check if the ModelState is valid
            if (ModelState.IsValid)
            {
                // Add the new member to the Members DbSet and save changes to the database
                _db.Members.Add(new_member);
                _db.SaveChanges();

                // Set the MemberName session variable to the new member's name
                HttpContext.Session.SetString("MemberName", new_member.Name);

                // Redirect the user to the Register action in the Home controller
                return RedirectToAction("Register", "Home");
            }

            // Redirect the user to the Index action in the Home controller
            return RedirectToAction("Index", "Home");
        }

        // Define the Login action with HttpGet attribute
        [HttpGet]
        public IActionResult Login()
        {
            // Return the Login view
            return View();
        }

        // Define the Login action with HttpPost attribute, which takes email and password as parameters
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            // Find the member in the database with the matching email and password
            var member = _db.Members.SingleOrDefault(m => m.Email == email && m.Password == password);

            // Check if the member exists
            if (member != null)
            {
                // Set the MemberName and MemberRole session variables
                HttpContext.Session.SetString("MemberName", member.Name);
                HttpContext.Session.SetString("MemberRole", member.Role);

                // Redirect the user to the Login action in the Home controller
                return RedirectToAction("Login", "Home");
            }

            // Set an error message for invalid login credentials
            ViewBag.ErrorMessage = "Invalid login credentials.";

            // Redirect the user to the Account action in the Home controller
            return RedirectToAction("Account", "Home");
        }

        // Define the Logout action with HttpGet attribute
        [HttpGet]
        public IActionResult Logout()
        {
            // Clear all session variables
            HttpContext.Session.Clear();

            // Redirect the user to the Index action in the Home controller
            return RedirectToAction("Index", "Home");
        }
    }
}
