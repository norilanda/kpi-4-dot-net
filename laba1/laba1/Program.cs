//Розробити структуру даних для зберігання інформації про книги в бібліотеці.
//Книга характеризується: назвою, прізвищем автора, вартістю, датою видання, видавництвом, списком інвентарних номерів (книга в кількох примірниках).
//У одного автора може бути декілька книг.
using laba1;
using static System.Reflection.Metadata.BlobBuilder;
using System.Text.RegularExpressions;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        //creating publisher list
        List<Publisher> publishers = new List<Publisher>()
        { 
            new Publisher(0, "Ballantine Books"),
            new Publisher(1, "Doubleday"),
            new Publisher(2, "T. Egerton"),
            new Publisher(3, "Charles Scribner's Sons"),
            new Publisher(4, "Scribner's"),
            new Publisher(5, "Bantam Books"),
            new Publisher(6, "George Allen & Unwin"),
            new Publisher(7, "Chapman & Hall"),
            new Publisher(8, "Kurt Wolff Verlag"),
            new Publisher(9, "Verlag Die Schmiede")
        };
        //creating list of books
        List<Book> books = new List<Book>()
            {
                new Book(0, "Fahrenheit 451", 1000, new DateOnly(1953, 10, 19), publishers[0].PublisherId),
                new Book(1, "Dandelion Wine", 1900, new DateOnly(1957, 09, 21), publishers[1].PublisherId),
                new Book(2, "The Martian Chronicles", 690, new DateOnly(1950, 04, 06), publishers[1].PublisherId),
                new Book(3, "Pride and Prejudice", 962, new DateOnly(1813, 01, 28), publishers[2].PublisherId),
                new Book(4, "The Sun Also Rises", 3210, new DateOnly(1926, 10, 22), publishers[4].PublisherId),
                new Book(5, "A Farewell to Arms", 1090, new DateOnly(1926, 10, 22), publishers[4].PublisherId),
                new Book(6, "The Theory of Everything", 1300, new DateOnly(2010, 09, 07), publishers[5].PublisherId),
                new Book(7, "A Brief History of Time", 1300, new DateOnly(1988, 03, 19), publishers[5].PublisherId),
                new Book(8, "The Hobbit", 3210, new DateOnly(1937, 09, 21), publishers[6].PublisherId),
                new Book(9, "The Lord of the Rings", 3055, new DateOnly(1954, 09, 21), publishers[6].PublisherId),
                new Book(10, "A Tale of Two Cities", 830, new DateOnly(1959, 04, 30), publishers[7].PublisherId),
                new Book(11, "The Metamorphosis", 743, new DateOnly(1915, 08, 25), publishers[8].PublisherId),
                new Book(12, "The Trial", 3045, new DateOnly(1925, 09, 21), publishers[9].PublisherId),
            };
        //creating list of authors
        List<Author> authors = new List<Author>()
            {
                new Author(0, "Ray", "Bradbury"),
                new Author(1, "Jane", "Austen"),
                new Author(2, "Ernest", "Hemingway"),
                new Author(3, "Stephen", "Hawkingon"),
                new Author(4, "Leonard", "Mlodinow"),
                new Author(5, "J. R. R.", "Tolkien"),
                new Author(6, "Charles", "Dickens"),
                new Author(7, "Franz", "Kafka"),
            };
        //creating 3 libraries
        List<Library> libraries = new List<Library>()
        {
            new Library(0, "Library 1"),
            new Library(1, "Library 2"),
            new Library(2, "Library 3")
        };

        //creating list of BookOfAuthor objects that connect books and corresponding authors from lists
        List<BookOfAuthor> bookOfAuthorList = new List<BookOfAuthor>();
        //connecting books with authors from first lists
        bookOfAuthorList.Add(new BookOfAuthor(books[0].BookId, authors[0].AuthorId));
        bookOfAuthorList.Add(new BookOfAuthor(books[1].BookId, authors[0].AuthorId));
        bookOfAuthorList.Add(new BookOfAuthor(books[2].BookId, authors[0].AuthorId));
        bookOfAuthorList.Add(new BookOfAuthor(books[3].BookId, authors[1].AuthorId));
        bookOfAuthorList.Add(new BookOfAuthor(books[4].BookId, authors[2].AuthorId));
        bookOfAuthorList.Add(new BookOfAuthor(books[5].BookId, authors[2].AuthorId));
        bookOfAuthorList.Add(new BookOfAuthor(books[6].BookId, authors[3].AuthorId));
        bookOfAuthorList.Add(new BookOfAuthor(books[6].BookId, authors[4].AuthorId));
        bookOfAuthorList.Add(new BookOfAuthor(books[7].BookId, authors[3].AuthorId));
        bookOfAuthorList.Add(new BookOfAuthor(books[8].BookId, authors[5].AuthorId));
        bookOfAuthorList.Add(new BookOfAuthor(books[9].BookId, authors[5].AuthorId));
        bookOfAuthorList.Add(new BookOfAuthor(books[10].BookId, authors[6].AuthorId));
        bookOfAuthorList.Add(new BookOfAuthor(books[11].BookId, authors[7].AuthorId));
        bookOfAuthorList.Add(new BookOfAuthor(books[12].BookId, authors[7].AuthorId));

        //creating connections between books and libraries
        List<BookOfLibrary> bookOfLibraryList = new List<BookOfLibrary>()
        {
            new BookOfLibrary(libraries[0].LibraryId, books[0].BookId, new List<int>(){1, 2, 3, 4, 5} ),
            new BookOfLibrary(libraries[0].LibraryId, books[1].BookId, new List<int>(){6, 7, 8} ),
            new BookOfLibrary(libraries[0].LibraryId, books[2].BookId, new List<int>(){9, 10, 11} ),
            new BookOfLibrary(libraries[0].LibraryId, books[3].BookId, new List<int>(){12} ),
            new BookOfLibrary(libraries[0].LibraryId, books[4].BookId, new List<int>(){13, 14, 15} ),
            new BookOfLibrary(libraries[0].LibraryId, books[5].BookId, new List<int>(){16, 17, 18} ),
            new BookOfLibrary(libraries[0].LibraryId, books[6].BookId, new List<int>(){19, 20} ),
            new BookOfLibrary(libraries[0].LibraryId, books[7].BookId, new List<int>(){21, 22, 23} ),
            new BookOfLibrary(libraries[0].LibraryId, books[8].BookId, new List<int>(){24} ),
            new BookOfLibrary(libraries[0].LibraryId, books[9].BookId, new List<int>(){25, 26, 27, 28} ),

            new BookOfLibrary(libraries[1].LibraryId, books[0].BookId, new List<int>(){1, 2, 3}  ),
            new BookOfLibrary(libraries[1].LibraryId, books[1].BookId, new List<int>(){4, 5}  ),
            new BookOfLibrary(libraries[1].LibraryId, books[8].BookId, new List<int>(){6} ),
            new BookOfLibrary(libraries[1].LibraryId, books[10].BookId, new List<int>(){7, 8} ),
            new BookOfLibrary(libraries[1].LibraryId, books[11].BookId, new List<int>(){9, 10} ),

            new BookOfLibrary(libraries[2].LibraryId, books[12].BookId, new List<int>(){1, 2, 3} ),
            new BookOfLibrary(libraries[2].LibraryId, books[0].BookId, new List<int>(){4} ),
            new BookOfLibrary(libraries[2].LibraryId, books[6].BookId, new List<int>(){5, 6} )
    };

        //1. (Extentions syntax) Select all authors and all their books
        Query1(books, authors, bookOfAuthorList);

        //2. (Query syntax) Select authors for each book that has price bigger than 1000
        Query2(books, publishers);

        //3. (Extentions syntax) Order books published before 1950 by titles
        Query3(books, 1950);

        // 4. (Extentions syntax) Show if there any publishers whose Name contains 'd' letter
        Query4(publishers, 'd');

        //5. (Extentions syntax) Select books with minimum price for every library
        Query5(books, libraries, bookOfLibraryList);

        //6. (Extentions syntax) Show top 5 the most expensive books
        Query6(books, 5);

        //7. (Query syntax) Show sum of books for every author and order them by book number from bigger to smaller and then by author firstname
        Query7(authors, bookOfAuthorList);

        //8. (Query syntax) Select books with max price
        Query8(books);

        //9. (Extentions syntax) Select first 'numberToTake' and last 'numberToTake' books, ordered by price
        Query9(books, 2);

        //10. (Extentions syntax) Select authors that are common for all libraries
        Query10(authors, bookOfLibraryList, bookOfAuthorList);

        //11. (Extentions syntax) Select authors different (unique) for all libraries
        Query11(authors, bookOfLibraryList, bookOfAuthorList);

        //12. (Query syntax) Show publishers that have Names started with 'B' letter
        Query12(publishers);

        //13. (Query syntax + Extentions syntax) Select 'percentFilter' number of books ordered by number of sum of copies in all libraries from max to min
        Query13(books, bookOfLibraryList, 0.5);

        //14. (Extentions syntax) Select 5-th book from list ordered by date
        Query14(books, 5);

        //15. (Extentions syntax) Select books with shortest Title
        Query15(books);

        //16. (Extentions syntax) Select all books that have price bigger than average price of all books
        Query16(books);

        //17. (Extentions syntax) Select the top 5 most frequent words in book titles
        Query17(books, 5);

        //18. (Extentions syntax) Select percent of sum of all books prices for every book
        Query18(books);

        //19. (Query syntax) Group books by their publishing month
        Query19(books);

        // 20. (Query syntax + Extentions syntax) Select as one string book and its publisher
        Query20(books, publishers);
    }

    // (Extentions syntax) 1. Select all authors and all their books
    public static void Query1(List<Book> books, List<Author> authors, List<BookOfAuthor> bookOfAuthorList)
    {
        var query1 = authors.GroupJoin(
        bookOfAuthorList,
        author => author.AuthorId,
        book => book.IdOfAuthor,
        (author, bs) => new
        {
            Author = author,
            Book = bs.Join( books,
                            ab => ab.IdOfBook,
                            book => book.BookId,
                            (_, book) => book)
        }
    );
        Console.WriteLine("1. Authors and all their books titles:");
        Output.PrintToConsole(query1.Select(item => new Tuple<Author, IEnumerable<Book>>(item.Author, item.Book)));
    }
    // (Query syntax) 2. Select all publishers and books published by them (left join)
    public static void Query2(List<Book> books, List<Publisher> publishers)
    {
        var query2 = from publisher in publishers
                      join book in books on publisher.PublisherId equals book.PublisherId into gr
                      from book2 in gr.DefaultIfEmpty()
                      select new
                      {
                          Publisher = publisher,
                          BookNumber = book2
                      };
        Console.WriteLine($"2. All publishers and books published by them (left join):");
        Output.PrintToConsole(query2.Select(item => new Tuple<Publisher, Book>(item.Publisher, item.BookNumber)));
    }

    // (Extentions syntax) 3. Order books published before yearFilter by titles
    public static void Query3(List<Book> books, int yearFilter=2000)
    {
        var query3 = books.Where(b => b.PublishingDate.Year < yearFilter)
                          .OrderBy(b => b.Title);
        Console.WriteLine($"3. Ordered by titles list of books published before {yearFilter}:");
        Output.PrintToConsole(query3);
    }

    // 4. (Extentions syntax) Show if there any publishers whose Name contains 'letterToSearch' letter
    public static void Query4(List<Publisher> publishers, char letterToSearch) 
    {
        string query4 = publishers.Any(p => p.PublisherName.Contains(letterToSearch)) ?
                        $"There are publishers, whose name contains {letterToSearch} letter" :
                        "NO publishers have such a name";
        Console.WriteLine($"4. Are there any publishers whose Name contains {letterToSearch} letter?");
        Console.WriteLine($"\t{query4}\n");
    }

    // returns libraries and their books as a Tuple<Library, IEnumerable<Book>>
    public static IEnumerable<Tuple<Library, IEnumerable<Book>>> GetBooksForEveryLibrary(List<Book> books, List<Library> libraries, List<BookOfLibrary> bookOfLibraryList)
    {
        var booksGroupedByLibrary = libraries.GroupJoin(bookOfLibraryList,
                                              l => l.LibraryId,
                                              bl => bl.LibraryId,
                                              (l, bl) => new
                                              {
                                                  Library = l,
                                                  Books = bl.Join(books,
                                                                  bl1 => bl1.BookId,
                                                                  b => b.BookId,
                                                                  (_, b) => b)
                                              }
                                               );
        return booksGroupedByLibrary.Select(item => new Tuple<Library, IEnumerable<Book>>(item.Library, item.Books));
    }

    // 5. (Extentions syntax) Select books with minimum price for every library
    public static void Query5(List<Book> books, List<Library> libraries, List<BookOfLibrary> bookOfLibraryList)
    {
        var booksGrouped = GetBooksForEveryLibrary(books, libraries, bookOfLibraryList);
        var query5 = booksGrouped
                        .Select(item => new
                        {
                            Library = item.Item1,
                            minBookCollection = item.Item2
                                .Where(x => x.Price == item.Item2
                                .Min(y => y.Price))
                        });
        Console.WriteLine($"5. Books that have minimum price for every library");
        Output.PrintToConsole(query5.Select(item => new Tuple<Library, IEnumerable<Book>>(item.Library, item.minBookCollection)));
    }

    // 6. (Extentions syntax) Show top 'topNumberFilter' the most expensive books
    public static void Query6(List<Book> books, int topNumberFilter = 5)
    {
        var query6 = books
                .OrderByDescending(b => b.Price)
                .ThenBy(b => b.Title)
                .Take(topNumberFilter);
            
        Console.WriteLine($"6. Top {topNumberFilter} the most expensive books:");
        Output.PrintToConsole(query6);
    }

    //  7. (Query syntax) Show number of books for every author and order them by book number from bigger to smaller and then by author firstname
    public static void Query7(List<Author> authors, List<BookOfAuthor> bookOfAuthorList)
    {
        var query7 = from authorBookNumber in (
                         from ab in bookOfAuthorList
                         group ab by ab.IdOfAuthor
                         into authorGroup
                         select new
                         {
                             Author = (from a in authors
                                       where a.AuthorId == authorGroup.Key
                                       select a).Single(),
                             BookNum = authorGroup.Count()
                         })
                     orderby authorBookNumber.BookNum descending, authorBookNumber.Author.Firstname
                     select authorBookNumber;
        Console.WriteLine("7. Authors' number of books, ordered by this number and then by author's first name:");
        Output.PrintToConsole(query7.Select(item => new Tuple<Author, double>(item.Author, item.BookNum)));
    }

    // 8. (Query syntax) Select books with max price
    public static void Query8(List<Book> books)
    {
        double maxPrice = (from b1 in books
                           select b1.Price).Max();
        var query8 = from b in books
                     where b.Price == maxPrice
                     select b;
        Console.WriteLine("8. All books which price is max:");
        Output.PrintToConsole(query8);
    }

    // 9. (Extentions syntax) Select first 'numberToTake' and last 'numberToTake' books, ordered by price
    public static void Query9(List<Book> books, int numberToTake = 2)
    {
        IEnumerable<Book> orderedBooks = books
            .OrderBy(b => b.Price)
            .ThenBy(b => b.Title.FirstOrDefault());
        var query9 = orderedBooks.Take(numberToTake)
                    .Union(
                    orderedBooks.TakeLast(numberToTake), new BookComparerById());
        Console.WriteLine($"9. There are first {numberToTake} and last {numberToTake} number of books from book list ordered by price and title:");
        Output.PrintToConsole(query9);
    }

    // 10. (Extentions syntax) Select authors that are common for all libraries
    public static void Query10(List<Author> authors, List<BookOfLibrary> bookOfLibraryList, List<BookOfAuthor> bookOfAuthorList)
    {
        var authorsGroupedByLib = GetAuthorsGroupedByLib(authors, bookOfLibraryList, bookOfAuthorList);
        var query10 = authorsGroupedByLib
            .Aggregate((first, next) => first.Intersect(next, new AuhtorComparerById()));
        Console.WriteLine("10. All authors that are in all libraries:");
        Output.PrintToConsole(query10);
    }
    
    //returns authors objects grouped by library
    public static IEnumerable<IEnumerable<Author>> GetAuthorsGroupedByLib(List<Author> authors, List<BookOfLibrary> bookOfLibraryList, List<BookOfAuthor> bookOfAuthorList)
    {
        return bookOfLibraryList.GroupBy(
            bl => bl.LibraryId,
            bl => bl.BookId,
            (key, g) => new
            {
                Key = key,
                AuthorsGrouped = bookOfAuthorList.Join(g,
                                                       ba => ba.IdOfBook,
                                                       bookIdInGroup => bookIdInGroup,
                                                       (ba, _) => ba)
                                                    .Join(
                                                    authors,
                                                    ba => ba.IdOfAuthor,
                                                    a => a.AuthorId,
                                                    (ba, a) => a)
            })
            .Select(a => a.AuthorsGrouped.Distinct(new AuhtorComparerById()));
    }

    // 11. (Extentions syntax) Select authors different (unique) for all libraries
    public static void Query11(List<Author> authors, List<BookOfLibrary> bookOfLibraryList, List<BookOfAuthor> bookOfAuthorList)
    {
        var authorsGroupedByLib = GetAuthorsGroupedByLib(authors, bookOfLibraryList, bookOfAuthorList);
        AuhtorComparerById comparer = new AuhtorComparerById();
        var query11 = authorsGroupedByLib
            .Aggregate((first, next) => first
                .Union(next, new AuhtorComparerById())
                .Except(authorsGroupedByLib
                    .SelectMany(a => a)
                    .Where(a => authorsGroupedByLib.SelectMany(a1 => a1)
                                                   .Count(x => comparer.Equals(x, a)) > 1)));
        Console.WriteLine("11. All authors that are different (unique) for all libraries:");
        Output.PrintToConsole(query11);
    }

    // 12. (Query syntax) Select publishers that has Name started with a 'B' letter
    public static void Query12(List<Publisher> publishers)
    {
        var query12 = from p in publishers
                      where p.PublisherName.ToUpper().FirstOrDefault() == 'B'
                      select p;
        Console.WriteLine("12. Publishers that has Name started with a 'B' letter:");
        Output.PrintToConsole(query12);
    }

    // 13. (Query syntax + Extentions syntax) Select 'percentFilter' number of books ordered by number of sum of copies in all libraries from max to min
    public static void Query13(List<Book> books, List<BookOfLibrary> bookOfLibraryList, double percentFilter = 0.3)
    {
        var query13 = (from b in books
                      join groupedNumberOfCopies in
                          (from bl in bookOfLibraryList
                           group bl.InventoryNumbers by bl.BookId into g
                           select new
                           {
                               g.Key,
                               CountOfCopies = g.SelectMany(n => n).Count()
                           })
                      on b.BookId equals groupedNumberOfCopies.Key
                      select new
                      {
                          Book = b,
                          groupedNumberOfCopies.CountOfCopies
                      })
                      .OrderByDescending(item => item.CountOfCopies)
                      .Take((int)(books.Count()* percentFilter));
        Console.WriteLine("13. Number of books ordered by number of sum of copies in all libraries from max to min (last column = sum of copies):");
        Output.PrintToConsole(query13.Select(item => new Tuple<Book, double>(item.Book, item.CountOfCopies)));
    }

    // 14. (Extentions syntax) Select n-th book from list ordered by date
    public static void Query14(List<Book> books, int n = 5)
    {
        int indexOfBookInList = n - 1;
        var query14 = books.OrderBy(b => b.PublishingDate)
                .ElementAtOrDefault(indexOfBookInList);
        Console.WriteLine($"14. {indexOfBookInList + 1}-th book in ordered by date list of books:");
        Console.WriteLine($"\t{query14}\n");
    }

    // 15. (Extentions syntax) Select books with the shortest Title
    public static void Query15(List<Book> books)
    {
        int lengthOfShortestTitle = books.Min(b => b.Title.Count());
        var query15 = books.Where(b => b.Title.Count() == lengthOfShortestTitle);
        Console.WriteLine("15. All books with shortest titles:");
        Output.PrintToConsole(query15);
    }

    // 16. (Extentions syntax) Select all books that have price bigger than average price of all books
    public static void Query16(List<Book> books)
    {
        double averagePriceOfBooksInlib2 = books.Average(b => b.Price);
        var query16 = books.Where(b => b.Price > averagePriceOfBooksInlib2);
        Console.WriteLine($"16. Books that have price bigger than average price of all books ( {Math.Round(averagePriceOfBooksInlib2, 3)} ):");
        Output.PrintToConsole(query16);
    }

    // 17. (Extentions syntax) Select the top 'topNumberFilter' most frequent words in book titles
    public static void Query17(List<Book> books, int topNumberFilter = 5)
    {
        Regex rgx = new Regex("[^a-zA-Z0-9 -]");
        IEnumerable<string> allWordsInTitles = books.SelectMany(b => rgx.Replace(b.Title, "")
                                                                        .ToLower()
                                                                        .Split());
        var query17 = allWordsInTitles.GroupBy(word => word,
                                               word => allWordsInTitles.Count(w => w.Equals(word)),
                                         (word, num) => new { Word = word, Num = num.Count() })
                                .OrderByDescending(item => item.Num)
                                .ThenBy(item => item.Word)
                                .Take(topNumberFilter);
        Console.WriteLine($"17. Top {topNumberFilter} most frequent words in books' titles:");
        Output.PrintToConsole(query17.Select(item => new Tuple<string, int>(item.Word, item.Num)));
    }

    // 18. (Extentions syntax) Select percent of sum of all books prices for every book
    public static void Query18(List<Book> books)
    {
        double sumPriceOfAllBooks = books.Sum(b => b.Price);
        var query18 = books.Select(b => new { Book = b,
                                              Percent = (double)b.Price / sumPriceOfAllBooks });
        Console.WriteLine("18. Percentage of price for every book (percentage is in last column): ");
        Output.PrintToConsole(query18.Select(item => new Tuple<Book, double>(item.Book, Math.Round(item.Percent,3))));
    }

    // 19. (Query syntax) Group books by their publishing month
    public static void Query19(List<Book> books)
    {
        var query19 = from book in books
                      group book by book.PublishingDate.Month into groupByMonths
                      orderby groupByMonths.Key
                      select groupByMonths;
        Console.WriteLine("19. Books grouped by month they where published:");
        Output.PrintToConsole(query19);
    }

    // 20. (Query syntax + Extentions syntax) Select as one string book and its publisher
    public static void Query20(List<Book> books, List<Publisher> publishers)
    {
        IEnumerable<string> titles = from b in books
                                     orderby b.Title
                                     select b.Title;
        IEnumerable<string> publishersOfBooks = from b in books
                                                orderby b.Title
                                                join p in publishers on b.PublisherId equals p.PublisherId
                                                select p.PublisherName;
        var query20 = titles.Zip(publishersOfBooks, (t, p) => String.Concat(t.PadRight(23), ", ", p));
        Console.WriteLine($"20. Books and their publishers:");
        Output.PrintToConsole(query20);
    }
}

