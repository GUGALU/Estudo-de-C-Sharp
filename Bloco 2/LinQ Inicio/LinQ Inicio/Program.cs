using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_Inicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 2, 3, 4, 5 };

            IEnumerable<int> results = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            foreach(int x in results)
            {
                Console.WriteLine(x);
            }
        }
    }
}
