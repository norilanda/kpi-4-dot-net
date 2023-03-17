using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    public class BookOfAuthor
    {
        private Book _book;
        private Author _author;

        public Book book { get; set; }
        public Author author { get; set; }

        public BookOfAuthor(Book book, Author author)
        {
            this._book = book;
            this._author = author;
        }
        public static List<BookOfAuthor> CreateBookOfAuthorList()
        {
            List<BookOfAuthor> list = new List<BookOfAuthor>()
            {
                new BookOfAuthor(
                    new Book("Fahrenheit 451", 730, new DateOnly(1953, 10, 19), "Ballantine Books", new List<int>(){1, 2, 3, 4, 5}),
                    new Author("Ray", "Bradbury")),
                new BookOfAuthor(
                    new Book("Dandelion Wine", 1900, new DateOnly(1957, 09, 21), "Doubleday", new List<int>(){6, 7, 8}),
                    new Author("Ray", "Bradbury")),
                new BookOfAuthor(
                    new Book("The Martian Chronicles", 100, new DateOnly(1950, 04, 06), "Doubleday", new List<int>(){9, 10}),
                    new Author("Ray", "Bradbury")),
                new BookOfAuthor(
                    new Book("The Call of the Wild", 900, new DateOnly(1903, 01, 10), "Macmillan Publishers", new List<int>(){11}),
                    new Author("Jack ", "London")),
                new BookOfAuthor(
                    new Book("Heart of Darkness", 2930, new DateOnly(1899, 02, 10), "Blackwood's Magazine", new List<int>(){12, 13, 14}),
                    new Author("Joseph ", "Conrad")),
                new BookOfAuthor(
                    new Book("Pride and Prejudice", 962, new DateOnly(1813, 01, 28), "T. Egerton", new List<int>(){15, 16}),
                    new Author("Jane ", "Austen")),
                new BookOfAuthor(
                    new Book("The Great Gatsby", 1200, new DateOnly(1925, 04, 10), "Charles Scribner's Sons", new List<int>(){17}),
                    new Author("Scott ", "Fitzgerald")),
                new BookOfAuthor(
                    new Book("To Kill a Mockingbird", 398, new DateOnly(1960, 07, 11), "J. B. Lippincott & Co.", new List<int>(){18, 19, 20}),
                    new Author("Harper ", "Lee")),
                new BookOfAuthor(
                    new Book("Sense and Sensibility", 962, new DateOnly(1811, 10, 30), "T. Egerton", new List<int>(){21, 22}),
                    new Author("Jane ", "Austen")),
                new BookOfAuthor(
                    new Book("Animal Farm", 280, new DateOnly(1945, 08, 17), "Secker and Warburg", new List<int>(){23}),
                    new Author("George ", "Orwell")),
                new BookOfAuthor(
                    new Book("Nineteen Eighty-Four", 978, new DateOnly(1949, 06, 08), "Secker and Warburg", new List<int>(){24, 25}),
                    new Author("George ", "Orwell")),
                new BookOfAuthor(
                    new Book("he Sun Also Rises", 3210, new DateOnly(1926, 10, 22), "Scribner's", new List<int>(){26, 27}),
                    new Author("Ernest ", "Hemingway")),
                 new BookOfAuthor(
                    new Book("A Farewell to Arms", 1090, new DateOnly(1926, 10, 22), "Scribner's", new List<int>(){28, 29, 30}),
                    new Author("Ernest ", "Hemingway")),
                 new BookOfAuthor(
                    new Book("The Theory of Everything: The Origin and Fate of the Universe", 1300, new DateOnly(2010, 09, 07), "Bantam Books", new List<int>(){31, 32}),
                    new Author("Stephen ", "Hawkingon")),
                 new BookOfAuthor(
                    new Book("The Theory of Everything: The Origin and Fate of the Universe", 1300, new DateOnly(2010, 09, 07), "Bantam Books", new List<int>(){31, 32}),
                    new Author("Leonard ", "Mlodinow")),
                 new BookOfAuthor(
                    new Book("A Brief History of Time", 1300, new DateOnly(1988, 03, 19), "Bantam Books", new List<int>(){33, 34, 35}),
                    new Author("Stephen ", "Hawkingon")),
                 new BookOfAuthor(
                    new Book("The Book Thief", 800, new DateOnly(2005, 03, 14), "Picador", new List<int>(){36}),
                    new Author("Markus ", "Zusak")),
                 new BookOfAuthor(
                    new Book("The Hobbit", 3045, new DateOnly(1937, 09, 21), "George Allen & Unwin", new List<int>(){37, 38}),
                    new Author("J. R. R. ", "Tolkien")),
                 new BookOfAuthor(
                    new Book("The Lord of the Rings", 3055, new DateOnly(1954, 09, 21), "George Allen & Unwin", new List<int>(){39, 40, 41, 42}),
                    new Author("J. R. R. ", "Tolkien")),
                 new BookOfAuthor(
                    new Book("The Girl with the Dragon Tattoo", 1875, new DateOnly(2005, 08, 01), "Norstedts Förlag", new List<int>(){43}),
                    new Author("Stieg ", "Larsson")),
            };
            return list;            
        }
    }
}
