using BooksWebAPI.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace BooksWebAPI.Client.Interfaces
{
    public interface IBookApiClient
    {
        Task<List<BookVm>> GetBooksByTitle(string title);
        Task<BookVm> GetBookById(string id);
    }
}