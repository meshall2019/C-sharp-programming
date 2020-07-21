using System;

namespace Lab7_ConsoleApplication
{
    enum Days { Sunday = 1, Monday, Tuesday, Wendesday, Thursday, Friday, Saturday };
    enum Moths { Jan = 1, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, oct, Nov, Dec };
    class Program
    {
        static void Main(string[] args)
        {
            Days today = Days.Wendesday;
            int dayNumber = (int)today;
            Console.WriteLine("{0} is day number #{1}. ", today, dayNumber);

            Moths thisMonth = Moths.Dec;
            byte monthNumber = (byte)thisMonth;
            Console.WriteLine("{0} is month number #{1}.", thisMonth, monthNumber);
        }
    }
}
