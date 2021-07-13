using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MySaying.Models;
using Project.Business.Concrete;
using Project.Core.Utilities.Result;
using Project.DataAccess.Concrete;
using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySaying.Controllers
{
   
    public class BookController : Controller
    {
       private BookManager _bookManager;
        public BookController()
        {
            _bookManager = new BookManager(new EfBookDal());
        }
        public IActionResult Index()
        {
            
            
                IDataResult<List<Book>> result=  _bookManager.GetAll();
                
            
       
            return View(result);

        }
        [Authorize]
        public IActionResult Delete(int id)
        {

           var result=_bookManager.Get(id);
            _bookManager.Delete(result.Data);
            
            return RedirectToAction("Index");
        }
        [Authorize]
        [HttpGet]
        public IActionResult Modify(int id = 0)
        {


            if (id != 0)//güncellemek için boş değer döndürme
            {
                var result = _bookManager.Get(id);
                return View(result.Data);
            }
            else
            {
                return View(new Book());
            }

        }
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken] 
        public IActionResult Modify(Book book)
        {


            if (ModelState.IsValid)
            {
                if (book.ID!=null)
                {
                    _bookManager.Update(book);
                }
                else
                {
                    _bookManager.Add(book);
                }
            }
            return View(book);
        }
    }
}
