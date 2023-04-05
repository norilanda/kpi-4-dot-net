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
        public int IdOfBook { get; set; }
        public int IdOfAuthor { get; set; }

        public BookOfAuthor() { }
        public BookOfAuthor(int book, int author)
        {
            this.IdOfBook = book;
            this.IdOfAuthor = author;
        }
        public override string ToString()
        {
            return $"book id: {IdOfBook}\tauthor id {IdOfAuthor}";
        }
    }
}
