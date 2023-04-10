using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    /// <summary>
    ///     Class shows connections between library and books. Its attributes:
    ///      LibraryId - id of a library;
    ///      BookId - id of a book;
    ///      InventoryNumbers - numbers that numerate copies of book; 
    /// </summary>
    public class BookOfLibrary
    {
        public int LibraryId { get; set; }
        public int BookId { get; set; }
        public List<int> InventoryNumbers { get; set; }

        public BookOfLibrary() { }
        public BookOfLibrary(int libraryId, int bookId, List<int> inventoryNumbers)
        {
            this.LibraryId = libraryId;
            this.BookId = bookId;
            this.InventoryNumbers = new List<int>(inventoryNumbers);
        }
        public override string ToString()
        {
            return $"lib_id: {LibraryId.ToString().PadRight(3)} book_id: {BookId.ToString().PadRight(3)} inventory_numbers: [{new string(string.Join(", ", InventoryNumbers.ToArray()) + "]").PadRight(18)}";
        }
    }
}
