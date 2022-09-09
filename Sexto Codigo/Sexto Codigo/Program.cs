using System;

namespace Sexto_Codigo
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma1 = Calculadora.Sum(1, 3);
            int soma2 = Calculadora.Sum(1, 2, 5);
            int soma3 = Calculadora.Sum(1, 5, 6, 7);

            Console.WriteLine(soma1);
            Console.WriteLine(soma2);
            Console.WriteLine(soma3);
        }
    }
}
