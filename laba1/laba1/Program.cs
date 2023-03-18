//Розробити структуру даних для зберігання інформації про книги в бібліотеці. Книга характеризується: назвою, прізвищем автора, вартістю, датою видання, видавництвом, списком інвентарних номерів (книга в кількох примірниках). У одного автора може бути декілька книг.
using laba1;
using static System.Reflection.Metadata.BlobBuilder;

List<Book> books1 = new List<Book>()
            {
                new Book(0, "Fahrenheit 451", 730, new DateOnly(1953, 10, 19), "Ballantine Books", new List<int>(){1, 2, 3, 4, 5}),
                new Book(1, "Dandelion Wine", 1900, new DateOnly(1957, 09, 21), "Doubleday", new List<int>(){6, 7, 8}),
                new Book(2, "The Martian Chronicles", 100, new DateOnly(1950, 04, 06), "Doubleday", new List<int>(){9, 10}),
                new Book(3, "The Call of the Wild", 900, new DateOnly(1903, 01, 10), "Macmillan Publishers", new List<int>(){11}),
                new Book(4, "Heart of Darkness", 2930, new DateOnly(1899, 02, 10), "Blackwood's Magazine", new List<int>(){12, 13, 14}),
                new Book(5, "Pride and Prejudice", 962, new DateOnly(1813, 01, 28), "T. Egerton", new List<int>(){15, 16}),
                new Book(6, "The Great Gatsby", 1200, new DateOnly(1925, 04, 10), "Charles Scribner's Sons", new List<int>(){17}),
                new Book(7, "To Kill a Mockingbird", 398, new DateOnly(1960, 07, 11), "J. B. Lippincott & Co.", new List<int>(){18, 19, 20}),
                new Book(8, "Sense and Sensibility", 962, new DateOnly(1811, 10, 30), "T. Egerton", new List<int>(){21, 22}),
                new Book(9, "Animal Farm", 280, new DateOnly(1945, 08, 17), "Secker and Warburg", new List<int>(){23}),
                new Book(11, "Nineteen Eighty-Four", 978, new DateOnly(1949, 06, 08), "Secker and Warburg", new List<int>(){24, 25}),
                new Book(11, "he Sun Also Rises", 3210, new DateOnly(1926, 10, 22), "Scribner's", new List<int>(){26, 27}),
                new Book(12, "A Farewell to Arms", 1090, new DateOnly(1926, 10, 22), "Scribner's", new List<int>(){28, 29, 30}),
                new Book(13, "The Theory of Everything: The Origin and Fate of the Universe", 1300, new DateOnly(2010, 09, 07), "Bantam Books", new List<int>(){31, 32}),
                new Book(14, "A Brief History of Time", 1300, new DateOnly(1988, 03, 19), "Bantam Books", new List<int>(){33, 34, 35}),
                new Book(15, "The Book Thief", 800, new DateOnly(2005, 03, 14), "Picador", new List<int>(){36}),
                new Book(16, "The Hobbit", 3045, new DateOnly(1937, 09, 21), "George Allen & Unwin", new List<int>(){37, 38}),
                new Book(17, "The Lord of the Rings", 3055, new DateOnly(1954, 09, 21), "George Allen & Unwin", new List<int>(){39, 40, 41, 42}),
                new Book(18, "The Girl with the Dragon Tattoo", 1875, new DateOnly(2005, 08, 01), "Norstedts Förlag", new List<int>(){43}),
            };
List<Book> books2 = new List<Book>()
{
                new Book(0, "Fahrenheit 451", 830, new DateOnly(1953, 10, 19), "Ballantine Books", new List<int>(){1, 2, 3, 4}),
                new Book(1, "Dandelion Wine", 900, new DateOnly(1957, 09, 21), "Doubleday", new List<int>(){5, 6, 7, 8}),
                new Book(2, "The Hobbit", 2100, new DateOnly(1937, 09, 21), "George Allen & Unwin", new List<int>(){9, 10}),
                new Book(3, "A Tale of Two Cities ", 830, new DateOnly(1959, 04, 30), "Chapman & Hall", new List<int>(){11, 12, 13}),
                new Book(4, "The Metamorphosis", 743, new DateOnly(1915, 08, 25), "Kurt Wolff Verlag", new List<int>(){14, 15}),
                new Book(5, "The Trial", 3045, new DateOnly(1925, 09, 21), "Verlag Die Schmiede", new List<int>(){16, 17, 18}),
};
List<Author> authors1 = new List<Author>()
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
List<Author> authors2 = new List<Author>()
{
                new Author(0, "Ray", "Bradbury"),
                new Author(1, "J. R. R.", "Tolkien"),
                new Author(2, "Charles", "Dickens"),
                new Author(3, "Franz", "Kafka"),
              };
List<BookOfAuthor> bookOfAuthorList1 = new List<BookOfAuthor>();
List<BookOfAuthor> bookOfAuthorList2 = new List<BookOfAuthor>();
try
{
    bookOfAuthorList1.Add(new BookOfAuthor(books1[0].BookId, authors1[0].AuthorId));
    bookOfAuthorList1.Add(new BookOfAuthor(books1[1].BookId, authors1[0].AuthorId));
    bookOfAuthorList1.Add(new BookOfAuthor(books1[2].BookId, authors1[0].AuthorId));
    bookOfAuthorList1.Add(new BookOfAuthor(books1[3].BookId, authors1[1].AuthorId));
    bookOfAuthorList1.Add(new BookOfAuthor(books1[4].BookId, authors1[2].AuthorId));
    bookOfAuthorList1.Add(new BookOfAuthor(books1[5].BookId, authors1[3].AuthorId));
    bookOfAuthorList1.Add(new BookOfAuthor(books1[6].BookId, authors1[4].AuthorId));
    bookOfAuthorList1.Add(new BookOfAuthor(books1[7].BookId, authors1[5].AuthorId));
    bookOfAuthorList1.Add(new BookOfAuthor(books1[8].BookId, authors1[3].AuthorId));
    bookOfAuthorList1.Add(new BookOfAuthor(books1[9].BookId, authors1[6].AuthorId));
    bookOfAuthorList1.Add(new BookOfAuthor(books1[10].BookId, authors1[6].AuthorId));
    bookOfAuthorList1.Add(new BookOfAuthor(books1[11].BookId, authors1[7].AuthorId));
    bookOfAuthorList1.Add(new BookOfAuthor(books1[12].BookId, authors1[7].AuthorId));
    bookOfAuthorList1.Add(new BookOfAuthor(books1[13].BookId, authors1[8].AuthorId));
    bookOfAuthorList1.Add(new BookOfAuthor(books1[13].BookId, authors1[9].AuthorId));
    bookOfAuthorList1.Add(new BookOfAuthor(books1[14].BookId, authors1[8].AuthorId));
    bookOfAuthorList1.Add(new BookOfAuthor(books1[15].BookId, authors1[10].AuthorId));
    bookOfAuthorList1.Add(new BookOfAuthor(books1[16].BookId, authors1[11].AuthorId));
    bookOfAuthorList1.Add(new BookOfAuthor(books1[17].BookId, authors1[11].AuthorId));
    bookOfAuthorList1.Add(new BookOfAuthor(books1[18].BookId, authors1[12].AuthorId));

    bookOfAuthorList2.Add(new BookOfAuthor(books2[0].BookId, authors2[0].AuthorId));
    bookOfAuthorList2.Add(new BookOfAuthor(books2[1].BookId, authors2[0].AuthorId));
    bookOfAuthorList2.Add(new BookOfAuthor(books2[2].BookId, authors2[1].AuthorId));
    bookOfAuthorList2.Add(new BookOfAuthor(books2[3].BookId, authors2[2].AuthorId));
    bookOfAuthorList2.Add(new BookOfAuthor(books2[4].BookId, authors2[3].AuthorId));
    bookOfAuthorList2.Add(new BookOfAuthor(books2[5].BookId, authors2[3].AuthorId));
}
catch (IndexOutOfRangeException e)
    { Console.WriteLine(e.Message); }

Library lib1 = new Library("Library 1", books1, authors1, bookOfAuthorList1);
Library lib2 = new Library("Library 2", books2, authors2, bookOfAuthorList2);
Library lib3 = new Library("Empty Library 3", new List<Book>(), new List<Author>(), new List<BookOfAuthor>());

List<Library> allLibs = new List<Library>()
{
    lib1,
    lib2,
    lib3
};


//foreach (var book in library.Books) Console.WriteLine(book.ToString());
//foreach (var author in library.Authors) Console.WriteLine(author.ToString());

//1. Selects all authors and titles of all their books
var query1 = lib1.Authors.GroupJoin(
        lib1.BookOfAuthorList,
        author => author.AuthorId,
        book => book.IdOfAuthor,
        (auth, books) => new { author = auth,
                               book = books.Select(b => b.IdOfBook).Join(
                                   lib1.Books,
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
var query2 = from b in lib1.Books
             select new {
                 book = b,
                 authors = (from ab in lib1.BookOfAuthorList 
                 join a in lib1.Authors on ab.IdOfAuthor equals a.AuthorId
                 where b.BookId == ab.IdOfBook
                 select a).ToList() };
//foreach (var item in query2)
//    Console.WriteLine($"{item.book}\t{String.Join(", ", item.authors)}");

//3. Order books published before 2000 by titles and show number of every book (count inventory number)
var query3 = lib1.Books.OrderBy(b => b.Title)
                .Where(b => b.PublishingDate.Year < 2000)
                .Select(b => new
                {
                    book = b,
                    copyNumber = b.InventoryNumbers.Count()
                });
//foreach (var item in query3)
//    Console.WriteLine($"{item.book}\t{item.copyNumber}");

//4. Show inventory numbers of all books for each author
var query4 = lib1.Authors.GroupJoin(
        lib1.BookOfAuthorList,
        a => a.AuthorId,
        ab => ab.IdOfAuthor,
        (a, ab) => new
        {
            author = a,
            inventNumbers = lib1.Books
                        .Where(b => ab.Select(x => x.IdOfBook)
                                      .Contains(b.BookId))
                        .SelectMany(y => y.InventoryNumbers)
        }
        );
foreach (var item in query4)
    Console.WriteLine($"{item.author}\t{String.Join(", ", item.inventNumbers)}");

//5. Show all books published since 2000 year, sorted by date

var query5 = lib1.Books.Where(b => b.PublishingDate.Year >= 2000).OrderBy(b => b.PublishingDate);
//foreach (var book in query5) Console.WriteLine(book.ToString());

//6. Show most expensive book/-s and its/their author/-s

//7. Show sum of all books multiplied by its inventory number for every author

//8. Select books written by more than one author

//9. Select all books that are in libraries

//10. Select books that are common for 2 libraries

//11. Select books that are in lib2 but are not in lib1

//12. Show authors and publishers of their books

//13. Select average number of number of each book (count inventory numbers) in library

//14. Select the latest books by publishing date

//15. Select all publishers from 2 libs

//16. Select price sum of top 5 expensive books

//17. Select the most frequent word in book titles

//var query17 = lib1.

//18. Select percent of sum of all books for every book
double sumPriceOfAllBooks = lib1.Books.Sum(b => b.Price);
var query18 = lib1.Books.Select(b => new { book = b, Percent = (double)b.Price / sumPriceOfAllBooks });
//foreach (var b in query18) Console.WriteLine($"{b.book.Title},\t{b.book.Price},\t{b.Percent.ToString("0.00")}");

//19. Group books by their publishing month

//20. Show books that have only one inventory number

//21. From lib1 select all books that have price bigger than average price of all books in lib2
