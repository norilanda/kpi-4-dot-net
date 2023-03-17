﻿//Розробити структуру даних для зберігання інформації про книги в бібліотеці. Книга характеризується: назвою, прізвищем автора, вартістю, датою видання, видавництвом, списком інвентарних номерів (книга в кількох примірниках). У одного автора може бути декілька книг.
using laba1;
Library library = new Library();
library.Books = Book.CreateBookList();
library.Authors = Author.CreateAuthorList();
library.ConnectBookAndAuthor();