using BooksWebAPI.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksWebAPI.Server.Interfaces
{
    public interface IBookRepository
    {
        List<BookEm> GetAllByTitleString(string title);
        List<BookEm> GetAllByGenreString(string genre);
        BookEm GetSingleById(string id);
    }
}
