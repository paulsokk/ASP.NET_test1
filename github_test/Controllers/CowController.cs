using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using github_test.Models;

namespace github_test.Controllers
{
    public class CowController : Controller
    {
        // GET: Cow
        public ActionResult Index()
        {
            CowModel Cow1 = new CowModel() { Name = "Alma", Weight = 120 };
            return View("Cow name: {0}. Cow weight: {1}.", Cow1.Name, Cow1.Weight);
        }
    }
}