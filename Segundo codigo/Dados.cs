using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Segundo_Codigo
{
    public class Dados
    {
        public string informarNome(){
            Console.WriteLine("Digite os dados do produto:");
            Console.Write("Nome: ");
            return Console.ReadLine();
        }
        public double informarPreco(){
            Console.Write("Preço: ");
            return double.Parse(Console.ReadLine());
        }
    }
}