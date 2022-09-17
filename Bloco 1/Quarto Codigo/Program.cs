using System;
namespace Quarto_Codigo{
    class Program{
        static void Main(string[] args){

            double? x = null;
            double? y = 10.0;
            double a = x ?? 5.0;
            double b = y ?? 0.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue){
                Console.WriteLine(x.Value);
            }
            else{
                Console.WriteLine("O valor de X é nullo");
            }
            if (y.HasValue){
                Console.WriteLine(y.Value);
            }
            else{
                Console.WriteLine("O valor de Y é nullo");
            }

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}