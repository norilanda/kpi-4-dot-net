﻿using laba1;

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
        }
    }
}