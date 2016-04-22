using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;
using WebApplication.Logic;

namespace WebApplication.Controllers
{
    public class OutputController : Controller
    {
        // GET: Output
        public ActionResult Index(PokerInputModels input)
        {
            Calculator calc = new Calculator();
            PokerOutputModels output = calc.Calculate(input);

            return View(output);
        }
    }
}