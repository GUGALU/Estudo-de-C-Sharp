using System;

namespace Terceiro_Codigo{
    class Program{
        static void Main(string[] args){
            Point ponto;

            ponto.x = 10;
            ponto.y = 20;

            Console.WriteLine(ponto);

            ponto = new Point();
            Console.WriteLine(ponto);
        }
    }
}