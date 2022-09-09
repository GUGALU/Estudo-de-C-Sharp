using System;

namespace Sexto_Codigo
{
    class Program
    {
        static void Main(string[] args)
        {
            // sem o params na funcao
            //int soma1 = Calculadora.Sum(new int[] { 1, 3 });
            //int soma2 = Calculadora.Sum(new int[] { 1, 3, 5 });
            //int soma3 = Calculadora.Sum(new int[] { 1, 3, 8, 10 });

            // com o params
            int soma1 = Calculadora.Sum(1, 3);
            int soma2 = Calculadora.Sum(1, 3, 5);
            int soma3 = Calculadora.Sum(1, 3, 10, 7);

            Console.WriteLine(soma1);
            Console.WriteLine(soma2);
            Console.WriteLine(soma3);

            int multiplicado = 10;
            Calculadora.Triple(ref multiplicado);
            Console.WriteLine(multiplicado);

            int multiplicado2 = 10;
            int triple_out;
            Calculadora.Triple_out(multiplicado2, out triple_out);
            Console.WriteLine(triple_out);
        }
    }
}