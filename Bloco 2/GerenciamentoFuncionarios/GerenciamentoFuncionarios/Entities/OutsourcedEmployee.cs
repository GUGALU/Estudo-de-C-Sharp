using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoFuncionarios.Entities
{
    internal class OutsourcedEmployee : Employee
    {
        public double AdicionalCharge { get; set; }

        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee(string name, int hours, double valueHour, double adicionalcharge) : base(name, hours, valueHour)
        {
            AdicionalCharge = adicionalcharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdicionalCharge;
        }
    }
}
