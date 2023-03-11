using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    public class Library
    {
        private List<Book> _books;
        private List<Author> _authors;
        public Library(List<Book> books, List<Author> authors)
        {
            this._books = new List<Book>(books);
            this._authors = new List<Author>(authors);
        }
        public Library() 
        {
            this._books = Book.CreateBookList();
            this._authors = Author.CreateAuthorList();
            ConnectBookAndAuthor();
        }
        private void ConnectBookAndAuthor()
        {
            try
            {
                _books[0].AddAuthor(_authors[0]);
                _books[1].AddAuthor(_authors[0]);
                _books[2].AddAuthor(_authors[0]);

                _books[3].AddAuthor(_authors[1]);
                _books[4].AddAuthor(_authors[2]);
                _books[5].AddAuthor(_authors[3]);
                _books[6].AddAuthor(_authors[4]);
                _books[7].AddAuthor(_authors[5]);
                _books[8].AddAuthor(_authors[3]);

                _books[9].AddAuthor(_authors[6]);
                _books[10].AddAuthor(_authors[6]);
                _books[11].AddAuthor(_authors[7]);
                _books[12].AddAuthor(_authors[7]);

                _books[13].AddAuthor(_authors[8]);
                _books[13].AddAuthor(_authors[9]);
                _books[14].AddAuthor(_authors[8]);
                _books[15].AddAuthor(_authors[10]);

                _books[16].AddAuthor(_authors[11]);
                _books[17].AddAuthor(_authors[11]);
                _books[18].AddAuthor(_authors[12]);
                //---------------------------------------------

                _authors[0].AddBook(_books[0]);
                _authors[0].AddBook(_books[1]);
                _authors[0].AddBook(_books[2]);

                _authors[1].AddBook(_books[3]);
                _authors[2].AddBook(_books[4]);
                _authors[3].AddBook(_books[5]);
                _authors[4].AddBook(_books[6]);
                _authors[5].AddBook(_books[7]);
                _authors[3].AddBook(_books[8]);

                _authors[6].AddBook(_books[9]);
                _authors[6].AddBook(_books[10]);
                _authors[7].AddBook(_books[11]);
                _authors[7].AddBook(_books[12]);
                _authors[8].AddBook(_books[13]);
                _authors[9].AddBook(_books[13]);
                _authors[8].AddBook(_books[14]);
                _authors[10].AddBook(_books[15]);
                _authors[11].AddBook(_books[16]);
                _authors[11].AddBook(_books[17]);
                _authors[12].AddBook(_books[18]);

            }
            catch (IndexOutOfRangeException e)
            { Console.WriteLine(e.Message); }
        }
        public void DisplayLibrary()
        {
            foreach(Book book in _books)
            {
                Console.WriteLine(book.ToString());
                Console.WriteLine("-----------------------------------");
            }
            Console.WriteLine();
        }
        public void DisplayAllAuthors()
        {
            foreach (Author author in _authors)
            {
                Console.WriteLine(author.ToString());                
            }
            Console.WriteLine();
        }
    }
}
