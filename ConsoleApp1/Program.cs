using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Globalization;

namespace CurrencyFormatter
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a;
            decimal b;
            decimal c;

            decimal total;
            decimal average;
            decimal smallest;
            decimal largest;

            Console.WriteLine("Enter first dollar amount.");
            a = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter second dollar amount.");
            b = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter third dollar amount.");
            c = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("You entered the following:");
            Console.WriteLine(a + ", " + b + ", " + c);

            total = a + b + c;
            average = total / 3;
            smallest = Math.Min(Math.Min(a, b), c);
            largest = Math.Max(Math.Max(a, b), c);

            Console.WriteLine("The Average: " + average);
            Console.WriteLine("The Smallest: " + smallest);
            Console.WriteLine("The Largest: " + largest);
            Console.WriteLine("");
            Console.WriteLine("US: " + total.ToString("C2"));
            //Console.WriteLine("Swedish: " + total.ToString("C2"));
            Console.WriteLine("Swedish: " + total.ToString("C", CultureInfo.CreateSpecificCulture("sv-SE")));
            //Console.WriteLine("C2".ToString("C2", CurrentCulture));
            Console.WriteLine("Japanaese: " + total.ToString("C", CultureInfo.CreateSpecificCulture("ja-JP")));
            //Console.WriteLine("C2".ToString("C", CultureInfo.CreateSpecificCulture("ja-JP")));
            Console.WriteLine("Thai: " + total.ToString("C2"));

            Console.Read();
        }
    }
}
