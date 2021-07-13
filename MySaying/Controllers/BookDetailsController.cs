using Microsoft.AspNetCore.Mvc;
using MySaying.Models;
using Project.Business.Concrete;
using Project.Core.Utilities;
using Project.DataAccess.Concrete;
using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySaying.Controllers
{
    public class BookDetailsController : Controller
    {
        BookManager _bookManager;
        CommentManager _commentManager;
        public BookDetailsController()
        {
            _bookManager = new BookManager(new EfBookDal());
            _commentManager = new CommentManager(new EfCommentDal());
        }


        public IActionResult Index(int id)
        {
            BookDetailVM vmModel = new BookDetailVM();

            vmModel.Book = _bookManager.Get(id).Data;
            vmModel.Comments = _commentManager.GetAllWithQuery(id).Data;

            return View(vmModel);
        }


        [HttpPost]
        public IActionResult AddComment(Comment comment)
        {
            _commentManager.Add(comment);

            return RedirectToAction("Index","BookDetails", new { id = comment.BookId });
        }
    }
}
