using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace BooksWebAPI.Server.Models
{
    /// <summary>
    /// The Entity Model for a Book object. 
    /// The xml attributes for the properties are there to follow the convention of 
    /// lower case letters for xml elements, just like in the books.xml file that was retrieved 
    /// from Sigma ITC.
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