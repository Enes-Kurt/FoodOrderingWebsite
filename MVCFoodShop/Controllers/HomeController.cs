﻿using Microsoft.AspNetCore.Mvc;
using MVCFoodShop.Models;
using System.Diagnostics;

namespace MVCFoodShop.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

    }
}