using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    /// <summary>
    /// Contains information about all books, authors and connections between them
    /// </summary>
    public class Library
    {
        private string _name;
        private List<Book> _books;
        private List<Author> _authors;
        private List<BookOfAuthor> _bookOfAuthorList;
        public List<BookOfAuthor> BookOfAuthorList { get => _bookOfAuthorList; set => _bookOfAuthorList = value; }
        public List<Book> Books { get => _books; set => _books = value; }
        public List<Author> Authors { get => _authors; set => _authors = value; }
        public string Name => _name;

        public Library(string name, List<Book> books, List<Author> authors, List<BookOfAuthor> bookOfAuthors)
        {
            this._name = name;
            this._books = books;
            this._authors = authors;
            this._bookOfAuthorList = bookOfAuthors;
        }
    }
}
