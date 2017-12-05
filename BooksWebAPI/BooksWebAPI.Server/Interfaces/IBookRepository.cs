﻿using BooksWebAPI.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksWebAPI.Server.Interfaces
{
    public interface IBookRepository
    {
        List<BookEm> GetBooksByTitleString(string title);
        BookEm GetBookById(string id);
    }
}
