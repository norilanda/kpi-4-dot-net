﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
    public class Event
    {
        public enum LevelType
        {
            Information,
            Warning,
            Error
        }
        public LevelType Level { get; set; }
        public string Source { get; set; }
        public DateTime DateAndTime { get; set; }
        public string Message { get; set; }

        public Event() { }
        public Event(LevelType level, string source, DateTime dateTime, string message)
        {
            this.Level = level;
            this.Source = source;
            this.DateAndTime = dateTime;
            this.Message = message;
        }

        public override string ToString()
        {
            return $"{Level}, {Source}, {DateAndTime},\n{Message}";
        }

    }
}
