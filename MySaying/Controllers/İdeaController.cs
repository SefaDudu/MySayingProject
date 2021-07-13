using Microsoft.AspNetCore.Mvc;
using Project.Business.Concrete;
using Project.DataAccess.Concrete;
using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySaying.Controllers
{
    public class İdeaController : Controller
    {

        OpinionManager opinionManager;


        public İdeaController()
        {
            opinionManager = new OpinionManager(new EfOpinionDal());
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddComment(Opinion opinion)
        {
            opinionManager.Add(opinion);
            return RedirectToAction("Index");

        }


    }
}
