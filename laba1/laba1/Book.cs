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
    ///     _bookId - a unique id of book in a specific library. Books with the same title in different libraries may have different ids;
    ///     _title - title of a book;
    ///     _price - book's price;
    ///     _publishingDate, _publisher - these fields show who and when published the book for the first time;
    ///     _inventoryNumbers - numbers that numerate copies of book
    /// </summary>
    public class Book
    {
        private int _bookId;
        private string _title;
        private double _price;
        private DateOnly _publishingDate;
        private string _publisher;
        private List<int> _inventoryNumbers;

        public int BookId => _bookId;
        public string Title => _title;
        public double Price => _price;
        public DateOnly PublishingDate => _publishingDate;
        public string Publisher => _publisher;
        public List<int> InventoryNumbers => _inventoryNumbers;

        public Book(int id, string title, double price, DateOnly date, string publisher, List<int> inventoryNumbers)
        {
            this._bookId = id;
            this._title = title;
            this._price = price;
            this._publishingDate = date;
            this._publisher = publisher;
            this._inventoryNumbers = new List<int>(inventoryNumbers);
        }
        public Book(Book b)
        {
            this._bookId = b._bookId;
            this._title = b._title;
            this._price = b._price;
            this._publishingDate = b._publishingDate;
            this._publisher = b._publisher;
            this._inventoryNumbers = new List<int>(b._inventoryNumbers);
        }
        public override string ToString()
        {
            string str = $"{_bookId.ToString().PadRight(3)} {_title.PadRight(25)} {_price.ToString().PadRight(7)} {_publishingDate}    {_publisher.PadRight(25)} [{new string(string.Join(", ", _inventoryNumbers.ToArray())+"]").PadRight(18)}";
            return str;
        }
    }
}
