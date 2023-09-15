﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text.Encodings.Web;

namespace WebApp.Controllers
{
    public class HelloWorldController : Controller
    {
/*        public IActionResult Index()
        {
            return View();
        }*/

        public string Index()
        {
            return ("Hello");
        }

        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, num is {ID}");
        }

    }
}
