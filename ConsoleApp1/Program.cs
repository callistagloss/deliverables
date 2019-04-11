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
            double a;
            double b;
            double c;

            double total;
            double average;
            double smallest;
            double largest;

            Console.WriteLine("Enter the first dollar amount.");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second dollar amount.");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the third dollar amount.");
            c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("You entered the following:");
            Console.WriteLine(a + ", " + b + ", " + c);

            total = a + b + c;
            average = total / 3;
            smallest = Math.Min(Math.Min(a, b), c);
            largest = Math.Max(Math.Max(a, b), c);

            Console.WriteLine("\nThe average is: " + average);
            Console.WriteLine("The smallest is: " + smallest);
            Console.WriteLine("The largest is: " + largest);
            Console.WriteLine("");
            Console.WriteLine("\nUS: " + total.ToString("C2"));
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
