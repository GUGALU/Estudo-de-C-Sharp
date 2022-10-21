using System;

namespace GetHashCode_e_Equals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client { Name = "Julia", Email = "julia@gmail.com" };
            Client b = new Client { Name = "Alex", Email = "alex@gmail.com" };

            Console.WriteLine(a.Equals(b)); //comparar conteudo
            Console.WriteLine(a == b); //comparar memoria
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}
