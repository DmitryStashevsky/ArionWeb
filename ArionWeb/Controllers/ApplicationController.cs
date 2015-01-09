using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace ArionWeb.Controllers
{
    public class ApplicationController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult Classifier()
        {
            return View();
        }
    }
}
