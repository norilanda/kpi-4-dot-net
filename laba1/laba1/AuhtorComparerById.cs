using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    /// <summary>
    ///     Comparer that allow to compare authors by their ids
    /// </summary>
    public class AuhtorComparerById : IEqualityComparer<Author>
    {
        public bool Equals(Author x, Author y)
        {
            return x.AuthorId == y.AuthorId;
        }
        public int GetHashCode(Author obj)
        {
            if (obj == null) return 0;
            return obj.AuthorId.GetHashCode();
        }
    }
}
