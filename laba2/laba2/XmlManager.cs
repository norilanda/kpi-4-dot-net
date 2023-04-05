using laba1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace laba2
{
    public static class XmlManager
    {
        public static void WriteBookInLibraryToXml(Container container, string path)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = "\t";

            XmlWriter writer = XmlWriter.Create(path, settings);
            writer.WriteStartElement("Container");
            //writing Publishers
            writer.WriteStartElement("Publishers");
            foreach (Publisher publisher in container.Publishers)
            {
                writer.WriteStartElement("Publisher");
                    writer.WriteElementString("PublisherId", publisher.PublisherId.ToString());
                    writer.WriteElementString("PublisherName", publisher.PublisherName);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();

            //writing Books
            writer.WriteStartElement("Books");
            foreach(Book book in container.Books)
            {
                writer.WriteStartElement("Book");
                    writer.WriteElementString("BookId", book.BookId.ToString());
                    writer.WriteElementString("Title", book.Title);
                    writer.WriteElementString("Price", book.Price.ToString());
                    writer.WriteElementString("PublishingDate", book.PublishingDate.ToString());
                    writer.WriteElementString("PublisherId", book.PublisherId.ToString());
                writer.WriteEndElement();
            }
            writer.WriteEndElement();

            //writing Authors
            writer.WriteStartElement("Authors");
            foreach(Author author in container.Authors)
            {
                writer.WriteStartElement("Author");
                    writer.WriteElementString("AuthorId", author.AuthorId.ToString());
                    writer.WriteElementString("Firstname", author.Firstname);
                    writer.WriteElementString("Lastname", author.Lastname);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();

            //writing Libraries
            writer.WriteStartElement("Libraries");
            foreach(Library library in container.Libraries)
            {
                writer.WriteStartElement("Library");
                    writer.WriteElementString("LibraryId", library.LibraryId.ToString());
                    writer.WriteElementString("LibraryName", library.LibraryName);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();

            //writing BookOfAuthorList
            writer.WriteStartElement("BookOfAuthorList");
            foreach (BookOfAuthor bookOfAuthor in container.BookOfAuthorList)
            {
                writer.WriteStartElement("BookOfAuthor");
                    writer.WriteElementString("IdOfBook", bookOfAuthor.IdOfBook.ToString());
                    writer.WriteElementString("IdOfAuthor", bookOfAuthor.IdOfAuthor.ToString());
                writer.WriteEndElement();
            }
            writer.WriteEndElement();

            //writing BookOfLibraryList
            writer.WriteStartElement("BookOfLibraryList");
            foreach (BookOfLibrary bookOfLibrary in container.BookOfLibraryList)
            {
                writer.WriteStartElement("BookOfLibrary");
                    writer.WriteElementString("LibraryId", bookOfLibrary.LibraryId.ToString());
                    writer.WriteElementString("BookId", bookOfLibrary.BookId.ToString());
                    writer.WriteStartElement("InventoryNumbers");
                        foreach (int number in bookOfLibrary.InventoryNumbers)
                            writer.WriteElementString("int", number.ToString());
                    writer.WriteEndElement();
                writer.WriteEndElement();
            }
            writer.WriteEndElement();

            writer.WriteEndElement();
            writer.Close();
        }
        public static Container DeserializeFromXml(string path)
        {
            Container container;
            XmlSerializer serializer = new XmlSerializer(typeof(Container));
            using (StreamReader sr = new StreamReader(path))
            {
                container = (Container)serializer.Deserialize(sr);
            }
            return container;
        }
    }
}
