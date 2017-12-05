using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace BooksWebAPI.Server.Models
{
    /// <summary>
    /// The Entity Model for a Book object. 
    /// </summary>
    public class BookEm
    {
        [XmlAttribute("id")]
        public string Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public DateTime PublishDate { get; set; }
        public string Description { get; set; }
    }
}