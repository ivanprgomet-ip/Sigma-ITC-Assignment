using BooksWebAPI.Server.Interfaces;
using BooksWebAPI.Server.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Net.Http;
using System.Web.Mvc;

namespace BooksWebAPI.Server.Controllers
{
    public class BookController : Controller
    {
        private IBookRepository bookRepo;

        public BookController() : this(new BookRepository()) { }

        public BookController(IBookRepository bookRepo)
        {
            if (bookRepo == null)
                throw new ArgumentNullException(nameof(bookRepo));

            this.bookRepo = bookRepo;
        }

        [HttpGet]
        [Route("getbybookid/{id}")]
        public object GetByBookId(string id)
        {
            var em = bookRepo.GetSingleById(id);
            if (em != null)
                return em;
            else
                return new HttpNotFoundResult("Sorry, the book could not be found...");
        }

        [HttpGet]
        [Route("getbybooktitle/{title}")]
        public object GetByBookTitle(string title) // todo: why does it only work with id parameter
        {
            var em = bookRepo.GetAllByTitleString(title);

            if (em.Count == 0)
                return new HttpNotFoundResult("Sorry, but there are no books that match the title string...");
            else
                return em;
        }
    }
}