using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using finalProject101.Models;

namespace finalProject101.Controllers
{
    public class UserControllerOld : Controller
    {
        // GET: User
        public ActionResult Random()
        {
            var user = new User() { Ufname = "abel", Ulname = "mekuria2" };
            return View(user);
        }
    }
}