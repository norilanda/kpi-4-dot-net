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
        private int _bookId;
        private string _title;
        private double _price;
        private DateOnly _publishingDate;
        private int _publisherId;

        public int BookId => _bookId;
        public string Title => _title;
        public double Price => _price;
        public DateOnly PublishingDate => _publishingDate;
        public int Publisher => _publisherId;

        public Book(int id, string title, double price, DateOnly date, int publisherId)
        {
            this._bookId = id;
            this._title = title;
            this._price = price;
            this._publishingDate = date;
            this._publisherId = publisherId;
        }
        public override string ToString()
        {
            string str = $"{_bookId.ToString().PadRight(3)} {_title.PadRight(25)} {_price.ToString().PadRight(7)} {_publishingDate}    {_publisherId.ToString().PadRight(25)}";
            return str;
        }
    }
}
