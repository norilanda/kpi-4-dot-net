using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    public class Book
    {
        private string _title;
        private double _price;
        private Date _publishingDate;
        private string _publisher;
        private List<int> _inventoryNumbers;
        private List<Author> _authorList;

        public string Title => _title;
        public double Price { get; set; }
        public Date PublishingDate { get; set; }
        public string Publisher { get; set; }
        public List<int> InventoryNumbers { get; set; }
        public List<Author> AuthorList => _authorList;

        public Book(string title, double price, Date date, string publisher, List<int> inventoryNumbers)
        {
            this._title = title;
            this._price = price;
            this._publishingDate = date;
            this._publisher = publisher;
            this._inventoryNumbers = new List<int>(inventoryNumbers);
            this._authorList = new List<Author>();
        }
        public void AddAuthor(Author author) => this._authorList.Add(author);
        public override string ToString()
        {
            string str = $"Title: {_title}; price: {_price}; publishing date: {_publishingDate}; publisher: {_publisher} | Inventory numbers: {string.Join(", ", _inventoryNumbers.ToArray())}\nAuthor(s): ";
            string[] authorsNamesAndSurnames = new string[_authorList.Count];
            for (int i=0; i<_authorList.Count; i++) {
                authorsNamesAndSurnames[i] = _authorList[i].Firstname + " " + _authorList[i].Lastname;
            }
            str += string.Join(", ", authorsNamesAndSurnames);
            return str;
        }
        public static List<Book> CreateBookList()
        {
            List<Book> bookList = new List<Book>()
            {
                new Book("Fahrenheit 451", 730, new Date(1953, 10, 19), "Ballantine Books", new List<int>(){1, 2, 3, 4, 5}),
                new Book("Dandelion Wine", 1900, new Date(1957, 09, 21), "Doubleday", new List<int>(){6, 7, 8}),
                new Book("The Martian Chronicles", 100, new Date(1950, 04, 06), "Doubleday", new List<int>(){9, 10}),
                new Book("The Call of the Wild", 900, new Date(1903, 01, 10), "Macmillan Publishers", new List<int>(){11}),
                new Book("Heart of Darkness", 2930, new Date(1899, 02, 10), "Blackwood's Magazine", new List<int>(){12, 13, 14}),
                new Book("Pride and Prejudice", 962, new Date(1813, 01, 28), "T. Egerton", new List<int>(){15, 16}),
                new Book("The Great Gatsby", 1200, new Date(1925, 04, 10), "Charles Scribner's Sons", new List<int>(){17}),
                new Book("To Kill a Mockingbird", 398, new Date(1960, 07, 11), "J. B. Lippincott & Co.", new List<int>(){18, 19, 20}),
                new Book("Sense and Sensibility", 962, new Date(1811, 10, 30), "T. Egerton", new List<int>(){21, 22}),
                new Book("Animal Farm", 280, new Date(1945, 08, 17), "Secker and Warburg", new List<int>(){23}),
                new Book("Nineteen Eighty-Four", 978, new Date(1949, 06, 08), "Secker and Warburg", new List<int>(){24, 25}),
                new Book("he Sun Also Rises", 3210, new Date(1926, 10, 22), "Scribner's", new List<int>(){26, 27}),
                new Book("A Farewell to Arms", 1090, new Date(1926, 10, 22), "Scribner's", new List<int>(){28, 29, 30}),
                new Book("The Theory of Everything: The Origin and Fate of the Universe", 1300, new Date(2010, 09, 07), "Bantam Books", new List<int>(){31, 32}),
                new Book("A Brief History of Time", 1300, new Date(1988, 03, 19), "Bantam Books", new List<int>(){33, 34, 35}),
                new Book("The Book Thief", 800, new Date(2005, 03, 14), "Picador", new List<int>(){36}),
                new Book("The Hobbit", 3045, new Date(1937, 09, 21), "George Allen & Unwin", new List<int>(){37, 38}),
                new Book("The Lord of the Rings", 3055, new Date(1954, 09, 21), "George Allen & Unwin", new List<int>(){39, 40, 41, 42}),
                new Book("The Girl with the Dragon Tattoo", 1875, new Date(2005, 08, 01), "Norstedts Förlag", new List<int>(){43}),
            };

            return bookList;
        }
    }
}
