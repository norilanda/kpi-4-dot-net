//Розробити структуру даних для зберігання інформації про книги в бібліотеці.
//Книга характеризується: назвою, прізвищем автора, вартістю, датою видання, видавництвом, списком інвентарних номерів (книга в кількох примірниках).
//У одного автора може бути декілька книг.
using laba1;
using static System.Reflection.Metadata.BlobBuilder;
using System.Text.RegularExpressions;

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
                new Book(0, "Fahrenheit 451", 730, new DateOnly(1953, 10, 19), publishers[0].PublisherId),
                new Book(1, "Dandelion Wine", 1900, new DateOnly(1957, 09, 21), publishers[1].PublisherId),
                new Book(2, "The Martian Chronicles", 100, new DateOnly(1950, 04, 06), publishers[1].PublisherId),
                new Book(3, "Pride and Prejudice", 962, new DateOnly(1813, 01, 28), publishers[2].PublisherId),
                new Book(4, "The Great Gatsby", 1200, new DateOnly(1925, 04, 10), publishers[3].PublisherId),
                new Book(5, "The Sun Also Rises", 3210, new DateOnly(1926, 10, 22), publishers[4].PublisherId),
                new Book(6, "A Farewell to Arms", 1090, new DateOnly(1926, 10, 22), publishers[4].PublisherId),
                new Book(7, "The Theory of Everything", 1300, new DateOnly(2010, 09, 07), publishers[5].PublisherId),
                new Book(8, "A Brief History of Time", 1300, new DateOnly(1988, 03, 19), publishers[5].PublisherId),
                new Book(9, "The Hobbit", 3210, new DateOnly(1937, 09, 21), publishers[6].PublisherId),
                new Book(10, "The Lord of the Rings", 3055, new DateOnly(1954, 09, 21), publishers[6].PublisherId),
                new Book(11, "A Tale of Two Cities", 830, new DateOnly(1959, 04, 30), publishers[7].PublisherId),
                new Book(12, "The Metamorphosis", 743, new DateOnly(1915, 08, 25), publishers[8].PublisherId),
                new Book(13, "The Trial", 3045, new DateOnly(1925, 09, 21), publishers[9].PublisherId),
            };
        //creating list of authors
        List<Author> authors = new List<Author>()
            {
                new Author(0, "Ray", "Bradbury"),
                new Author(1, "Jane", "Austen"),
                new Author(2, "Scott", "Fitzgerald"),
                new Author(3, "Ernest", "Hemingway"),
                new Author(4, "Stephen", "Hawkingon"),
                new Author(5, "Leonard", "Mlodinow"),
                new Author(6, "J. R. R.", "Tolkien"),
                new Author(7, "Charles", "Dickens"),
                new Author(8, "Franz", "Kafka"),
            };

        //creating list of BookOfAuthor objects that connect books and corresponding authors from lists
        List<BookOfAuthor> bookOfAuthorList = new List<BookOfAuthor>();
        try
        {
            //connecting books with authors from first lists
            bookOfAuthorList.Add(new BookOfAuthor(books[0].BookId, authors[0].AuthorId));
            bookOfAuthorList.Add(new BookOfAuthor(books[1].BookId, authors[0].AuthorId));
            bookOfAuthorList.Add(new BookOfAuthor(books[2].BookId, authors[0].AuthorId));
            bookOfAuthorList.Add(new BookOfAuthor(books[3].BookId, authors[1].AuthorId));
            bookOfAuthorList.Add(new BookOfAuthor(books[4].BookId, authors[2].AuthorId));
            bookOfAuthorList.Add(new BookOfAuthor(books[5].BookId, authors[3].AuthorId));
            bookOfAuthorList.Add(new BookOfAuthor(books[6].BookId, authors[3].AuthorId));
            bookOfAuthorList.Add(new BookOfAuthor(books[7].BookId, authors[4].AuthorId));
            bookOfAuthorList.Add(new BookOfAuthor(books[7].BookId, authors[5].AuthorId));
            bookOfAuthorList.Add(new BookOfAuthor(books[8].BookId, authors[4].AuthorId));
            bookOfAuthorList.Add(new BookOfAuthor(books[9].BookId, authors[6].AuthorId));
            bookOfAuthorList.Add(new BookOfAuthor(books[10].BookId, authors[6].AuthorId));
            bookOfAuthorList.Add(new BookOfAuthor(books[11].BookId, authors[7].AuthorId));
            bookOfAuthorList.Add(new BookOfAuthor(books[12].BookId, authors[8].AuthorId));
            bookOfAuthorList.Add(new BookOfAuthor(books[13].BookId, authors[8].AuthorId));
        }
        catch (IndexOutOfRangeException e)
        { Console.WriteLine(e.Message); }

        //creating 3 libraries
        List<Library> libraries = new List<Library>()
        {
            new Library(0, "Library 1"),
            new Library(1, "Library 2"),
            new Library(2, "Library 3")
        };

        //creating connections between books and libraries
        List<BookOfLibrary> bookOfLibraryList = new List<BookOfLibrary>()
        {
            new BookOfLibrary(libraries[0].LibraryId, books[0].BookId, new List<int>(){1, 2, 3, 4, 5} ),
            new BookOfLibrary(libraries[0].LibraryId, books[1].BookId, new List<int>(){6, 7, 8} ),
            new BookOfLibrary(libraries[0].LibraryId, books[2].BookId, new List<int>(){9, 10} ),
            new BookOfLibrary(libraries[0].LibraryId, books[3].BookId, new List<int>(){11, 12} ),
            new BookOfLibrary(libraries[0].LibraryId, books[4].BookId, new List<int>(){13} ),
            new BookOfLibrary(libraries[0].LibraryId, books[5].BookId, new List<int>(){14, 15} ),
            new BookOfLibrary(libraries[0].LibraryId, books[6].BookId, new List<int>(){16, 17, 18} ),
            new BookOfLibrary(libraries[0].LibraryId, books[7].BookId, new List<int>(){19, 20} ),
            new BookOfLibrary(libraries[0].LibraryId, books[8].BookId, new List<int>(){21, 22, 23} ),
            new BookOfLibrary(libraries[0].LibraryId, books[9].BookId, new List<int>(){24} ),
            new BookOfLibrary(libraries[0].LibraryId, books[10].BookId, new List<int>(){25, 26, 27, 28} ),

            new BookOfLibrary(libraries[1].LibraryId, books[0].BookId, new List<int>(){1, 2, 3}  ),
            new BookOfLibrary(libraries[1].LibraryId, books[1].BookId, new List<int>(){4, 5}  ),
            new BookOfLibrary(libraries[1].LibraryId, books[9].BookId, new List<int>(){6} ),
            new BookOfLibrary(libraries[1].LibraryId, books[11].BookId, new List<int>(){7, 8} ),
            new BookOfLibrary(libraries[1].LibraryId, books[12].BookId, new List<int>(){9, 10} ),

            new BookOfLibrary(libraries[2].LibraryId, books[13].BookId, new List<int>(){1, 2, 3} ),
            new BookOfLibrary(libraries[2].LibraryId, books[0].BookId, new List<int>(){4} ),
            new BookOfLibrary(libraries[2].LibraryId, books[7].BookId, new List<int>(){5, 6} )
    };

        //1. (Extentions syntax) Selects all authors and titles of all their books from all libraries
        Query1(books, authors, bookOfAuthorList);

        //2. (Query syntax) Select authors for each book that has price bigger than 1000
        Query2(books, authors, bookOfAuthorList, 1000);

        //3. (Extentions syntax) Order books published before 2000 by titles
        Query3(books, 2000);

        //4. (Query syntax) Show books and libraries they are in
        Query4(books, libraries, bookOfLibraryList);

        ////5. (Extentions syntax) Show all books published since 2000 year, sorted by date
        //Query5();

        //6. (Extentions syntax) Show top 5 most expensive books and its/their author/-s
        Query6(books, authors, bookOfAuthorList, 5);

        //7. (Query syntax) Show sum of all books for every author and order them by book number from bigger to smaller and then by author firstname
        Query7(books, authors, bookOfAuthorList);

        //8. (Query syntax) Select books with max price
        Query8(books);

        ////9. (Extentions syntax) 
        //Query9();

        ////10. (Extentions syntax) Select authors that are common for 2 libraries
        //Query10(authors, libraries);

        ////11. (Extentions syntax) Select authors different for 2 libs
        //Query11();

        ////12. (Extentions syntax) Show authors in all libraries and publishers of their books
        //Query12(books, authors, bookOfAuthorList, publishers);

        ////13. (Extentions syntax) Select average number of copies of each book (count inventory numbers) for each library
        //Query13(libraries, bookOfLibraryList);

        //14. (Extentions syntax) Select 5-th book from list ordered by date
        Query14(books, 5);

        //15. (Extentions syntax) Select books with shortest Title
        Query15(books);

        //16. (Extentions syntax) From lib1 select all books that have price bigger than average price of all books in lib2
        Query16(books);

        //17. (Extentions syntax) Select the top 5 most frequent words in book titles
        Query17(books, 5);

        //18. (Extentions syntax) Select percent of sum of all books for every book
        Query18(books);

        //19. (Query syntax) Group books by their publishing month
        Query19(books);

        ////20. (Query syntax) Show books that have only one inventory number
        //Query20();
    }

    /// (Extentions syntax)
    /// 1. Selects all authors and titles of all their books from all libraries
    public static void Query1(List<Book> books, List<Author> authors, List<BookOfAuthor> bookOfAuthorList)
    {
        var query1 = authors.GroupJoin(
        bookOfAuthorList,
        author => author.AuthorId,
        book => book.IdOfAuthor,
        (auth, bs) => new
        {
            author = auth,
            book = bs.Select(b => b.IdOfBook).Join(
                                   books,
                                   bookId => bookId,
                                   book => book.BookId,
                                   (_, book) => book)
        }
    );
        Console.WriteLine("1. Authors and all their books titles:");
        foreach (var bookOfAuthor in query1)
        {
            Console.WriteLine($"\t{bookOfAuthor.author}:");
            foreach (var book in bookOfAuthor.book)
            {
                Console.WriteLine("\t\t"+book.Title);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    /// (Query syntax)
    /// 2. Select authors for each book that has price bigger than priceToFilter
    public static void Query2(List<Book> books, List<Author> authors, List<BookOfAuthor> bookOfAuthorList, int priceToFilter)
    {
        var query2 = from b in books
                     where b.Price > priceToFilter
                     select new
                     {
                         book = b,
                         authors = (from ab in bookOfAuthorList
                                    join a in authors on ab.IdOfAuthor equals a.AuthorId
                                    where b.BookId == ab.IdOfBook
                                    select a).ToList()
                     };
        Console.WriteLine($"2. Books that have price > {priceToFilter} and their authors:");
        foreach (var item in query2)
            Console.WriteLine($"\t{item.book.Title.PadRight(25)}\t{item.book.Price}" +
                $"\n\t\t{String.Join(", ", item.authors)}");
        Console.WriteLine();
    }

    /// (Extentions syntax)
    /// 3. Order books published before yearFilter by titles
    public static void Query3(List<Book> books, int yearFilter)
    {
        var query3 = books.OrderBy(b => b.Title)
                .Where(b => b.PublishingDate.Year < yearFilter);
        Console.WriteLine($"3. Ordered by titles list of books published before {yearFilter}:");
        foreach (var item in query3)
            Console.WriteLine($"\t{item}");
        Console.WriteLine();
    }

    /// 4. (Query syntax) Show books and libraries they are in
    public static void Query4(List<Book> books, List<Library> libs, List<BookOfLibrary> bookOfLibraryList)
    {
        var query4 = from bl in bookOfLibraryList
                     group bl by bl.LibraryId
                     into g
                     select new
                     {
                         library = (from l in libs
                                   where l.LibraryId == g.Key
                                   select l).Single(),
                         booksInlib = from b in books
                                      join g1 in g on b.BookId equals g1.BookId
                                      select b
                     };
        Console.WriteLine("4. Books and libraries they are in:");
        foreach (var item in query4)
        { 
            Console.WriteLine($"\t{item.library}"); 
            foreach(var item2 in item.booksInlib)
                Console.WriteLine($"\t\t{item2}");
        }
        Console.WriteLine();
    }


    //    /// 5. (Extentions syntax) Show 
    //    public static void Query5(Library lib)
    //    {
    //        var query5 =
    //        Console.WriteLine($"5. ");
    //        foreach (var book in query5) Console.WriteLine("\t" + book.ToString());
    //        Console.WriteLine();
    //    }

    /// 6. (Extentions syntax) Show top 'topNumberFilter' most expensive books and its/their author/-s
    public static void Query6(List<Book> books, List<Author> authors, List<BookOfAuthor> bookOfAuthorList, int topNumberFilter = 5)
    {
        var query6 = books
                .OrderByDescending(b => b.Price)
                .ThenBy(b => b.Title)
                .Take(topNumberFilter)
                .GroupJoin(
                bookOfAuthorList,
                b => b.BookId,
                ab => ab.IdOfBook,
                (b, ab) => new
                {
                    book = b,
                    authors = ab.Select(x => x.IdOfAuthor)
                            .Join(
                                authors,
                                ab => ab,
                                a => a.AuthorId,
                                (_, a) => a).ToList()
                }
            );
        Console.WriteLine($"6. Top {topNumberFilter} expensive books and their authors");
        foreach (var item in query6)
            Console.WriteLine($"\t{item.book} {String.Join(", ", item.authors)}");
        Console.WriteLine();
    }

    ///  7. (Query syntax) Show sum of all books for every author and order them by book number from bigger to smaller and then by author firstname
    public static void Query7(List<Book> books, List<Author> authors, List<BookOfAuthor> bookOfAuthorList)
    {
        var query7 = from aBookn in (
                         from ab in bookOfAuthorList
                         group ab by ab.IdOfAuthor
                         into authorGroup
                         select new
                         {
                             author = (from a in authors
                                       where a.AuthorId == authorGroup.Key
                                       select a).Single(),
                             bookNum = authorGroup.Count()
                         })
                     orderby aBookn.bookNum descending, aBookn.author.Firstname
                     select aBookn;
        Console.WriteLine("7. Authors' number of books, ordered by this number and then by author's first name:");
        foreach (var item in query7)
            Console.WriteLine($"\t{item.author.ToString().PadRight(18)} {item.bookNum}");
        Console.WriteLine();
    }

    /// 8. (Query syntax) Select books with max price
    public static void Query8(List<Book> books)
    {
        var query8 = from b in books
                     where b.Price == (from b1 in books
                                       select b1.Price).Max()
                     select b;
        Console.WriteLine("8. All books which price is max:");
        foreach (var item in query8)
            Console.WriteLine("\t" + item);
        Console.WriteLine();
    }

    ///// 9. (Extentions syntax) Select 
    //public static void Query9()
    //{
    //    var query9 =
    //    Console.WriteLine("9. ");
    //    foreach (var item in query9)
    //        Console.WriteLine($"\t{item}");
    //    Console.WriteLine();
    //}

    //    /// 10. (Extentions syntax) Select authors that are common for all libraries
    //    public static void Query10(List<Author> authors, List <Library> libs)
    //    {
    //        var query10 = lib1.Authors.Intersect(lib2.Authors, new AuthorComparerByName());
    //        Console.WriteLine("10. All authors that are in all libraries:");
    //        foreach (var item in query10)
    //            Console.WriteLine($"\t{item.Firstname} {item.Lastname}");
    //        Console.WriteLine();
    //    }

    //    /// 11. (Extentions syntax) Select authors different for all libs
    //    public static void Query11(List<Author> authors, List<Library> libs)
    //    {
    //        var query11 = (from a1 in lib1.Authors
    //                       select a1)
    //                   .Union(
    //                   from a2 in lib2.Authors
    //                   select a2, new AuthorComparerByName())
    //               .Except(
    //                    (from a1 in lib1.Authors
    //                     select a1)
    //                    .Intersect(from a2 in lib2.Authors
    //                               select a2,
    //                               new AuthorComparerByName())
    //                    );
    //        Console.WriteLine("11. All authors that are different for all libraries:");
    //        foreach (var item in query11)
    //            Console.WriteLine("\t" + item);
    //        Console.WriteLine();
    //    }

    //    /// 12. (Extentions syntax) Show authors and publishers of their books
    //    public static void Query12(List<Book> books, List<Author> authors, List<BookOfAuthor> bookOfAuthorList, List<Publisher> publishers)
    //    {
    //        var query12 = 
    //        Console.WriteLine("12. Authors and publishers of their books:");
    //        foreach (var item in query12)
    //            Console.WriteLine($"\t{item.author.ToString().PadRight(18)}\t{String.Join(", ", item.publishers)}");
    //        Console.WriteLine();
    //    }

    //    /// 13. (Extentions syntax) Select average number of copies of each book (count inventory numbers) for each library
    //    public static void Query13(List<Library> libs, List<BookOfLibrary> bookOfLibraryList)
    //    {
    //        var query13 = 
    //        Console.WriteLine("13. Average number of copies of books for each library:");
    //        foreach (var item in query13)
    //            Console.WriteLine($"\t{item.Name.PadRight(18)} {item.averageNumOfCopies.ToString("0.00")}");
    //        Console.WriteLine();
    //    }

    /// 14. (Extentions syntax) Select n-th book from list ordered by date
    public static void Query14(List<Book> books, int n = 5)
    {
        int indexOfBookInList = n - 1;
        var query14 = books.OrderBy(b => b.PublishingDate)
                .ElementAtOrDefault(indexOfBookInList);
        Console.WriteLine($"14. {indexOfBookInList + 1}th book in ordered by date list of books:");
        Console.WriteLine($"\t{query14}");
        Console.WriteLine();
    }

    /// 15. (Extentions syntax) Select books with shortest Title
    public static void Query15(List<Book> books)
    {
        var query15 = books.Where(b => b.Title.Count()
                                    == books.Min(b => b.Title.Count()));
        Console.WriteLine("15. All books with shortest titles:");
        foreach (var item in query15)
            Console.WriteLine("\t" + item);
        Console.WriteLine();
    }

    /// 16. (Extentions syntax) Select all books that have price bigger than average price of all books
    public static void Query16(List<Book> books)
    {
        double averagePriceOfBooksInlib2 = books.Average(b => b.Price);
        var query16 = books.Where(b => b.Price > averagePriceOfBooksInlib2);
        Console.WriteLine($"16. Books in lib1 that have price bigger than average price of books in lib2({averagePriceOfBooksInlib2}):");
        foreach (var item in query16)
            Console.WriteLine("\t" + item);
        Console.WriteLine();
    }

    /// 17. (Extentions syntax) Select the top 'topNumberFilter' most frequent words in book titles
    public static void Query17(List<Book> books, int topNumberFilter = 5)
    {
        Regex rgx = new Regex("[^a-zA-Z0-9 -]");
        var query17 = books.SelectMany(b => rgx.Replace(b.Title, "")
                                                    .ToLower()
                                                    .Split())
                                .GroupBy(word => word,
                                         word => books.SelectMany(b => rgx.Replace(b.Title, "")
                                                    .ToLower()
                                                    .Split())
                                         .Where(w => w.Equals(word))
                                         .Count(),
                                         (word, num) => new { Word = word, Num = num.Count() })
                                .OrderByDescending(item => item.Num)
                                .ThenBy(item => item.Word)
                                .Take(topNumberFilter);
        Console.WriteLine($"17. Top {topNumberFilter} most frequent words in books' titles:");
        foreach (var item in query17)
            Console.WriteLine($"\t{item.Word.PadRight(12)} {item.Num}");
        Console.WriteLine();
    }

    /// 18. (Extentions syntax) Select percent of sum of all books for every book
    public static void Query18(List<Book> books)
    {
        double sumPriceOfAllBooks = books.Sum(b => b.Price);
        var query18 = books.Select(b => new { book = b, Percent = (double)b.Price / sumPriceOfAllBooks });
        Console.WriteLine("18. Percentage of price for every book: ");
        foreach (var b in query18)
            Console.WriteLine($"\t{b.book} {b.Percent.ToString("0.00")}%");
        Console.WriteLine();
    }

    /// 19. (Query syntax) Group books by their publishing month
    public static void Query19(List<Book> books)
    {
        var query19 = from book in books
                      group book by book.PublishingDate.Month
              into groupByMonths
                      orderby groupByMonths.Key
                      select groupByMonths;
        Console.WriteLine("19. Books grouped by month they where published:");
        foreach (var item in query19)
        {
            Console.WriteLine($"\tMonth {item.Key}");
            foreach (var item1 in item)
                Console.WriteLine($"\t\t{item1}");
        }
        Console.WriteLine();
    }

    //    /// 20. (Query syntax) 
    //    public static void Query20(Library lib)
    //    {
    //        var query20 =
    //        Console.WriteLine($"20. :");
    //        foreach (var item in query20)
    //            Console.WriteLine("\t"+item);
    //        Console.WriteLine();
    //    }
}

