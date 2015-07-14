using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    class LibraryFine : IAlgorithm
    {
        private int amount;
        private DateTime actual;
        private DateTime expected;

        private const int FINE_FOR_YEAR = 10000;
        private const int FINE_FOR_MONTH = 500;
        private const int FINE_FOR_DAY = 15;
        

        public LibraryFine(DateTime actual, DateTime expected)
        {
            this.actual = actual;
            this.expected = expected;
        }


        public void Resolve()
        {
            if (actual.Year.CompareTo(expected.Year) > 0)
            {
                this.amount = FINE_FOR_YEAR;
            }
            else if (actual.Year.Equals(expected.Year))
            {
                if (actual.Month.CompareTo(expected.Month) > 0)
                {
                    this.amount = (actual.Month - expected.Month) * FINE_FOR_MONTH;
                }
                else if (actual.Day.CompareTo(expected.Day) > 0 && actual.Month.Equals(expected.Month))
                {
                    this.amount = (actual.Day - expected.Day) * FINE_FOR_DAY;
                }
            }
        }


        public string GetResult()
        {
            return this.amount.ToString();
        }
    }
}
