using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    public class BookOfAuthor
    {
        private int _idOfBook;
        private int _idOfAuthor;

        public int IdOfBook { get; set; }
        public int IdOfAuthor { get; set; }

        public BookOfAuthor(int book, int author)
        {
            this._idOfBook = book;
            this._idOfAuthor = author;
        }
    }
}
