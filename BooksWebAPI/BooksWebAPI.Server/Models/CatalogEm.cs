using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace BooksWebAPI.Server.Models
{
    [XmlRoot("catalog")]
    public class CatalogEm
    {
        [XmlElement("book")]
        public List<BookEm> Books { get; set; }
    }
}