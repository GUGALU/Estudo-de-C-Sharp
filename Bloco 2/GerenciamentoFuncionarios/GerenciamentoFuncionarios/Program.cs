using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerenciamentoFuncionarios.Entities;

namespace GerenciamentoFuncionarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");

                Console.Write("Outsouced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value hour: ");
                double valueHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'y')
                {
                    Console.Write("Aditional charger: ");
                    double aditionalCharger = double.Parse(Console.ReadLine());
                    list.Add(new OutsourcedEmployee(name, hours, valueHour, aditionalCharger));
                }
                else
                {
                    list.Add(new Employee(name, hours, valueHour));
                }
            }
            Console.WriteLine();
            Console.WriteLine("Payments - ");
            foreach (Employee emp in list)
            {
                Console.WriteLine($"{emp.Name} - ${emp.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
