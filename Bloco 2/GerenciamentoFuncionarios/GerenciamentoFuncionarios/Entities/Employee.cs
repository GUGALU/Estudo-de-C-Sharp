using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoFuncionarios.Entities
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValueHour { get; set; }

        public Employee()
        {

        }

        public Employee(string name, int hours, double valueHour)
        {
            Name = name;
            Hours = hours;
            ValueHour = valueHour;
        }

        public virtual double Payment()
        {
            return Hours * ValueHour;
        }
    }
}