using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class OutputController : Controller
    {
        // GET: Output
        public ActionResult Index(PokerInputModels input)
        {
            PokerOutputModels output = input.Calculate();

            return View(output);
        }
    }
}