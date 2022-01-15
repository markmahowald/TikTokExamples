using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string planet = "Earth";
            string aptNumber = "42";
            string country = "USA";
            string streetAddress = "1234 Test St";
            string state = "Colorado";

            System.Console.WriteLine($"{streetAddress} {aptNumber}\n{state}, {country}\n{planet}");
        }
    }
}
