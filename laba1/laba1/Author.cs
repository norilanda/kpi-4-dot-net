using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    public class Author
    {
        private string _firstName;
        private string _lastName;
        private List<Book> _bookList;

        public string Firstname => this._firstName;
        public string Lastname => this._lastName;
        public List<Book> BookList => _bookList;

        public Author(string firstName, string lastName)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this._bookList = new List<Book>();
        }
        public void AddBook(Book book) => this._bookList.Add(book);
        public static List<Author> CreateAuthorList()
        {
            List<Author> authorList = new List<Author>()
            {
                new Author("Ray", "Bradbury"),
                new Author("Jack", "London"),
                new Author("Joseph", "Conrad"),
                new Author("Jane", "Austen"),
                new Author("Scott", "Fitzgerald"),
                new Author("Harper", "Lee"),
                new Author("George", "Orwell"),
                new Author("Ernest", "Hemingway"),
                new Author("Stephen", "Hawkingon"),
                new Author("Leonard", "Mlodinow"),
                new Author("Markus", "Zusak"),
                new Author("J. R. R.", "Tolkien"),
                new Author("Stieg", "Larsson")
            };
            return authorList;
        }
    }
}
