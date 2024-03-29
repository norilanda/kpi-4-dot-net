﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace laba1
{
    /// <summary>
    ///     Information about publisher, its properties are:
    ///      PublisherId - unique publisher id;
    ///      PublisherName - publisher name
    /// </summary>
    public class Publisher
    {
        public int PublisherId { get; set; }
        public string PublisherName { get; set; }

        public Publisher() { }
        public Publisher(int id, string name)
        {
            this.PublisherId = id;
            this.PublisherName = name;
        }
        public override string ToString()
        {
            return $"{PublisherId.ToString().PadRight(3)} {PublisherName.PadRight(20)}";
        }
        // creating Publisher object from XElement
        public static Publisher Parse(XElement publisher)
        {
            return new Publisher((int)publisher.Element("PublisherId"), (string)publisher.Element("PublisherName"));
        }
    }
}
