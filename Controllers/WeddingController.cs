using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WeddingPlanner.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace WeddingPlanner.Controllers
{
    public class WeddingController : Controller
    {
        private Context dbContext;
     
        public WeddingController(Context context)
        {
            dbContext = context;
        } 

        [Route("")]
        [HttpGet]
        public IActionResult LoginReg()
        {
            return View("LoginRegistration");
        }

        [HttpPost("Register")]
        public IActionResult Register(User newUser)
        {

            // Check initial ModelState
            if(ModelState.IsValid)
            {
                
                // If a User exists with provided email
                if(dbContext.users.Any(u => u.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "Email already in use!");
                    
                    return View("LoginRegistration");
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                dbContext.Add(newUser);
                dbContext.SaveChanges();
                HttpContext.Session.SetInt32("UserId", newUser.UserId);
                return RedirectToAction("Dashboard");
            }
            return View("LoginRegistration");
        } 

        [HttpPost("Login")]
        public IActionResult Login(string Email, string Password)
        {
            if(ModelState.IsValid)
            {
                // If inital ModelState is valid, query for a user with provided email
                var userInDb = dbContext.users.FirstOrDefault(u => u.Email == Email);
                // If no user exists with provided email
                if(userInDb == null)
                {
                    // Add an error to ModelState and return to View!
                    ModelState.AddModelError("Email", "Invalid Email/Password");
                    return View("LoginRegistration");
                }
                 // Initialize hasher object
                var hasher = new PasswordHasher<User>();
                
                // varify provided password against hash stored in db
                var result = hasher.VerifyHashedPassword(userInDb, userInDb.Password, Password);
                
                // result can be compared to 0 for failure
                if(result == 0)
                {
                    ModelState.AddModelError("Password", "Invalid Password");
                }
                HttpContext.Session.SetInt32("UserId", userInDb.UserId);
                return RedirectToAction("Dashboard");
            }
            return View("LoginRegistration");
        }

        [Route("Dashboard")]
        [HttpGet]
        public IActionResult Dashboard(int WeddingId)
        {
            int? CheckId = HttpContext.Session.GetInt32("UserId");
            if (CheckId == null)
            {
                return RedirectToAction("LoginReg"); 
            }
            List<Wedding> allWeddings = dbContext.weddings
            .Include(gl=>gl.GuestList)
            .ThenInclude(u => u.User)
            .ToList();
            ViewBag.AllWeddings = allWeddings;
            return View("Dashboard", allWeddings);
        }

        [HttpGet("ShowPlan")]
        public IActionResult ShowPlan()
        {
            return View("PlanWedding");
        }

        [HttpPost("PlanWedding")]
        public IActionResult PlanWedding(Wedding createWedding)
        {
            dbContext.weddings.Add(createWedding);
            dbContext.SaveChanges();
            return RedirectToAction("ShowWedding", new {WeddingId = createWedding.WeddingId});
        }
        
        [HttpPost("RSVP/{WeddingId}")]
        public IActionResult RSVP(int WeddingId)
        {
            Reservation rsvp = new Reservation
            {
                UserId = (int) HttpContext.Session.GetInt32("UserId"),
                WeddingId = WeddingId
            };
            dbContext.reservations.Add(rsvp);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpPost("UNRSVP/{WeddingId}")]
        public IActionResult UNRSVP(int WeddingId)
        {
            Reservation rsvp = dbContext.reservations
            .Where(a => a.UserId == (int) HttpContext.Session
            .GetInt32("UserId"))
            .Where(b => b.WeddingId == WeddingId)
            .SingleOrDefault();
            dbContext.reservations.Remove(rsvp);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpGet("Show/{WeddingId}")]
        public IActionResult ShowWedding(int WeddingId)
        {
            Wedding RetrieveOne = dbContext.weddings
            .Include(a=>a.GuestList)
            .ThenInclude(b=>b.User)
            .FirstOrDefault(us => us.WeddingId == WeddingId);
            ViewBag.AllGuests = RetrieveOne;
            return View("ShowWedding", RetrieveOne);
        }

        [HttpGet("Logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("LoginRegistration");
        }

    }
}
