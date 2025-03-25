using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment_2.DataAccessLayer;

namespace Assignment_2.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult User(string txtName, string txtPassword)
        {
            string returnedmsg;
            Boolean fromgetuser = false;
            UserDataAccess obj = new UserDataAccess();
            fromgetuser = obj.GetUser(txtName, txtPassword);

            if (fromgetuser)
            {
                returnedmsg = "authenticated";
                ViewBag.Message = returnedmsg;
            }
            else
            {
                returnedmsg = "unauthenticated";
                ViewBag.Message = returnedmsg;
            }
            return View("Login");
        }
    }
}