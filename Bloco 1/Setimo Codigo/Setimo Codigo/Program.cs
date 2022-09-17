using System;
using System.Collections.Generic;


namespace Setimo_Codigo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();

            lista.Add("Marcos");
            lista.Add("Paulo");
            lista.Add("Joao");
            lista.Add("Anna");
            lista.Add("Gustavo");
            lista.Insert(1, "Gabriel");

            foreach(string obj in lista)
            {
                Console.WriteLine(obj);
                Console.WriteLine("--------------");
            }

            Console.WriteLine("Numero de elementos na lista: " + lista.Count);

            string elemento1 = lista.Find(x => x[0] == 'G');
            Console.WriteLine("Primeiro nome com 'G': " + elemento1);

            string elemento2 = lista.FindLast(x => x[0] == 'G');
            Console.WriteLine("Umtimo nome com 'G': " + elemento2);

            int posicao1 = lista.FindIndex(x => x[0] == 'G');
            Console.WriteLine("priemira posição 'G': " + posicao1);

            int posicao2 = lista.FindLastIndex(x => x[0] == 'G');
            Console.WriteLine("Ultima posição 'G': " + posicao2);

            List<string> lista2 = lista.FindAll(x => x.Length >= 3);
            Console.WriteLine("----------------");
            foreach(string obj in lista2)
            {
                Console.WriteLine(obj);
            }

            lista.Remove("Anna");
            Console.WriteLine("----------------");
            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            }

            lista.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("----------------");
            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            }

            lista.RemoveAt(2);
            Console.WriteLine("----------------");
            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            }

            lista.RemoveRange(2,3);
            Console.WriteLine("----------------");
            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
