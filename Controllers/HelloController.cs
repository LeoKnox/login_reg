using System;
using Microsoft.AspNetCore.Mvc;
using login_reg.Models;

namespace login_reg
{
    public class HelloController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }
    }
}