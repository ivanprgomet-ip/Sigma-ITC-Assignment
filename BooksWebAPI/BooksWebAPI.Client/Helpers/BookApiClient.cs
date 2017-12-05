using BooksWebAPI.Client.Interfaces;
using BooksWebAPI.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace BooksWebAPI.Client.Helpers
{
    public class BookApiClient: IBookApiClient
    {


        public BookApiClient()
        {
           
        }

        public async Task<BookVm> GetBookById(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<BookVm>> GetBooksByTitle(string title)
        {
            throw new NotImplementedException();
        }
    }
}