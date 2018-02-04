using QuestionApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuestionApp.Controllers
{
    public class HomeController : Controller
    {
     

        [HttpGet]
        public ActionResult Index()
        {
            return View(new QViewModel());
        }


        [HttpPost]
        public JsonResult GetAnswer(string json)
        {
            
            int index = _rnd.Next(_db.Count);
            var answer = _db[index];

            return Json(answer);

        }

        private static Random _rnd = new Random();
        private static List<string> _db = new List<string> { "yes", "no", "Definitely yes", "I don't know", "Looks Like yes" };
    }
}