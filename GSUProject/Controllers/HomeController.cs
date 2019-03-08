using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccess;
using GSUProject.Models;
using DataAccess.DataAccess;
using DataAccess.Models;

namespace GSUProject.Controllers
{
    public class HomeController : Controller
    {
        GsuEventsDBEntities g = new GsuEventsDBEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public JsonResult GetAllEvents(EventModel model)
        {
            var t = new Event().GetEvents(model);

            return Json(t);
        }
        public JsonResult GetSearchEvents(string query = "")
        {
            var r = new Event().SearchEvents(query);
            return Json(r);
        }
        public JsonResult GetResults(string query = "")
        {
            var re = new Event().SearchResults(query);

            return Json(re);
        }
        public JsonResult GetEventType(string query = "")
        {
            var Eres = new Event().GetEventType(query);

            return Json(Eres);
        }
        #region TraditionalMethod 3/7/2019
        //public List<EventModel> GetAllEvents(EventModel model)
        //{


        //    return new Event().GetEvents(model);
        //}
        #endregion

        public ActionResult Details()
        {
            return View();
        }
        public ActionResult Search()
        {
            return View();
        }
    }
}