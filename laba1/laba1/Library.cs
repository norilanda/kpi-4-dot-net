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
        private List<Book> _books;
        private List<Author> _authors;
        private List<BookOfAuthor> _bookOfAuthorList;
        public List<BookOfAuthor> BookOfAuthorList { get; set; }
        public List<Book> Books { get => _books; set => _books = value; }
        public List<Author> Authors { get => _authors; set => _authors = value; }

        public Library()
        {
            this._bookOfAuthorList = new List<BookOfAuthor>();
        }
        public void ConnectBookAndAuthor()
        {
            try
            {
                this._bookOfAuthorList.Add(new BookOfAuthor(_books[0].BookId, _authors[0].AuthorId));
                this._bookOfAuthorList.Add(new BookOfAuthor(_books[1].BookId, _authors[0].AuthorId));
                this._bookOfAuthorList.Add(new BookOfAuthor(_books[2].BookId, _authors[0].AuthorId));
                this._bookOfAuthorList.Add(new BookOfAuthor(_books[3].BookId, _authors[1].AuthorId));
                this._bookOfAuthorList.Add(new BookOfAuthor(_books[4].BookId, _authors[2].AuthorId));
                this._bookOfAuthorList.Add(new BookOfAuthor(_books[5].BookId, _authors[3].AuthorId));
                this._bookOfAuthorList.Add(new BookOfAuthor(_books[6].BookId, _authors[4].AuthorId));
                this._bookOfAuthorList.Add(new BookOfAuthor(_books[7].BookId, _authors[5].AuthorId));
                this._bookOfAuthorList.Add(new BookOfAuthor(_books[8].BookId, _authors[3].AuthorId));
                this._bookOfAuthorList.Add(new BookOfAuthor(_books[9].BookId, _authors[6].AuthorId));
                this._bookOfAuthorList.Add(new BookOfAuthor(_books[10].BookId, _authors[6].AuthorId));
                this._bookOfAuthorList.Add(new BookOfAuthor(_books[11].BookId, _authors[7].AuthorId));
                this._bookOfAuthorList.Add(new BookOfAuthor(_books[12].BookId, _authors[7].AuthorId));
                this._bookOfAuthorList.Add(new BookOfAuthor(_books[13].BookId, _authors[8].AuthorId));
                this._bookOfAuthorList.Add(new BookOfAuthor(_books[13].BookId, _authors[9].AuthorId));
                this._bookOfAuthorList.Add(new BookOfAuthor(_books[14].BookId, _authors[8].AuthorId));
                this._bookOfAuthorList.Add(new BookOfAuthor(_books[15].BookId, _authors[10].AuthorId));
                this._bookOfAuthorList.Add(new BookOfAuthor(_books[16].BookId, _authors[11].AuthorId));
                this._bookOfAuthorList.Add(new BookOfAuthor(_books[17].BookId, _authors[11].AuthorId));
                this._bookOfAuthorList.Add(new BookOfAuthor(_books[18].BookId, _authors[12].AuthorId));

            }
            catch (IndexOutOfRangeException e)
            { Console.WriteLine(e.Message); }
        }
    }
}
