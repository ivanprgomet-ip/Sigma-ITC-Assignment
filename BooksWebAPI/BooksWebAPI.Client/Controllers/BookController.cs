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