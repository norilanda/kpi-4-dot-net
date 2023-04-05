using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    /// <summary>
    ///     Information about publisher, its properties are:
    ///     _publisherId - unique publisher id;
    ///     _publisherName - publisher name
    /// </summary>
    public class Publisher
    {
        private int _publisherId;
        private string _publisherName;

        public int PublisherId => _publisherId;
        public string PublisherName => _publisherName;

        public Publisher(int id, string name)
        {
            this._publisherId = id;
            this._publisherName = name;
        }
        public override string ToString()
        {
            return $"{_publisherId.ToString().PadRight(3)} {_publisherName.PadRight(20)}";
        }
    }
}
