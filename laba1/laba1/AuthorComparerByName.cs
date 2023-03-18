using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    public class AuthorComparerByName : IEqualityComparer<Author>
    {
        public bool Equals(Author x, Author y)
        {
            return x.Firstname.Equals(y.Firstname) && x.Lastname.Equals(y.Lastname);
        }
        public int GetHashCode(Author obj)
        {
            if (obj == null) return 0;
            return (obj.Firstname+obj.Lastname).GetHashCode();
        }
    }
}
