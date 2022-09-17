using System;
using System.Globalization;

namespace Topicos_especiais2
{
    class program
    {
        static void Main(string[] args)
        {
            //DateTime d1 = DateTime.Now;
            //Console.WriteLine(d1);
            //Console.WriteLine(d1.Ticks);

            //DateTime d1 = new DateTime(2022, 8, 15);
            //DateTime d2 = new DateTime(2022, 8, 15, 13, 5, 58);
            //DateTime d3 = new DateTime(2022, 8, 15, 13, 5, 58, 275);
            //Console.WriteLine(d1);
            //Console.WriteLine(d2);
            //Console.WriteLine(d3);

            //DateTime d1 = DateTime.Now;
            //DateTime d2 = DateTime.UtcNow;
            //DateTime d3 = DateTime.Today;
            //Console.WriteLine(d1);
            //Console.WriteLine(d2);
            //Console.WriteLine(d3);

            //DateTime d1 = DateTime.Parse("2022-08-15");
            //DateTime d2 = DateTime.Parse("2022-08-15 13:05:58");
            //DateTime d3 = DateTime.Parse("15/08/2022");
            //DateTime d4 = DateTime.Parse("15/08/2022 13:05:58");
            //Console.WriteLine(d1);
            //Console.WriteLine(d2);
            //Console.WriteLine(d3);
            //Console.WriteLine(d4);

            //DateTime d1 = DateTime.ParseExact("2022-08-15", "yyyy-MM-dd",CultureInfo.InvariantCulture);
            //DateTime d2 = DateTime.ParseExact("15/08/2022 13:05:58", "dd/MM/yyyy HH:mm:ss",CultureInfo.InvariantCulture);
            //Console.WriteLine(d1);
            //Console.WriteLine(d2);

            TimeSpan t1 = TimeSpan.FromDays(1.5);
            TimeSpan t2 = TimeSpan.FromHours(1.5);
            TimeSpan t3 = TimeSpan.FromMinutes(1.5);
            TimeSpan t4 = TimeSpan.FromSeconds(1.5);
            TimeSpan t5 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan t6 = TimeSpan.FromTicks(900000000L);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);
        }
    }
}