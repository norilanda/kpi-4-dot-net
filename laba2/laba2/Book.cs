using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
        public DateOnly PublishingDate { get; set; }
        public int PublisherId { get; set; }

        public Book() { }
        public Book(int id, string title, double price, DateOnly date, int publisherId)
        {
            this.BookId = id;
            this.Title = title;
            this.Price = price;
            this.PublishingDate = date;
            this.PublisherId = publisherId;
        }
        public override string ToString()
        {
            string str = $"{BookId.ToString().PadRight(3)} {Title.PadRight(25)} {Price.ToString().PadRight(7)} {PublishingDate}    {PublisherId.ToString().PadRight(3)}";
            return str;
        }
        public static Book Parse(XElement book)
        {
            return new Book((int)book.Element("BookId"), (string)book.Element("Title"), (double)(book.Element("Price")),
                            DateOnly.Parse(book.Element("PublishingDate").Value), (int)(book.Element("PublisherId")));
        }
    }
}
