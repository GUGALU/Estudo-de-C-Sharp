using System;
using Heranca_Polimorfismo.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(1500, "Gustavo", 5950.00, 2500.00);

            Console.WriteLine(account.Balance);

            //account.Balance = 300.00;
            // ^^ não e posivel ja que adicionei protected ao set, apenas poderei modificar em sub classes
        }
    }
}
