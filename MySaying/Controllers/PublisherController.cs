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
    public class PublisherController : Controller
    {
        PublisherManager _publisherManager;
        public PublisherController()
        {
            _publisherManager = new PublisherManager(new EfPublisherDal());
        }
        public IActionResult Index()
        {
            var result = _publisherManager.GetAll();
            return View(result);
        }
        public IActionResult Delete(int id)
        {

            var result = _publisherManager.Get(id);
            _publisherManager.Delete(result.Data);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Modify(int id = 0)
        {


            if (id != 0)//güncellemek için boş değer döndürme
            {
                var result = _publisherManager.Get(id);
                return View(result.Data);
            }
            else
            {
                return View(new Publisher());
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Modify(Publisher publisher)
        {


            if (ModelState.IsValid)
            {
                if (publisher.ID != null)
                {
                    _publisherManager.Update(publisher);
                }
                else
                {
                    _publisherManager.Add(publisher);
                }
            }
            return View(publisher);
        }
    }
}
