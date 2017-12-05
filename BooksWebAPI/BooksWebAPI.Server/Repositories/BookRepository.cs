using BooksWebAPI.Server.Interfaces;
using BooksWebAPI.Server.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Xml.Serialization;

namespace BooksWebAPI.Server.Repositories
{
    public class BookRepository : IBookRepository
    {
        private CatalogEm Catalog { get; set; }

        public BookRepository()
        {
            #region deserialize books xml file

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(CatalogEm));

            using (var reader = new StreamReader(HostingEnvironment.MapPath(@"~/App_Data/books.xml")))
            {
                Catalog = (CatalogEm)xmlSerializer.Deserialize(reader);// TODO: why getting all null values except the Id property?
            }

            #endregion
        }

        public BookEm GetBookById(string id)
        {
            BookEm retrieved = Catalog.Books.Where(b => b.Id == id).FirstOrDefault();

            return retrieved == null ? null : retrieved;
        }

        public List<BookEm> GetBooksByTitleString(string title)
        {
            return Catalog.Books.Where(b => b.Title.Contains(title)).ToList();
        }
    }
}