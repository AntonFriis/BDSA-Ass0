using System;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Write a year to check if it's a leap year:");
            var year = Console.ReadLine();
            var parsedYear = 0;
            try
            {
                parsedYear = Int32.Parse(year);
                Console.WriteLine(IsLeapYear(parsedYear) ? "yay" : "nay");
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{year}'");
            }
        }

        public static bool IsLeapYear(int year)
        {
            if (year < 1582) return false;
            if (year % 4 != 0) return false;
            if (year % 100 == 0)
            {
                return year % 400 == 0;
            }
            return true;
        } 
        
    }
}
