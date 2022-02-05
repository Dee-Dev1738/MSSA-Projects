using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModDemo4
{
    enum Department
    {
        A,
        B,
        C,
        D
    }
    enum Months
    {
        Januray,
        February,
        March,
        April,
        July,
        August,
        September,
        October,
        November,
        December,
    }

    struct Anime
    {
        public int Eid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Department Dept { get; set; }
    }
}
