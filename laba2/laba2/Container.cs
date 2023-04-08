using laba1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    /// <summary>
    /// Class contains lists of objects and references between them. Was created to make deserialization easier
    /// Properties:
    ///     Publishers - all publishers
    ///     Books - all books
    ///     Authors - all authors
    ///     Libraries - all libraries
    ///     BookOfAuthorList - references between books and authors
    ///     BookOfLibraryList - references between books and libraries
    /// </summary>
    public class Container
    {
        public List<Publisher> Publishers {  get; set; }
        public List<Book> Books { get; set; }
        public List<Author> Authors { get; set; }
        public List<Library> Libraries { get; set; }
        public List<BookOfAuthor> BookOfAuthorList { get; set; }
        public List<BookOfLibrary> BookOfLibraryList { get; set; }
        public Container()
        {
            
        }
    }
}
