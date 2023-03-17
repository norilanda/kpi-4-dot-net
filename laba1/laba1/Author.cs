using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    /// <summary>
    /// Author class contains author's id, his first name and last name
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
        public static List<Author> CreateAuthorList()
        {
            List<Author> authorList = new List<Author>()
            {
                new Author(1, "Ray", "Bradbury"),
                new Author(2, "Jack", "London"),
                new Author(3, "Joseph", "Conrad"),
                new Author(4, "Jane", "Austen"),
                new Author(5, "Scott", "Fitzgerald"),
                new Author(6, "Harper", "Lee"),
                new Author(7, "George", "Orwell"),
                new Author(8, "Ernest", "Hemingway"),
                new Author(9, "Stephen", "Hawkingon"),
                new Author(10, "Leonard", "Mlodinow"),
                new Author(11, "Markus", "Zusak"),
                new Author(12, "J. R. R.", "Tolkien"),
                new Author(13, "Stieg", "Larsson")
            };
            return authorList;
        }
    }
}
