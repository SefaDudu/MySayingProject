using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MySaying.Models;
using Project.Business.Concrete;
using Project.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MySaying.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private SayingManager _sayingManager;
        private BookManager _bookManager;
        public HomeController(ILogger<HomeController> logger )
        {
            _logger = logger;
            _sayingManager = new SayingManager(new EfSayingDal());
            _bookManager = new BookManager(new EfBookDal());
        }

        
        public IActionResult Index()
        {
            var result = _sayingManager.GetAll();
            return View(result);
        }

        public IActionResult GetBook(int id)
        {
            var result = _bookManager.Get(id);
            return Json(result.Data);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
