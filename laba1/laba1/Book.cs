using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    /// <summary>
    /// Class contains information about specific book in a library.
    /// It has such fields as bookId, title, price, publishing date, publisher and inventory numbers
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
            //string str = $"Id: {_bookId} Title: {_title}; price: {_price}; date: {_publishingDate}; publisher: {_publisher}; | Inventory numbers: {string.Join(", ", _inventoryNumbers.ToArray())}";
            return str;
        }
    }
}
