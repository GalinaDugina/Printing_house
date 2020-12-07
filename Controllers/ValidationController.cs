using System;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PH.Models;
using PH.Models.Data;

namespace PH.Controllers
{
    public class ValidationController : Controller
    {
        private PrintingHouseContext _db;
        private readonly UserManager<User> _userManager;

        public ValidationController(PrintingHouseContext db, UserManager<User> userManager)
        {
            _db = db;
            _userManager = userManager;
        }

        public bool CheckEmail(string email)
        {
            return !_db.Users.Any(u => u.Email == email);
        }
    }
}