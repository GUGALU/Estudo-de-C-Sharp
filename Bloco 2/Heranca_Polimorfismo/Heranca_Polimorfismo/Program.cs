using System;
using System.Globalization;
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

            List<Account> lista = new List<Account>();

            lista.Add(new SavingAccount(1010, "Fernanda", 1250.00, 1000.00));
            lista.Add(new BusinessAccount(1020, "Alex", 2050.00, 1500.00));
            lista.Add(new SavingAccount(1030, "Pietro", 3500.00, 1300.00));
            lista.Add(new BusinessAccount(1040, "Gustavo", 1200.00, 1000.00));

            double sum = 0.0;
            foreach(Account acc in lista)
            {
                sum += acc.Balance;
            }

            Console.WriteLine("Total balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));

            foreach(Account acc in lista)
            {
                acc.WithDraw(10.0);
            }

            foreach(Account acc in lista)
            {
                Console.WriteLine("Update balance for "
                    + acc.Holder
                    + " - "
                    + acc.Balance.ToString("F2", CultureInfo.InvariantCulture)
                    );
            }

        }
    }
}