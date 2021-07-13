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
    public class WriterController : Controller
    {
        WriterManager _writerManager;
        public WriterController()
        {
            _writerManager = new WriterManager(new EfWriterDal());
        }
        public IActionResult Index()
        {
            var result = _writerManager.GetAll();
            return View(result);
        }
        public IActionResult Delete(int id)
        {

            var result = _writerManager.Get(id);
            _writerManager.Delete(result.Data);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Modify(int id = 0)
        {


            if (id != 0)//güncellemek için boş değer döndürme
            {
                var result = _writerManager.Get(id);
                return View(result.Data);
            }
            else
            {
                return View(new Writer());
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Modify(Writer writer)
        {


            if (ModelState.IsValid)
            {
                if (writer.ID != null)
                {
                    _writerManager.Update(writer);
                }
                else
                {
                    _writerManager.Add(writer);
                }
            }
            return View(writer);
        }

    }
}

