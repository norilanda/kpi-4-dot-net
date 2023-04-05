using laba1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
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
