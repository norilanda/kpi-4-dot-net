using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    /// <summary>
    ///     Class contains information about specific book in a library.
    ///     Its attributes are: 
    ///     _bookId - a unique id of a book;
    ///     _title - title of a book;
    ///     _price - book's price;
    ///     _publishingDate - date when book was published at the first time
    ///     _publisherId - id of a publisher;
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
    }
}
