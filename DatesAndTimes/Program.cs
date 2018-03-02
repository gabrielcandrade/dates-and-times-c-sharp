using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;

            //Console.WriteLine(myValue.ToString()); // DD/MM/YY HH:MM
            //Console.WriteLine(myValue.ToShortDateString()); // DD/MM/YY
            //Console.WriteLine(myValue.ToShortTimeString()); // HH:MM
            //Console.WriteLine(myValue.ToLongDateString()); // quinta-feira, 3 de Agosto de 2017
            //Console.WriteLine(myValue.ToLongTimeString()); // HH:MM:SS

            //Console.WriteLine(myValue.AddDays(3).ToLongDateString()); // Added 3 days
            //Console.WriteLine(myValue.AddHours(3).ToLongTimeString()); // Added 3 hours
            //Console.WriteLine(myValue.AddHours(-3).ToLongTimeString()); // Added -3 hours

            //Console.WriteLine(myValue.Month);

            //DateTime myBirthday = new DateTime(1995, 05, 22);
            //Console.WriteLine(myBirthday.ToShortDateString());

            DateTime myBirthday = DateTime.Parse("22/05/1995");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine(myAge.TotalDays);

            Console.ReadLine();
        }
    }
}
