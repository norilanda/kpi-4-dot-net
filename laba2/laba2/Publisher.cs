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
        public int PublisherId { get; set; }
        public string PublisherName { get; set; }

        public Publisher(int id, string name)
        {
            this.PublisherId = id;
            this.PublisherName = name;
        }
        public override string ToString()
        {
            return $"{PublisherId.ToString().PadRight(3)} {PublisherName.PadRight(20)}";
        }
    }
}
