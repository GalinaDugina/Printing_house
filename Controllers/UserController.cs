using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using PH.Models;
using PH.Models.Data;

namespace PH.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        private PrintingHouseContext _db;

        public readonly IHostEnvironment _environment;
        //private FileUploadService _fileUpload;

        public UserController(UserManager<User> userManager, SignInManager<User> signInManager,
            PrintingHouseContext db, IHostEnvironment environment)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _db = db;
            _environment = environment;
        }

        [Authorize]
        // GET
    public IActionResult Index(string? userId )
    {
        if (userId == null)
        {
            userId = _userManager.GetUserId(User);
        }
        User user = _db.Users.FirstOrDefault(u => u.Id == userId);
       
        
            return View(user);
        }
   

  //  [Authorize(Roles = "admin")]
    public IActionResult UserList()
    {
        List<User> users = _db.Users.ToList();
        return View(users);
    }

    //[Authorize(Roles = "admin")]
    public IActionResult Block(string id)
    {
        User user = _db.Users.FirstOrDefault(u => u.Id == id);
        if (user.IsBlock)
        {
            user.IsBlock = false;
        }
        else
        {
            user.IsBlock = true;
        }

        _db.Entry(user).State = EntityState.Modified;
        _db.SaveChanges();
        return RedirectToAction("UserList");
    }
    }
}