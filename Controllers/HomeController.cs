using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CSharpBeltExam.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace CSharpBeltExam.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private MyContext _context;
        public HomeController(ILogger<HomeController> logger, MyContext context)
        {
            _logger = logger;
            _context = context;
        }
        //USERS LOG/REG
        public IActionResult Index()
        {
            return View();
        }


        //Register

        //Register
        [HttpPost("users/add")]
        public IActionResult AddUser(User newUser)
        {
            if(ModelState.IsValid)
            {
                if(_context.Users.Any(a => a.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "Email is already registered");
                    return View("Index");
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                _context.Users.Add(newUser);
                _context.SaveChanges();
                //set up session
                HttpContext.Session.SetInt32("UserId", newUser.UserId);
                return RedirectToAction("Dashboard");
            } else {
                return View("Index");
            }
        }

        //Login

        [HttpPost("users/login")]
        public IActionResult LoginUser(LoginUser loggedIn)
        {
            if(ModelState.IsValid)
            {
                //Find user:
                User userInDB = _context.Users.FirstOrDefault(a => a.Email == loggedIn.LoginEmail);
                if(userInDB == null)
                {
                    ModelState.AddModelError("LoginEmail", "Invalid login Attempt");
                    return View("Index");
                }
                //hash entered password and check with DB:
                var hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(loggedIn, userInDB.Password, loggedIn.LoginPassword);
                if (result == 0)
                {
                    ModelState.AddModelError("LoginEmail", "Invalid login Attempt");
                    return View("Index");
                }
                //set up session
                HttpContext.Session.SetInt32("UserId", userInDB.UserId);
                return RedirectToAction("Dashboard");
            } else {
                return View("Index");
            }
        }

        [HttpGet("Dashboard")]
        public IActionResult Dashboard()
        {
            //set up session credential
            if(HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("Index");
            }
            ViewBag.AllMeetings = _context.Meetings.Include(a => a.Coordinator).Include(a => a.InvitesMade).OrderBy(a => a.Date).ToList();
            ViewBag.LoggedIn = _context.Users.FirstOrDefault(a => a.UserId == HttpContext.Session.GetInt32("UserId"));
            return View();
        }

        //Add new meeting
        [HttpGet("meeting/add")]
        public IActionResult AddMeeting()
        {
            if(HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost("meeting/new")]
        public IActionResult NewMeeting(Meeting newMeeting)
        {
            if(ModelState.IsValid)
            {
                newMeeting.UserId = (int)HttpContext.Session.GetInt32("UserId");
                _context.Meetings.Add(newMeeting);
                _context.SaveChanges();
                return RedirectToAction("Dashboard");
            } else {
                return View("AddMeeting");
            }
        }

        //View One Meetup
        [HttpGet("meeting/{meetId}")]
        public IActionResult OneMeeting(int meetId)
        {
            if(HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("Index");
            }
            if(_context.Invites.Where(a => a.MeetingId == meetId).Any(a => a.UserId == (int)HttpContext.Session.GetInt32("UserId")))
            {
                ViewBag.Attending = true;
            } else {
                ViewBag.Attending = false;
            }
            ViewBag.Meeting = _context.Meetings.Include(a => a.Coordinator).Include(a => a.InvitesMade).ThenInclude(a => a.Participant).FirstOrDefault(a => a.MeetingId == meetId);
            ViewBag.User = HttpContext.Session.GetInt32("UserId");
            return View();
        }

        //Join a meetup
        [HttpPost("meeting/join/{meetId}")]
        public IActionResult JoinMeeting(int meetId, string navigation)
        {
            if(HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("Index");
            }
            Meeting meeting = _context.Meetings.FirstOrDefault(a => a.MeetingId == meetId);
            Invite newInvite = new Invite{UserId = (int)HttpContext.Session.GetInt32("UserId"), MeetingId = meetId};
            _context.Invites.Add(newInvite);
            _context.SaveChanges();
            if(navigation == "onemeeting")
            {
                return Redirect($"/meeting/{meetId}");
            } else {
                return RedirectToAction("Dashboard");
            }
        }

        //Unjoin a meetup
        [HttpPost("meeting/unjoin/{meetId}")]
        public IActionResult UnjoinMeeting(int meetId, string navigation)
        {
            if(HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("Index");
            }
            Invite InviteToDelete = _context.Invites.SingleOrDefault(a => a.UserId == (int)HttpContext.Session.GetInt32("UserId") && a.MeetingId == meetId);
            _context.Invites.Remove(InviteToDelete);
            _context.SaveChanges();
            if(navigation == "onemeeting")
            {
                return Redirect($"/meeting/{meetId}");
            } else {
                return RedirectToAction("Dashboard");
            }
        }

        //DELETE meeting
        [HttpGet("meeting/delete/{meetId}")]
        public IActionResult DeleteMeeting(int meetId)
        {
            if(HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("Index");
            }
            Meeting MeetToDelete = _context.Meetings.SingleOrDefault(a => a.MeetingId == meetId);
            _context.Meetings.Remove(MeetToDelete);
            _context.SaveChanges();
            return RedirectToAction("Dashboard");
        }



        //LOGOUT
        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
