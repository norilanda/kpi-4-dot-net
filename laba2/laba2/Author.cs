﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

        public int AuthorId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public Author() { }
        public Author(int id, string firstName, string lastName)
        {
            this.AuthorId = id;
            this.Firstname = firstName;
            this.Lastname = lastName;
        }
        public override string ToString()
        {
            string str = $"{AuthorId} {Firstname} {Lastname}";
            return str;
        }
        public static Author Parse(XElement author)
        {
            return new Author(int.Parse(author.Element("AuthorId").Value), author.Element("Firstname").Value, author.Element("Lastname").Value);
        }
    }
}
