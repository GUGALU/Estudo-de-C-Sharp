using System;
using System.Globalization;
using static System.Console;

namespace Quinto_Codigo
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(ReadLine());

            //double[] vetor = new double[n];

            //for (int i = 0; i < n; i++)
            //{
            //    vetor[i] = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
            //}

            //double soma = 0.0;
            //for (int i = 0; i < n; i++)
            //{
            //    soma += vetor[i];
            //}

            //double media = soma / n;

            //WriteLine("Media dos numeros do vetor: " + media.ToString("F2"));

            int input = int.Parse(ReadLine());

            Product[] vetor = new Product[input];

            for(int i = 0; i < input; i++)
            {
                string nome = ReadLine();
                double preco = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
                vetor[i] = new Product { Nome = nome, Preco = preco };
            }
            double soma = 0.0;
            for (int i = 0; i < input; i++)
            {
                soma += vetor[i].Preco;
            }
            double media = soma / input;

            WriteLine("Media dos numeros do vetor: " + media.ToString("F2"));
        }
    }
}