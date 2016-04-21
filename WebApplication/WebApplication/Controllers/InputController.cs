using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class InputController : Controller
    {
        // GET: Input
        public ActionResult Index()
        {
            return View(new PokerInputModels());
        }

        public ActionResult Calculate(PokerInputModels input)
        {
            if (input.SmallBlind >= input.BigBlind)
                ModelState.AddModelError("BigBlind", "Big Blind must be greater than Small Blind");

            if (input.Ante > input.SmallBlind)
                ModelState.AddModelError("Ante", "Small Blind must be greater than Ante");

            if (!ModelState.IsValid)
                return View("Index", input);

            return RedirectToAction("Index","Output", input);
        }
    }
}