//Розробити структуру даних для зберігання інформації про книги в бібліотеці. Книга характеризується: назвою, прізвищем автора, вартістю, датою видання, видавництвом, списком інвентарних номерів (книга в кількох примірниках). У одного автора може бути декілька книг.
using laba1;
using static System.Reflection.Metadata.BlobBuilder;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        List<Book> books1 = new List<Book>()
            {
                new Book(0, "Fahrenheit 451", 730, new DateOnly(1953, 10, 19), "Ballantine Books", new List<int>(){1, 2, 3, 4, 5}),
                new Book(1, "Dandelion Wine", 1900, new DateOnly(1957, 09, 21), "Doubleday", new List<int>(){6, 7, 8}),
                new Book(2, "The Martian Chronicles", 100, new DateOnly(1950, 04, 06), "Doubleday", new List<int>(){9, 10}),
                new Book(3, "Pride and Prejudice", 962, new DateOnly(1813, 01, 28), "T. Egerton", new List<int>(){11, 12}),
                new Book(4, "The Great Gatsby", 1200, new DateOnly(1925, 04, 10), "Charles Scribner's Sons", new List<int>(){13}),
                new Book(5, "The Sun Also Rises", 3210, new DateOnly(1926, 10, 22), "Scribner's", new List<int>(){14, 15}),
                new Book(6, "A Farewell to Arms", 1090, new DateOnly(1926, 10, 22), "Scribner's", new List<int>(){16, 17, 18}),
                new Book(7, "The Theory of Everything", 1300, new DateOnly(2010, 09, 07), "Bantam Books", new List<int>(){19, 20}),
                new Book(8, "A Brief History of Time", 1300, new DateOnly(1988, 03, 19), "Bantam Books", new List<int>(){21, 22, 23}),
                new Book(9, "The Hobbit", 3210, new DateOnly(1937, 09, 21), "George Allen & Unwin", new List<int>(){24}),
                new Book(10, "The Lord of the Rings", 3055, new DateOnly(1954, 09, 21), "George Allen & Unwin", new List<int>(){25, 26, 27, 28})
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
                new Author(0, "Ray", "Bradbury"),
                new Author(1, "Jane", "Austen"),
                new Author(2, "Scott", "Fitzgerald"),
                new Author(3, "Ernest", "Hemingway"),
                new Author(4, "Stephen", "Hawkingon"),
                new Author(5, "Leonard", "Mlodinow"),
                new Author(6, "J. R. R.", "Tolkien")
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
            bookOfAuthorList1.Add(new BookOfAuthor(books1[6].BookId, authors1[3].AuthorId));
            bookOfAuthorList1.Add(new BookOfAuthor(books1[7].BookId, authors1[4].AuthorId));
            bookOfAuthorList1.Add(new BookOfAuthor(books1[7].BookId, authors1[5].AuthorId));
            bookOfAuthorList1.Add(new BookOfAuthor(books1[8].BookId, authors1[4].AuthorId));
            bookOfAuthorList1.Add(new BookOfAuthor(books1[9].BookId, authors1[6].AuthorId));
            bookOfAuthorList1.Add(new BookOfAuthor(books1[10].BookId, authors1[6].AuthorId));

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

        //1. (Extentions syntax) Selects all authors and titles of all their books
        Query1(lib1);

        //2. (Query syntax) Select authors for each book that has price bigger than 1000
        Query2(lib1);

        //3. (Extentions syntax) Order books published before 2000 by titles and show number of every book (count inventory number)
        Query3(lib1);

        //4. (Extentions syntax) Show inventory numbers of all books for each author
        Query4(lib1);

        //5. (Extentions syntax) Show all books published since 2000 year, sorted by date
        Query5(lib1);

        //6. (Extentions syntax) Show top 5 most expensive books and its/their author/-s
        Query6(lib1);

        //7. (Query syntax) Show sum of all books for every author and order them by book number from bigger to smaller and then by author firstname
        Query7(lib1);

        //8. (Query syntax) Select books with max price
        Query8(lib1);

        //9. (Extentions syntax) Select titles of all books that are in lib1 and lib2 ordered by titles
        Query9(lib1, lib2);

        //10. (Extentions syntax) Select authors that are common for 2 libraries
        Query10(lib1, lib2);

        //11. (Extentions syntax) Select authors different for 2 libs
        Query11(lib1, lib2);

        //12. (Extentions syntax) Show authors in all libraries and publishers of their books
        Query12(allLibs);

        //13. (Extentions syntax) Select average number of copies of each book (count inventory numbers) for each library
        Query13(allLibs);

        //14. (Extentions syntax) Select 5-th book from list ordered by date
        Query14(lib1);

        //15. (Extentions syntax) Select books with shortest Title
        Query15(lib1);

        //16. (Extentions syntax) From lib1 select all books that have price bigger than average price of all books in lib2
        Query16(lib1, lib2);

        //17. (Extentions syntax) Select the top 10 most frequent words in book titles
        Query17(lib1);

        //18. (Extentions syntax) Select percent of sum of all books for every book
        Query18(lib1);

        //19. (Query syntax) Group books by their publishing month
        Query19(lib1);

        //20. (Query syntax) Show books that have only one inventory number
        Query20(lib1);
    }

    /// <summary>
    /// (Extentions syntax)
    /// 1. Selects all authors and titles of all their books
    /// </summary>
    /// <param name="lib"></param>
    public static void Query1(Library lib)
    {
        var query1 = lib.Authors.GroupJoin(
        lib.BookOfAuthorList,
        author => author.AuthorId,
        book => book.IdOfAuthor,
        (auth, books) => new
        {
            author = auth,
            book = books.Select(b => b.IdOfBook).Join(
                                   lib.Books,
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

    /// <summary>
    /// (Query syntax)
    /// 2. Select authors for each book that has price bigger than 1000
    /// </summary>
    /// <param name="lib"></param>
    public static void Query2(Library lib)
    {
        int priceToFilter = 1000;
        var query2 = from b in lib.Books
                     where b.Price > priceToFilter
                     select new
                     {
                         book = b,
                         authors = (from ab in lib.BookOfAuthorList
                                    join a in lib.Authors on ab.IdOfAuthor equals a.AuthorId
                                    where b.BookId == ab.IdOfBook
                                    select a).ToList()
                     };
        Console.WriteLine($"2. Books that have price > {priceToFilter} and their authors:");
        foreach (var item in query2)
            Console.WriteLine($"\t{item.book.Title.PadRight(25)}\t{item.book.Price}" +
                $"\n\t\t{String.Join(", ", item.authors)}");
        Console.WriteLine();
    }

    /// <summary>
    /// (Extentions syntax)
    /// 3. Order books published before 2000 by titles and show number of every book (count inventory number)
    /// </summary>
    /// <param name="lib"></param>
    public static void Query3(Library lib)
    {
        int yearFilter = 2000;
        var query3 = lib.Books.OrderBy(b => b.Title)
                .Where(b => b.PublishingDate.Year < yearFilter)
                .Select(b => new
                {
                    book = b,
                    copyNumber = b.InventoryNumbers.Count()
                });
        Console.WriteLine($"3. Ordered by titles list of books published before {yearFilter} with count of their inventory numbers");
        foreach (var item in query3)
            Console.WriteLine($"\t{item.book} {item.copyNumber}");
        Console.WriteLine();
    }

    /// <summary>
    /// 4. (Extentions syntax) Show inventory numbers of all books for each author
    /// </summary>
    /// <param name="lib"></param>
    public static void Query4(Library lib)
    {
        var query4 = lib.Authors.GroupJoin(
        lib.BookOfAuthorList,
        a => a.AuthorId,
        ab => ab.IdOfAuthor,
        (a, ab) => new
        {
            author = a,
            inventNumbers = lib.Books
                        .Where(b => ab.Select(x => x.IdOfBook)
                                      .Contains(b.BookId))
                        .SelectMany(y => y.InventoryNumbers)
        }
        );
        Console.WriteLine("4. Authors and their books inventory numbers:");
        foreach (var item in query4)
            Console.WriteLine($"\t{item.author.ToString().PadRight(20)} {String.Join(", ", item.inventNumbers)}");
        Console.WriteLine();
    }

    /// <summary>
    /// 5. (Extentions syntax) Show all books published since 2000 year, sorted by date
    /// </summary>
    /// <param name="lib"></param>
    public static void Query5(Library lib)
    {
        int yearFilter = 2000;
        var query5 = lib.Books
                         .OrderBy(b => b.PublishingDate)
                         .SkipWhile(b => b.PublishingDate.Year < yearFilter);
        Console.WriteLine($"5. All book published after {yearFilter} ordered by date");
        foreach (var book in query5) Console.WriteLine("\t" + book.ToString());
        Console.WriteLine();
    }

    /// <summary>
    /// 6. (Extentions syntax) Show top 5 most expensive books and its/their author/-s
    /// </summary>
    /// <param name="lib"></param>
    public static void Query6(Library lib)
    {
        int topNumberFilter = 5;
        var query6 = lib.Books
                .OrderByDescending(b => b.Price)
                .Take(topNumberFilter)
                .GroupJoin(
                lib.BookOfAuthorList,
                b => b.BookId,
                ab => ab.IdOfBook,
                (b, ab) => new
                {
                    book = b,
                    authors = ab.Select(x => x.IdOfAuthor)
                            .Join(
                                lib.Authors,
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

    /// <summary>
    /// 7. (Query syntax) Show sum of all books for every author and order them by book number from bigger to smaller and then by author firstname
    /// </summary>
    /// <param name="lib"></param>
    public static void Query7(Library lib)
    {
        var query7 = from aBookn in (
                         from ab in lib.BookOfAuthorList
                         group ab by ab.IdOfAuthor
                         into authorGroup
                         select new
                         {
                             author = (from a in lib.Authors
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

    /// <summary>
    /// 8. (Query syntax) Select books with max price
    /// </summary>
    /// <param name="lib"></param>
    public static void Query8(Library lib)
    {
        var query8 = from b in lib.Books
                     where b.Price == (from b1 in lib.Books
                                       select b1.Price).Max()
                     select b;
        Console.WriteLine("8. All books which price is max:");
        foreach (var item in query8)
            Console.WriteLine("\t"+item);
    }

    /// <summary>
    /// 9. (Extentions syntax) Select titles of all books that are in lib1 and lib2 ordered by titles
    /// </summary>
    /// <param name="lib1"></param>
    /// <param name="lib2"></param>
    public static void Query9(Library lib1, Library lib2)
    {
        var query9 = lib1.Books.Select(b => b.Title)
                               .Union(lib2.Books.Select(b => b.Title))
                               .OrderBy(title => title);
        Console.WriteLine("9. All books titles from lib1 and lib2:");
        foreach (var item in query9)
            Console.WriteLine($"\t{item}");
        Console.WriteLine();
    }

    /// <summary>
    /// 10. (Extentions syntax) Select authors that are common for 2 libraries
    /// </summary>
    /// <param name="lib1"></param>
    /// <param name="lib2"></param>
    public static void Query10(Library lib1, Library lib2)
    {
        var query10 = lib1.Authors.Intersect(lib2.Authors, new AuthorComparerByName());
        Console.WriteLine("10. All authors that are in both lib1 and lib2:");
        foreach (var item in query10)
            Console.WriteLine($"\t{item.Firstname} {item.Lastname}");
        Console.WriteLine();
    }

    /// <summary>
    /// 11. (Extentions syntax) Select authors different for 2 libs
    /// </summary>
    /// <param name="lib1"></param>
    /// <param name="lib2"></param>
    public static void Query11(Library lib1, Library lib2)
    {
        var query11 = (from a1 in lib1.Authors
                       select a1)
                   .Union(
                   from a2 in lib2.Authors
                   select a2, new AuthorComparerByName())
               .Except(
                    (from a1 in lib1.Authors
                     select a1)
                    .Intersect(from a2 in lib2.Authors
                               select a2,
                               new AuthorComparerByName())
                    );
        Console.WriteLine("11. All authors that are in lib1 but are not in lib2 and that are in lib2 but are not in lib1:");
        foreach (var item in query11)
            Console.WriteLine("\t" + item);
        Console.WriteLine();
    }

    /// <summary>
    /// 12. (Extentions syntax) Show authors in all libraries and publishers of their books
    /// </summary>
    /// <param name="allLibs"></param>
    public static void Query12(List<Library> allLibs)
    {
        var query12 = allLibs.SelectMany(l => l.Authors
                             .GroupJoin(
                                    l.BookOfAuthorList,
                                    a => a.AuthorId,
                                    ab => ab.IdOfAuthor,
                                    (a, ab) => new
                                    {
                                        author = a,
                                        publishers = l.Books.Where(b => ab.Select(x => x.IdOfBook)
                                            .Contains(b.BookId))
                                            .Select(b => b.Publisher),
                                    })).GroupBy(item => item.author,
                                        item => item.publishers,
                                        new AuthorComparerByName()
                                        ).Select(item => new
                                        {
                                            author = item.Key,
                                            publishers = item.SelectMany(x => x)
                                                             .Distinct()
                                                             .ToList()
                                        })
                              .OrderBy(item => item.author.Firstname);
        Console.WriteLine("12. Authors and publishers of their books:");
        foreach (var item in query12)
            Console.WriteLine($"\t{item.author.ToString().PadRight(18)}\t{String.Join(", ", item.publishers)}");
        Console.WriteLine();
    }

    /// <summary>
    /// 13. (Extentions syntax) Select average number of copies of each book (count inventory numbers) for each library
    /// </summary>
    /// <param name="allLibs"></param>
    public static void Query13(List<Library> allLibs)
    {
        var query13 = allLibs.Select(l => new
        {
            Name = l.Name,
            averageNumOfCopies = l.Books.Any() ? l.Books.Average(b => b.InventoryNumbers.Count()) : 0
        });
        Console.WriteLine("13. Average number of copies of books for each library:");
        foreach (var item in query13)
            Console.WriteLine($"\t{item.Name.PadRight(18)} {item.averageNumOfCopies.ToString("0.00")}");
        Console.WriteLine();
    }

    /// <summary>
    /// 14. (Extentions syntax) Select 5-th book from list ordered by date
    /// </summary>
    /// <param name="lib"></param>
    public static void Query14(Library lib)
    {
        int indexOfBookInList = 4;
        var query14 = lib.Books.OrderBy(b => b.PublishingDate)
                .ElementAtOrDefault(indexOfBookInList);
        Console.WriteLine($"14. {indexOfBookInList+1}th book in ordered by date list of books:");
        Console.WriteLine($"\t{query14}");
        Console.WriteLine();
    }

    /// <summary>
    /// 15. (Extentions syntax) Select books with shortest Title
    /// </summary>
    /// <param name="lib"></param>
    public static void Query15(Library lib)
    {
        var query15 = lib.Books.Where(b => b.Title.Count()
                                    == lib.Books.Min(b => b.Title.Count()));
        Console.WriteLine("15. All books with shortest titles:");
        foreach (var item in query15)
            Console.WriteLine("\t"+item);
        Console.WriteLine();
    }

    /// <summary>
    /// 16. (Extentions syntax) From lib1 select all books that have price bigger than average price of all books in lib2
    /// </summary>
    /// <param name="lib1"></param>
    /// <param name="lib2"></param>
    public static void Query16(Library lib1, Library lib2)
    {
        double averagePriceOfBooksInlib2 = lib2.Books.Average(b => b.Price);
        var query16 = lib1.Books.Where(b => b.Price > averagePriceOfBooksInlib2);
        Console.WriteLine($"16. Books in lib1 that have price bigger than average price of books in lib2({averagePriceOfBooksInlib2}):");
        foreach (var item in query16)
            Console.WriteLine("\t"+item);
        Console.WriteLine();
    }

    /// <summary>
    /// 17. (Extentions syntax) Select the top 10 most frequent words in book titles
    /// </summary>
    /// <param name="lib"></param>
    public static void Query17(Library lib)
    {
        int topNumberFilter = 10;
        Regex rgx = new Regex("[^a-zA-Z0-9 -]");
        var query17 = lib.Books.SelectMany(b => rgx.Replace(b.Title, "")
                                                    .ToLower()
                                                    .Split())
                                .GroupBy(word => word,
                                         word => lib.Books.SelectMany(b => rgx.Replace(b.Title, "")
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

    /// <summary>
    /// 18. (Extentions syntax) Select percent of sum of all books for every book
    /// </summary>
    /// <param name="lib"></param>
    public static void Query18(Library lib)
    {
        double sumPriceOfAllBooks = lib.Books.Sum(b => b.Price);
        var query18 = lib.Books.Select(b => new { book = b, Percent = (double)b.Price / sumPriceOfAllBooks });
        Console.WriteLine("18. Percentage of price for every book: ");
        foreach (var b in query18) 
            Console.WriteLine($"\t{b.book} {b.Percent.ToString("0.00")}%");
        Console.WriteLine();
    }

    /// <summary>
    /// 19. (Query syntax) Group books by their publishing month
    /// </summary>
    /// <param name="lib"></param>
    public static void Query19(Library lib)
    {
        var query19 = from book in lib.Books
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

    /// <summary>
    /// 20. (Query syntax) Show books that have only one inventory number
    /// </summary>
    /// <param name="lib"></param>
    public static void Query20(Library lib)
    {
        int inventoryNumberCountFilter = 1;
        var query20 = from book in lib.Books
                      where book.InventoryNumbers.Count() == inventoryNumberCountFilter
                      select book;
        Console.WriteLine($"20. Books that have {inventoryNumberCountFilter} inventory numbers:");
        foreach (var item in query20)
            Console.WriteLine("\t"+item);
        Console.WriteLine();
    }
}

