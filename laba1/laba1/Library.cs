using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    public class Library
    {
        private List<BookOfAuthor> _bookOfAuthorList;
        public List<BookOfAuthor> BookOfAuthorList { get; set; }

        public Library(List<BookOfAuthor> bookList)
        {
            this._bookOfAuthorList = new List<BookOfAuthor>(bookList);
        }
    }
}
