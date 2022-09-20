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
            Account account = new Account(1000, "Fernanda", 2050.0);
            BusinessAccount businessAccount = new BusinessAccount(1100, "Gustavo", 5950.00, 2500.00);

            //UPCASTING

            Account account1 = businessAccount;
            Account account2 = new BusinessAccount(1200, "Julio", 1350.0, 650.0);
            Account account3 = new SavingAccount(1300, "Maria", 5000.0, 0.01);

            //DOWNCASTING(inseguro)

            BusinessAccount account4 = (BusinessAccount)account2;
            account4.Loan(100.0);

            if(account3 is BusinessAccount)
            {
                //BusinessAccount account5 = (BusinessAccount)account3;
                BusinessAccount account5 = account3 as BusinessAccount;
                account5.Loan(120.0);
                Console.WriteLine("Loan");
            }

            if(account3 is SavingAccount)
            {
                //SavingAccount account5 = (SavingAccount)account3;
                SavingAccount account5 = account3 as SavingAccount;
                account5.UpdateBalance();
                Console.WriteLine("Update");
            }

        }
    }
}
