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
        private DateOnly _publishingDate;
        private string _publisher;
        private List<int> _inventoryNumbers;

        public string Title => _title;
        public double Price { get; set; }
        public DateOnly PublishingDate { get; set; }
        public string Publisher { get; set; }
        public List<int> InventoryNumbers { get; set; }

        public Book(string title, double price, DateOnly date, string publisher, List<int> inventoryNumbers)
        {
            this._title = title;
            this._price = price;
            this._publishingDate = date;
            this._publisher = publisher;
            this._inventoryNumbers = inventoryNumbers;
            this._inventoryNumbers = new List<int>(inventoryNumbers);
        }
        public override string ToString()
        {
            string str = $"Title: {_title}; price: {_price}; publishing date: {_publishingDate}; publisher: {_publisher} | Inventory numbers: {string.Join(", ", _inventoryNumbers.ToArray())}\nAuthor(s): ";
            return str;
        }
    }
}
