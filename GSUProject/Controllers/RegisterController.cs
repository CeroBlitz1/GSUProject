using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccess.Models;
using DataAccess.DataAccess;

namespace GSUProject.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        //public JsonResult GetResults(string query = "")
        //{
        //    var re = new Event().SearchResults(query);

        //    return Json(re);
        //}

        public JsonResult Register(UserModel model)
        {
            var Reg = new Users().SaveUsers(model);

            return Json(Reg);
        }
        public JsonResult Login(UserModel model)
        {
            var log = new Users().UserLogin(model);

            return Json(log);
        }
    }
}