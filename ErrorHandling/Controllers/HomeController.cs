using ErrorHandling.Filter;
using ErrorHandling.Models;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ErrorHandling.Controllers
{
    [CustomHandleExceptionFilterAttribute(ErrorPage ="Hata1")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //throw new Exception("Veri tabanı bağlanırken hata meydana geldi");
            int a = 5;
            int b = 0;
            int result = a / b;
            return View();
        }
        [CustomHandleExceptionFilterAttribute(ErrorPage = "Hata2 ")]
        public IActionResult Privacy()
        {
           
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            var exception = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            ViewBag.path = exception.Path;
            ViewBag.Message = exception.Error.Message.ToString();
            return View();
        }
        public IActionResult Hata1()
        {
            return  View();
        }  
        public IActionResult Hata2()
        {
            return View();
        }
    }
}
