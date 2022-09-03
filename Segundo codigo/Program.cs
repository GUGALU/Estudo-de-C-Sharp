using System;
using System.Globalization;
namespace Segundo_Codigo{
    class Program
    {
        static void Main(){
           Produto produto = new Produto("TV",500.00,10);

            produto.Nome = "T";

           Console.WriteLine(produto.Nome);
           Console.WriteLine(produto.Preco);
           Console.WriteLine(produto.Quantidade);
        }
    }
}
// orientando a objeto aos poucos