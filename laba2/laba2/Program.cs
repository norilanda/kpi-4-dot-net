using laba1;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;
using static System.Reflection.Metadata.BlobBuilder;

namespace laba2
{
    internal class Program
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
            List<BookOfAuthor> bookOfAuthorList = new List<BookOfAuthor>()
            { 
            //connecting books with authors from first lists
            new BookOfAuthor(books[0].BookId, authors[0].AuthorId),
            new BookOfAuthor(books[1].BookId, authors[0].AuthorId),
            new BookOfAuthor(books[2].BookId, authors[0].AuthorId),
            new BookOfAuthor(books[3].BookId, authors[1].AuthorId),
            new BookOfAuthor(books[4].BookId, authors[2].AuthorId),
            new BookOfAuthor(books[5].BookId, authors[2].AuthorId),
            new BookOfAuthor(books[6].BookId, authors[3].AuthorId),
            new BookOfAuthor(books[6].BookId, authors[4].AuthorId),
            new BookOfAuthor(books[7].BookId, authors[3].AuthorId),
            new BookOfAuthor(books[8].BookId, authors[5].AuthorId),
            new BookOfAuthor(books[9].BookId, authors[5].AuthorId),
            new BookOfAuthor(books[10].BookId, authors[6].AuthorId),
            new BookOfAuthor(books[11].BookId, authors[7].AuthorId),
            new BookOfAuthor(books[12].BookId, authors[7].AuthorId),
        };

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

            //adding all lists to container
            Container container = new Container();
            container.Publishers = publishers;
            container.Books = books;
            container.Authors = authors;
            container.Libraries = libraries;
            container.BookOfAuthorList = bookOfAuthorList;
            container.BookOfLibraryList = bookOfLibraryList;

            string path = "books.xml";
            XmlManager.WriteBookInLibraryToXml(container, path );
            //XmlSerializer serializer = new XmlSerializer(typeof(BookInlLibraryContainer));
            //using (StreamWriter writer = new StreamWriter(path))
            //{
            //    serializer.Serialize(writer, container);
            //}
            Container containerFromFile = XmlManager.DeserializeFromXml(path);
            Output.PrintToConsole( containerFromFile );
            Console.WriteLine("===========================================================================================\n");

            XDocument data = XDocument.Load(path);

            try
            {
                var query1 = Query1(data);
                Console.WriteLine("1. Authors and all their books titles:");
                Output.PrintToConsole(query1);
            }
            catch(ArgumentNullException e)
            { Console.WriteLine(e.Message + "\n"); }
            catch(NullReferenceException e)
            { Console.WriteLine(e.Message + "\n"); }

            var query2 = Query2(data);
            Console.WriteLine("2. Publisher and books they have published (left join):");
            Output.PrintToConsole( query2 );

            var query3 = Query3(data, (x) => x > 1950 && x < 2000);
            Console.WriteLine($"3. Ordered by date list of books published on years that > 1950 but < 2000:");
            Output.PrintToConsole(query3);

            char param4 = 'y';
            var query4 = Query4(data, param4);
            Console.WriteLine($"4. All publishers whose Name contains '{param4}' letter: ");
            if (query4.Any())
                Output.PrintToConsole(query4);
            else Console.WriteLine($"\tThere are no publishers whose Name contains '{param4}' letter");

            var query5 = Query5(data);
            Console.WriteLine($"5. Books that have minimum price for every library");
            Output.PrintToConsole(query5);

            int param6 = 5;
            var query6 = Query6(data, param6);
            Console.WriteLine($"6. Top {param6} the most expensive books:");
            Output.PrintToConsole (query6);

            var query7 = Query7(data);
            Console.WriteLine("7. Authors and their number of books:");
            Output.PrintToConsole(query7);

            var query8 = Query8(data);
            Console.WriteLine("8. All books which price is max:");
            Output.PrintToConsole(query8);

            int param9 = 1;
            var query9 = Query9(data, param9);
            Console.WriteLine($"9. How many copies of book with id '{param9}' are in every library:");
            Output.PrintToConsole(query9);

            var query10 = Query10(data);
            Console.WriteLine("10. Publishers of books for every author:");
            Output.PrintToConsole(query10);

            var query11 = Query11(data);
            Console.WriteLine("11. Books that are common for all libraries:");
            Output.PrintToConsole(query11);

            var query12 = Query12(data);
            Console.WriteLine("12. Select number of objects in every array (such as Books, Authors, Publishers, Libraries and so on):");
            Output.PrintToConsole(query12);

            var query13 = Query13(data);
            Console.WriteLine("13. All books with shortest titles:");
            Output.PrintToConsole(query13);

            double param14;
            var query14 = Query14(data, out param14);
            Console.WriteLine($"14. Books that have price bigger than average price of all books ( {Math.Round(param14, 3)} ):");
            Output.PrintToConsole(query14);

            var query15 = Query15(data);
            Console.WriteLine("15. Books grouped by month they where published:");
            Output.PrintToConsole(query15);

            Query16(data);
            Query17(path, "some new publisher");
            Query18(path, 2);
            Query19(path, 0, "A NEW BOOK TITLE!");
            Query20(path);

        }

        //1. Select all authors and all their books
        public static IEnumerable<Tuple<Author, IEnumerable<Book>>> Query1(XDocument data)
        {
            var query1 = from author in data.Descendants("Author")
                         join ab in data.Descendants("BookOfAuthor") on author.Element("AuthorId").Value equals ab.Element("IdOfAuthor").Value
                         join book in data.Descendants("Book") on ab.Element("IdOfBook").Value equals book.Element("BookId").Value
                         group book by author into g
                         select new { 
                             Author = Author.Parse(g.Key),
                             Book = g.Select(book => Book.Parse(book))
                         };
            return query1.Select(item => new Tuple<Author, IEnumerable<Book>>(item.Author, item.Book));
        }

        //2. Select publishers and their books (left join)
        public static IEnumerable<Tuple<string, string>> Query2(XDocument data)
        {
            var query2 = data.Descendants("Publisher").GroupJoin(data.Descendants("Book"),
                                                                 p => p.Element("PublisherId").Value,
                                                                 b => b.Element("PublisherId").Value,
                                                                 (p, b) => new { Publisher = p, Books = b }
                                                                )
                                                      .SelectMany(item => item.Books.DefaultIfEmpty(),
                                                                  (p, b) => new { Publisher = (string) p.Publisher.Element("PublisherName"),
                                                                                  Book= b == null ? "" : (string)b.Element("Title")});
            return query2.Select(item => new Tuple<string, string>(item.Publisher, item.Book));
        }
        //3. Order books published on years that satisfy 'Condition'
        public static IEnumerable<Book> Query3(XDocument data, Func<int, bool> Condition)
        {
            var query3 = data.Descendants("Book")
                            .Where(book => Condition(DateOnly.Parse(book.Element("PublishingDate").Value).Year))
                            .OrderBy(book => DateOnly.Parse(book.Element("PublishingDate").Value))
                            .Select(book => Book.Parse(book));
            return query3;
        }

        // 4. Select all publishers whose Name contains 'letterToSearch' letter
        public static IEnumerable<Publisher> Query4(XDocument data, char letterToSearch)
        {
            var query4 = from publisher in data.Descendants("Publisher")
                         where publisher.Element("PublisherName").Value.Contains(letterToSearch)
                         select Publisher.Parse(publisher);
            return query4;
        }
        // 5. Select books with minimum price for every library
        public static IEnumerable<Tuple<Library, Book>> Query5(XDocument data)
        {
            var query5 = data.Descendants("Library").Join(data.Descendants("BookOfLibrary"),
                                                          l => (string)l.Element("LibraryId"),
                                                          bl => (string)bl.Element("LibraryId"),
                                                          (l, bl) => new { Library = l, BookOfLibrary = bl })
                                                    .Join(data.Descendants("Book"),
                                                               first => (string)first.BookOfLibrary.Element("BookId"),
                                                               b => (string)b.Element("BookId"),
                                                               (first, b) => new { first.Library, Book = b })
                                                    .GroupBy(item => item.Library,
                                                             item => item.Book)
                                                    .Select(item => new { Library = Library.Parse(item.Key),
                                                        Book = Book.Parse(item.MinBy(book => (double)book.Element("Price"))) });
            return query5.Select(item => new Tuple<Library, Book>(item.Library, item.Book));
        }

        // 6. Show top 'topNumberFilter' the most expensive books
        public static IEnumerable<Book> Query6(XDocument data, int topNumberFilter)
        {
            var query6 = data.Descendants("Book")
                                .OrderByDescending(book => (double)book.Element("Price"))
                                .Take(topNumberFilter)
                                .Select(book => Book.Parse(book));
            return query6;
        }

        // 7. Select authors and number of their books
        public static IEnumerable<Tuple<Author, int>> Query7(XDocument data)
        {
            var query7 = data.Descendants("Author").GroupJoin(data.Descendants("BookOfAuthor"),
                                                              author => (string)author.Element("AuthorId"),
                                                              ab => (string)ab.Element("IdOfAuthor"),
                                                              (a, ab) => new
                                                              {
                                                                  Author = Author.Parse(a),
                                                                  BookNumber = ab.Count()
                                                              })
                                                   .OrderByDescending(item => item.BookNumber);
            return query7.Select(item => new Tuple<Author, int>(item.Author, item.BookNumber));
        }

        // 8. Select books with max price
        public static IEnumerable<Book> Query8(XDocument data)
        {
            double maxPrice = data.Descendants("Book")
                                  .Elements("Price")
                                  .Select(price => (double)price)
                                  .Max();
            var query8 = data.Descendants("Book")
                             .Where(b => (double)b.Element("Price") == maxPrice)
                             .Select(b => Book.Parse(b));
            return query8;
        }

        // 9. For book with 'bookToSearchId' show how many copies there are in every library
        public static IEnumerable<Tuple<Library, int>> Query9(XDocument data, int bookToSearchId)
        {
            var bookToSearchInLibs = data.Descendants("BookOfLibrary").Where(bl => (int)bl.Element("BookId") == bookToSearchId);
            var query9 = data.Descendants("Library")
                             .GroupJoin(bookToSearchInLibs,
                                        l => (string)l.Element("LibraryId"),
                                        bl => (string)bl.Element("LibraryId"),
                                        (l, bl) => new { Library = Library.Parse(l),
                                                         BookCopiesNumber = bl.Elements("InventoryNumbers")
                                                                              .Elements("int").Count()
                                        });
            return query9.Select(item => new Tuple<Library, int>(item.Library, item.BookCopiesNumber));
        }

        // 10. For every author select publishers of his books
        public static IEnumerable<Tuple<Author, IEnumerable<Publisher>>> Query10(XDocument data)
        {
            var query10 = from author in data.Descendants("Author")
                          join ab in data.Descendants("BookOfAuthor") on author.Element("AuthorId").Value equals ab.Element("IdOfAuthor").Value
                          join book in data.Descendants("Book") on ab.Element("IdOfBook").Value equals book.Element("BookId").Value
                          join publisher in data.Descendants("Publisher") on book.Element("PublisherId").Value equals publisher.Element("PublisherId").Value
                          group publisher by author into g
                          select new { 
                              Author = Author.Parse(g.Key),
                              Publishers = g.Select(p => Publisher.Parse(p)).DistinctBy(p => p.PublisherId)
                          };
            return query10.Select(item => new Tuple<Author, IEnumerable<Publisher>>(item.Author, item.Publishers));
        }

        // 11. Select books that are common for every library
        public static IEnumerable<Book> Query11(XDocument data)
        {
            var booksGroupedByLib = from book in data.Descendants("Book")
                                    join bl in data.Descendants("BookOfLibrary") on book.Element("BookId").Value equals bl.Element("BookId").Value
                                    group book by bl.Element("LibraryId").Value into g
                                    select g.Select(b => Book.Parse(b));
            var query11 = booksGroupedByLib.Aggregate((first, next) => first.Intersect(next, new BookComparerById()) );
            return query11;
        }

        // 12. Select number of objects in every array (such as Books, Authors, Publishers, Libraries and so on)
        public static IEnumerable<Tuple<string, int>> Query12(XDocument data)
        {
            var query12 = data.Root.Elements().Select(child => new { Name = child.Name.ToString(),
                                                                   NumberOfElements = child.Elements().Count() });
            return query12.Select(item => new Tuple<string, int>(item.Name, item.NumberOfElements));
        }

        // 13. Select books with the shortest Title
        public static IEnumerable<Book> Query13(XDocument data)
        {
            int lengthOfShortestTitle = data.Descendants("Book").Min(b => ((string)b.Element("Title")).Count());
            var query13 = from book in data.Descendants("Book")
                          where ((string)book.Element("Title")).Count() == lengthOfShortestTitle
                          select Book.Parse(book);
            return query13;
        }
        // 14. Select all books that have price bigger than average price of all books
        public static IEnumerable<Book> Query14(XDocument data, out double averagePrice)
        {
            double average = data.Descendants("Book").Select(book => (double)book.Element("Price")).Average();
            var query14 = data.Descendants("Book").Where(book => (double)book.Element("Price") > average)
                                                  .Select(book => Book.Parse(book));
            averagePrice = average;
            return query14;
        }

        // 15. Group books by their publishing month
        public static IEnumerable<IGrouping<int, Book>> Query15(XDocument data)
        {
            var query15 = from book in data.Descendants("Book")
                          group Book.Parse(book) by DateOnly.Parse(book.Element("PublishingDate").Value).Month
                          into g
                          orderby g.Key
                          select g;
            return query15;
        }

        // ===================================================================================================================
        // Creates a new xml document in which are only authors. Every author has his Id as attribute, last and first name as elements inside
        public static void Query16(XDocument data)
        {
            string newPath = "queries-results/query16.xml";
            var query16 = new XDocument(
                          new XElement("Authors", data.Descendants("Author")
                                                  .Select(author => new XElement(author.Name,
                                                                    new XAttribute("AuthorId", author.Element("AuthorId").Value),
                                                                    author.Element("AuthorId").ElementsAfterSelf()) ))
                          );
            query16.Save(newPath);
        }

        // Adding a new publisher to a document
        public static void Query17(string path, string publisherName)
        {
            string newPath = "queries-results/query17.xml";
            XDocument data = XDocument.Load(path);
            int last_publisher_id = (int)data.Descendants("Publisher").LastOrDefault().Element("PublisherId");
            data.Descendants("Publisher")
                              .LastOrDefault()
                              .AddAfterSelf(new XElement("Publisher", new XElement("PublisherId", last_publisher_id + 1),
                                                                      new XElement("PublisherName", publisherName)));
            data.Save(newPath);
        }

        // Deleting inventory numbers for library with id 'libraryId'
        public static void Query18(string path, int libraryId)
        {
            string newPath = "queries-results/query18.xml";
            XDocument data = XDocument.Load(path);
            var query18 = data.Descendants("BookOfLibrary")
                              .Where(bl => (int)bl.Element("LibraryId") == libraryId)
                              .Elements("InventoryNumbers")
                              .SelectMany(bl => bl.Elements());
            query18.Remove();
            data.Save(newPath);
        }

        // Replacing title of book that has Id == 'bookId' with 'newTitle'
        public static void Query19(string path, int bookId, string newTitle)
        {
            string newPath = "queries-results/query19.xml";
            XDocument data = XDocument.Load(path);
            var query19 = data.Descendants("Book")
                              .Where(b => (int)b.Element("BookId") == bookId)
                              .Select(b => b.Element("Title"))
                              .FirstOrDefault();
            if (query19 != null)
                query19.ReplaceWith(new XElement("Title", newTitle));
            data.Save(newPath);
        }

        // Order publishers by their names and save this to a new document
        public static void Query20(string path)
        {
            string newPath = "queries-results/query20.xml";
            XDocument data = XDocument.Load(path);
            var orderedPublishers = data.Descendants("Publisher").OrderBy(item => (string)item.Element("PublisherName"));
            data.Descendants("Publishers").FirstOrDefault().ReplaceAll(orderedPublishers);
            data.Save(newPath);
        }
    }
}