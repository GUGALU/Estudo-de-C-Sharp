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
            Account account1 = new Account(1000, "Fernanda", 1000.0);
            Account account2 = new SavingAccount(1300, "Maria", 1000.0, 0.01);

            Console.WriteLine("Saldo conta1: " + account1.Balance);
            Console.WriteLine("Saldo conta2: " + account2.Balance);

            account1.WithDraw(100.0);
            account2.WithDraw(100.0);

            Console.WriteLine("Saldo conta1 pos saque: " + account1.Balance);
            Console.WriteLine("Saldo conta2 pos saque: " + account2.Balance);
        }
    }
}