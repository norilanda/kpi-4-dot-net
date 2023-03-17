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
    }
}
