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
                new Book(3, "The Call of the Wild", 900, new DateOnly(1903, 01, 10), "Macmillan Publishers", new List<int>(){11}),
                new Book(4, "Heart of Darkness", 2930, new DateOnly(1899, 02, 10), "Blackwood's Magazine", new List<int>(){12, 13, 14}),
                new Book(5, "Pride and Prejudice", 962, new DateOnly(1813, 01, 28), "T. Egerton", new List<int>(){15, 16}),
                new Book(6, "The Great Gatsby", 1200, new DateOnly(1925, 04, 10), "Charles Scribner's Sons", new List<int>(){17}),
                new Book(7, "To Kill a Mockingbird", 398, new DateOnly(1960, 07, 11), "J. B. Lippincott & Co.", new List<int>(){18, 19, 20}),
                new Book(8, "Sense and Sensibility", 962, new DateOnly(1811, 10, 30), "T. Egerton", new List<int>(){21, 22}),
                new Book(9, "Animal Farm", 280, new DateOnly(1945, 08, 17), "Secker and Warburg", new List<int>(){23}),
                new Book(10, "Nineteen Eighty-Four", 978, new DateOnly(1949, 06, 08), "Secker and Warburg", new List<int>(){24, 25}),
                new Book(11, "The Sun Also Rises", 3210, new DateOnly(1926, 10, 22), "Scribner's", new List<int>(){26, 27}),
                new Book(12, "A Farewell to Arms", 1090, new DateOnly(1926, 10, 22), "Scribner's", new List<int>(){28, 29, 30}),
                new Book(13, "The Theory of Everything: The Origin and Fate of the Universe", 1300, new DateOnly(2010, 09, 07), "Bantam Books", new List<int>(){31, 32}),
                new Book(14, "A Brief History of Time", 1300, new DateOnly(1988, 03, 19), "Bantam Books", new List<int>(){33, 34, 35}),
                new Book(15, "The Book Thief", 800, new DateOnly(2005, 03, 14), "Picador", new List<int>(){36}),
                new Book(16, "The Hobbit", 3210, new DateOnly(1937, 09, 21), "George Allen & Unwin", new List<int>(){37, 38}),
                new Book(17, "The Lord of the Rings", 3055, new DateOnly(1954, 09, 21), "George Allen & Unwin", new List<int>(){39, 40, 41, 42})
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
                new Author(12, "J. R. R.", "Tolkien")
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

        //2. (Query syntax) Select authors for each book
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
        foreach (var bookOfAuthor in query1)
        {
            Console.WriteLine($"{bookOfAuthor.author}:");
            foreach (var book in bookOfAuthor.book)
            {
                Console.WriteLine(book.Title);
            }
            Console.WriteLine();
        }
    }

    /// <summary>
    /// (Query syntax)
    /// 2. Select authors for each book (with using query syntax)
    /// </summary>
    /// <param name="lib"></param>
    public static void Query2(Library lib)
    {
        var query2 = from b in lib.Books
                     select new
                     {
                         book = b,
                         authors = (from ab in lib.BookOfAuthorList
                                    join a in lib.Authors on ab.IdOfAuthor equals a.AuthorId
                                    where b.BookId == ab.IdOfBook
                                    select a).ToList()
                     };
        foreach (var item in query2)
            Console.WriteLine($"{item.book}\t{String.Join(", ", item.authors)}");
    }

    /// <summary>
    /// (Extentions syntax)
    /// 3. Order books published before 2000 by titles and show number of every book (count inventory number)
    /// </summary>
    /// <param name="lib"></param>
    public static void Query3(Library lib)
    {
        var query3 = lib.Books.OrderBy(b => b.Title)
                .Where(b => b.PublishingDate.Year < 2000)
                .Select(b => new
                {
                    book = b,
                    copyNumber = b.InventoryNumbers.Count()
                });
        foreach (var item in query3)
            Console.WriteLine($"{item.book}\t{item.copyNumber}");
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
        foreach (var item in query4)
            Console.WriteLine($"{item.author}\t{String.Join(", ", item.inventNumbers)}");
    }

    /// <summary>
    /// 5. (Extentions syntax) Show all books published since 2000 year, sorted by date
    /// </summary>
    /// <param name="lib"></param>
    public static void Query5(Library lib)
    {
        var query5 = lib.Books.Where(b => b.PublishingDate.Year >= 2000)
                              .OrderBy(b => b.PublishingDate);
        foreach (var book in query5) Console.WriteLine(book.ToString());
    }

    /// <summary>
    /// 6. (Extentions syntax) Show top 5 most expensive books and its/their author/-s
    /// </summary>
    /// <param name="lib"></param>
    public static void Query6(Library lib)
    {
        var query6 = lib.Books
                .OrderByDescending(b => b.Price)
                .Take(5)
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
        foreach (var item in query6)
            Console.WriteLine($"{item.book}\t{String.Join(", ", item.authors)}");
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
                     orderby aBookn.author.Firstname
                     orderby aBookn.bookNum descending
                     select aBookn;
        foreach (var item in query7)
            Console.WriteLine($"{item.author}\t{item.bookNum}");

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
        foreach (var item in query8)
            Console.WriteLine(item);
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

        foreach (var item in query9)
            Console.WriteLine($"{item}");
    }

    /// <summary>
    /// 10. (Extentions syntax) Select authors that are common for 2 libraries
    /// </summary>
    /// <param name="lib1"></param>
    /// <param name="lib2"></param>
    public static void Query10(Library lib1, Library lib2)
    {
        var query10 = lib1.Authors.Intersect(lib2.Authors, new AuthorComparerByName());
        foreach (var item in query10)
            Console.WriteLine($"{item.Firstname} {item.Lastname}");
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
        foreach (var item in query11)
            Console.WriteLine(item);
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
        foreach (var item in query12)
            Console.WriteLine($"{item.author}:\t{String.Join(", ", item.publishers)}");
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
        foreach (var item in query13)
            Console.WriteLine($"{item.Name}: {item.averageNumOfCopies.ToString("0.00")}");
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
        Console.WriteLine($"Book on the {indexOfBookInList + 1} place:\n\t{query14}");

    }

    /// <summary>
    /// 15. (Extentions syntax) Select books with shortest Title
    /// </summary>
    /// <param name="lib"></param>
    public static void Query15(Library lib)
    {
        var query15 = lib.Books.Where(b => b.Title.Count()
                                    == lib.Books.Min(b => b.Title.Count()));
        foreach (var item in query15)
            Console.WriteLine(item);
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
        Console.WriteLine($"Books that have price bigger than {averagePriceOfBooksInlib2}:");
        foreach (var item in query16)
            Console.WriteLine(item);
    }

    /// <summary>
    /// 17. (Extentions syntax) Select the top 10 most frequent words in book titles
    /// </summary>
    /// <param name="lib"></param>
    public static void Query17(Library lib)
    {
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
                                .Take(10);
        foreach (var item in query17)
            Console.WriteLine($"{item.Word}, {item.Num}");
    }

    /// <summary>
    /// 18. (Extentions syntax) Select percent of sum of all books for every book
    /// </summary>
    /// <param name="lib"></param>
    public static void Query18(Library lib)
    {
        double sumPriceOfAllBooks = lib.Books.Sum(b => b.Price);
        var query18 = lib.Books.Select(b => new { book = b, Percent = (double)b.Price / sumPriceOfAllBooks });
        foreach (var b in query18) 
            Console.WriteLine($"{b.book.Title},\t{b.book.Price},\t{b.Percent.ToString("0.00")}");
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
        foreach (var item in query19)
        {
            Console.WriteLine($"Month {item.Key}");
            foreach (var item1 in item)
                Console.WriteLine($"\t{item1}");
        }
    }

    /// <summary>
    /// 20. (Query syntax) Show books that have only one inventory number
    /// </summary>
    /// <param name="lib"></param>
    public static void Query20(Library lib)
    {
        var query20 = from book in lib.Books
                      where book.InventoryNumbers.Count() == 1
                      select book;
        foreach (var item in query20)
            Console.WriteLine(item);
    }
}

