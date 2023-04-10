using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace laba1
{
    /// <summary>
    ///     Contains information about library.
    ///     The attributes of the class are:
    ///      LibraryId - unique library id
    ///      Name - library name;
    /// </summary>
    public class Library
    {
        public int LibraryId { get; set; }
        public string LibraryName { get; set; }

        public Library() { }
        public Library(int id, string name)
        {
            this.LibraryId = id;
            this.LibraryName = name;
        }
        public override string ToString()
        {
            return $"{LibraryId.ToString().PadRight(3)} {LibraryName.PadRight(17)}";
        }
        // creating Library object from XElement
        public static Library Parse(XElement library)
        {
            return new Library((int)library.Element("LibraryId"), (string)library.Element("LibraryName"));
        }
    }
}
