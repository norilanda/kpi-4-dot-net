using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    /// <summary>
    ///     Author class contains such attributes as 
    ///     _authorId - unique id of an author. Same authors in different libraries may have different ids;
    ///     _firstName - author's first name;
    ///     _lastName - last name;
    /// </summary>
    public class Author
    {
        private int _authorId;
        private string _firstName;
        private string _lastName;

        public int AuthorId => _authorId;
        public string Firstname => _firstName;
        public string Lastname => _lastName;

        public Author(int id, string firstName, string lastName)
        {
            this._authorId = id;
            this._firstName = firstName;
            this._lastName = lastName;
        }
        public override string ToString()
        {
            string str = $"{_firstName} {_lastName}";
            return str;
        }
    }
}
