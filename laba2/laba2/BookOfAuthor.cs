using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    /// <summary>
    ///     Contains information about connections between books and authors.
    ///     Shows authors of each book and books of each authors
    ///     Attributes _idOfBook and _idOfAuthor represent ids of objects of corresponding classes
    /// </summary>
    public class BookOfAuthor
    {
        private int _idOfBook;
        private int _idOfAuthor;

        public int IdOfBook => _idOfBook;
        public int IdOfAuthor => _idOfAuthor;

        public BookOfAuthor(int book, int author)
        {
            this._idOfBook = book;
            this._idOfAuthor = author;
        }
    }
}
