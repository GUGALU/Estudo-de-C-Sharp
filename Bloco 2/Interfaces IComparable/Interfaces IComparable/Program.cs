using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using Interfaces_IComparable.Entities;

namespace Interfaces_IComparable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\\Users\\Gustavo\\Desktop\\GU\\Code\\C#\\Bloco 2\\IComparable\\in.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach (Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
