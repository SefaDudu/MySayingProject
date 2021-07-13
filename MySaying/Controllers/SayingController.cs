using Microsoft.AspNetCore.Authorization;
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
    [Authorize]
    public class SayingController : Controller
    {
        SayingManager _sayingManager;
        public SayingController()
        {
            _sayingManager = new SayingManager(new EfSayingDal());
        }
        public IActionResult Index()
        {
            var result = _sayingManager.GetAll();
            return View(result);
        }
        public IActionResult Delete(int id)
        {
            var result = _sayingManager.Get(id);
            _sayingManager.Delete(result.Data);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Modify(int id = 0)
        {


            if (id != 0)//güncellemek için boş değer döndürme
            {
                var result = _sayingManager.Get(id);
                return View(result.Data);
            }
            else
            {
                return View(new Saying());
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Modify(Saying saying)
        {


            if (ModelState.IsValid)
            {
                if (saying.ID != null)
                {
                    _sayingManager.Update(saying);
                }
                else
                {
                    _sayingManager.Add(saying);
                }
            }
            return View(saying);
        }
    }
}
