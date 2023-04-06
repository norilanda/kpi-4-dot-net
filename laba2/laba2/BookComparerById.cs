using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    /// <summary>
    ///     Comparer that allow to compare books by their ids
    /// </summary>
    public class BookComparerById : IEqualityComparer<Book>
    {
        public bool Equals(Book x, Book y)
        {
            return x.BookId == y.BookId;
        }
        public int GetHashCode(Book obj)
        {
            if (obj == null) return 0;
            return obj.BookId.GetHashCode();
        }
    }
}
