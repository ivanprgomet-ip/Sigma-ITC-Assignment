﻿using BooksWebAPI.Server.Interfaces;
using BooksWebAPI.Server.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Net.Http;
using System.Web.Http;

namespace BooksWebAPI.Server.Controllers
{
    [RoutePrefix("api/books")]
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
        [System.Web.Http.AcceptVerbs("GET")]
        [Route("GetByBookId/{id}")]
        public IHttpActionResult GetByBookId(string id)
        {
            var em = bookRepo.GetSingleById(id);
            if (em != null)
                return Ok(em);
            else
                return NotFound();
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.AcceptVerbs("GET")]
        [Route("GetByBookTitle/{title}")]
        public IHttpActionResult GetByBookTitle(string title)
        {
            var em = bookRepo.GetAllByTitleString(title);

            if (em.Count == 0)
                return NotFound();
            else
                return Ok(em);
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.AcceptVerbs("GET")]
        [Route("GetByBookGenre/{genre}")]
        public IHttpActionResult GetByBookGenre(string genre)
        {
            var em = bookRepo.GetAllByGenreString(genre);

            if (em.Count == 0)
                return NotFound();
            else
                return Ok(em);
        }
    }
}