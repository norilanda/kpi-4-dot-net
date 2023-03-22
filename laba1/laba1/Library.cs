using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    /// <summary>
    ///     Contains information about library.
    ///     The attributes of the class are:
    ///     _libraryId - unique library id
    ///     _name - library name;
    /// </summary>
    public class Library
    {
        private int _libraryId;
        private string _libraryName;

        public int LibraryId => _libraryId;
        public string Name => _libraryName;

        public Library(int id, string name)
        {
            this._libraryId = id;
            this._libraryName = name;
        }
        public override string ToString()
        {
            return $"{_libraryId.ToString().PadRight(3)} {_libraryName.PadRight(17)}";
        }
    }
}
