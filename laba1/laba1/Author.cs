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

        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public Author(string firstName, string lastName)
        {
            this._firstName = firstName;
            this._lastName = lastName;
        }
    }
}
