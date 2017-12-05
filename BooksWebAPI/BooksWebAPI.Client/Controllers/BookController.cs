using BooksWebAPI.Client.Helpers;
using BooksWebAPI.Client.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace BooksWebAPI.Client.Controllers
{
    public class BookController : Controller
    {
        private IBookApiClient bookApiClient;

        public BookController():this(new BookApiClient()) { }

        public BookController(IBookApiClient bookApiClient)
        {
            if(bookApiClient ==  null)
                throw new ArgumentNullException(nameof(bookApiClient));

            this.bookApiClient = bookApiClient;
        }

        // GET: Book
        public ActionResult Index()
        {
            return View();
        }


        public Task<ActionResult> GetByTitle(string title)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
}