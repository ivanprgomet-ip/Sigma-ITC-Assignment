using BooksWebAPI.Client.Helpers;
using BooksWebAPI.Client.Interfaces;
using BooksWebAPI.Client.Models;
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

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> GetByTitle(string title)
        {
            List<BookVm> result = await bookApiClient.GetBooksByTitle(title);

            return View("Index", result);

        }

        [HttpPost]
        public async Task<ActionResult> GetById(string id)
        {
            var result = await bookApiClient.GetBookById(id);

            if (result != null)
                return View("Index", new List<BookVm> { result });

            return View("Index");
        }
    }
}