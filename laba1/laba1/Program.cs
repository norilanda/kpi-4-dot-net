//Розробити структуру даних для зберігання інформації про книги в бібліотеці. Книга характеризується: назвою, прізвищем автора, вартістю, датою видання, видавництвом, списком інвентарних номерів (книга в кількох примірниках). У одного автора може бути декілька книг.
using laba1;
using static System.Reflection.Metadata.BlobBuilder;

Library library = new Library();
library.Books = Book.CreateBookList();
library.Authors = Author.CreateAuthorList();
library.ConnectBookAndAuthor();

//foreach (var book in library.Books) Console.WriteLine(book.ToString());
//foreach (var author in library.Authors) Console.WriteLine(author.ToString());

//1. Selects all authors and titles of all their books
var query1 = library.Authors.GroupJoin(
        library.BookOfAuthorList,
        author => author.AuthorId,
        book => book.IdOfAuthor,
        (auth, books) => new { author = auth,
                               book = books.Select(b => b.IdOfBook).Join(
                                   library.Books,
                                   bookId => bookId,
                                   book => book.BookId,
                                   (_, book) => book)                                   
                                }
    );
foreach (var bookOfAuthor in query1)
{
    Console.WriteLine($"{bookOfAuthor.author}:");
    foreach (var book in bookOfAuthor.book)
    {
        Console.WriteLine(book.Title);
    }
    Console.WriteLine();
}

//2. Select authors for each book (with using query syntax)

//3. Order books by titles and show number of every book (count inventory number)

//4. Show inventory numbers of all books for each author

//5. Show all books published since 2000 year, sorted by date

//6. Show most expensive book/-s and its/their author/-s

//7. Show sum of all books multiplied by its inventory number for every author

//8. Select books written by more than one author

//9.

//10.

//11.

//12.

//13.

//14.

//15.

//16.

//17.

//18.

//19.

//20.
