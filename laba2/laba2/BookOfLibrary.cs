using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    /// <summary>
    ///     Class shows connections between library and books. Its attributes:
    ///     _libraryId - id of a library;
    ///     _bookId - id of a book;
    ///     _inventoryNumbers - numbers that numerate copies of book; 
    /// </summary>
    public class BookOfLibrary
    {
        private int _libraryId;
        private int _bookId;
        private List<int> _inventoryNumbers;

        public int LibraryId => _libraryId;
        public int BookId => _bookId;
        public List<int> InventoryNumbers => _inventoryNumbers;

        public BookOfLibrary(int libraryId, int bookId, List<int> inventoryNumbers)
        {
            this._libraryId = libraryId;
            this._bookId = bookId;
            this._inventoryNumbers = new List<int>(inventoryNumbers);
        }
        public override string ToString()
        {
            return $"{_libraryId.ToString().PadRight(3)} {_bookId.ToString().PadRight(3)} [{new string(string.Join(", ", _inventoryNumbers.ToArray()) + "]").PadRight(18)}";
        }
    }
}
