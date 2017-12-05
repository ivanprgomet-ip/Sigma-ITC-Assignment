using BooksWebAPI.Server.Interfaces;
using BooksWebAPI.Server.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BooksWebAPI.Server.Controllers
{
    public class BookController : Controller
    {
        private IBookRepository bookRepo;

        public BookController():this(new BookRepository()) { }

        public BookController(IBookRepository bookRepo)
        {
            if (bookRepo == null)
                throw new ArgumentNullException(nameof(bookRepo));

            this.bookRepo = bookRepo;
        }

        public ActionResult Index()
        {
            return View();
        }

        // search for book(s) by title
            // shall find books where only a part of the title might be the search word

        //public ActionResult GetByBookTitle(string title)
        //{

        //}

        //public ActionResult GetByBookId(string id)
        //{

        //}

    }
}