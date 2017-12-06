using BooksWebAPI.Server.Interfaces;
using BooksWebAPI.Server.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Net.Http;
//using System.Web.Mvc;
using System.Web.Http;

namespace BooksWebAPI.Server.Controllers
{
    public class BookController : ApiController
    {
        private IBookRepository bookRepo;

        public BookController() : this(new BookRepository()) { }

        public BookController(IBookRepository bookRepo)
        {
            if (bookRepo == null)
                throw new ArgumentNullException(nameof(bookRepo));

            this.bookRepo = bookRepo;
        }

        [System.Web.Http.HttpGet]
        //[Route("getbybookid/{id}")]
        public object GetByBookId(string id)
        {
            var em = bookRepo.GetSingleById(id);
            if (em != null)
                return em;
            else
                return Content(HttpStatusCode.NotFound, "could not find the book");
        }

        [System.Web.Http.HttpGet]
        //[Route("getbybooktitle/{title}")]
        public object GetByBookTitle(string id) // TODO: why does it only work with id parameter
        {
            var em = bookRepo.GetAllByTitleString(id);

            if (em.Count == 0)
                return Content(HttpStatusCode.NotFound, "could not find any bok that matched the title string");
            else
                return em;
        }
    }
}