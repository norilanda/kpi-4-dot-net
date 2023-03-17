using System;
using System.Collections.Generic;
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
        public double Price { get; set; }
        public DateOnly PublishingDate { get; set; }
        public string Publisher { get; set; }
        public List<int> InventoryNumbers { get; set; }

        public Book(int id, string title, double price, DateOnly date, string publisher, List<int> inventoryNumbers)
        {
            this._bookId = id;
            this._title = title;
            this._price = price;
            this._publishingDate = date;
            this._publisher = publisher;
            this._inventoryNumbers = inventoryNumbers;
            this._inventoryNumbers = new List<int>(inventoryNumbers);
        }
        public override string ToString()
        {
            string str = $"Id: {_bookId} Title: {_title}; price: {_price}; publishing date: {_publishingDate}; publisher: {_publisher} | Inventory numbers: {string.Join(", ", _inventoryNumbers.ToArray())}";
            return str;
        }
        public static List<Book> CreateBookList()
        {
            List<Book> bookList = new List<Book>()
            {
                new Book(0, "Fahrenheit 451", 730, new DateOnly(1953, 10, 19), "Ballantine Books", new List<int>(){1, 2, 3, 4, 5}),
                new Book(1, "Dandelion Wine", 1900, new DateOnly(1957, 09, 21), "Doubleday", new List<int>(){6, 7, 8}),
                new Book(2, "The Martian Chronicles", 100, new DateOnly(1950, 04, 06), "Doubleday", new List<int>(){9, 10}),
                new Book(3, "The Call of the Wild", 900, new DateOnly(1903, 01, 10), "Macmillan Publishers", new List<int>(){11}),
                new Book(4, "Heart of Darkness", 2930, new DateOnly(1899, 02, 10), "Blackwood's Magazine", new List<int>(){12, 13, 14}),
                new Book(5, "Pride and Prejudice", 962, new DateOnly(1813, 01, 28), "T. Egerton", new List<int>(){15, 16}),
                new Book(6, "The Great Gatsby", 1200, new DateOnly(1925, 04, 10), "Charles Scribner's Sons", new List<int>(){17}),
                new Book(7, "To Kill a Mockingbird", 398, new DateOnly(1960, 07, 11), "J. B. Lippincott & Co.", new List<int>(){18, 19, 20}),
                new Book(8, "Sense and Sensibility", 962, new DateOnly(1811, 10, 30), "T. Egerton", new List<int>(){21, 22}),
                new Book(9, "Animal Farm", 280, new DateOnly(1945, 08, 17), "Secker and Warburg", new List<int>(){23}),
                new Book(11, "Nineteen Eighty-Four", 978, new DateOnly(1949, 06, 08), "Secker and Warburg", new List<int>(){24, 25}),
                new Book(11, "he Sun Also Rises", 3210, new DateOnly(1926, 10, 22), "Scribner's", new List<int>(){26, 27}),
                new Book(12, "A Farewell to Arms", 1090, new DateOnly(1926, 10, 22), "Scribner's", new List<int>(){28, 29, 30}),
                new Book(13, "The Theory of Everything: The Origin and Fate of the Universe", 1300, new DateOnly(2010, 09, 07), "Bantam Books", new List<int>(){31, 32}),
                new Book(14, "A Brief History of Time", 1300, new DateOnly(1988, 03, 19), "Bantam Books", new List<int>(){33, 34, 35}),
                new Book(15, "The Book Thief", 800, new DateOnly(2005, 03, 14), "Picador", new List<int>(){36}),
                new Book(16, "The Hobbit", 3045, new DateOnly(1937, 09, 21), "George Allen & Unwin", new List<int>(){37, 38}),
                new Book(17, "The Lord of the Rings", 3055, new DateOnly(1954, 09, 21), "George Allen & Unwin", new List<int>(){39, 40, 41, 42}),
                new Book(18, "The Girl with the Dragon Tattoo", 1875, new DateOnly(2005, 08, 01), "Norstedts Förlag", new List<int>(){43}),
            };

            return bookList;
        }
    }
}
