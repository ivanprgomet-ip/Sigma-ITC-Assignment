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
        [XmlElement("author")]
        public string Author { get; set; }
        [XmlElement("title")]
        public string Title { get; set; }
        [XmlElement("genre")]
        public string Genre { get; set; }
        [XmlElement("price")]
        public decimal Price { get; set; }
        [XmlElement("publish_date")]
        public DateTime PublishDate { get; set; }
        [XmlElement("description")]
        public string Description { get; set; }
    }
}