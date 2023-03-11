using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{    
    public class Date
    {
        int _year;
        int _month;
        int _day;
        public Date(int year, int month, int day)
        {
            this._year = year;
            this._month = month;
            this._day = day;
        }
        public override string ToString()
        {
            return $"{_day.ToString().PadLeft(2, '0')}.{_month.ToString().PadLeft(2, '0')}.{_year}";
        }
    }
}
