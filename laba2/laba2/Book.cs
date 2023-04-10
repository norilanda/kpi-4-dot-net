using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace laba1
{
    /// <summary>
    ///     Class contains information about specific book in a library.
    ///     Its attributes are: 
    ///      BookId - a unique id of a book;
    ///      Title - title of a book;
    ///      Price - book's price;
    ///      PublishingDate - date when book was published at the first time
    ///      PublisherId - id of a publisher;
    /// </summary>
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }

        [XmlElement(DataType = "date")]
        public DateTime PublishingDate { get; set; }
        public int PublisherId { get; set; }

        public Book() { }
        public Book(int id, string title, double price, DateTime date, int publisherId)
        {
            this.BookId = id;
            this.Title = title;
            this.Price = price;
            this.PublishingDate = date;
            this.PublisherId = publisherId;
        }
        public override string ToString()
        {
            string str = $"{BookId.ToString().PadRight(3)} {Title.PadRight(25)} {Price.ToString().PadRight(7)} {PublishingDate.ToShortDateString()}    {PublisherId.ToString().PadRight(3)}";
            return str;
        }
        // creating Book object from XElement
        public static Book Parse(XElement book)
        {
            return new Book((int)book.Element("BookId"), (string)book.Element("Title"), (double)(book.Element("Price")),
                            DateTime.Parse(book.Element("PublishingDate").Value), (int)(book.Element("PublisherId")));
        }
    }
}
