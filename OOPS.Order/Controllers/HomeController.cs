using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OOPS.Order.Controllers
{
    using OOPS.Order.Models;

    /// <summary>
    /// Represents the home controller
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Default page - Home
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            return View();
        }
    }
}
